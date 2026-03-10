using AppGenealogySystem.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGenealogySystem.Controls.Bom
{
    internal class ActionBomColumn : DataGridViewColumn
    {
        public ActionBomColumn()
        {
            this.CellTemplate = new ActionBomCell();
        }
    }
}
