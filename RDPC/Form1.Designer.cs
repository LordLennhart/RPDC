namespace RDPC
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connectBtn = new MetroFramework.Controls.MetroButton();
            this.shutdownBtn = new MetroFramework.Controls.MetroButton();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.rebootBtn = new MetroFramework.Controls.MetroButton();
            this.signoffBtn = new MetroFramework.Controls.MetroButton();
            this.openrdpLabel = new System.Windows.Forms.LinkLabel();
            this.creationLabel = new System.Windows.Forms.Label();
            this.dragAreaPanel = new System.Windows.Forms.Panel();
            this.changeFormatPanel = new System.Windows.Forms.Panel();
            this.closeImage = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectBtn.Location = new System.Drawing.Point(268, 57);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(105, 23);
            this.connectBtn.TabIndex = 4;
            this.connectBtn.Text = "Verbinden";
            this.connectBtn.UseSelectable = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // shutdownBtn
            // 
            this.shutdownBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shutdownBtn.Location = new System.Drawing.Point(379, 57);
            this.shutdownBtn.Name = "shutdownBtn";
            this.shutdownBtn.Size = new System.Drawing.Size(105, 23);
            this.shutdownBtn.TabIndex = 6;
            this.shutdownBtn.Text = "Herunterfahren";
            this.shutdownBtn.UseSelectable = true;
            this.shutdownBtn.Click += new System.EventHandler(this.shutdownBtn_Click);
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadingLabel.Location = new System.Drawing.Point(419, 83);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(35, 13);
            this.loadingLabel.TabIndex = 7;
            this.loadingLabel.Text = "label1";
            // 
            // rebootBtn
            // 
            this.rebootBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rebootBtn.Location = new System.Drawing.Point(490, 57);
            this.rebootBtn.Name = "rebootBtn";
            this.rebootBtn.Size = new System.Drawing.Size(105, 23);
            this.rebootBtn.TabIndex = 8;
            this.rebootBtn.Text = "Neustarten";
            this.rebootBtn.UseSelectable = true;
            this.rebootBtn.Click += new System.EventHandler(this.rebootBtn_Click);
            // 
            // signoffBtn
            // 
            this.signoffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signoffBtn.Location = new System.Drawing.Point(602, 57);
            this.signoffBtn.Name = "signoffBtn";
            this.signoffBtn.Size = new System.Drawing.Size(105, 23);
            this.signoffBtn.TabIndex = 16;
            this.signoffBtn.Text = "Abmelden";
            this.signoffBtn.UseSelectable = true;
            this.signoffBtn.Click += new System.EventHandler(this.signoffBtn_Click);
            // 
            // openrdpLabel
            // 
            this.openrdpLabel.AutoSize = true;
            this.openrdpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openrdpLabel.Location = new System.Drawing.Point(599, 24);
            this.openrdpLabel.Name = "openrdpLabel";
            this.openrdpLabel.Size = new System.Drawing.Size(111, 13);
            this.openrdpLabel.TabIndex = 17;
            this.openrdpLabel.TabStop = true;
            this.openrdpLabel.Text = "RDP Datei bearbeiten";
            this.openrdpLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openrdpLabel_LinkClicked);
            // 
            // creationLabel
            // 
            this.creationLabel.AutoSize = true;
            this.creationLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.creationLabel.Location = new System.Drawing.Point(12, 97);
            this.creationLabel.Name = "creationLabel";
            this.creationLabel.Size = new System.Drawing.Size(134, 13);
            this.creationLabel.TabIndex = 18;
            this.creationLabel.Text = "Made By Lennart Schröder";
            this.creationLabel.MouseEnter += new System.EventHandler(this.creationLabel_MouseEnter);
            this.creationLabel.MouseLeave += new System.EventHandler(this.creationLabel_MouseLeave);
            // 
            // dragAreaPanel
            // 
            this.dragAreaPanel.Location = new System.Drawing.Point(12, 5);
            this.dragAreaPanel.Name = "dragAreaPanel";
            this.dragAreaPanel.Size = new System.Drawing.Size(676, 16);
            this.dragAreaPanel.TabIndex = 20;
            this.dragAreaPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragAreaPanel_MouseDown);
            // 
            // changeFormatPanel
            // 
            this.changeFormatPanel.BackgroundImage = global::RDPC.Properties.Resources.SqaureIcon;
            this.changeFormatPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeFormatPanel.Location = new System.Drawing.Point(691, 97);
            this.changeFormatPanel.Name = "changeFormatPanel";
            this.changeFormatPanel.Size = new System.Drawing.Size(16, 16);
            this.changeFormatPanel.TabIndex = 21;
            this.changeFormatPanel.Click += new System.EventHandler(this.changeFormatPanel_Click);
            // 
            // closeImage
            // 
            this.closeImage.BackgroundImage = global::RDPC.Properties.Resources.X;
            this.closeImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeImage.Location = new System.Drawing.Point(694, 5);
            this.closeImage.Name = "closeImage";
            this.closeImage.Size = new System.Drawing.Size(16, 16);
            this.closeImage.TabIndex = 19;
            this.closeImage.Click += new System.EventHandler(this.panel2_Click);
            this.closeImage.MouseEnter += new System.EventHandler(this.closeImage_MouseEnter);
            this.closeImage.MouseLeave += new System.EventHandler(this.closeImage_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RDPC.Properties.Resources.ComTec_Logo_ohne_Schriftzug_transparent_1_;
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 69);
            this.panel1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(719, 119);
            this.Controls.Add(this.changeFormatPanel);
            this.Controls.Add(this.dragAreaPanel);
            this.Controls.Add(this.closeImage);
            this.Controls.Add(this.creationLabel);
            this.Controls.Add(this.openrdpLabel);
            this.Controls.Add(this.signoffBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rebootBtn);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.shutdownBtn);
            this.Controls.Add(this.connectBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RDPC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton connectBtn;
        private MetroFramework.Controls.MetroButton shutdownBtn;
        private System.Windows.Forms.Label loadingLabel;
        private MetroFramework.Controls.MetroButton rebootBtn;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton signoffBtn;
        private System.Windows.Forms.LinkLabel openrdpLabel;
        private System.Windows.Forms.Label creationLabel;
        private System.Windows.Forms.Panel closeImage;
        private System.Windows.Forms.Panel dragAreaPanel;
        private System.Windows.Forms.Panel changeFormatPanel;
    }
}

