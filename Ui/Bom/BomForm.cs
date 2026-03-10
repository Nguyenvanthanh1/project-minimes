using AppGenealogySystem.Models;
using AppGenealogySystem.Models.Dto;
using AppGenealogySystem.Service;
using AppGenealogySystem.Ui.Product;
using Microsoft.Extensions.DependencyInjection;
using Svg;


namespace AppGenealogySystem.Ui.Bom
{
    public partial class BomForm : Form
    {
        private readonly bool typeFormEdit;
        private readonly IServiceProvider? _serviceProvider;
        private readonly IBomService? _bomProvider;
        private Dictionary<string, string> _dataResponse = new Dictionary<string, string>();
        private long ParentProductId;
        private BomVerDto? BomVerDto;
        private event HandleShowHeader? ShowHeader;
        private delegate void HandleShowHeader();
        private BomDto? BomDto;
        public BomForm(string productDisplay, BomVerDto bomVerDto, long parentProductId, bool isEdit, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            typeFormEdit = isEdit;
            BomVerDto = bomVerDto;
            ParentProductId = parentProductId;
            _serviceProvider = serviceProvider;
            _bomProvider = _serviceProvider?.GetService(typeof(IBomService)) as BomService;
            RenderHeader(productDisplay, bomVerDto.BomVersion);
            renderParentComponent(bomVerDto.VersionId);
        }
        public BomForm(bool type, int bomId, IBomService bomService)
        {
            _bomProvider = bomService;
            typeFormEdit = type;
            InitializeComponent();
            if (type)
            {
                if (bomService != null)
                {
                    renderGetData(bomService, bomId);
                }
            }
        }

        private async void renderGetData(IBomService bomService, int bomId)
        {
            BomDto = await bomService.GetBomById(bomId);
            if (BomDto != null)
            {
                combUom.Enabled = false;
                if (BomDto.BomVersion != null && !string.IsNullOrEmpty(BomDto.DisplayName))
                {
                    var bomVer = new BomDto() { BomVersion = BomDto.BomVersion };
                    RenderHeader(BomDto.DisplayName, bomVer.BomVersion);
                }
                renderEditOnly(BomDto, bomService);

            }

        }
        private async void renderEditOnly(BomDto data, IBomService bomService)
        {
            btnLookup.Hide();
            btnAutoFill.Hide();
            txtName.Text = data.ChildProductName;
            txtCode.Text = data.ChildProductCode;
            txtReason.Text = data.ChangeReason;
            txtGroup.Text = data.AlternateGroup;
            cboxCritical.Checked = data.IsCritical;
            if (data.ParentBomId != null)
            {
                combParentCom.Enabled = false;
                var parentData = await bomService.GetParentComponent(data.ParentBomId);
                combParentCom.DataSource = parentData;
                combParentCom.ValueMember = "BomId";
                combParentCom.DisplayMember = "ProductName";
                cboxTop.Enabled = false;
            }
            else
            {
                cboxTop.Checked = true;
                combParentCom.Enabled = false;
            }

            txtSequence.Text = data.Sequence.ToString();
            numQty.Value = data.Quantity;
            if (data.ProductType != null && data.TrackingMethod != null)
            {
                lblComponent.Text = $"{data.ProductType.ToString()}    Tracking:  {data.TrackingMethod.ToString()} ";
                lblComponent.Visible = true;
            }
            else
            {
                lblComponent.Visible = false;
            }

            dateEffective.Text = data.EffectDateText;
            combUom.Text = data.UOM;
            if (data.ExpiryDate == null)
            {
                dateExpiry.Enabled = false;
            }
            else
            {
                dateExpiry.Enabled = true;
                dateExpiry.Text = data.ExpiryDateText;
                cboxExpiry.Checked = true;
            }
            panelEditOnly.Visible = true;

        }

        private async void renderParentComponent(int versionId)
        {
            var bomService = _serviceProvider?.GetService<IBomService>();
            if (bomService is BomService sv)
            {
                var data = await sv.GetBomVersionProduct(versionId);
                if (data != null)
                {
                    var noneType = new BomVersionProduct() { BomId = null, ProductName = "None" };
                    data.Insert(0, noneType);
                    combParentCom.DataSource = data;
                    combParentCom.ValueMember = "BomId";
                    combParentCom.DisplayMember = "ProductName";
                }
            }
        }

        private void cboxTop_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox cb)
            {
                if (combParentCom.DataSource == null)
                {
                    var data = new List<BomVersionProduct>();
                    var noneType = new BomVersionProduct() { BomId = null, ProductName = "None" };
                    data.Insert(0, noneType);
                }
                if (cb.Checked && !typeFormEdit)
                {
                    combParentCom.Enabled = false;
                    combParentCom.SelectedIndex = 0;
                }
                else
                {
                    combParentCom.Enabled = true;
                }
            }
        }
        private void RenderHeader(string productDisplay, string value)
        {
            flowHeader.BorderStyle = BorderStyle.FixedSingle;

            Label labelProduct = new Label() { Text = $"Parent Product : {productDisplay}", AutoSize = true, Margin = new Padding(3, 10, 0, 0) };
            Label version = new Label() { Text = $"Version: {value}" };
            flowHeader.Controls.Add(labelProduct);
            flowHeader.Controls.Add(version);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetControls(panelContent);
        }
        private void resetControls(Control controls)
        {
            foreach (Control contrl in controls.Controls)
            {
                if (typeFormEdit && contrl.Name == "panelEditOnly")
                {
                    continue;
                }
                if (contrl is CheckBox cb)
                {
                    cb.Checked = false;
                }
                if (contrl is TextBox tx)
                {
                    tx.Text = string.Empty;
                }
                if (contrl is ComboBox cob)
                {
                    cob.SelectedIndex = -1;
                }
                if (contrl.HasChildren)
                {
                    resetControls(contrl);
                }
            }
            lblComponent.Text = string.Empty;
            numQty.Value = 1;
            cboxCritical.Checked = true;

        }
        private void BomForm_Load(object sender, EventArgs e)
        {
            foreach (string item in ProductForm.listUOM)
            {
                combUom.Items.Add(item);
            }
            string pathIconReset = @"Images\reset.svg";
            SvgDocument svgReset = SvgDocument.Open(pathIconReset);
            Bitmap bmReset = svgReset.Draw(16, 16);
            btnReset.Image = bmReset;
            btnReset.ImageAlign = ContentAlignment.MiddleCenter;
            btnReset.TextAlign = ContentAlignment.MiddleCenter;
            btnReset.TextImageRelation = TextImageRelation.ImageBeforeText;
            cboxCritical.Checked = true;
        }

        public async void ActionFillData(Dictionary<string, string> data)
        {
            if (data.ContainsKey("ProductCode") && data.ContainsKey("ProductName"))
            {
                txtCode.Text = data["ProductCode"];
                txtName.Text = data["ProductName"];
            }
            _dataResponse = data;
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            // Dùng ActivatorUnilities.CreateInstrance để thêm param vào class
            using (var scope = _serviceProvider?.CreateScope())
            {
                var formLookup = ActivatorUtilities.CreateInstance<LookupProduct>(
                    scope.ServiceProvider,
                    ParentProductId
                );
                formLookup.sendData += ActionFillData;

                formLookup.ShowDialog();
            }
        }

        private void btnAutoFill_Click(object sender, EventArgs e)
        {
            if (_dataResponse != null)
            {
                if (_dataResponse.ContainsKey("TrackingMethod") && _dataResponse.ContainsKey("ProductType"))
                {
                    lblComponent.Visible = true;
                    lblComponent.Text = $"{_dataResponse["ProductType"]}    Tracking Method : {_dataResponse["TrackingMethod"]}";
                    foreach (string item in combUom.Items)
                    {
                        if (item == _dataResponse["BaseUOM"])
                        {
                            combUom.Text = item;
                            break;
                        }
                    }
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var dataCollection = CollectionData();
            if (validData(dataCollection))
            {

                if (_bomProvider is BomService bomSV)
                {
                    bool isSave = await bomSV.SaveBomAsync(dataCollection);
                    if (isSave)
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private AppGenealogySystem.Models.Bom CollectionData()
        {
            int.TryParse(txtSequence.Text, out int sequenceData);
            long childProductId = 0;
            if (_dataResponse.ContainsKey("ProductId"))
            {
                childProductId = int.Parse(_dataResponse["ProductId"]);
            }
            else
            {
                if (BomDto != null)
                {
                    childProductId = BomDto.ChildProductId;
                }
            }

            var parentBomSelected = combParentCom.SelectedItem as BomVersionProduct;
            var bomData = new AppGenealogySystem.Models.Bom()
            {
                Quantity = numQty.Value,
                Sequence = sequenceData,
                AlternateGroup = txtGroup.Text,
                ChangeReason = txtReason.Text,
                IsCritical = cboxCritical.Checked,
                ParentBomId = parentBomSelected?.BomId,
                ParentProductId = ParentProductId,
                ChildProductId = childProductId
            };
            if (BomVerDto != null)
            {
                bomData.EffectiveDate = BomVerDto.EffectiveDate;
                bomData.VersionId = BomVerDto.VersionId;
            }
            else if (BomDto != null)
            {
                bomData.EffectiveDate = DateOnly.FromDateTime(dateEffective.Value);
                bomData.VersionId = BomDto.VersionId;
                bomData.ParentProductId = BomDto.ParentProductId;
                bomData.BomId = BomDto.BomId;
                if (!string.IsNullOrEmpty(dateExpiry.ToString()) && cboxExpiry.Checked)
                {
                    bomData.ExpiryDate = DateOnly.FromDateTime(dateExpiry.Value);
                }
            }

            return bomData;

        }
        private DateOnly FormatDateOnly(string dtp)
        {
            DateTime parsedDateTime = DateTime.Parse(dtp);
            var dateOnly = DateOnly.FromDateTime(parsedDateTime);
            return dateOnly;
        }
        private bool validData(AppGenealogySystem.Models.Bom bomData)
        {
            bool valid = true;
            if (bomData.Quantity <= 0)
            {
                MessageBox.Show("Quantity can better 0");
                valid = false;
            }
            else if (bomData.Sequence <= 0)
            {
                MessageBox.Show("Sequence need better 0");
                valid = false;
            }
            if (string.IsNullOrEmpty(bomData.Sequence.ToString()))
            {
                MessageBox.Show("Sequence is required");
                valid = false;
            }
            if (string.IsNullOrEmpty(bomData.AlternateGroup?.ToString()))
            {
                MessageBox.Show("AlternateGroup is required");
                valid = false;
            }
            if (typeFormEdit && string.IsNullOrEmpty(bomData.ChangeReason))
            {
                MessageBox.Show("Reason not empty in edit");
                valid = false;
            }
            return valid;
        }

        private void cboxExpiry_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox cb)
            {
                if (cb.Checked)
                {
                    dateExpiry.Enabled = true;
                }
                else
                {
                    dateExpiry.Enabled = false;
                }
            }
        }
    }
}
