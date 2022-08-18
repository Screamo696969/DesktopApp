namespace BigApp
{
    partial class TheApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheApp));
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.radio = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.Button();
            this.currency = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.MyApp = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMainMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panelHome.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMainMenu.Controls.Add(this.radio);
            this.panelMainMenu.Controls.Add(this.settings);
            this.panelMainMenu.Controls.Add(this.calc);
            this.panelMainMenu.Controls.Add(this.currency);
            this.panelMainMenu.Controls.Add(this.panelLogo);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(200, 750);
            this.panelMainMenu.TabIndex = 0;
            this.panelMainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainMenu_Paint);
            // 
            // radio
            // 
            this.radio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.radio.Dock = System.Windows.Forms.DockStyle.Top;
            this.radio.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radio.Image = ((System.Drawing.Image)(resources.GetObject("radio.Image")));
            this.radio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radio.Location = new System.Drawing.Point(0, 260);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(200, 70);
            this.radio.TabIndex = 5;
            this.radio.Text = "     Radio";
            this.radio.UseVisualStyleBackColor = false;
            this.radio.Click += new System.EventHandler(this.radio_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settings.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings.Location = new System.Drawing.Point(0, 670);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(200, 80);
            this.settings.TabIndex = 4;
            this.settings.Text = "     Settings";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // calc
            // 
            this.calc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.calc.Dock = System.Windows.Forms.DockStyle.Top;
            this.calc.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calc.Image = ((System.Drawing.Image)(resources.GetObject("calc.Image")));
            this.calc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calc.Location = new System.Drawing.Point(0, 180);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(200, 80);
            this.calc.TabIndex = 3;
            this.calc.Text = "     Calculator";
            this.calc.UseVisualStyleBackColor = false;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // currency
            // 
            this.currency.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.currency.Dock = System.Windows.Forms.DockStyle.Top;
            this.currency.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currency.Image = ((System.Drawing.Image)(resources.GetObject("currency.Image")));
            this.currency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.currency.Location = new System.Drawing.Point(0, 100);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(200, 80);
            this.currency.TabIndex = 2;
            this.currency.Text = "     Currency";
            this.currency.UseVisualStyleBackColor = false;
            this.currency.Click += new System.EventHandler(this.currency_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.panel1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.MyApp);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(6, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(70, 70);
            this.Logo.TabIndex = 6;
            this.Logo.TabStop = false;
            this.Logo.WaitOnLoad = true;
            // 
            // MyApp
            // 
            this.MyApp.AutoSize = true;
            this.MyApp.BackColor = System.Drawing.Color.Transparent;
            this.MyApp.Font = new System.Drawing.Font("Myriad Pro Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MyApp.ForeColor = System.Drawing.Color.Transparent;
            this.MyApp.Location = new System.Drawing.Point(79, 28);
            this.MyApp.Name = "MyApp";
            this.MyApp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyApp.Size = new System.Drawing.Size(118, 37);
            this.MyApp.TabIndex = 1;
            this.MyApp.Text = "My App";
            this.MyApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.RosyBrown;
            this.panelHome.Controls.Add(this.lblTitle);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panelHome.Location = new System.Drawing.Point(200, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(750, 100);
            this.panelHome.TabIndex = 1;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHome_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(349, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.label1);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(200, 100);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(750, 650);
            this.panelDesktopPane.TabIndex = 0;
            this.panelDesktopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPane_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(301, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME";
            // 
            // TheApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 750);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TheApp";
            this.Text = "TheApp";
            this.Load += new System.EventHandler(this.TheApp_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMainMenu;
        private Button currency;
        private Panel panelLogo;
        private Button calc;
        private Button settings;
        private Panel panelHome;
        private Panel panel1;
        private Panel panelDesktopPane;
        private Label lblTitle;
        private Button radio;
        private Label MyApp;
        private PictureBox Logo;
        private Label label1;
    }
}