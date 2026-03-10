namespace AppGenealogySystem.Ui.WOUi
{
    partial class WOForm
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
            ucHeader1 = new UcHeader();
            panel1 = new Panel();
            label12 = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            groupBox5 = new GroupBox();
            txtNote = new TextBox();
            label11 = new Label();
            groupBox4 = new GroupBox();
            panel10 = new Panel();
            txtSalesOrder = new TextBox();
            label10 = new Label();
            panel9 = new Panel();
            combCustomer = new ComboBox();
            label9 = new Label();
            groupBox3 = new GroupBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel7 = new Panel();
            combDateStart = new ComboBox();
            dateStart = new DateTimePicker();
            label7 = new Label();
            panel8 = new Panel();
            combDateEnd = new ComboBox();
            dateEnd = new DateTimePicker();
            label8 = new Label();
            groupBox2 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel4 = new Panel();
            txtProduct = new TextBox();
            btnLookup = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            panel5 = new Panel();
            btnView = new FontAwesome.Sharp.IconButton();
            combBomver = new ComboBox();
            label5 = new Label();
            panel6 = new Panel();
            combUOM = new ComboBox();
            numQtyPlan = new NumericUpDown();
            label6 = new Label();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            btnAuto = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtWONum = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            flowRadioType = new FlowLayoutPanel();
            label2 = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQtyPlan).BeginInit();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // ucHeader1
            // 
            ucHeader1.Dock = DockStyle.Top;
            ucHeader1.Location = new Point(0, 0);
            ucHeader1.Margin = new Padding(3, 2, 3, 2);
            ucHeader1.Name = "ucHeader1";
            ucHeader1.Size = new Size(1133, 41);
            ucHeader1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label12);
            panel1.Controls.Add(flowLayoutPanel4);
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(0, 46);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 633);
            panel1.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(143, 602);
            label12.Name = "label12";
            label12.Size = new Size(391, 15);
            label12.TabIndex = 6;
            label12.Text = "Tip: Save Draft = WO not active yet | Release WO = Ready for production ";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(iconButton1);
            flowLayoutPanel4.Controls.Add(iconButton2);
            flowLayoutPanel4.Controls.Add(iconButton3);
            flowLayoutPanel4.Location = new Point(144, 554);
            flowLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(712, 34);
            flowLayoutPanel4.TabIndex = 5;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton1.IconColor = Color.Turquoise;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 22;
            iconButton1.Location = new Point(3, 2);
            iconButton1.Margin = new Padding(3, 2, 3, 2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(101, 22);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "Save Draft";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Rocket;
            iconButton2.IconColor = Color.IndianRed;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 22;
            iconButton2.Location = new Point(110, 2);
            iconButton2.Margin = new Padding(3, 2, 3, 2);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(92, 22);
            iconButton2.TabIndex = 1;
            iconButton2.Text = "Release";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(208, 2);
            iconButton3.Margin = new Padding(3, 2, 3, 2);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(82, 22);
            iconButton3.TabIndex = 2;
            iconButton3.Text = "Cancel";
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtNote);
            groupBox5.Controls.Add(label11);
            groupBox5.Location = new Point(8, 438);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(1110, 116);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "📝 NOTES";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(136, 14);
            txtNote.Margin = new Padding(3, 2, 3, 2);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.ScrollBars = ScrollBars.Vertical;
            txtNote.Size = new Size(383, 98);
            txtNote.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(80, 26);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 0;
            label11.Text = "Notes";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(panel10);
            groupBox4.Controls.Add(panel9);
            groupBox4.Location = new Point(499, 309);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(624, 124);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "👤 CUSTOMER INFO (Optional - for Make-to-Order)   ";
            // 
            // panel10
            // 
            panel10.Controls.Add(txtSalesOrder);
            panel10.Controls.Add(label10);
            panel10.Location = new Point(5, 64);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(613, 34);
            panel10.TabIndex = 1;
            // 
            // txtSalesOrder
            // 
            txtSalesOrder.Location = new Point(138, 8);
            txtSalesOrder.Margin = new Padding(3, 2, 3, 2);
            txtSalesOrder.Name = "txtSalesOrder";
            txtSalesOrder.Size = new Size(191, 23);
            txtSalesOrder.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 10);
            label10.Name = "label10";
            label10.Size = new Size(86, 15);
            label10.TabIndex = 0;
            label10.Text = "Sales Order Ref";
            // 
            // panel9
            // 
            panel9.Controls.Add(combCustomer);
            panel9.Controls.Add(label9);
            panel9.Location = new Point(5, 25);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(613, 34);
            panel9.TabIndex = 0;
            // 
            // combCustomer
            // 
            combCustomer.FormattingEnabled = true;
            combCustomer.Location = new Point(138, 4);
            combCustomer.Margin = new Padding(3, 2, 3, 2);
            combCustomer.Name = "combCustomer";
            combCustomer.Size = new Size(191, 23);
            combCustomer.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 6);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 0;
            label9.Text = "Customer";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowLayoutPanel3);
            groupBox3.Location = new Point(3, 309);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(491, 124);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "📅 SCHEDULE";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(panel7);
            flowLayoutPanel3.Controls.Add(panel8);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(102, 12);
            flowLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(382, 108);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(combDateStart);
            panel7.Controls.Add(dateStart);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(3, 2);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(368, 46);
            panel7.TabIndex = 0;
            // 
            // combDateStart
            // 
            combDateStart.FormattingEnabled = true;
            combDateStart.Location = new Point(269, 10);
            combDateStart.Margin = new Padding(3, 2, 3, 2);
            combDateStart.Name = "combDateStart";
            combDateStart.Size = new Size(78, 23);
            combDateStart.TabIndex = 2;
            // 
            // dateStart
            // 
            dateStart.Format = DateTimePickerFormat.Custom;
            dateStart.Location = new Point(152, 11);
            dateStart.Margin = new Padding(3, 2, 3, 2);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(112, 23);
            dateStart.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 10);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(104, 15);
            label7.TabIndex = 0;
            label7.Text = "Planned Start Date";
            // 
            // panel8
            // 
            panel8.Controls.Add(combDateEnd);
            panel8.Controls.Add(dateEnd);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(3, 52);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(368, 46);
            panel8.TabIndex = 1;
            // 
            // combDateEnd
            // 
            combDateEnd.FormattingEnabled = true;
            combDateEnd.Location = new Point(269, 13);
            combDateEnd.Margin = new Padding(3, 2, 3, 2);
            combDateEnd.Name = "combDateEnd";
            combDateEnd.Size = new Size(78, 23);
            combDateEnd.TabIndex = 4;
            // 
            // dateEnd
            // 
            dateEnd.Format = DateTimePickerFormat.Custom;
            dateEnd.Location = new Point(152, 14);
            dateEnd.Margin = new Padding(3, 2, 3, 2);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(112, 23);
            dateEnd.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 15);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 0;
            label8.Text = "Planned End Date";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel2);
            groupBox2.Location = new Point(3, 160);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(1128, 145);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = " 📦 PRODUCT TO MANUFACTURE ";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Controls.Add(panel5);
            flowLayoutPanel2.Controls.Add(panel6);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(102, 20);
            flowLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(543, 121);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtProduct);
            panel4.Controls.Add(btnLookup);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(3, 2);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(538, 34);
            panel4.TabIndex = 0;
            // 
            // txtProduct
            // 
            txtProduct.BorderStyle = BorderStyle.FixedSingle;
            txtProduct.Enabled = false;
            txtProduct.Location = new Point(163, 9);
            txtProduct.Margin = new Padding(3, 2, 3, 2);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(204, 23);
            txtProduct.TabIndex = 3;
            // 
            // btnLookup
            // 
            btnLookup.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnLookup.IconColor = Color.DarkCyan;
            btnLookup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLookup.IconSize = 16;
            btnLookup.Location = new Point(377, 9);
            btnLookup.Margin = new Padding(3, 2, 3, 2);
            btnLookup.Name = "btnLookup";
            btnLookup.Size = new Size(99, 22);
            btnLookup.TabIndex = 2;
            btnLookup.Text = "Lookup";
            btnLookup.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLookup.UseVisualStyleBackColor = true;
            btnLookup.Click += btnLookup_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 12);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 0;
            label4.Text = "Product";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnView);
            panel5.Controls.Add(combBomver);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(3, 40);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(538, 38);
            panel5.TabIndex = 1;
            // 
            // btnView
            // 
            btnView.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnView.IconColor = Color.SandyBrown;
            btnView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnView.IconSize = 16;
            btnView.Location = new Point(377, 4);
            btnView.Margin = new Padding(3, 2, 3, 2);
            btnView.Name = "btnView";
            btnView.Size = new Size(99, 22);
            btnView.TabIndex = 2;
            btnView.Text = "View Bom";
            btnView.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnView.UseVisualStyleBackColor = true;
            // 
            // combBomver
            // 
            combBomver.FormattingEnabled = true;
            combBomver.Location = new Point(163, 4);
            combBomver.Margin = new Padding(3, 2, 3, 2);
            combBomver.Name = "combBomver";
            combBomver.Size = new Size(204, 23);
            combBomver.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 7);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 0;
            label5.Text = "Bom version";
            // 
            // panel6
            // 
            panel6.Controls.Add(combUOM);
            panel6.Controls.Add(numQtyPlan);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(3, 82);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(538, 34);
            panel6.TabIndex = 2;
            // 
            // combUOM
            // 
            combUOM.FormattingEnabled = true;
            combUOM.Location = new Point(277, 6);
            combUOM.Margin = new Padding(3, 2, 3, 2);
            combUOM.Name = "combUOM";
            combUOM.Size = new Size(78, 23);
            combUOM.TabIndex = 2;
            // 
            // numQtyPlan
            // 
            numQtyPlan.DecimalPlaces = 2;
            numQtyPlan.Location = new Point(163, 7);
            numQtyPlan.Margin = new Padding(3, 2, 3, 2);
            numQtyPlan.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQtyPlan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQtyPlan.Name = "numQtyPlan";
            numQtyPlan.Size = new Size(109, 23);
            numQtyPlan.TabIndex = 1;
            numQtyPlan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 8);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 0;
            label6.Text = "Quantity Planned";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Location = new Point(3, 2);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1128, 153);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " 📋 WORK ORDER INFORMATION";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(102, 20);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(570, 129);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAuto);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtWONum);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(541, 60);
            panel2.TabIndex = 0;
            // 
            // btnAuto
            // 
            btnAuto.IconChar = FontAwesome.Sharp.IconChar.DiceThree;
            btnAuto.IconColor = Color.LimeGreen;
            btnAuto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAuto.IconSize = 22;
            btnAuto.ImageAlign = ContentAlignment.MiddleLeft;
            btnAuto.Location = new Point(339, 10);
            btnAuto.Margin = new Padding(3, 2, 3, 2);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(80, 29);
            btnAuto.TabIndex = 4;
            btnAuto.Text = "Auto";
            btnAuto.TextAlign = ContentAlignment.MiddleRight;
            btnAuto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += btnAuto_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F);
            label3.Location = new Point(163, 45);
            label3.Name = "label3";
            label3.Size = new Size(118, 13);
            label3.TabIndex = 3;
            label3.Text = "Format WO-YYYY-NNN";
            // 
            // txtWONum
            // 
            txtWONum.Location = new Point(163, 10);
            txtWONum.Margin = new Padding(3, 2, 3, 2);
            txtWONum.Name = "txtWONum";
            txtWONum.Size = new Size(171, 23);
            txtWONum.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 14);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "WO Number";
            // 
            // panel3
            // 
            panel3.Controls.Add(flowRadioType);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 66);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(509, 52);
            panel3.TabIndex = 1;
            // 
            // flowRadioType
            // 
            flowRadioType.Location = new Point(163, 2);
            flowRadioType.Margin = new Padding(3, 2, 3, 2);
            flowRadioType.Name = "flowRadioType";
            flowRadioType.Size = new Size(344, 48);
            flowRadioType.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 16);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 0;
            label2.Text = "WO Type";
            // 
            // WOForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1133, 556);
            Controls.Add(panel1);
            Controls.Add(ucHeader1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "WOForm";
            Text = "WOForm";
            Load += WOForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            groupBox3.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            groupBox2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQtyPlan).EndInit();
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private UcHeader ucHeader1;
        private Panel panel1;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnAuto;
        private Label label3;
        private TextBox txtWONum;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private FlowLayoutPanel flowRadioType;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btnLookup;
        private ComboBox combBomver;
        private Label label4;
        private Panel panel5;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton btnView;
        private ComboBox combUOM;
        private Label label5;
        private ComboBox comboBox3;
        private NumericUpDown numQtyPlan;
        private Label label6;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel7;
        private DateTimePicker dateStart;
        private Label label7;
        private Panel panel8;
        private Label label8;
        private GroupBox groupBox5;
        private TextBox txtNote;
        private Label label11;
        private Panel panel10;
        private TextBox txtSalesOrder;
        private Label label10;
        private Panel panel9;
        private ComboBox combCustomer;
        private Label label9;
        private ComboBox combDateStart;
        private ComboBox combDateEnd;
        private DateTimePicker dateEnd;
        private Label label12;
        private FlowLayoutPanel flowLayoutPanel4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private TextBox txtProduct;
    }
}