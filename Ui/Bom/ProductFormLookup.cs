using AppGenealogySystem.Enums;
using AppGenealogySystem.Models;
using AppGenealogySystem.Models.Dto;
using AppGenealogySystem.Service;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppGenealogySystem.Ui.Bom
{
    public partial class ProductFormLookup : Form
    {
        protected CancellationTokenSource? cts;
        private readonly IBomService _bomService;
        private bool isFiltered = false;
        public Action<Dictionary<string, string>>? sendData;
        public Action<Dictionary<string, string>>? sendParentProduct;
        protected TextBox SearchBox => textSearch;
        protected ComboBox TypeComboBox => combType;
        protected ComboBox TrackingComboBox => combTracking;

        public ProductFormLookup(IBomService bomService)
        {
            InitializeComponent();
            _bomService = bomService;
        }
        //AddEvent Before event parent
        //public event EventHandler SearchTextChanged
        //{
        //    add { textSearch.TextChanged += value; }
        //    remove { textSearch.TextChanged -= value; }
        //}
        //public event DataGridViewCellEventHandler SendDataCell
        //{
        //    add { dataLookupProduct.CellDoubleClick += value; }
        //    remove { dataLookupProduct.CellDoubleClick -= value; }
        //}
        protected void RemoveBaseSearchHandler()
        {
            textSearch.TextChanged -= textSearch_TextChanged;
        }

        protected void ProductFormLookup_Load(object sender, EventArgs e)
        {
            renderFilter();
            // Warm-up EF Core: chạy một query đơn giản để JIT compile

            var sttColumns = new DataGridViewTextBoxColumn()
            {
                Name = "STT",
                HeaderText = "STT",
                Width = 50,
                ReadOnly = true
            };
            if (!dataLookupProduct.Columns.Contains("STT"))
            {
                dataLookupProduct.Columns.Insert(0, sttColumns);
            }
        }

        protected List<ComboItem<T>> renderCombobox<T>() where T : struct, Enum
        {
            var items = new List<ComboItem<T>>();
            items.Add(new ComboItem<T> { Value = null, Text = "All" });
            items.AddRange(Enum.GetValues(typeof(T))
                               .Cast<T>()
                               .Select(e => new ComboItem<T> { Value = e, Text = e.ToString() }));

            return items;
        }


        public virtual void renderFilter()
        {
            combType.DataSource = renderCombobox<ProductType>();
            combType.ValueMember = "Value";
            combType.DisplayMember = "Text";
            combTracking.DataSource = renderCombobox<TrackingMethod>();
            combTracking.ValueMember = "Value";
            combTracking.DisplayMember = "Text";
            this.ActiveControl = groupBox1;
        }

        protected void AddSourceProduct(List<ProductLookup>? products)
        {
            dataLookupProduct.DataSource = products;
        }
        protected async void textSearch_TextChanged(object sender, EventArgs e)
        {
            showLoading(true);
            cts?.Cancel();
            cts = new CancellationTokenSource();
            var token = cts.Token;

            if (sender is TextBox tx)
            {
                if (!token.IsCancellationRequested)
                {
                    try
                    {
                        await Task.Delay(1000, token);
                        if (IsAlphaNumeric(textSearch.Text))
                        {
                            if (tx.Text.Length < 2)
                            {
                                MessageBox.Show("Cần có 2 ký tự để tự động tìm kiếm");
                                AddSourceProduct(null);
                                showLoading(false);
                                showEmpty(true);
                                return;
                            }
                            else
                            {
                                var trackingValue = combTracking.SelectedItem as ComboItem<TrackingMethod>;
                                var typeValue = combType.SelectedItem as ComboItem<ProductType>;
                                if (trackingValue != null && typeValue != null)
                                {
                                    Logger.LogInfo($"Time StartSearch {DateTime.Now}");
                                    DoSearch(textSearch.Text, typeValue, trackingValue);
                                    Logger.LogInfo($"Time EndSearch {DateTime.Now}");
                               
                                    showLoading(false);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cần có 2 ký tự để tự động tìm kiếm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    catch
                    {

                    }
                }

            }
        }
        protected bool IsAlphaNumeric(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z0-9]+$");
        }

        protected async void DoSearch(string searchText, ComboItem<ProductType>? itemProductType, long parentProductId)
        {
            dataLookupProduct.DataSource = null;
            var parameter = Expression.Parameter(typeof(Products), "x");
            Expression body = null;
            Expression<Func<Products, bool>>? newFilter = null;
            if (itemProductType != null)
            {
                if (!itemProductType.IsAll)
                {
                    var left = Expression.Property(parameter, nameof(Products.ProductType));
                    var right = Expression.Constant(itemProductType.Value);
                    var condition = Expression.Equal(left, right);
                    body = body == null ? condition : Expression.AndAlso(body, condition);
                }
                else
                {
                    var leftComponent = Expression.Property(parameter, nameof(Products.ProductType));
                    var rightComponent = Expression.Constant(ProductType.Component);
                    var Componentcondition = Expression.Equal(leftComponent, rightComponent);
                    var SubAssCondition = Expression.Equal(Expression.Property(parameter, nameof(ProductType)), Expression.Constant(ProductType.SubAssembly));
                    var mergeCondition = Expression.OrElse(Componentcondition, SubAssCondition);
                    body = body == null ? mergeCondition : Expression.AndAlso(body, mergeCondition);
                }
                if (body != null)
                {
                    var productCondition = Expression.NotEqual(Expression.Property(parameter, nameof(Products.ProductId)), Expression.Constant(parentProductId));
                    body = body == null ? productCondition : Expression.AndAlso(body, productCondition);
                    newFilter = Expression.Lambda<Func<Products, bool>>(body, parameter);
                }
                var products = await _bomService.GetProductLookup(searchText, newFilter);
                if (products != null && products.Count > 0)
                {
                    dataLookupProduct.DataSource = products;
                    dataLookupProduct.Columns["ProductId"].Visible = false;
                    panelData.Visible = true;

                }
                else
                {
                    panelLoading.Visible = false;
                    showEmpty(true);
                }
            }


        }
        private async void DoSearch(string searchText, ComboItem<ProductType> productType, ComboItem<TrackingMethod> tracking)
        {
            dataLookupProduct.DataSource = null;

            ParameterExpression param = Expression.Parameter(typeof(Products), "x");
            Expression? body = null;
            Expression<Func<Products, bool>>? newFilter = null;

            if (tracking.IsAll && !productType.IsAll)
            {
                var left = Expression.Property(param, nameof(Products.ProductType));
                var right = Expression.Constant(productType.Value);
                var condition = Expression.Equal(left, right);

                body = body == null ? condition : Expression.AndAlso(body, condition);
            }
            else if (productType.IsAll && !tracking.IsAll)
            {
                var left = Expression.Property(param, nameof(Products.TrackingMethod));
                var right = Expression.Constant(tracking.Value);
                var condition = Expression.Equal(left, right);

                body = body == null ? condition : Expression.AndAlso(body, condition);
            }
            else if (!productType.IsAll && !tracking.IsAll)
            {
                var conditionProductType = Expression.Equal(Expression.Property(param, nameof(Products.ProductType)), Expression.Constant(productType.Value));
                var conditionTrackingMethod = Expression.Equal(Expression.Property(param, nameof(Products.TrackingMethod)), Expression.Constant(tracking.Value));
                var combineCondition = Expression.AndAlso(conditionProductType, conditionTrackingMethod);
                body = null ?? combineCondition;

            }
            if (body != null)
            {
                newFilter = Expression.Lambda<Func<Products, bool>>(body, param);
            }

            var products = await _bomService.GetProductLookup(searchText, newFilter);
            if (products != null && products.Count > 0)
            {
                dataLookupProduct.DataSource = products;
                dataLookupProduct.Columns["ProductId"].Visible = false;
                panelData.Visible = true;

            }
            else
            {
                panelLoading.Visible = false;
                showEmpty(true);
            }
        }

        protected void showEmpty(bool show)
        {
            lblEmpty.Text = "Không có sản phẩm tồn tại";
            panelHide.Visible = show;
            panelData.Visible = show;
            lblEmpty.Visible = show;
        }
        private void dataLookupProduct_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dataLookupProduct.Rows[e.RowIndex].Cells["STT"] != null)
            {
                dataLookupProduct.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
            }

        }

        protected void showLoading(bool isLoading)
        {
            showEmpty(false);
            panelData.Visible = isLoading;
            panelLoading.Visible = isLoading;
            panelHide.Visible = isLoading;



        }

        protected async void combTracking_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textSearch.Text))
            {
                cts?.Cancel();
                cts = new CancellationTokenSource();
                var token = cts.Token;
                if (!token.IsCancellationRequested)
                {
                    try
                    {
                        showLoading(true);
                        await Task.Delay(1000, token);
                        if (sender is ComboBox b)
                        {
                            var trackingSelect = b.SelectedItem as ComboItem<TrackingMethod>;
                            var typeSelect = combType.SelectedItem as ComboItem<ProductType>;
                            if (trackingSelect != null && typeSelect != null)
                            {
                                DoSearch(textSearch.Text, typeSelect, trackingSelect);
                                isFiltered = true;
                                showLoading(false);
                            }
                        }
                    }
                    catch { }
                }
            }

        }

        private async void combType_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textSearch.Text))
            {
                cts?.Cancel();
                cts = new CancellationTokenSource();
                var token = cts.Token;
                if (!token.IsCancellationRequested)
                {
                    try
                    {
                        showLoading(true);
                        await Task.Delay(1000, token);
                        if (sender is ComboBox b)
                        {
                            var trackingSelect = combTracking.SelectedItem as ComboItem<TrackingMethod>;
                            var typeSelect = b.SelectedItem as ComboItem<ProductType>;
                            if (trackingSelect != null && typeSelect != null)
                            {
                                DoSearch(textSearch.Text, typeSelect, trackingSelect);
                                showLoading(false);
                            }
                        }
                    }
                    catch { }
                }
            }
        }

        private async void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private async void dataLookupProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataLookupProduct.Rows[e.RowIndex];

                var result = new Dictionary<string, string>();

                foreach (DataGridViewCell cell in row.Cells)
                {
                    string header = dataLookupProduct.Columns[cell.ColumnIndex].HeaderText;
                    string value = cell.Value?.ToString();
                    result[header] = value;
                }
                sendData?.Invoke(result);
                sendParentProduct?.Invoke(result);
                this.Close();
            }
        }

    }
}
