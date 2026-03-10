using AppGenealogySystem.Ui.WOUi;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGenealogySystem.UC
{
    public partial class UCWorkOrder : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        public UCWorkOrder(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var formWO = _serviceProvider.GetRequiredService<WOForm>();
            formWO.ShowDialog();
        }
    }
}
