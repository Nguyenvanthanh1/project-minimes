using AppGenealogySystem.Models;
using AppGenealogySystem.Service;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Globalization;

namespace AppGenealogySystem.Ui.Product
{
    public partial class ProductView : Form
    {
        private IDataService _dataServicecs { get; set; }
        public ProductView(long id, IDataService dataService)
        {
            _dataServicecs = dataService;
            InitializeComponent();
            View(id);

        }


        private void View(long id)
        {
            Products? productObj = _dataServicecs.FindOne<Products>(x => x.ProductId == id);
            if (productObj != null)
            {
                var label1 = new Label()
                {
                    Width = 500,
                    Text = $"Product: {productObj.ProductCode} - {productObj.ProductName}"
                };
                var label2 = new Label()
                {
                    Width = 500,
                    Text = $"Status: {ConvertStatus(productObj.IsActive)} | Type: {productObj.ProductType} | Tracking: {productObj.TrackingMethod}"
                };
                flowHeader.Controls.Add(label1);
                flowHeader.Controls.Add(label2);
                txtBoxDesc.Text = productObj.Description;
                AddContentToInfor($"Base UOM : {productObj.BaseUOM}");
                AddContentToInfor($"Shelf Life: {productObj.DefaultShelfLife}");
                CultureInfo cul = new CultureInfo("vi-VN");
                //Convert tiền VND
                string result = productObj.CostStandard.ToString("C0", cul);
                flowBaseInfo.Padding = new Padding(0,10,0,10);
                AddContentToInfor($"StandardCode: {result}");
                AddContentToInfor($"Create: {productObj.CreatedDate}");
                AddContentToInfor($"By: {productObj.CreatedBy}");
                AddContentToInfor($"Create: {productObj.CreatedDate}");
                AddContentToInfor($"By: {productObj.CreatedBy}");
                AddContentToStatistic($"Current Revision: {productObj.RevisionCurrent}");
                AddContentToStatistic($"Drawing: {productObj.DrawingNumber}");

            }

        }
        private void AddContentToStatistic(string text)
        {
            var label = new Label()
            {
                AutoSize = true,
                Text = text,
                Margin = new Padding(0, 8, 0, 0)
            };

            flowStatistics.Controls.Add(label);
        }

        private void AddContentToInfor(string text)
        {
            var label = new Label()
            {
                Margin = new Padding(0, 8, 0, 0),
                AutoSize = true,
                Text = text
            };
            flowBaseInfo.Controls.Add(label);
        }


        private string ConvertStatus(bool status)
        {
            if (status)
            {
                return "Active";
            }
            else
            {
                return "Not Active";
            }
        }
    }
}
