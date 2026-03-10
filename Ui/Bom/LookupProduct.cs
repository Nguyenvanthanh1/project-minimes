using AppGenealogySystem.Enums;
using AppGenealogySystem.Models.Dto;
using AppGenealogySystem.Service;
using System.Windows.Forms;

namespace AppGenealogySystem.Ui.Bom
{
    public class LookupProduct : ProductFormLookup
    {
        private long _parentProductId { set; get; }
        public LookupProduct(IBomService bomService, long parentProductId) : base(bomService)
        {
            _parentProductId = parentProductId;
            this.Text = "Lookup Product Child";
            this.RemoveBaseSearchHandler();
            SearchBox.TextChanged += OverrideSearchFunc;
        }

        public override void renderFilter()
        {
            TrackingComboBox.Hide();
            TypeComboBox.DataSource = renderComboxProductType();
            TypeComboBox.ValueMember = "Value";
            TypeComboBox.DisplayMember = "Text";
            //base.renderFilter();


        }
        protected List<ComboItem<ProductType>> renderComboxProductType()
        {
            var items = new List<ComboItem<ProductType>>();
            items.Add(new ComboItem<ProductType> { Value = null, Text = "All" });
            items.AddRange(Enum.GetValues(typeof(ProductType))
                               .Cast<ProductType>()
                               .Where(x => x == ProductType.Component || x == ProductType.SubAssembly)
                               .Select(e => new ComboItem<ProductType> { Value = e, Text = e.ToString() }));

            return items;
        }
        private async void OverrideSearchFunc(object sender, EventArgs e)
        {
            showLoading(true);
            cts?.Cancel();
            cts = new CancellationTokenSource();
            var token = cts.Token;
            if (!token.IsCancellationRequested)
            {
                try
                {
                    if (sender is TextBox tb)
                    {
                        await Task.Delay(1000, token);
                        if (IsAlphaNumeric(tb.Text))
                        {
                            if (tb.Text.Length < 2)
                            {
                                MessageBox.Show("Cần có 2 ký tự để tự động tìm kiếm");
                                AddSourceProduct(null);
                                showLoading(false);
                                showEmpty(true);
                                return;
                            }
                            else
                            {
                                var typeValue = TypeComboBox.SelectedItem as ComboItem<ProductType>;
                                Logger.LogInfo($"Time DoSearch {DateTime.Now}");
                                DoSearch(SearchBox.Text, typeValue, _parentProductId);
                                Logger.LogInfo($"Time EndSearch {DateTime.Now}");
                                showLoading(false);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cần có 2 ký tự để tự động tìm kiếm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                }
                catch
                {

                }
            }
        }
    }
}
