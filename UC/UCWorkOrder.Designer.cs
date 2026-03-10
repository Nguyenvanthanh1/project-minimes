namespace AppGenealogySystem.UC
{
    partial class UCWorkOrder
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
            btnNew = new FontAwesome.Sharp.IconButton();
            ucHeader1 = new UcHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNew);
            panel1.Location = new Point(3, 50);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1249, 131);
            panel1.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnNew.IconColor = Color.LightSeaGreen;
            btnNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNew.IconSize = 16;
            btnNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnNew.Location = new Point(785, 81);
            btnNew.Margin = new Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(98, 22);
            btnNew.TabIndex = 1;
            btnNew.Text = "New WO";
            btnNew.TextAlign = ContentAlignment.MiddleRight;
            btnNew.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // ucHeader1
            // 
            ucHeader1.Dock = DockStyle.Top;
            ucHeader1.Location = new Point(0, 0);
            ucHeader1.Margin = new Padding(3, 2, 3, 2);
            ucHeader1.Name = "ucHeader1";
            ucHeader1.Size = new Size(1254, 45);
            ucHeader1.TabIndex = 1;
            // 
            // UCWorkOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucHeader1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCWorkOrder";
            Size = new Size(1254, 560);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private UcHeader ucHeader1;
        private FontAwesome.Sharp.IconButton btnNew;
    }
}
