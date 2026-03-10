namespace AppGenealogySystem
{
    partial class UCBomList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            ucHeader1 = new UcHeader();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            panelOverlay = new Panel();
            lblStatus = new Label();
            panel6 = new Panel();
            lblStatusButton = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            btnAdd = new Button();
            btnRefersh = new FontAwesome.Sharp.IconButton();
            btnView = new Button();
            btnExport = new Button();
            label4 = new Label();
            dataGridBom = new DataGridView();
            panelBomInfo = new Panel();
            flowHeaderList = new FlowLayoutPanel();
            boxStep2 = new GroupBox();
            panel4 = new Panel();
            lblDateVersion = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label3 = new Label();
            combVersion = new ComboBox();
            btnNewVer = new Button();
            boxStep1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            combProdcuct = new ComboBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panelOverlay.SuspendLayout();
            panel6.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBom).BeginInit();
            panelBomInfo.SuspendLayout();
            boxStep2.SuspendLayout();
            panel4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            boxStep1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ucHeader1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1231, 38);
            panel1.TabIndex = 1;
            // 
            // ucHeader1
            // 
            ucHeader1.Location = new Point(0, 0);
            ucHeader1.Margin = new Padding(3, 2, 3, 2);
            ucHeader1.Name = "ucHeader1";
            ucHeader1.Size = new Size(1231, 36);
            ucHeader1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(1225, 29);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(235, 15);
            label1.TabIndex = 0;
            label1.Text = "BILL OF MATERIALS (BOM) MANAGEMENT";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(boxStep2);
            panel3.Controls.Add(boxStep1);
            panel3.Location = new Point(3, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(1225, 754);
            panel3.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(panelOverlay);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(dataGridBom);
            panel5.Controls.Add(panelBomInfo);
            panel5.Location = new Point(3, 122);
            panel5.Name = "panel5";
            panel5.Size = new Size(1207, 629);
            panel5.TabIndex = 2;
            // 
            // panelOverlay
            // 
            panelOverlay.Controls.Add(lblStatus);
            panelOverlay.Location = new Point(77, 102);
            panelOverlay.Name = "panelOverlay";
            panelOverlay.Size = new Size(1064, 393);
            panelOverlay.TabIndex = 3;
            panelOverlay.Visible = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Location = new Point(571, 127);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 19);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "label6";
            // 
            // panel6
            // 
            panel6.Controls.Add(lblStatusButton);
            panel6.Controls.Add(flowLayoutPanel3);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(77, 501);
            panel6.Name = "panel6";
            panel6.Size = new Size(1064, 102);
            panel6.TabIndex = 2;
            // 
            // lblStatusButton
            // 
            lblStatusButton.AutoSize = true;
            lblStatusButton.Location = new Point(638, 15);
            lblStatusButton.Name = "lblStatusButton";
            lblStatusButton.Size = new Size(38, 15);
            lblStatusButton.TabIndex = 2;
            lblStatusButton.Text = "label5";
            lblStatusButton.Visible = false;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(btnAdd);
            flowLayoutPanel3.Controls.Add(btnRefersh);
            flowLayoutPanel3.Controls.Add(btnView);
            flowLayoutPanel3.Controls.Add(btnExport);
            flowLayoutPanel3.Location = new Point(94, 48);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(868, 35);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.AutoSize = true;
            btnAdd.BackColor = SystemColors.ButtonHighlight;
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 30);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Component";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRefersh
            // 
            btnRefersh.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRefersh.AutoSize = true;
            btnRefersh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefersh.IconColor = Color.Black;
            btnRefersh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefersh.IconSize = 24;
            btnRefersh.Location = new Point(138, 3);
            btnRefersh.Name = "btnRefersh";
            btnRefersh.Size = new Size(100, 30);
            btnRefersh.TabIndex = 4;
            btnRefersh.Text = "Refersh";
            btnRefersh.TextAlign = ContentAlignment.MiddleRight;
            btnRefersh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefersh.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            btnView.Location = new Point(244, 3);
            btnView.Name = "btnView";
            btnView.RightToLeft = RightToLeft.No;
            btnView.Size = new Size(153, 29);
            btnView.TabIndex = 2;
            btnView.Text = "View Bom Version";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(403, 3);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(94, 29);
            btnExport.TabIndex = 3;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 15);
            label4.Name = "label4";
            label4.Size = new Size(260, 15);
            label4.TabIndex = 0;
            label4.Text = "Legend: │ = has child components (expandable)";
            // 
            // dataGridBom
            // 
            dataGridBom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridBom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBom.Location = new Point(77, 102);
            dataGridBom.Name = "dataGridBom";
            dataGridBom.RowHeadersWidth = 51;
            dataGridBom.Size = new Size(1064, 393);
            dataGridBom.TabIndex = 1;
            dataGridBom.DataBindingComplete += dataGridBom_DataBindingComplete;
            dataGridBom.RowPostPaint += dataGridBom_RowPostPaint;
            // 
            // panelBomInfo
            // 
            panelBomInfo.Controls.Add(flowHeaderList);
            panelBomInfo.Location = new Point(77, 3);
            panelBomInfo.Name = "panelBomInfo";
            panelBomInfo.Size = new Size(1064, 93);
            panelBomInfo.TabIndex = 0;
            // 
            // flowHeaderList
            // 
            flowHeaderList.BorderStyle = BorderStyle.FixedSingle;
            flowHeaderList.FlowDirection = FlowDirection.TopDown;
            flowHeaderList.Location = new Point(185, 6);
            flowHeaderList.Name = "flowHeaderList";
            flowHeaderList.Size = new Size(632, 87);
            flowHeaderList.TabIndex = 0;
            // 
            // boxStep2
            // 
            boxStep2.Controls.Add(panel4);
            boxStep2.Controls.Add(flowLayoutPanel2);
            boxStep2.Location = new Point(460, 3);
            boxStep2.Name = "boxStep2";
            boxStep2.Size = new Size(371, 113);
            boxStep2.TabIndex = 1;
            boxStep2.TabStop = false;
            boxStep2.Text = "Step 2: Select BOM Version ";
            // 
            // panel4
            // 
            panel4.Controls.Add(lblDateVersion);
            panel4.Location = new Point(6, 66);
            panel4.Name = "panel4";
            panel4.Size = new Size(355, 37);
            panel4.TabIndex = 1;
            // 
            // lblDateVersion
            // 
            lblDateVersion.AutoSize = true;
            lblDateVersion.Location = new Point(3, 3);
            lblDateVersion.Name = "lblDateVersion";
            lblDateVersion.Size = new Size(38, 15);
            lblDateVersion.TabIndex = 0;
            lblDateVersion.Text = "label4";
            lblDateVersion.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(combVersion);
            flowLayoutPanel2.Controls.Add(btnNewVer);
            flowLayoutPanel2.Location = new Point(6, 19);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(355, 41);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 6);
            label3.Margin = new Padding(3, 6, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 0;
            label3.Text = "Version: ";
            // 
            // combVersion
            // 
            combVersion.Enabled = false;
            combVersion.FormattingEnabled = true;
            combVersion.Location = new Point(60, 3);
            combVersion.Name = "combVersion";
            combVersion.Size = new Size(168, 23);
            combVersion.TabIndex = 1;
            combVersion.SelectedIndexChanged += combVersion_SelectedIndexChanged;
            // 
            // btnNewVer
            // 
            btnNewVer.Location = new Point(234, 3);
            btnNewVer.Name = "btnNewVer";
            btnNewVer.Size = new Size(110, 29);
            btnNewVer.TabIndex = 2;
            btnNewVer.Text = "New Version";
            btnNewVer.UseVisualStyleBackColor = true;
            btnNewVer.Click += btnNewVer_Click;
            // 
            // boxStep1
            // 
            boxStep1.Controls.Add(flowLayoutPanel1);
            boxStep1.Location = new Point(10, 3);
            boxStep1.Name = "boxStep1";
            boxStep1.Size = new Size(444, 102);
            boxStep1.TabIndex = 0;
            boxStep1.TabStop = false;
            boxStep1.Text = "Step 1: Select Parent Product";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(combProdcuct);
            flowLayoutPanel1.Controls.Add(btnSearch);
            flowLayoutPanel1.Location = new Point(6, 26);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 5, 0, 0);
            flowLayoutPanel1.Size = new Size(419, 49);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 11);
            label2.Margin = new Padding(3, 6, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 0;
            label2.Text = "Product: ";
            // 
            // combProdcuct
            // 
            combProdcuct.FormattingEnabled = true;
            combProdcuct.Location = new Point(64, 8);
            combProdcuct.Name = "combProdcuct";
            combProdcuct.Size = new Size(221, 23);
            combProdcuct.TabIndex = 1;
            combProdcuct.SelectedIndexChanged += combProdcuct_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = SystemColors.Highlight;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 22;
            btnSearch.Location = new Point(291, 5);
            btnSearch.Margin = new Padding(3, 0, 3, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(0, 5, 0, 0);
            btnSearch.Size = new Size(61, 29);
            btnSearch.TabIndex = 3;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // UCBomList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCBomList";
            Size = new Size(1231, 849);
            Load += UCBomList_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panelOverlay.ResumeLayout(false);
            panelOverlay.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBom).EndInit();
            panelBomInfo.ResumeLayout(false);
            boxStep2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            boxStep1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private UcHeader ucHeader1;
        private Panel panel3;
        private Label label1;
        private GroupBox boxStep2;
        private GroupBox boxStep1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private ComboBox combProdcuct;
        private Panel panel5;
        private Panel panelBomInfo;
        private Panel panel4;
        private Label lblDateVersion;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label3;
        private ComboBox combVersion;
        private DataGridView dataGridBom;
        private Panel panel6;
        private Label lblStatusButton;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button btnAdd;
        private Button button2;
        private Button btnView;
        private Button btnExport;
        private Label label4;
        private Button btnNewVer;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FlowLayoutPanel flowHeaderList;
        private FontAwesome.Sharp.IconButton btnRefersh;
        private Panel panelOverlay;
        private Label lblStatus;
    }
}
