using AppGenealogySystem.Models;
using AppGenealogySystem.Service;
using System.Text.RegularExpressions;

namespace AppGenealogySystem.Ui.Bom
{
    public partial class BomVersionForm : Form
    {
        public long ParentProductId
        {
            set; get;
        }

        private readonly IBomService _bomService;
        public event HandleClose? ReloadVersion;
        public BomVersionForm(long parentProductId, IBomService bomService)
        {
            ParentProductId = parentProductId;
            _bomService = bomService;
            InitializeComponent();
        }
        public delegate void HandleClose();
        private DateOnly FormatDateOnly(string dtp)
        {
            DateTime parsedDateTime = DateTime.Parse(dtp);
            var dateOnly = DateOnly.FromDateTime(parsedDateTime);
            return dateOnly;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> formData = new Dictionary<string, string>();
            CollectionFormData(formData);
            if (ValidateData(formData))
            {
                DateOnly? checkExpiry = null;
                if (!bool.Parse(formData["cboxExpire"]))
                {
                    checkExpiry = FormatDateOnly(formData["dateExpiry"]);
                }

                var bomVersion = new BomVersion()
                {
                    BOMVersion = formData["txtName"],
                    ParentProductId = ParentProductId,
                    EffectiveDate = FormatDateOnly(formData["dateEffec"]),
                    ExpiryDate = checkExpiry,
                    ChangeReason = formData["txtReason"],
                    IsDefault = bool.Parse(formData["cboxDefault"])
                };

                try
                {
                    btnSave.Enabled = false;
                    _bomService.AddAsync(bomVersion);
                }
                catch
                {
                    MessageBox.Show("Không thể lưu bom version hãy kiểm tra log", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = true;
                    return;
                }
                finally
                {
                    btnSave.Enabled = true;
                    MessageBox.Show("Lưu bom version thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private bool matchRegexMajor(string text)
        {
            string pattern = @"^\d+\.\d+$"; // ví dụ: 1.0, 2.1
            bool isValid = Regex.IsMatch(text, pattern);
            return isValid;
        }
        private bool ValidateData(Dictionary<string, string> data)
        {
            bool isValid = true;
            if (data.ContainsKey("txtName"))
            {
                if (string.IsNullOrEmpty(data["txtName"]))
                {
                    isValid = false;
                    MessageBox.Show("Not have bom version name");
                }
                if (data.ContainsKey("dateEffec"))
                {
                    if (string.IsNullOrEmpty(data["dateEffec"]))
                    {
                        isValid = false;
                        MessageBox.Show("Not have effective date");
                    }
                }
                if (data.ContainsKey("txtReason"))
                {
                    if (string.IsNullOrEmpty(data["txtReason"]))
                    {
                        isValid = false;
                        MessageBox.Show("Not have reason ");
                    }
                }
            }

            return isValid;
        }

        private void CollectionFormData(Dictionary<string, string> formData)
        {
            FilterControl(this, ref formData);
        }
        private void FilterControl(Control parent, ref Dictionary<string, string> formData)
        {

            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox tb)
                {
                    formData[tb.Name] = tb.Text;
                }
                else if (ctrl is ComboBox cb)
                {
                    formData[cb.Name] = cb.SelectedItem?.ToString() ?? "";
                }
                else if (ctrl is CheckBox chk)
                {
                    formData[chk.Name] = chk.Checked.ToString();
                }
                else if (ctrl is DateTimePicker dtpick)
                {
                    formData[dtpick.Name] = dtpick.Text;
                }
                if (ctrl.HasChildren)
                {
                    FilterControl(ctrl, ref formData);
                }
            }
        }

        private void BomVersionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReloadVersion?.Invoke();
        }
    }
}
