using AppGenealogySystem.Models;
using AppGenealogySystem.Service;
using AppGenealogySystem.Ui.Product;
using System.Windows.Forms.VisualStyles;

namespace AppGenealogySystem.Controls
{
    internal class ActionCell : DataGridViewTextBoxCell
    {
        protected enum HoverButton
        {
            None,
            Edit,
            Delete,
            View
        }

        protected HoverButton _hoverButton = HoverButton.None;

        #region RECT CALCULATION

        protected (Rectangle edit, Rectangle delete, Rectangle view)
            GetButtonRects(Rectangle cellBounds)
        {
            int buttonWidth = 50;
            int buttonHeight = 22;
            int spacing = 5;

            int totalWidth = (buttonWidth * 3) + (spacing * 2);

            int startX = (cellBounds.Width - totalWidth) / 2;
            int centerY = (cellBounds.Height - buttonHeight) / 2;

            Rectangle edit = new Rectangle(startX, centerY, buttonWidth, buttonHeight);
            Rectangle delete = new Rectangle(startX + buttonWidth + spacing, centerY, buttonWidth, buttonHeight);
            Rectangle view = new Rectangle(startX + (buttonWidth + spacing) * 2, centerY, buttonWidth, buttonHeight);

            return (edit, delete, view);
        }

        #endregion

        #region PAINT

        protected override void Paint(Graphics graphics,
            Rectangle clipBounds,
            Rectangle cellBounds,
            int rowIndex,
            DataGridViewElementStates cellState,
            object value,
            object formattedValue,
            string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex,
                cellState, value, formattedValue,
                errorText, cellStyle,
                advancedBorderStyle, paintParts);

            var rects = GetButtonRects(cellBounds);
            DrawButtons(graphics, cellBounds, rects);


        }


        protected virtual void DrawButtons(Graphics graphics, Rectangle cellBounds, (Rectangle edit, Rectangle delete, Rectangle view) rects)
        {
            DrawButton(graphics, cellBounds, rects.edit, "\u270F", HoverButton.Edit);
            DrawButton(graphics, cellBounds, rects.delete, "🗑️", HoverButton.Delete);
            DrawButton(graphics, cellBounds, rects.view, "\U0001F441", HoverButton.View);
        }
        protected void DrawButton(Graphics g,
            Rectangle cellBounds,
            Rectangle relativeRect,
            string text,
            HoverButton type)
        {
            Rectangle absoluteRect = new Rectangle(
                cellBounds.Left + relativeRect.X,
                cellBounds.Top + relativeRect.Y,
                relativeRect.Width,
                relativeRect.Height);

            var state = (_hoverButton == type)
                ? PushButtonState.Hot
                : PushButtonState.Normal;

            ButtonRenderer.DrawButton(
                g,
                absoluteRect,
                text,
                new Font("Segoe UI Emoji", 9),
                false,
                state);
        }

        #endregion

        #region MOUSE MOVE

        protected override void OnMouseMove(DataGridViewCellMouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (DataGridView == null || e.RowIndex < 0) return;

            var cellRect = DataGridView.GetCellDisplayRectangle(
                e.ColumnIndex, e.RowIndex, false);

            var rects = GetButtonRects(cellRect);

            Point mousePoint = new Point(e.X, e.Y);

            HoverButton newHover = HoverButton.None;

            if (rects.edit.Contains(mousePoint))
                newHover = HoverButton.Edit;
            else if (rects.delete.Contains(mousePoint))
                newHover = HoverButton.Delete;
            else if (rects.view.Contains(mousePoint))
                newHover = HoverButton.View;

            if (_hoverButton != newHover)
            {
                _hoverButton = newHover;
                DataGridView.InvalidateCell(this);
            }

            // Cursor
            DataGridView.Cursor = newHover == HoverButton.None
                ? Cursors.Default
                : Cursors.Hand;
        }

        protected override void OnMouseLeave(int rowIndex)
        {
            base.OnMouseLeave(rowIndex);

            _hoverButton = HoverButton.None;

            if (DataGridView != null)
            {
                DataGridView.Cursor = Cursors.Default;
                DataGridView.InvalidateCell(this);
            }
        }

        #endregion

        #region CLICK

        protected override async void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (DataGridView == null || e.RowIndex < 0)
                return;

            var row = DataGridView.Rows[e.RowIndex];
            var column = DataGridView.Columns[e.ColumnIndex];

            IDataService? dataService = column.Tag as IDataService;
            if (dataService == null) return;

            var idValue = row.Cells["ProductId"].Value?.ToString();
            if (string.IsNullOrEmpty(idValue)) return;

            long id = long.Parse(idValue);

            switch (_hoverButton)
            {
                case HoverButton.Edit:
                    var dataRow = dataService.FindOne<Products>(p => p.ProductId == id);
                    if (dataRow != null)
                    {
                        var form = new ProductForm(dataRow, "edit", dataService);
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
                            await dataService.DeleteAsync<Products>(id);
                            MessageBox.Show("Xoá thành công",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            DataGridView?.Invalidate();

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

                case HoverButton.View:
                    var viewForm = new ProductView(id, dataService);
                    viewForm.ShowDialog();
                    break;
            }
        }

        #endregion
    }
}
