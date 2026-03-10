namespace AppGenealogySystem
{
    partial class UcHeader
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
            panelHeader = new Panel();
            panelButton = new FlowLayoutPanel();
            panelTitle = new Panel();
            lblTitle = new Label();
            panelHeader.SuspendLayout();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(panelButton);
            panelHeader.Controls.Add(panelTitle);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1269, 55);
            panelHeader.TabIndex = 0;
            // 
            // panelButton
            // 
            panelButton.Location = new Point(815, 3);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(451, 49);
            panelButton.TabIndex = 3;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(lblTitle);
            panelTitle.Location = new Point(3, 3);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(806, 52);
            panelTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F);
            lblTitle.Location = new Point(86, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(63, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // UcHeader
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelHeader);
            Name = "UcHeader";
            Size = new Size(1269, 55);
            panelHeader.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelTitle;
        private FlowLayoutPanel panelButton;
    }
}
