using AppGenealogySystem.Enums;
using AppGenealogySystem.Models;
using AppGenealogySystem.Models.Dto;
using AppGenealogySystem.Service;
using DocumentFormat.OpenXml.VariantTypes;
using System.Linq.Expressions;

namespace AppGenealogySystem.Ui.ProductLookupUi
{
    public partial class LookupUiProduct : Form
    {
        private CancellationTokenSource? cts;

        private IBomService _bomService;
        public LookupUiProduct(List<ComboItem<ProductType>>? listType, List<TrackingMethod>? listTracking, IBomService bomService)
        {
            InitializeComponent();
            _bomService = bomService;
            panelProduct.Visible = false;
            renderFilter(listType, listTracking);
        }

        private void renderFilter(List<ComboItem<ProductType>>? listType, List<TrackingMethod>? listTracking)
        {
            if (listTracking == null)
            {

                combType.DataSource = listType;
                combType.ValueMember = "Value";
                combType.DisplayMember = "Text";
                flowTracking.Hide();
            }
            else
            {
                combType.DataSource = listType;
                combTracking.DataSource = listTracking;
            }

        }
        private void LookupUiProduct_Load(object sender, EventArgs e)
        {

        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            cts?.Cancel();
            cts = new CancellationTokenSource();
            var token = cts.Token;
            if (!token.IsCancellationRequested)
            {
                try
                {
                    await Task.Delay(1000, token);
                    SearchByFilter();
                    if (txtSearch.Text.Length < 2)
                    {
                        MessageBox.Show("Cần có thêm 2 ký tự");

                    }
                }
                catch
                {

                }
                var text = txtSearch.Text;
            }

        }


        private async void SearchByFilter()
        {
            if (combType.SelectedItem is ComboItem<ProductType> p)
            {

                var param = Expression.Parameter(typeof(Products), "x");
                Expression? body = null;
                if (p.IsAll)
                {
                    if (combType.DataSource is List<ComboItem<ProductType>> dt)
                    {
                        var dataFilter = dt.Where(x => x.IsAll == false).ToList();
                        if (dataFilter != null)
                        {
                            if (dataFilter.Count > 0)
                            {
                                foreach (var item in dataFilter)
                                {
                                    var leftCond = Expression.Property(param, nameof(ProductType));
                                    var rightCond = Expression.Constant(item.Value);
                                    var condition = Expression.Equal(leftCond, rightCond);
                                    body = body == null ? condition : Expression.OrElse(body, condition);
                                }
                            }
                            if (body != null)
                            {
                                var newFilter = Expression.Lambda<Func<Products, bool>>(body, param);
                                var products = await _bomService.GetProductLookup(txtSearch.Text, newFilter);
                                panelProduct.Visible = true;
                                dataProductLookup.DataSource = products;
                                //dataProductLookup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                dataProductLookup.Columns["ProductId"].Visible = false;
                            }

                        }

                    }
                }
            }
            //Expression<Func<Products, bool>> predicate
        }
    }
}
