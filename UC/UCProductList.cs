using AppGenealogySystem.Controls;
using AppGenealogySystem.Enums;
using AppGenealogySystem.Models;
using AppGenealogySystem.Service;
using AppGenealogySystem.Ui.Product;
using Microsoft.Extensions.DependencyInjection;
using System.Linq.Expressions;

namespace AppGenealogySystem
{
    public partial class UCProductList : UserControl
    {
        protected Dictionary<ComboBox, Array> dictComb = new Dictionary<ComboBox, Array>();

        private readonly IServiceProvider _serviceProvider;
        private readonly IDataService _dataService;
        private int totalPage = 0;
        private List<int> listPagi = new List<int>();
        private int limitPage = 10;
        private int limitIncre = 0;
        private bool focustOne = true;
        private int count { get; set; }
        public UCProductList(IServiceProvider serviceProvider, IDataService dataService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _dataService = dataService;
            count = _dataService.GetCount<Products>();
        }

        private void ShowLoading(bool isLoading)
        {
            panelLoading.Visible = isLoading;
            panelLoading.BringToFront();
        }
        private async void UCProductList_Load(object sender, EventArgs e)
        {
            ShowLoading(true);
            int offset = 30;
            ucHeaderProduct.UpdateHeader("Product", new List<string> { "New" }, "product");
            UpdateFilter();
            var existButton = ucHeaderProduct.getPanelButton().Controls["btn_product_New"];
            if (existButton != null)
            {
                existButton.Click += productNew_Click;
            }

            int count = _dataService.GetCount<Products>();

            try
            {
                var products = await _dataService.GetDataLimitAsync<Products, object>(
                p => true,
                 p => new
                 {
                     p.ProductId,
                     p.ProductCode,
                     p.ProductName,
                     //p.Description,
                     p.TrackingMethod,
                     p.ProductType,
                     //p.DefaultShelfLife,
                     p.CostStandard,
                     p.IsActive
                 }, 0, offset
                );
                if (products != null && products.Count > 0)
                {
                    ActionColumn actionColumn = new ActionColumn();
                    actionColumn.HeaderText = "Actions";
                    actionColumn.Width = 200;
                    actionColumn.ReadOnly = true;
                    actionColumn.Tag = _dataService;
                    dataGridProduct.Columns.Add(actionColumn);
                    dataGridProduct.DataSource = products;
                    dataGridProduct.Columns["ProductId"].Visible = false;
                    dataGridProduct.Columns["ProductName"].Width = 250;
                    dataGridProduct.Columns.Insert(0, new DataGridViewTextBoxColumn()
                    {
                        Name = "STT",
                        HeaderText = "STT",
                        Width = 80,
                        ReadOnly = true
                    });
                }

                if (count > 0)
                {
                    //renderPagination(offset);
                    //lblCurrentPage.Text = "Current Page : 1";
                }
            }
            finally
            {
                ShowLoading(false);
            }

        }
        private void productNew_Click(object sender, EventArgs e)
        {

            using (var scope = _serviceProvider.CreateScope())
            {
                // 2. Yêu cầu DI lấy ProductForm ra
                // Lúc này DI sẽ tự động truyền DataService, DbContext... vào ProductForm cho bạn
                var fProduct = scope.ServiceProvider.GetRequiredService<ProductForm>();

                // 3. Hiển thị Form
                fProduct.ShowDialog();
            }
        }

        private void UpdateFilter()
        {
            var productTypeValues = Enum.GetValues(typeof(ProductType));
            dictComb[cobType] = productTypeValues;
            var trackingMethod = Enum.GetValues(typeof(TrackingMethod));
            dictComb[cobTracking] = trackingMethod;
            var status = Enum.GetValues(typeof(Status));
            dictComb[cobStatus] = status;
            RenderFilter(dictComb);


        }

        private async void ReloadData()
        {
            try
            {
                ShowLoading(true);
                var products = await _dataService.GetDataAsync<Products, object>(
                p => true,
                 p => new
                 {
                     p.ProductId,
                     p.ProductCode,
                     p.ProductName,
                     //p.Description,
                     p.TrackingMethod,
                     p.ProductType,
                     //p.DefaultShelfLife,
                     p.CostStandard,
                     p.IsActive
                 }
                );
                dataGridProduct.DataSource = products;
                renderPagination(30);
            }
            finally
            {
                ShowLoading(false);
            }
        }
        private async void renderPagination(int offset, int incre = 0, int limit = 10, string typePagination = "default")
        {
            listPagi.Clear();

            if (count < offset)
            {
                totalPage = 1;
            }
            else
            {
                totalPage = count / offset;
            }
            if (count % 30 != 0 && count > offset)
            {
                totalPage += 1;
            }
            for (int i = 1; i <= totalPage; i++)
            {
                listPagi.Add(i);
            }

            lblCurrentPage.Visible = true;
            lblCount.Text = $"/{count}";

            if (flowButton.Controls.Count > 0)
            {
                flowButton.Controls.Clear();
            }
            if (limit > 10)
            {
                limit = 10;
            }

            List<int> arrayList = listPagi.GetRange(incre, limit);
            if (txtSearch.Text != null)
            {
                typePagination = txtSearch.Text;
            }
            foreach (int i in arrayList)
            {
                Button bt = new Button() { Text = $"{i}", Width = 50, Height = 30, BackColor = Color.AntiqueWhite, Tag = typePagination };
                if (i == 1)
                {
                    if (focustOne)
                    {
                        bt.Name = "firstBtn";
                        bt.Focus();
                        bt.BackColor = Color.OliveDrab;
                    }
                }
                else if (lblCurrentPage.Tag != null)
                {
                    if (bt.Text == lblCurrentPage.Tag.ToString())
                    {
                        bt.BackColor = Color.OliveDrab;
                    }
                }

                bt.Click += ClickPagination;
                flowButton.Controls.Add(bt);
            }
            if (limitPage <= totalPage)
            {
                Button btnNext = new Button() { Text = $"...", Name = "btnNext", Width = 50, Height = 30 };
                btnNext.Click += ClickPagination;
                flowButton.Controls.Add(btnNext);


            }
            if (limit < 10)
            {
                var btn = flowButton.Controls["btnNext"];
                flowButton.Controls.Remove(btn);
            }
            if (incre >= 10)
            {
                var btnPre = new Button() { Name = "btnPre", Text = "Pre", Width = 50, Height = 30 };
                btnPre.Click += ClickPagination;
                flowButton.Controls.Add(btnPre);
                flowButton.Controls.SetChildIndex(btnPre, 0);
            }
            if (!focustOne)
            {
                var btnFirst = flowButton.Controls["firstBtn"];
                if (btnFirst != null)
                {
                    btnFirst.BackColor = Color.AntiqueWhite;
                }
            }
            if (incre == 0)
            {
                var btn = flowButton.Controls["btnPre"];
                flowButton.Controls.Remove(btn);
            }
        }

        private async void ClickPagination(object sender, EventArgs e)
        {

            int offset = 30;
            Button? btn = sender as Button;
            if (btn != null)
            {
                if (btn.Name == "btnNext")
                {
                    limitIncre += 10;
                    if (limitIncre + 10 > (totalPage))
                    {
                        renderPagination(offset, limitIncre, (totalPage) - limitIncre);
                    }
                    else
                    {
                        renderPagination(offset, limitIncre);
                    }
                }
                else if (btn.Name == "btnPre")
                {
                    focustOne = false;
                    if (limitIncre > 10)
                    {
                        limitIncre -= 10;
                    }
                    else if (limitIncre == limitPage)
                    {
                        limitIncre = 0;
                    }
                    renderPagination(offset, limitIncre);
                }
                else
                {
                    Expression<Func<Products, bool>> filter = x => true;

                    if (btn.Tag != null)
                    {
                        string? text = btn.Tag.ToString();
                        if (string.IsNullOrEmpty(text))
                        {

                        }
                        if (text != null && text != "default")
                        {
                            filter = x => x.ProductCode.Contains(text);
                        }
                    }

                    foreach (Control control in flowButton.Controls)
                    {
                        if (control is Button b)
                        {
                            if (b.Name == "btnNext" || b.Name == "btnPre")
                            {
                                continue;
                            }
                            b.BackColor = Color.AntiqueWhite;
                        }
                    }
                    btn.BackColor = Color.OliveDrab;
                    var products = await _dataService.GetDataLimitAsync<Products, object>(
                    filter,
                     p => new
                     {
                         p.ProductId,
                         p.ProductCode,
                         p.ProductName,
                         //p.Description,
                         p.TrackingMethod,
                         p.ProductType,
                         //p.DefaultShelfLife,
                         p.CostStandard,
                         p.IsActive
                     }, (30 * (int.Parse(btn.Text) - 1)), offset
                    );
                    dataGridProduct.DataSource = products;
                    lblCurrentPage.Text = $"Current Page: {btn.Text}";
                    lblCurrentPage.Tag = btn.Text;
                    dataGridProduct.Columns["ProductId"].Visible = false;
                }

            }
        }
        private void RenderFilter(Dictionary<ComboBox, Array> dict)
        {
            if (dict.Count > 0)
            {
                foreach (var itemComb in dict.ToList())
                {
                    var combObj = itemComb.Key;
                    foreach (var item in itemComb.Value)
                    {
                        itemComb.Key.Items.Add(item);
                    }
                    combObj.Items.Insert(0, "All");
                    combObj.SelectedIndex = 0;
                }
            }

        }

        private async void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                var countSearch = await _dataService.GetCountFilterAsync<Products>(p => p.ProductCode.Contains(searchText));
                var productList = await _dataService.GetDataLimitAsync<Products, object>(
                   p => p.ProductCode.Contains(searchText),
                    p => new
                    {
                        p.ProductId,
                        p.ProductCode,
                        p.ProductName,
                        //p.Description,
                        p.TrackingMethod,
                        p.ProductType,
                        //p.DefaultShelfLife,
                        p.CostStandard,
                        p.IsActive
                    }, 0, 30
                   );
                dataGridProduct.DataSource = productList;
                dataGridProduct.Columns["ProductId"].Visible = false;
                count = countSearch;
                limitIncre = 0;
                focustOne = true;
                renderPagination(30, limit: (count / 30 + 1), typePagination: searchText);
            }

        }

        private void dataGridProduct_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridProduct.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            _dataService.Fake(100);
            //ReloadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = string.Empty;
            }
            focustOne = true;
            ReloadData();
        }
    }

}
