
using AppGenealogySystem.Enums;
using AppGenealogySystem.Service;
using AppGenealogySystem.Models;
using System.Linq;
using System.Runtime.CompilerServices;
namespace AppGenealogySystem.Ui.Product
{
    public partial class ProductForm : Form
    {

        private IDataService? _dataServicecs { get; set; }
        public static List<string> listUOM = new List<string>()

{
    "PCS",
    "KG",
    "G",
    "M",
    "CM",
    "MM",
    "L",
    "ML",
    "BOX",
    "Pack",
    "Dozen",
    "Pallet",
    "Bag",
    "Set"
};
        private readonly Products? productObj = new Products();
        private readonly string _type = string.Empty;
        public ProductForm(Products product, string type, IDataService? dataServicecs)
        {
            InitializeComponent();
            productObj = product;
            _dataServicecs = dataServicecs;
            _type = type;
            LoadComponent();
        }
        public static List<string> getlListUom()
        {
            return listUOM;
        }
        private Dictionary<string, Array> listRadio = new Dictionary<string, Array>();
        public ProductForm(IDataService dataServicecs)
        {
            InitializeComponent();
            _dataServicecs = dataServicecs;
            LoadComponent();
        }

        public void LoadComponent()
        {
            foreach (var item in listUOM)
            {
                cobUOM.Items.Add(item);
            }
            cobUOM.SelectedIndex = 0;
            var productTypeData = Enum.GetValues(typeof(ProductType));
            listRadio["ProductType"] = productTypeData;
            var trackingMethodData = Enum.GetValues(typeof(TrackingMethod));
            listRadio["TrackingMethod"] = trackingMethodData;
            if (listRadio.Count > 0)
                foreach (var item in listRadio.Select((kvp, idx) => new { kvp.Key, kvp.Value, idx }))
                {
                    foreach (var val in item.Value.Cast<Enum>().Select((v, i) => new { v, i }))
                    {
                        if (item.Key == "ProductType")
                        {
                            var radio = new RadioButton();
                            radio.Text = val.v.ToString();
                            radio.Name = $"radio_btn_product{val.i}";
                            radio.TabIndex = val.i;
                            radio.Tag = val.i;
                            radio.Size = new Size(130, 30);
                            panelProductType.Controls.Add(radio);
                        }
                        else if (item.Key == "TrackingMethod")
                        {
                            var radio = new RadioButton();
                            radio.Text = val.v.ToString();
                            radio.Name = $"radio_btn_track{val.i}";
                            radio.TabIndex = val.i;
                            radio.Tag = val.i;
                            radio.Size = new Size(130, 30);
                            panelTracking.Controls.Add(radio);
                        }
                    }
                }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnResetProduct_Click(object sender, EventArgs e)
        {
            ResetControls(this);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string textNeedCheck = txtCode.Text.Trim();
            if (string.IsNullOrEmpty(textNeedCheck))
            {
                MessageBox.Show("Vui lòng nhập mã để kiểm tra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblCheckStatus.Visible = false;
                return;
            }
            var codeFound = _dataServicecs.FindOne<Products>(x => x.ProductCode == textNeedCheck);

            if (codeFound != null)
            {
                lblCheckStatus.Text = "\u274C" + " Fail";
                lblCheckStatus.ForeColor = Color.Red;
                lblCheckStatus.Visible = true;
            }
            else
            {
                lblCheckStatus.Text = "\u2714" + " Ok";
                lblCheckStatus.ForeColor = Color.Green;
                lblCheckStatus.Visible = true;
            }

        }

        private bool FindCode(string text)
        {
            var codeFound = _dataServicecs.FindOne<Products>(x => x.ProductCode == text);
            if (codeFound != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ResetControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox tb)
                {
                    tb.Clear();
                }
                else if (ctrl is ComboBox cb)
                {
                    cb.SelectedIndex = 0;
                }
                else if (ctrl is RadioButton rb)
                {
                    rb.Checked = false;
                }
                else if (ctrl is CheckBox chk)
                {
                    chk.Checked = false;
                }

                // Nếu control có chứa control con (GroupBox, Panel, TabPage...)
                if (ctrl.HasChildren)
                {
                    ResetControls(ctrl);
                }
            }
        }
        private void btnSaveProduct_Click(object sender, EventArgs e)
        {

            RadioButton? checkRadioProductType = panelProductType.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
            RadioButton? checkRadioTracking = panelTracking.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);

            if (FindCode(txtCode.Text) && !string.IsNullOrEmpty(txtCode.Text) && _type != "edit")
            {
                MessageBox.Show("Mã code đang trùng lặp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //txtCode,txtName,txtDecs,panelProductType,panelTracking,cobUOM,txtLife,txtCost,txtRevision,txtDrawNum,cboActive
            if (string.IsNullOrWhiteSpace(txtCode.Text)
                || string.IsNullOrWhiteSpace(txtName.Text)
                || string.IsNullOrEmpty(checkRadioProductType?.Text)
                || string.IsNullOrEmpty(checkRadioTracking?.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã và Tên sản phẩm, Tracking Method, Product Type!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 2. Sử dụng TryParse để ép kiểu an toàn
            // Nếu ép kiểu thất bại, giá trị sẽ mặc định là 0 thay vì làm văng ứng dụng
            int.TryParse(txtLife.Text.Trim(), out int shelfLife);
            decimal.TryParse(txtCost.Text.Trim(), out decimal costStandard);
            try
            {
                productObj.ProductCode = txtCode.Text;
                productObj.ProductName = txtName.Text;
                productObj.Description = txtDesc.Text;
                productObj.BaseUOM = cobUOM.Text;
                productObj.DefaultShelfLife = shelfLife;
                productObj.DrawingNumber = txtDrawNum.Text;
                productObj.CostStandard = costStandard;
                productObj.IsActive = cboxActive.Checked;
                productObj.TrackingMethod = (TrackingMethod)(int)checkRadioTracking.Tag;
                productObj.ProductType = (ProductType)(int)checkRadioProductType.Tag;
                productObj.CreatedDate = DateTime.Now;
                productObj.CreatedBy = 1; // Giả sử ID admin là 1, bạn có thể lấy từ biến toàn cục


                // 3. Gọi service để lưu
                if (_type == "edit")
                {
                    _dataServicecs?.Update(productObj);
                    MessageBox.Show("Sửa sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _dataServicecs?.Add(productObj);
                    MessageBox.Show("Lưu sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi lưu dữ liệu: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            if (_type == "edit")
            {
                if (productObj != null)
                {
                    var productTypeFind = panelProductType.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Text == productObj.ProductType.ToString());
                    var trackingFind = panelTracking.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Text == productObj.TrackingMethod.ToString());
                    var uomFind = cobUOM.FindString(productObj.BaseUOM);
                    txtCode.Text = productObj.ProductCode;
                    txtCost.Text = $"{productObj.CostStandard}";
                    txtDesc.Text = productObj.Description;
                    txtDrawNum.Text = productObj.DrawingNumber;
                    txtLife.Text = $"{productObj.DefaultShelfLife}";
                    txtName.Text = productObj.ProductName;
                    txtRevision.Text = productObj.RevisionCurrent;
                    cboxActive.Checked = productObj.IsActive;
                    cobUOM.SelectedIndex = uomFind;
                    if ((productTypeFind != null && trackingFind != null))
                    {
                        productTypeFind.Checked = true;
                        trackingFind.Checked = true;
                    }
                    var flowlayout = new FlowLayoutPanel() { Width = 700, Location = new Point(30, 50) };
                    var labelCreated = new Label()
                    {
                        Text = $"Created By {productObj.CreatedBy}     Created Date : {productObj.CreatedDate}",
                        Width = 500,
                    };
                    var labelModified = new Label()
                    {
                        Text = $"Modified By 123 Modified Date : 12333",
                        Width = 500
                    };
                    flowlayout.Controls.Add(labelCreated);
                    flowlayout.Controls.Add(labelModified);
                    groupAdd.Controls.Add(flowlayout);


                }
            }
        }
    }
}
