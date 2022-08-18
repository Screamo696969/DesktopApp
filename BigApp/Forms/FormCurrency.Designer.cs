namespace BigApp.Forms
{
    partial class FormCurrency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCurrency));
            this.listCurrency = new System.Windows.Forms.ComboBox();
            this.priceToUAH = new System.Windows.Forms.TextBox();
            this.summ = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameOfValute = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listCurrency
            // 
            this.listCurrency.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listCurrency.FormattingEnabled = true;
            this.listCurrency.Location = new System.Drawing.Point(262, 30);
            this.listCurrency.Name = "listCurrency";
            this.listCurrency.Size = new System.Drawing.Size(121, 45);
            this.listCurrency.TabIndex = 0;
            this.listCurrency.SelectedIndexChanged += new System.EventHandler(this.listCurrency_SelectedIndexChanged);
            // 
            // priceToUAH
            // 
            this.priceToUAH.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceToUAH.Location = new System.Drawing.Point(493, 179);
            this.priceToUAH.Name = "priceToUAH";
            this.priceToUAH.Size = new System.Drawing.Size(121, 43);
            this.priceToUAH.TabIndex = 1;
            this.priceToUAH.TextChanged += new System.EventHandler(this.priceToUAH_TextChanged);
            // 
            // summ
            // 
            this.summ.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.summ.Location = new System.Drawing.Point(493, 261);
            this.summ.Name = "summ";
            this.summ.Size = new System.Drawing.Size(121, 43);
            this.summ.TabIndex = 2;
            this.summ.TextChanged += new System.EventHandler(this.summ_TextChanged);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(327, 443);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 43);
            this.result.TabIndex = 3;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(274, 345);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(162, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Конвертировать";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(493, 425);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(96, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Скопировать";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(493, 454);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите валюту";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(93, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Курс к UAH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(93, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введите сумму в валюте";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(157, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Результат";
            // 
            // NameOfValute
            // 
            this.NameOfValute.AutoSize = true;
            this.NameOfValute.Font = new System.Drawing.Font("Open Sans Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameOfValute.Location = new System.Drawing.Point(416, 30);
            this.NameOfValute.Name = "NameOfValute";
            this.NameOfValute.Size = new System.Drawing.Size(63, 37);
            this.NameOfValute.TabIndex = 11;
            this.NameOfValute.Text = "test";
            this.NameOfValute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NameOfValute);
            this.panel1.Controls.Add(this.listCurrency);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 100);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.result);
            this.Controls.Add(this.summ);
            this.Controls.Add(this.priceToUAH);
            this.DoubleBuffered = true;
            this.Name = "FormCurrency";
            this.Text = "FormCurrency";
            this.Load += new System.EventHandler(this.FormCurrency_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox listCurrency;
        private TextBox priceToUAH;
        private TextBox summ;
        private TextBox result;
        private Button btnConvert;
        private Button btnCopy;
        private Button btnClear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label NameOfValute;
        private Panel panel1;
    }
}