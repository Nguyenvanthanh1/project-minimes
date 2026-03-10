
using AppGenealogySystem.Models.Dto;
using AppGenealogySystem.Service;
using AppGenealogySystem.Ui.Bom;

namespace AppGenealogySystem.Controls.Bom
{
    internal class ActionBomCell : ActionCell
    {
        protected override void DrawButtons(Graphics graphics, Rectangle cellBounds, (Rectangle edit, Rectangle delete, Rectangle view) rects)
        {
            DrawButton(graphics, cellBounds, rects.edit, "\u270F", HoverButton.Edit);
            DrawButton(graphics, cellBounds, rects.delete, "🗑️", HoverButton.Delete);
        }
        protected override async void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            if (DataGridView == null || e.RowIndex < 0)
                return;

            var row = DataGridView.Rows[e.RowIndex];
            var column = DataGridView.Columns[e.ColumnIndex];
            IBomService? bomService = column.Tag as IBomService;
            if (bomService == null) return;

            var idValue = row.Cells["BomId"].Value?.ToString();
            if (string.IsNullOrEmpty(idValue)) return;

            int bomId = int.Parse(idValue);

            switch (_hoverButton)
            {
                case HoverButton.Edit:

                    if (idValue != null)
                    {
                        var form = new BomForm(true, bomId, bomService);
                        form.ShowDialog();
                    }
                    break;

                case HoverButton.Delete:
                    var confirm = MessageBox.Show(
                        "Bạn có chắc muốn xoá?",
                        "Cảnh báo",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if (confirm == DialogResult.OK)
                    {
                        try
                        {
                            //await dataService.DeleteAsync<Products>(id);
                            //MessageBox.Show("Xoá thành công",
                            //    "Thông báo",
                            //    MessageBoxButtons.OK,
                            //    MessageBoxIcon.Information);

                            //DataGridView?.Invalidate();

                        }
                        catch
                        {
                            MessageBox.Show("Đã có lỗi xảy ra",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    break;
            }
        }
    }
}
