using AppGenealogySystem.Enums;
using AppGenealogySystem.Models.Dto;
using AppGenealogySystem.Service;
using AppGenealogySystem.Ui.ProductLookupUi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGenealogySystem.Ui.WOUi
{
    public partial class WOForm : Form
    {
        private IBomService _bomService;
        public WOForm(IBomService bomService)
        {
            _bomService = bomService;
            InitializeComponent();
        }

        private async void btnAuto_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            Random randomYear = new Random();
            int number = randomNumber.Next(1, 99);
            string prefix = number > 10 ? "0" : "00";
            int year = randomYear.Next(2000, 2050);
            string numberRender = $"WO-{year}-{prefix}{number}";
            txtWONum.Text = numberRender;
        }

        private void renderWoType()
        {
            var dataType = Enum.GetValues(typeof(WOType)).Cast<WOType>().Select(x => new { Value = ((int)x), Text = x.ToString() }).ToList();

            if (dataType.Count > 0)
            {
                foreach (var type in dataType)
                {
                    RadioButton rdbtn = new RadioButton()
                    {
                        Text = type.Text,
                        TabIndex = type.Value,
                        AutoSize = true
                    };
                    flowRadioType.Controls.Add(rdbtn);
                }
            }
        }

        private void WOForm_Load(object sender, EventArgs e)
        {
            renderWoType();
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            var items = new List<ComboItem<ProductType>>();
            items.Add(new ComboItem<ProductType> { Value = null, Text = "All" });
            var itemEnum = Enum.GetValues(typeof(ProductType))
                               .Cast<ProductType>()
                               .Select(e => new ComboItem<ProductType> { Value = e, Text = e.ToString() }).Where(x => x.Value == ProductType.FinishedGood || x.Value == ProductType.SubAssembly);
            items.AddRange(itemEnum);
            var formLookup = new LookupUiProduct(items, null,_bomService);
            formLookup.ShowDialog();
        }
    }
}
