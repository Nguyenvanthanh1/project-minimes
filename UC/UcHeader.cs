
namespace AppGenealogySystem
{
    public partial class UcHeader : UserControl
    {
        public UcHeader()
        {
            InitializeComponent();
        }

        public void UpdateHeader(string Text, List<string>? listNameButton, string type)
        {
            lblTitle.Text = Text;
            lblTitle.AutoSize = true;
            if (listNameButton != null)
            {
                if (listNameButton.Count > 0)
                {
                    foreach (string name in listNameButton)
                    {
                        Button button = new Button();
                        button.Text = name;
                        button.AutoSize = true;
                        button.Name = $"btn_{type}_{name}";
                        panelButton.Controls.Add(button);
                    }

                }
            }


        }
        public Panel getPanelButton()
        {
            return panelButton;
        }
    }
}
