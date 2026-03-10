namespace AppGenealogySystem
{
    partial class UCProductList
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
            ucHeaderProduct = new UcHeader();
            panel2 = new Panel();
            label6 = new Label();
            btnReset = new Button();
            txtSearch = new TextBox();
            btnImport = new Button();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            btnSearchProduct = new Button();
            cobStatus = new ComboBox();
            cobTracking = new ComboBox();
            cobType = new ComboBox();
            dataGridProduct = new DataGridView();
            panelProductMain = new Panel();
            panelLoading = new Panel();
            label9 = new Label();
            progressBarLoading = new ProgressBar();
            panel3 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            pnelBottom = new Panel();
            lblCurrentPage = new Label();
            panel5 = new Panel();
            label4 = new Label();
            flowButton = new FlowLayoutPanel();
            lblCount = new Label();
            cobLimit = new ComboBox();
            label5 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProduct).BeginInit();
            panelProductMain.SuspendLayout();
            panelLoading.SuspendLayout();
            panel3.SuspendLayout();
            pnelBottom.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ucHeaderProduct);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1228, 55);
            panel1.TabIndex = 1;
            // 
            // ucHeaderProduct
            // 
            ucHeaderProduct.Dock = DockStyle.Fill;
            ucHeaderProduct.Location = new Point(0, 0);
            ucHeaderProduct.Name = "ucHeaderProduct";
            ucHeaderProduct.Size = new Size(1228, 55);
            ucHeaderProduct.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(btnImport);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnSearchProduct);
            panel2.Controls.Add(cobStatus);
            panel2.Controls.Add(cobTracking);
            panel2.Controls.Add(cobType);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(1228, 69);
            panel2.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(678, 18);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 13;
            label6.Text = "Search:";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(1127, 14);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(72, 29);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(740, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(162, 27);
            txtSearch.TabIndex = 11;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(1054, 14);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(73, 29);
            btnImport.TabIndex = 10;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(312, 19);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 9;
            label8.Text = "Tracking:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(90, 20);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 8;
            label7.Text = "Product Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(507, 20);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 7;
            label1.Text = "Status:";
            // 
            // button1
            // 
            button1.Location = new Point(981, 14);
            button1.Name = "button1";
            button1.Size = new Size(74, 29);
            button1.TabIndex = 5;
            button1.Text = "Export";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(28, 17);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 4;
            label2.Text = "Filter: ";
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.BackColor = SystemColors.ButtonHighlight;
            btnSearchProduct.Location = new Point(905, 15);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(62, 29);
            btnSearchProduct.TabIndex = 3;
            btnSearchProduct.Text = "Search";
            btnSearchProduct.UseVisualStyleBackColor = false;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // cobStatus
            // 
            cobStatus.FormattingEnabled = true;
            cobStatus.Location = new Point(565, 16);
            cobStatus.Name = "cobStatus";
            cobStatus.Size = new Size(100, 28);
            cobStatus.TabIndex = 2;
            // 
            // cobTracking
            // 
            cobTracking.FormattingEnabled = true;
            cobTracking.Location = new Point(390, 17);
            cobTracking.Name = "cobTracking";
            cobTracking.Size = new Size(100, 28);
            cobTracking.TabIndex = 1;
            // 
            // cobType
            // 
            cobType.FormattingEnabled = true;
            cobType.Location = new Point(194, 17);
            cobType.Name = "cobType";
            cobType.Size = new Size(100, 28);
            cobType.TabIndex = 0;
            // 
            // dataGridProduct
            // 
            dataGridProduct.AllowUserToResizeColumns = false;
            dataGridProduct.AllowUserToResizeRows = false;
            dataGridProduct.BackgroundColor = SystemColors.ButtonFace;
            dataGridProduct.BorderStyle = BorderStyle.None;
            dataGridProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProduct.Location = new Point(2, 55);
            dataGridProduct.Name = "dataGridProduct";
            dataGridProduct.RowHeadersVisible = false;
            dataGridProduct.RowHeadersWidth = 51;
            dataGridProduct.ShowCellToolTips = false;
            dataGridProduct.Size = new Size(1215, 520);
            dataGridProduct.TabIndex = 3;
            dataGridProduct.RowPostPaint += dataGridProduct_RowPostPaint;
            // 
            // panelProductMain
            // 
            panelProductMain.BorderStyle = BorderStyle.FixedSingle;
            panelProductMain.Controls.Add(panelLoading);
            panelProductMain.Controls.Add(panel3);
            panelProductMain.Controls.Add(pnelBottom);
            panelProductMain.Controls.Add(panel4);
            panelProductMain.Controls.Add(dataGridProduct);
            panelProductMain.Location = new Point(0, 134);
            panelProductMain.Margin = new Padding(5);
            panelProductMain.Name = "panelProductMain";
            panelProductMain.Size = new Size(1222, 759);
            panelProductMain.TabIndex = 4;
            // 
            // panelLoading
            // 
            panelLoading.BackColor = SystemColors.MenuBar;
            panelLoading.Controls.Add(label9);
            panelLoading.Controls.Add(progressBarLoading);
            panelLoading.Location = new Point(6, 45);
            panelLoading.Name = "panelLoading";
            panelLoading.Size = new Size(1214, 520);
            panelLoading.TabIndex = 7;
            panelLoading.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(552, 102);
            label9.Name = "label9";
            label9.Size = new Size(114, 32);
            label9.TabIndex = 1;
            label9.Text = "Loading...";
            // 
            // progressBarLoading
            // 
            progressBarLoading.Anchor = AnchorStyles.None;
            progressBarLoading.Location = new Point(509, 149);
            progressBarLoading.MarqueeAnimationSpeed = 30;
            progressBarLoading.Name = "progressBarLoading";
            progressBarLoading.Size = new Size(200, 25);
            progressBarLoading.Style = ProgressBarStyle.Marquee;
            progressBarLoading.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button6);
            panel3.Location = new Point(27, 670);
            panel3.Name = "panel3";
            panel3.Size = new Size(1106, 47);
            panel3.TabIndex = 6;
            // 
            // button8
            // 
            button8.Location = new Point(366, 15);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 2;
            button8.Text = "Inventory";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(266, 15);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 1;
            button7.Text = "Genealogy";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(166, 15);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 0;
            button6.Text = "View Bom";
            button6.UseVisualStyleBackColor = true;
            // 
            // pnelBottom
            // 
            pnelBottom.Controls.Add(lblCurrentPage);
            pnelBottom.Controls.Add(panel5);
            pnelBottom.Controls.Add(flowButton);
            pnelBottom.Controls.Add(lblCount);
            pnelBottom.Controls.Add(cobLimit);
            pnelBottom.Controls.Add(label5);
            pnelBottom.Location = new Point(3, 571);
            pnelBottom.Name = "pnelBottom";
            pnelBottom.Size = new Size(1218, 84);
            pnelBottom.TabIndex = 5;
            // 
            // lblCurrentPage
            // 
            lblCurrentPage.AutoSize = true;
            lblCurrentPage.Location = new Point(850, 53);
            lblCurrentPage.Name = "lblCurrentPage";
            lblCurrentPage.Size = new Size(50, 20);
            lblCurrentPage.TabIndex = 9;
            lblCurrentPage.Text = "label6";
            lblCurrentPage.Visible = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Location = new Point(3, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(100, 64);
            panel5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 11);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 0;
            label4.Text = "Page: ";
            // 
            // flowButton
            // 
            flowButton.Location = new Point(109, 3);
            flowButton.Name = "flowButton";
            flowButton.Size = new Size(672, 81);
            flowButton.TabIndex = 7;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(977, 19);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(39, 20);
            lblCount.TabIndex = 6;
            lblCount.Text = "/300";
            // 
            // cobLimit
            // 
            cobLimit.FormattingEnabled = true;
            cobLimit.Location = new Point(904, 11);
            cobLimit.Name = "cobLimit";
            cobLimit.Size = new Size(67, 28);
            cobLimit.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(850, 14);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 4;
            label5.Text = "Show:";
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1214, 36);
            panel4.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            label3.Text = "Product List";
            // 
            // UCProductList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelProductMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCProductList";
            Size = new Size(1228, 915);
            Load += UCProductList_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProduct).EndInit();
            panelProductMain.ResumeLayout(false);
            panelLoading.ResumeLayout(false);
            panelLoading.PerformLayout();
            panel3.ResumeLayout(false);
            pnelBottom.ResumeLayout(false);
            pnelBottom.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Button btnSearchProduct;
        private ComboBox cobStatus;
        private ComboBox cobTracking;
        private ComboBox cobType;
        private DataGridView dataGridProduct;
        private Panel panelProductMain;
        private Panel panel4;
        private Label label3;
        private Panel panel3;
        private Panel pnelBottom;
        private Label lblCount;
        private Button button8;
        private Button button7;
        private Button button6;
        private UcHeader ucHeaderProduct;
        private Button button1;
        private Label label8;
        private Label label7;
        private Label label1;
        private Panel panelLoading;
        private ProgressBar progressBarLoading;
        private Label label9;
        private ComboBox cobLimit;
        private Label label5;
        private FlowLayoutPanel flowButton;
        private Panel panel5;
        private Label label4;
        private Button btnImport;
        private Label lblCurrentPage;
        private TextBox txtSearch;
        private Label label6;
        private Button btnReset;
    }
}
