namespace AppGenealogySystem.Ui.Bom
{
    partial class ProductFormLookup
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
            label1 = new Label();
            label2 = new Label();
            textSearch = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label4 = new Label();
            combTracking = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            combType = new ComboBox();
            dataLookupProduct = new DataGridView();
            panelData = new Panel();
            panelHide = new Panel();
            lblEmpty = new Label();
            panelLoading = new Panel();
            lblStatus = new Label();
            procBar = new ProgressBar();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataLookupProduct).BeginInit();
            panelData.SuspendLayout();
            panelHide.SuspendLayout();
            panelLoading.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1117, 51);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(54, 18);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 0;
            label1.Text = "Product Lookup";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(658, 32);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 4;
            label2.Text = "Search :";
            // 
            // textSearch
            // 
            textSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textSearch.Location = new Point(724, 29);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "2 char";
            textSearch.Size = new Size(211, 27);
            textSearch.TabIndex = 3;
            textSearch.TextChanged += textSearch_TextChanged;
            textSearch.KeyPress += textSearch_KeyPress;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(combTracking);
            flowLayoutPanel2.Location = new Point(391, 21);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(250, 35);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 6);
            label4.Margin = new Padding(3, 6, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 0;
            label4.Text = "Tracking:";
            // 
            // combTracking
            // 
            combTracking.DropDownStyle = ComboBoxStyle.DropDownList;
            combTracking.FormattingEnabled = true;
            combTracking.Location = new Point(76, 3);
            combTracking.Name = "combTracking";
            combTracking.Size = new Size(132, 28);
            combTracking.TabIndex = 1;
            combTracking.TextChanged += combTracking_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(combType);
            flowLayoutPanel1.Location = new Point(120, 21);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(247, 35);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 6);
            label3.Margin = new Padding(3, 6, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 0;
            label3.Text = "Type:";
            // 
            // combType
            // 
            combType.DropDownStyle = ComboBoxStyle.DropDownList;
            combType.FormattingEnabled = true;
            combType.Location = new Point(52, 3);
            combType.Name = "combType";
            combType.Size = new Size(137, 28);
            combType.TabIndex = 1;
            combType.TextChanged += combType_TextChanged;
            // 
            // dataLookupProduct
            // 
            dataLookupProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataLookupProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLookupProduct.Location = new Point(23, 18);
            dataLookupProduct.Name = "dataLookupProduct";
            dataLookupProduct.RowHeadersWidth = 51;
            dataLookupProduct.Size = new Size(946, 471);
            dataLookupProduct.TabIndex = 2;
            dataLookupProduct.CellDoubleClick += dataLookupProduct_CellDoubleClick;
            dataLookupProduct.RowPostPaint += dataLookupProduct_RowPostPaint;
            // 
            // panelData
            // 
            panelData.BorderStyle = BorderStyle.FixedSingle;
            panelData.Controls.Add(panelHide);
            panelData.Controls.Add(dataLookupProduct);
            panelData.Location = new Point(56, 137);
            panelData.Name = "panelData";
            panelData.Size = new Size(995, 513);
            panelData.TabIndex = 3;
            panelData.Visible = false;
            // 
            // panelHide
            // 
            panelHide.Controls.Add(lblEmpty);
            panelHide.Controls.Add(panelLoading);
            panelHide.Location = new Point(23, 18);
            panelHide.Name = "panelHide";
            panelHide.Size = new Size(946, 471);
            panelHide.TabIndex = 3;
            panelHide.Visible = false;
            // 
            // lblEmpty
            // 
            lblEmpty.AutoSize = true;
            lblEmpty.Font = new Font("Segoe UI", 11F);
            lblEmpty.Location = new Point(411, 174);
            lblEmpty.Name = "lblEmpty";
            lblEmpty.Size = new Size(63, 25);
            lblEmpty.TabIndex = 3;
            lblEmpty.Text = "label5";
            lblEmpty.Visible = false;
            // 
            // panelLoading
            // 
            panelLoading.Controls.Add(lblStatus);
            panelLoading.Controls.Add(procBar);
            panelLoading.Location = new Point(349, 70);
            panelLoading.Name = "panelLoading";
            panelLoading.Size = new Size(199, 81);
            panelLoading.TabIndex = 2;
            panelLoading.Visible = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F);
            lblStatus.Location = new Point(44, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(100, 28);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Loading ...";
            // 
            // procBar
            // 
            procBar.Location = new Point(3, 43);
            procBar.MarqueeAnimationSpeed = 20;
            procBar.Name = "procBar";
            procBar.Size = new Size(189, 29);
            procBar.Style = ProgressBarStyle.Marquee;
            procBar.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textSearch);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(flowLayoutPanel2);
            groupBox1.Location = new Point(56, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(995, 72);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // ProductFormLookup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 680);
            Controls.Add(groupBox1);
            Controls.Add(panelData);
            Controls.Add(panel1);
            Name = "ProductFormLookup";
            Text = "ProductFormLookup";
            Load += ProductFormLookup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataLookupProduct).EndInit();
            panelData.ResumeLayout(false);
            panelHide.ResumeLayout(false);
            panelHide.PerformLayout();
            panelLoading.ResumeLayout(false);
            panelLoading.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox textSearch;
        private Label label4;
        private ComboBox combTracking;
        private Label label3;
        private ComboBox combType;
        private DataGridView dataLookupProduct;
        private Panel panelData;
        private GroupBox groupBox1;
        private Panel panelHide;
        private ProgressBar procBar;
        private Panel panelLoading;
        private Label lblStatus;
        private Label lblEmpty;
    }
}