using AppGenealogySystem.Controls;
using AppGenealogySystem.Controls.Bom;
using AppGenealogySystem.Models;
using AppGenealogySystem.Models.Dto;
using AppGenealogySystem.Service;
using AppGenealogySystem.Ui.Bom;
using ClosedXML.Excel;
using Microsoft.Extensions.DependencyInjection;
using Svg;
using System.Drawing;

namespace AppGenealogySystem
{
    public partial class UCBomList : UserControl
    {
        private readonly IBomService _bomService;
        private IServiceProvider _serviceProvider;
        private ProductDto? currentSelected;
        private event LoadBom? LoadAction;
        public event HandlerShow? ShowDateVersion;

        public delegate void HandlerShow();
        public delegate void LoadBom();
        public UCBomList(IBomService bomService, IServiceProvider serviceProvider)
        {
            _bomService = bomService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }


        private void UCBomList_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnView.Enabled = false;
            combProdcuct.Enabled = false;
            LoadAction += LoadListBom;
            ucHeader1.UpdateHeader("Bom Management", new List<string> { }, "bom");
            string path = @"Images\add-plus.svg";
            string pathView = @"Images\eye.svg";

            SvgDocument svgDoc = SvgDocument.Open(path);
            SvgDocument svgView = SvgDocument.Open(pathView);

            // Render thành Bitmap với kích thước mong muốn
            Bitmap bmp = svgDoc.Draw(16, 16);
            Bitmap bmView = svgView.Draw(16, 16);
            renderBitmapImage(@"Images\export.svg", ref btnExport);


            // Gán vào Button
            btnView.Image = bmView;
            btnView.ImageAlign = ContentAlignment.MiddleLeft;
            btnView.TextAlign = ContentAlignment.MiddleRight;
            btnView.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.Image = bmp;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;

        }
        public void UpdateDataProductResponse(Dictionary<string, string> data)
        {
            if (data != null && data.Count > 0)
            {

                var selectedItem = combProdcuct.SelectedItem as ProductDto;
                data["DisplayName"] = $"{data["ProductCode"]} - {data["ProductName"]}";
                List<ProductDto> listProduct = new List<ProductDto>();
                listProduct?.Add(new ProductDto() { ProductId = long.Parse(data["ProductId"]), ProductCode = data["ProductCode"], ProductName = data["ProductName"] });
                if (data["DisplayName"] != selectedItem?.DisplayName)
                {
                    combProdcuct.DataSource = listProduct;
                    combProdcuct.ValueMember = "ProductId";
                    combProdcuct.DisplayMember = "DisplayName";
                }
            }

        }
        private void combProdcuct_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridBom.DataSource = null;
            lblDateVersion.Visible = false;
            var selectedItem = combProdcuct.SelectedItem as ProductDto;
            combVersion.DataSource = null;
            GetVersionList(selectedItem?.ProductId);
            if (combProdcuct.SelectedIndex == -1)
            {
                btnAdd.Enabled = false;
                btnView.Enabled = false;
            }
            else if (combProdcuct.SelectedIndex >= 0)
            {
                combVersion.Enabled = true;
            }
            ShowDateVersion += renderVersionDate;


        }

        public void ReloadComboBoxVersion()
        {
            combVersion.DataSource = null;
            var selectedItem = combProdcuct.SelectedItem as ProductDto;
            GetVersionList(selectedItem?.ProductId);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (combProdcuct.SelectedItem is ProductDto cb && combVersion.SelectedItem is BomVerDto bv)
            {
                using var scope = _serviceProvider.CreateScope();

                var bomForm = new BomForm(combProdcuct.Text, bv, cb.ProductId, isEdit: false, scope.ServiceProvider);
                bomForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Product and version bom is empty",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
        }

        private async void LoadListBom()
        {
            dataGridBom.DataSource = null;
            panelOverlay.Visible = false;
            var selectedVersion = combVersion.SelectedItem as BomVerDto;
            var selectedProduct = combProdcuct.SelectedItem as ProductDto;
            if (selectedVersion != null && selectedProduct != null)
            {
                var bomList = await _bomService.GetTreeBomNode(selectedProduct.ProductId, selectedVersion.VersionId);
                if (bomList != null && bomList.Count > 0)
                {
                    dataGridBom.DataSource = bomList;
                }
                if (flowHeaderList.Controls.Count <= 0)
                {
                    var labelStruct = new Label()
                    {
                        Text = $"BOM Structure for :{selectedProduct.DisplayName}",
                        AutoSize = true,
                        Margin = new Padding(0, 0, 0, 12)
                    };

                    var status = selectedVersion.IsDefault ? "Active" : "Unactive";
                    int totalCount = bomList != null ? bomList.Count : 0;
                    var labelStatus = new Label()
                    {
                        Text = $"Version : {selectedVersion.BomVersion} | Total Component : {totalCount} | Status: {status}",
                        AutoSize = true
                    };
                    flowHeaderList.Controls.Add(labelStruct);
                    flowHeaderList.Controls.Add(labelStatus);
                }
            }
            if (dataGridBom.DataSource == null)
            {
                panelOverlay.Visible = true;
                panelOverlay.BorderStyle = BorderStyle.FixedSingle;
                lblStatus.Text = "Khong có Bom khả dụng";
                //btnAdd.Enabled = false;
                //btnView.Enabled = false;
            }
        }
        private void renderVersionDate()
        {
            var selectedItemVersion = combVersion?.SelectedItem as BomVerDto;
            if (selectedItemVersion != null)
            {
                string textExpiry = string.Empty;
                if (selectedItemVersion.EffectDateText != null)
                {
                    textExpiry = "Expiry: Not Expiry";
                }
                else
                {
                    textExpiry = $"Expiry Date: {selectedItemVersion.ExpiryDateText}";
                }
                lblDateVersion.Visible = true;
                lblDateVersion.Text = $"Effective Date :{selectedItemVersion.EffectDateText}    {textExpiry} ";
                btnAdd.Enabled = true;
                btnView.Enabled = true;
            }
        }
        private async void GetVersionList(long? parentProductId)
        {
            if (parentProductId != null)
            {
                List<BomVerDto> listVersion = await _bomService.GetListVersionAsync(parentProductId);
                if (listVersion.Count > 0)
                {
                    combVersion.DataSource = listVersion;
                    combVersion.ValueMember = "VersionId";
                    combVersion.DisplayMember = "VersionActive";
                }
                if (dataGridBom.DataSource == null)
                {
                    LoadAction?.Invoke();
                }

            }
        }
        private void btnNewVer_Click(object sender, EventArgs e)
        {

            if (combProdcuct.SelectedIndex >= 0)
            {
                currentSelected = combProdcuct.SelectedItem as ProductDto;
                if (currentSelected != null)
                {
                    var formNewBomVersion = new BomVersionForm(currentSelected.ProductId, _bomService);
                    formNewBomVersion.ReloadVersion += ReloadComboBoxVersion;
                    formNewBomVersion.ShowDialog();
                }
            }
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var formLookup = scope.ServiceProvider.GetRequiredService<ProductFormLookup>();
                formLookup.sendParentProduct += UpdateDataProductResponse;
                // 3. Hiển thị Form
                formLookup.ShowDialog();
            }
        }

        private void combVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox cb)
            {
                if (cb.SelectedItem != null)
                {
                    ShowDateVersion?.Invoke();

                }
            }

        }

        private void renderBitmapImage(string path, ref Button button)
        {
            SvgDocument svgDoc = SvgDocument.Open(path);
            Bitmap bmImage = svgDoc.Draw(16, 16);
            //return bmImage;
            button.Image = bmImage;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.TextAlign = ContentAlignment.MiddleRight;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;

        }

        private void dataGridBom_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender is DataGridView dtv)
            {
                if (dtv.Columns.Contains("BomId"))
                {
                    dtv.Columns["BomId"].Visible = false;
                }
                if (!dtv.Columns.Contains("STT"))
                {
                    dtv.Columns.Insert(0, new DataGridViewTextBoxColumn()
                    {
                        Name = "STT",
                        HeaderText = "STT",
                        Width = 80,
                        ReadOnly = true
                    });
                }
                if (!dtv.Columns.Contains("Action"))
                {
                    if (combProdcuct.SelectedItem is ProductDto cb && combVersion.SelectedItem is BomVerDto bv)
                    {

                        var actionCol = new ActionBomColumn();
                        actionCol.HeaderText = "Action";
                        actionCol.Name = "Action";
                        actionCol.Width = 200;
                        actionCol.Tag = _bomService;
                        actionCol.ReadOnly = true;
                        dtv.Columns.Add(actionCol);
                    }
                }
                if (dtv.Columns.Contains("Level") && dtv.Columns.Contains("DisplayName"))
                {
                    dtv.Columns["Level"].Width = 70;
                    dtv.Columns["Sequence"].Width = 100;
                    dtv.Columns["UOM"].Width = 70;
                    dtv.Columns["IsCritical"].Width = 70;
                    dtv.Columns["QtyPerParent"].Width = 100;
                    dtv.Columns["DisplayName"].Width = 300;
                }

            }
        }

        private void dataGridBom_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dataGridBom.Columns.Contains("STT"))
            {
                dataGridBom.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();

            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (combProdcuct.SelectedIndex >= 0)
            {
                currentSelected = combProdcuct.SelectedItem as ProductDto;
                if (currentSelected != null)
                {
                    var formNewBomVersionHistory = new BomVersionHistory(currentSelected, _bomService);

                    formNewBomVersionHistory.ShowDialog();
                }
            }
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                lblStatusButton.Visible = true;
                lblStatusButton.BackColor = Color.Orchid;
                b.Enabled = false;
                lblStatusButton.Text = "Đang Export...";
                await Task.Run(() => ExportExcel());
                lblStatusButton.Text = "Xuất Excel thành công!";
                b.Enabled = true;
                await Task.Delay(2000);
                lblStatusButton.Visible = false;

            }
        }

        private async void ExportExcel()
        {
            using (var wb = new XLWorkbook())
            {
                var ws = wb.Worksheets.Add("Sheet1");
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (dataGridBom.DataSource != null)
                {
                    // Ghi tiêu đề cột
                    for (int i = 0; i < dataGridBom.Columns.Count; i++)
                    {
                        if (dataGridBom.Columns[i].HeaderText == "Action")
                        {
                            continue;
                        }
                        ws.Cell(1, i + 1).Value = dataGridBom.Columns[i].HeaderText;
                    }

                    // Ghi dữ liệu từng dòng
                    for (int i = 0; i < dataGridBom.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridBom.Columns.Count; j++)
                        {
                            ws.Cell(i + 2, j + 1).Value = dataGridBom.Rows[i].Cells[j].Value?.ToString();
                        }
                    }
                    string fileName = $"BomData{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    string fullPath = Path.Combine(documentsPath, fileName);

                    // Lưu file
                    wb.SaveAs(fullPath);
                }

            }
        }
    }
}
