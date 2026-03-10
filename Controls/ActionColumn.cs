using AppGenealogySystem.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGenealogySystem.Controls
{
    internal class ActionColumn : DataGridViewColumn
    {
        public ActionColumn()

        {
            this.CellTemplate = new ActionCell();
        }

    }
}
