using AppGenealogySystem.Models.Dto;
using AppGenealogySystem.Service;

namespace AppGenealogySystem.Ui.Bom
{
    public partial class BomVersionHistory : Form
    {
        private readonly IBomService _bomService;
        private long parentProductId;
        public BomVersionHistory(ProductDto productDto, IBomService bomService)
        {
            parentProductId = productDto.ProductId;
            _bomService = bomService;
            InitializeComponent();
            ucHeader1.UpdateHeader($"Bom version history - {productDto.ProductCode}", null, type: "history");
            panelHeader.Controls.Add(new Label()
            {
                Text = $"Product:  {productDto.DisplayName}",
                AutoSize = true,
            });
        }

        private async void BomVersionHistory_Load(object sender, EventArgs e)
        {
            dataBverHistory.DataSource = null;
            var data = await _bomService.GetBomVersionByProductId(parentProductId);
            if (data != null && dataBverHistory.DataSource == null)
            {
                dataBverHistory.DataSource = data;
            }

            if (dataBverHistory.Columns.Contains("ParentProductId") && dataBverHistory.Columns.Contains("VersionId"))
            {
                dataBverHistory.Columns["ParentProductId"].Visible = false;
                dataBverHistory.Columns["VersionId"].Visible = false;
            }
            if (dataBverHistory.Columns.Contains("Boms"))
            {
                dataBverHistory.Columns["Boms"].Visible = false;
            }

        }
    }
}
