namespace AppGenealogySystem.Ui.ProductLookupUi
{
    partial class LookupUiProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            txtSearch = new TextBox();
            flowTracking = new FlowLayoutPanel();
            label2 = new Label();
            combTracking = new ComboBox();
            flowType = new FlowLayoutPanel();
            label1 = new Label();
            combType = new ComboBox();
            panelProduct = new Panel();
            dataProductLookup = new DataGridView();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowTracking.SuspendLayout();
            flowType.SuspendLayout();
            panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataProductLookup).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(flowTracking);
            panel1.Controls.Add(flowType);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1243, 94);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(txtSearch);
            flowLayoutPanel1.Location = new Point(792, 25);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(263, 37);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 4);
            label3.Margin = new Padding(3, 4, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 0;
            label3.Text = "Search: ";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(57, 2);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search text here!";
            txtSearch.Size = new Size(187, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // flowTracking
            // 
            flowTracking.Controls.Add(label2);
            flowTracking.Controls.Add(combTracking);
            flowTracking.Location = new Point(424, 25);
            flowTracking.Margin = new Padding(3, 2, 3, 2);
            flowTracking.Name = "flowTracking";
            flowTracking.Size = new Size(271, 37);
            flowTracking.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 4);
            label2.Margin = new Padding(3, 4, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 0;
            label2.Text = "Tracking";
            // 
            // combTracking
            // 
            combTracking.DropDownStyle = ComboBoxStyle.DropDownList;
            combTracking.FormattingEnabled = true;
            combTracking.Location = new Point(61, 2);
            combTracking.Margin = new Padding(3, 2, 3, 2);
            combTracking.Name = "combTracking";
            combTracking.Size = new Size(125, 23);
            combTracking.TabIndex = 1;
            // 
            // flowType
            // 
            flowType.Controls.Add(label1);
            flowType.Controls.Add(combType);
            flowType.Location = new Point(109, 25);
            flowType.Margin = new Padding(3, 2, 3, 2);
            flowType.Name = "flowType";
            flowType.Size = new Size(222, 37);
            flowType.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 4);
            label1.Margin = new Padding(3, 4, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Type";
            // 
            // combType
            // 
            combType.DropDownStyle = ComboBoxStyle.DropDownList;
            combType.FormattingEnabled = true;
            combType.Location = new Point(41, 2);
            combType.Margin = new Padding(3, 2, 3, 2);
            combType.Name = "combType";
            combType.Size = new Size(125, 23);
            combType.TabIndex = 1;
            // 
            // panelProduct
            // 
            panelProduct.Controls.Add(dataProductLookup);
            panelProduct.Location = new Point(10, 107);
            panelProduct.Margin = new Padding(3, 2, 3, 2);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(1242, 359);
            panelProduct.TabIndex = 1;
            // 
            // dataProductLookup
            // 
            dataProductLookup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataProductLookup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProductLookup.Location = new Point(3, 10);
            dataProductLookup.Margin = new Padding(3, 2, 3, 2);
            dataProductLookup.Name = "dataProductLookup";
            dataProductLookup.RowHeadersWidth = 51;
            dataProductLookup.Size = new Size(1237, 347);
            dataProductLookup.TabIndex = 0;
            // 
            // LookupUiProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 520);
            Controls.Add(panelProduct);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LookupUiProduct";
            Text = "ProductLookupForm";
            Load += LookupUiProduct_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowTracking.ResumeLayout(false);
            flowTracking.PerformLayout();
            flowType.ResumeLayout(false);
            flowType.PerformLayout();
            panelProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataProductLookup).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowTracking;
        private Label label2;
        private ComboBox combTracking;
        private FlowLayoutPanel flowType;
        private Label label1;
        private ComboBox combType;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private TextBox txtSearch;
        private Panel panelProduct;
        private DataGridView dataProductLookup;
    }
}