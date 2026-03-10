namespace AppGenealogySystem.Ui.Bom
{
    partial class BomForm
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
            flowHeader = new FlowLayoutPanel();
            panel2 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel8 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            btnLookup = new Button();
            txtCode = new TextBox();
            panel4 = new Panel();
            btnAutoFill = new Button();
            txtName = new TextBox();
            panel5 = new Panel();
            lblComponent = new Label();
            panel6 = new Panel();
            combUom = new ComboBox();
            numQty = new NumericUpDown();
            panel7 = new Panel();
            cboxTop = new CheckBox();
            combParentCom = new ComboBox();
            panel9 = new Panel();
            label3 = new Label();
            panel10 = new Panel();
            label4 = new Label();
            panel11 = new Panel();
            label5 = new Label();
            panel12 = new Panel();
            label12 = new Label();
            panel13 = new Panel();
            label6 = new Label();
            panel14 = new Panel();
            label7 = new Label();
            panel15 = new Panel();
            txtSequence = new TextBox();
            panel16 = new Panel();
            cboxCritical = new CheckBox();
            panel17 = new Panel();
            label8 = new Label();
            panel19 = new Panel();
            txtGroup = new TextBox();
            groupForm = new GroupBox();
            panelEditOnly = new Panel();
            groupBox2 = new GroupBox();
            cboxExpiry = new CheckBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtReason = new TextBox();
            dateExpiry = new DateTimePicker();
            dateEffective = new DateTimePicker();
            panel18 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSave = new FontAwesome.Sharp.IconButton();
            btnReset = new Button();
            btnCacl = new Button();
            panelContent = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            panel19.SuspendLayout();
            groupForm.SuspendLayout();
            panelEditOnly.SuspendLayout();
            groupBox2.SuspendLayout();
            panel18.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowHeader);
            panel1.Location = new Point(12, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(1156, 90);
            panel1.TabIndex = 0;
            // 
            // flowHeader
            // 
            flowHeader.FlowDirection = FlowDirection.TopDown;
            flowHeader.Location = new Point(334, 3);
            flowHeader.Name = "flowHeader";
            flowHeader.Size = new Size(449, 78);
            flowHeader.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1156, 49);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 15);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.57143F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel1.Controls.Add(panel8, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Controls.Add(panel5, 1, 2);
            tableLayoutPanel1.Controls.Add(panel6, 1, 3);
            tableLayoutPanel1.Controls.Add(panel7, 1, 4);
            tableLayoutPanel1.Controls.Add(panel9, 0, 1);
            tableLayoutPanel1.Controls.Add(panel10, 0, 2);
            tableLayoutPanel1.Controls.Add(panel11, 0, 3);
            tableLayoutPanel1.Controls.Add(panel12, 0, 4);
            tableLayoutPanel1.Controls.Add(panel13, 0, 5);
            tableLayoutPanel1.Controls.Add(panel14, 0, 6);
            tableLayoutPanel1.Controls.Add(panel15, 1, 5);
            tableLayoutPanel1.Controls.Add(panel16, 1, 6);
            tableLayoutPanel1.Controls.Add(panel17, 0, 7);
            tableLayoutPanel1.Controls.Add(panel19, 1, 7);
            tableLayoutPanel1.Location = new Point(39, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.98701F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9870138F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9870138F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9870138F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9870138F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9870138F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9870138F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(740, 364);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(label2);
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(205, 41);
            panel8.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 11);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 5;
            label2.Text = "Component Code (*)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLookup);
            panel3.Controls.Add(txtCode);
            panel3.Location = new Point(214, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(523, 41);
            panel3.TabIndex = 0;
            // 
            // btnLookup
            // 
            btnLookup.Location = new Point(215, 7);
            btnLookup.Name = "btnLookup";
            btnLookup.Size = new Size(94, 29);
            btnLookup.TabIndex = 1;
            btnLookup.Text = "Lookup";
            btnLookup.UseVisualStyleBackColor = true;
            btnLookup.Click += btnLookup_Click;
            // 
            // txtCode
            // 
            txtCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCode.BorderStyle = BorderStyle.FixedSingle;
            txtCode.Location = new Point(3, 7);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(206, 27);
            txtCode.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAutoFill);
            panel4.Controls.Add(txtName);
            panel4.Location = new Point(214, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(523, 41);
            panel4.TabIndex = 1;
            // 
            // btnAutoFill
            // 
            btnAutoFill.Location = new Point(215, 7);
            btnAutoFill.Name = "btnAutoFill";
            btnAutoFill.Size = new Size(94, 29);
            btnAutoFill.TabIndex = 1;
            btnAutoFill.Text = "Auto-Fill";
            btnAutoFill.UseVisualStyleBackColor = true;
            btnAutoFill.Click += btnAutoFill_Click;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(3, 8);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(206, 27);
            txtName.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblComponent);
            panel5.Location = new Point(214, 97);
            panel5.Name = "panel5";
            panel5.Size = new Size(523, 41);
            panel5.TabIndex = 2;
            // 
            // lblComponent
            // 
            lblComponent.AutoSize = true;
            lblComponent.Location = new Point(3, 9);
            lblComponent.Name = "lblComponent";
            lblComponent.Size = new Size(50, 20);
            lblComponent.TabIndex = 0;
            lblComponent.Text = "label9";
            lblComponent.Visible = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(combUom);
            panel6.Controls.Add(numQty);
            panel6.Location = new Point(214, 144);
            panel6.Name = "panel6";
            panel6.Size = new Size(523, 41);
            panel6.TabIndex = 3;
            // 
            // combUom
            // 
            combUom.DropDownStyle = ComboBoxStyle.DropDownList;
            combUom.FormattingEnabled = true;
            combUom.Location = new Point(86, 7);
            combUom.Name = "combUom";
            combUom.Size = new Size(91, 28);
            combUom.TabIndex = 1;
            // 
            // numQty
            // 
            numQty.DecimalPlaces = 2;
            numQty.Location = new Point(3, 8);
            numQty.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQty.Name = "numQty";
            numQty.Size = new Size(77, 27);
            numQty.TabIndex = 0;
            numQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel7
            // 
            panel7.Controls.Add(cboxTop);
            panel7.Controls.Add(combParentCom);
            panel7.Location = new Point(214, 191);
            panel7.Name = "panel7";
            panel7.Size = new Size(523, 41);
            panel7.TabIndex = 4;
            // 
            // cboxTop
            // 
            cboxTop.AutoSize = true;
            cboxTop.Location = new Point(215, 5);
            cboxTop.Name = "cboxTop";
            cboxTop.Size = new Size(93, 24);
            cboxTop.TabIndex = 1;
            cboxTop.Text = "Top-level";
            cboxTop.UseVisualStyleBackColor = true;
            cboxTop.CheckedChanged += cboxTop_CheckedChanged;
            // 
            // combParentCom
            // 
            combParentCom.DropDownStyle = ComboBoxStyle.DropDownList;
            combParentCom.FormattingEnabled = true;
            combParentCom.Location = new Point(3, 3);
            combParentCom.Name = "combParentCom";
            combParentCom.Size = new Size(206, 28);
            combParentCom.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(label3);
            panel9.Location = new Point(3, 50);
            panel9.Name = "panel9";
            panel9.Size = new Size(205, 41);
            panel9.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 13);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 0;
            label3.Text = "Component Name (*)";
            // 
            // panel10
            // 
            panel10.Controls.Add(label4);
            panel10.Location = new Point(3, 97);
            panel10.Name = "panel10";
            panel10.Size = new Size(205, 41);
            panel10.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 9);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 0;
            label4.Text = "Product Type";
            // 
            // panel11
            // 
            panel11.Controls.Add(label5);
            panel11.Location = new Point(3, 144);
            panel11.Name = "panel11";
            panel11.Size = new Size(205, 41);
            panel11.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 10);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 0;
            label5.Text = "Quantity(*)";
            // 
            // panel12
            // 
            panel12.Controls.Add(label12);
            panel12.Location = new Point(3, 191);
            panel12.Name = "panel12";
            panel12.Size = new Size(205, 41);
            panel12.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(56, 9);
            label12.Name = "label12";
            label12.Size = new Size(132, 20);
            label12.TabIndex = 0;
            label12.Text = "Parent Component";
            // 
            // panel13
            // 
            panel13.Controls.Add(label6);
            panel13.Location = new Point(3, 238);
            panel13.Name = "panel13";
            panel13.Size = new Size(205, 41);
            panel13.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 0;
            label6.Text = "Sequence";
            // 
            // panel14
            // 
            panel14.Controls.Add(label7);
            panel14.Location = new Point(3, 285);
            panel14.Name = "panel14";
            panel14.Size = new Size(205, 41);
            panel14.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(119, 9);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 0;
            label7.Text = "Is Critical";
            // 
            // panel15
            // 
            panel15.Controls.Add(txtSequence);
            panel15.Location = new Point(214, 238);
            panel15.Name = "panel15";
            panel15.Size = new Size(523, 41);
            panel15.TabIndex = 11;
            // 
            // txtSequence
            // 
            txtSequence.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSequence.Location = new Point(3, 4);
            txtSequence.Name = "txtSequence";
            txtSequence.Size = new Size(133, 27);
            txtSequence.TabIndex = 0;
            // 
            // panel16
            // 
            panel16.Controls.Add(cboxCritical);
            panel16.Location = new Point(214, 285);
            panel16.Name = "panel16";
            panel16.Size = new Size(523, 41);
            panel16.TabIndex = 12;
            // 
            // cboxCritical
            // 
            cboxCritical.AutoSize = true;
            cboxCritical.Location = new Point(11, 9);
            cboxCritical.Name = "cboxCritical";
            cboxCritical.Size = new Size(18, 17);
            cboxCritical.TabIndex = 0;
            cboxCritical.UseVisualStyleBackColor = true;
            // 
            // panel17
            // 
            panel17.Controls.Add(label8);
            panel17.Location = new Point(3, 332);
            panel17.Name = "panel17";
            panel17.Size = new Size(205, 29);
            panel17.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 0);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 0;
            label8.Text = "Alternate Group";
            // 
            // panel19
            // 
            panel19.Controls.Add(txtGroup);
            panel19.Location = new Point(214, 332);
            panel19.Name = "panel19";
            panel19.Size = new Size(271, 29);
            panel19.TabIndex = 14;
            // 
            // txtGroup
            // 
            txtGroup.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtGroup.Location = new Point(3, -1);
            txtGroup.Name = "txtGroup";
            txtGroup.Size = new Size(148, 27);
            txtGroup.TabIndex = 0;
            // 
            // groupForm
            // 
            groupForm.Controls.Add(tableLayoutPanel1);
            groupForm.Location = new Point(9, 3);
            groupForm.Name = "groupForm";
            groupForm.Size = new Size(816, 396);
            groupForm.TabIndex = 3;
            groupForm.TabStop = false;
            groupForm.Text = "Component Information";
            // 
            // panelEditOnly
            // 
            panelEditOnly.Controls.Add(groupBox2);
            panelEditOnly.Location = new Point(9, 405);
            panelEditOnly.Name = "panelEditOnly";
            panelEditOnly.Size = new Size(832, 179);
            panelEditOnly.TabIndex = 4;
            panelEditOnly.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboxExpiry);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtReason);
            groupBox2.Controls.Add(dateExpiry);
            groupBox2.Controls.Add(dateEffective);
            groupBox2.Location = new Point(3, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(826, 162);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Version Controls";
            // 
            // cboxExpiry
            // 
            cboxExpiry.AutoSize = true;
            cboxExpiry.Location = new Point(111, 120);
            cboxExpiry.Name = "cboxExpiry";
            cboxExpiry.Size = new Size(132, 24);
            cboxExpiry.TabIndex = 6;
            cboxExpiry.Text = "Set Expiry Date";
            cboxExpiry.UseVisualStyleBackColor = true;
            cboxExpiry.CheckedChanged += cboxExpiry_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 80);
            label11.Name = "label11";
            label11.Size = new Size(85, 20);
            label11.TabIndex = 5;
            label11.Text = "Expiry Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 50);
            label10.Name = "label10";
            label10.Size = new Size(102, 20);
            label10.TabIndex = 4;
            label10.Text = "Effective Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(392, 29);
            label9.Name = "label9";
            label9.Size = new Size(111, 20);
            label9.TabIndex = 3;
            label9.Text = "Change Reason";
            // 
            // txtReason
            // 
            txtReason.Location = new Point(509, 26);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.ScrollBars = ScrollBars.Vertical;
            txtReason.Size = new Size(298, 118);
            txtReason.TabIndex = 2;
            // 
            // dateExpiry
            // 
            dateExpiry.Enabled = false;
            dateExpiry.Format = DateTimePickerFormat.Short;
            dateExpiry.Location = new Point(111, 78);
            dateExpiry.Name = "dateExpiry";
            dateExpiry.Size = new Size(166, 27);
            dateExpiry.TabIndex = 1;
            // 
            // dateEffective
            // 
            dateEffective.Format = DateTimePickerFormat.Short;
            dateEffective.Location = new Point(112, 45);
            dateEffective.Name = "dateEffective";
            dateEffective.Size = new Size(166, 27);
            dateEffective.TabIndex = 0;
            // 
            // panel18
            // 
            panel18.Controls.Add(flowLayoutPanel1);
            panel18.Location = new Point(155, 756);
            panel18.Name = "panel18";
            panel18.Size = new Size(846, 59);
            panel18.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnReset);
            flowLayoutPanel1.Controls.Add(btnCacl);
            flowLayoutPanel1.Location = new Point(180, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(425, 53);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSave.IconColor = Color.DeepSkyBlue;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 24;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(103, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnCacl
            // 
            btnCacl.Location = new Point(203, 3);
            btnCacl.Name = "btnCacl";
            btnCacl.Size = new Size(94, 29);
            btnCacl.TabIndex = 2;
            btnCacl.Text = "Cancel";
            btnCacl.UseVisualStyleBackColor = true;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(groupForm);
            panelContent.Controls.Add(panelEditOnly);
            panelContent.Location = new Point(152, 160);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(849, 590);
            panelContent.TabIndex = 6;
            // 
            // BomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 832);
            Controls.Add(panelContent);
            Controls.Add(panel18);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "BomForm";
            Text = "BomForm";
            Load += BomForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            groupForm.ResumeLayout(false);
            panelEditOnly.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel18.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowHeader;
        private Panel panel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel8;
        private Label label2;
        private Panel panel3;
        private Button btnLookup;
        private TextBox txtCode;
        private Panel panel4;
        private Button btnAutoFill;
        private TextBox txtName;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel9;
        private Label label3;
        private Panel panel10;
        private Label label4;
        private Panel panel11;
        private Label label5;
        private Panel panel12;
        private Label label6;
        private Panel panel13;
        private Label label7;
        private Panel panel14;
        private Label label8;
        private Panel panel15;
        private Panel panel16;
        private Label lblComponent;
        private ComboBox combUom;
        private NumericUpDown numQty;
        private TextBox txtSequence;
        private CheckBox cboxCritical;
        private TextBox txtGroup;
        private GroupBox groupForm;
        private Panel panelEditOnly;
        private GroupBox groupBox2;
        private Panel panel18;
        private FlowLayoutPanel flowLayoutPanel1;
        //private Button btnSave;
        private Button btnReset;
        private Button btnCacl;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtReason;
        private DateTimePicker dateExpiry;
        private DateTimePicker dateEffective;
        private CheckBox cboxExpiry;
        private Panel panelContent;
        private Panel panel17;
        private Panel panel19;
        private CheckBox cboxTop;
        private ComboBox combParentCom;
        private Label label12;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}