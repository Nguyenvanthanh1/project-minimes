namespace AppGenealogySystem.Ui.Bom
{
    partial class BomVersionForm
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
            btnSave = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            cboxDefault = new CheckBox();
            label6 = new Label();
            panel5 = new Panel();
            txtReason = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            cboxExpire = new CheckBox();
            label3 = new Label();
            dateExpiry = new DateTimePicker();
            panel3 = new Panel();
            dateEffec = new DateTimePicker();
            label4 = new Label();
            panel2 = new Panel();
            txtName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 51);
            panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(755, 13);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(145, 23);
            label1.TabIndex = 0;
            label1.Text = "New Bom Version";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(117, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(646, 439);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form Information";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel6, 0, 4);
            tableLayoutPanel1.Controls.Add(panel5, 0, 3);
            tableLayoutPanel1.Controls.Add(panel4, 0, 2);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Location = new Point(6, 42);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.272728F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.Size = new Size(634, 361);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(cboxDefault);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(3, 296);
            panel6.Name = "panel6";
            panel6.Size = new Size(544, 62);
            panel6.TabIndex = 4;
            // 
            // cboxDefault
            // 
            cboxDefault.AutoSize = true;
            cboxDefault.Location = new Point(184, 16);
            cboxDefault.Name = "cboxDefault";
            cboxDefault.Size = new Size(52, 24);
            cboxDefault.TabIndex = 2;
            cboxDefault.Text = "Yes";
            cboxDefault.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 16);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 1;
            label6.Text = "Is Default";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtReason);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(3, 198);
            panel5.Name = "panel5";
            panel5.Size = new Size(544, 92);
            panel5.TabIndex = 3;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(184, 3);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.ScrollBars = ScrollBars.Vertical;
            txtReason.Size = new Size(275, 86);
            txtReason.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 29);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 1;
            label5.Text = "Change Reason";
            // 
            // panel4
            // 
            panel4.Controls.Add(cboxExpire);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(dateExpiry);
            panel4.Location = new Point(3, 133);
            panel4.Name = "panel4";
            panel4.Size = new Size(622, 59);
            panel4.TabIndex = 2;
            // 
            // cboxExpire
            // 
            cboxExpire.AutoSize = true;
            cboxExpire.Location = new Point(454, 8);
            cboxExpire.Name = "cboxExpire";
            cboxExpire.Size = new Size(51, 24);
            cboxExpire.TabIndex = 3;
            cboxExpire.Text = "No";
            cboxExpire.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 12);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 1;
            label3.Text = "Expiry Date";
            // 
            // dateExpiry
            // 
            dateExpiry.Location = new Point(184, 7);
            dateExpiry.Name = "dateExpiry";
            dateExpiry.Size = new Size(250, 27);
            dateExpiry.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(dateEffec);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(3, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(544, 59);
            panel3.TabIndex = 1;
            // 
            // dateEffec
            // 
            dateEffec.Location = new Point(184, 12);
            dateEffec.Name = "dateEffec";
            dateEffec.Size = new Size(250, 27);
            dateEffec.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 19);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 1;
            label4.Text = "Effective Date(*)";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 59);
            panel2.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(184, 15);
            txtName.Name = "txtName";
            txtName.Size = new Size(245, 27);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 17);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 0;
            label2.Text = "Name(*)";
            // 
            // BomVersionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 549);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "BomVersionForm";
            Text = "BomVersionForm";
            FormClosed += BomVersionForm_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSave;
        private Label label1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel6;
        private Label label6;
        private Panel panel5;
        private Label label5;
        private Panel panel4;
        private DateTimePicker dateExpiry;
        private Label label4;
        private Panel panel3;
        private DateTimePicker dateEffec;
        private Label label3;
        private Panel panel2;
        private Label label2;
        private CheckBox cboxDefault;
        private TextBox txtReason;
        private CheckBox cboxExpire;
        private TextBox txtName;
    }
}