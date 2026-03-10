namespace AppGenealogySystem.Ui.Bom
{
    partial class BomVersionHistory
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
            panelHeader = new Panel();
            dataBverHistory = new DataGridView();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnView = new FontAwesome.Sharp.IconButton();
            btnCopy = new FontAwesome.Sharp.IconButton();
            btnDel = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataBverHistory).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ucHeader1
            // 
            ucHeader1.Dock = DockStyle.Top;
            ucHeader1.Location = new Point(0, 0);
            ucHeader1.Name = "ucHeader1";
            ucHeader1.Size = new Size(1226, 59);
            ucHeader1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panelHeader);
            panel1.Location = new Point(0, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(1217, 59);
            panel1.TabIndex = 1;
            // 
            // panelHeader
            // 
            panelHeader.Location = new Point(379, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(442, 56);
            panelHeader.TabIndex = 0;
            // 
            // dataBverHistory
            // 
            dataBverHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataBverHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataBverHistory.Location = new Point(0, 130);
            dataBverHistory.Name = "dataBverHistory";
            dataBverHistory.RowHeadersWidth = 51;
            dataBverHistory.Size = new Size(1217, 384);
            dataBverHistory.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 560);
            label1.Name = "label1";
            label1.Size = new Size(371, 20);
            label1.TabIndex = 5;
            label1.Text = "Note: Cannot delete version đã có Work Order sử dụng";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnView);
            flowLayoutPanel1.Controls.Add(btnCopy);
            flowLayoutPanel1.Controls.Add(btnDel);
            flowLayoutPanel1.Location = new Point(256, 520);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(390, 37);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btnView
            // 
            btnView.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnView.IconColor = Color.LightSeaGreen;
            btnView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnView.IconSize = 22;
            btnView.Location = new Point(3, 3);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 0;
            btnView.Text = "View";
            btnView.TextAlign = ContentAlignment.MiddleRight;
            btnView.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnView.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            btnCopy.IconChar = FontAwesome.Sharp.IconChar.Copy;
            btnCopy.IconColor = Color.Chocolate;
            btnCopy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCopy.IconSize = 22;
            btnCopy.ImageAlign = ContentAlignment.MiddleLeft;
            btnCopy.Location = new Point(103, 3);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(94, 29);
            btnCopy.TabIndex = 1;
            btnCopy.Text = "Copy";
            btnCopy.TextAlign = ContentAlignment.MiddleRight;
            btnCopy.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            btnDel.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            btnDel.IconColor = Color.IndianRed;
            btnDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDel.IconSize = 22;
            btnDel.ImageAlign = ContentAlignment.MiddleLeft;
            btnDel.Location = new Point(203, 3);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 2;
            btnDel.Text = "Delete";
            btnDel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDel.UseVisualStyleBackColor = true;
            // 
            // BomVersionHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 612);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataBverHistory);
            Controls.Add(panel1);
            Controls.Add(ucHeader1);
            Name = "BomVersionHistory";
            Text = "BomVersionHistory";
            Load += BomVersionHistory_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataBverHistory).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UcHeader ucHeader1;
        private Panel panel1;
        private Panel panelHeader;
        private DataGridView dataBverHistory;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnView;
        private FontAwesome.Sharp.IconButton btnCopy;
        private FontAwesome.Sharp.IconButton btnDel;
    }
}