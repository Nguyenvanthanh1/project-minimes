namespace AppGenealogySystem.Ui.Product
{
    partial class ProductView
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
            button1 = new Button();
            label1 = new Label();
            panelHeader = new Panel();
            flowHeader = new FlowLayoutPanel();
            panel3 = new Panel();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            flowBaseInfo = new FlowLayoutPanel();
            txtBoxDesc = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            flowStatistics = new FlowLayoutPanel();
            recentBox = new GroupBox();
            flowRecent = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            panelHeader.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            recentBox.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1163, 49);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(942, 11);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 15);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Product View";
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(flowHeader);
            panelHeader.Location = new Point(2, 58);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1163, 89);
            panelHeader.TabIndex = 1;
            // 
            // flowHeader
            // 
            flowHeader.FlowDirection = FlowDirection.TopDown;
            flowHeader.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowHeader.Location = new Point(152, 3);
            flowHeader.Name = "flowHeader";
            flowHeader.Size = new Size(805, 86);
            flowHeader.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(splitContainer1);
            panel3.Location = new Point(2, 153);
            panel3.Name = "panel3";
            panel3.Size = new Size(1163, 525);
            panel3.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(1163, 525);
            splitContainer1.SplitterDistance = 448;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 522);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Base Information";
            // 
            // panel2
            // 
            panel2.Controls.Add(flowBaseInfo);
            panel2.Controls.Add(txtBoxDesc);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(20, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 496);
            panel2.TabIndex = 0;
            // 
            // flowBaseInfo
            // 
            flowBaseInfo.FlowDirection = FlowDirection.TopDown;
            flowBaseInfo.Location = new Point(20, 192);
            flowBaseInfo.Name = "flowBaseInfo";
            flowBaseInfo.Size = new Size(384, 298);
            flowBaseInfo.TabIndex = 2;
            // 
            // txtBoxDesc
            // 
            txtBoxDesc.Location = new Point(20, 36);
            txtBoxDesc.Multiline = true;
            txtBoxDesc.Name = "txtBoxDesc";
            txtBoxDesc.ScrollBars = ScrollBars.Both;
            txtBoxDesc.Size = new Size(384, 141);
            txtBoxDesc.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 13);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 0;
            label2.Text = "Description :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowStatistics);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(688, 519);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Statistics";
            // 
            // flowStatistics
            // 
            flowStatistics.FlowDirection = FlowDirection.TopDown;
            flowStatistics.Location = new Point(30, 26);
            flowStatistics.Name = "flowStatistics";
            flowStatistics.Size = new Size(582, 466);
            flowStatistics.TabIndex = 0;
            // 
            // recentBox
            // 
            recentBox.Controls.Add(flowRecent);
            recentBox.Location = new Point(136, 684);
            recentBox.Name = "recentBox";
            recentBox.Size = new Size(933, 133);
            recentBox.TabIndex = 3;
            recentBox.TabStop = false;
            recentBox.Text = "Recent";
            // 
            // flowRecent
            // 
            flowRecent.AutoScroll = true;
            flowRecent.Location = new Point(6, 26);
            flowRecent.Name = "flowRecent";
            flowRecent.Size = new Size(909, 93);
            flowRecent.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Location = new Point(269, 823);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(643, 55);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(103, 3);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(203, 3);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 2;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(303, 3);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 3;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 890);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(recentBox);
            Controls.Add(panel3);
            Controls.Add(panelHeader);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "ProductView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelHeader.ResumeLayout(false);
            panel3.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            recentBox.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Panel panelHeader;
        private Panel panel3;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private Panel panel2;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowHeader;
        private Label label2;
        private FlowLayoutPanel flowBaseInfo;
        private TextBox txtBoxDesc;
        private FlowLayoutPanel flowStatistics;
        private GroupBox recentBox;
        private FlowLayoutPanel flowRecent;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}