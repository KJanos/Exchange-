namespace Exchange_
{
    partial class Form2
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
            this.text_CurrencyAdd = new System.Windows.Forms.TextBox();
            this.label_CurrencyAdd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_dif = new System.Windows.Forms.TextBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_CurrencyAdd
            // 
            this.text_CurrencyAdd.Location = new System.Drawing.Point(13, 58);
            this.text_CurrencyAdd.Name = "text_CurrencyAdd";
            this.text_CurrencyAdd.Size = new System.Drawing.Size(100, 20);
            this.text_CurrencyAdd.TabIndex = 0;
            // 
            // label_CurrencyAdd
            // 
            this.label_CurrencyAdd.AutoSize = true;
            this.label_CurrencyAdd.Location = new System.Drawing.Point(13, 24);
            this.label_CurrencyAdd.Name = "label_CurrencyAdd";
            this.label_CurrencyAdd.Size = new System.Drawing.Size(74, 13);
            this.label_CurrencyAdd.TabIndex = 1;
            this.label_CurrencyAdd.Text = "New Currency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "1 UAH =";
            // 
            // text_dif
            // 
            this.text_dif.Location = new System.Drawing.Point(228, 58);
            this.text_dif.Name = "text_dif";
            this.text_dif.Size = new System.Drawing.Size(100, 20);
            this.text_dif.TabIndex = 3;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(38, 97);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 4;
            this.button_Close.Text = "Add";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 152);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.text_dif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_CurrencyAdd);
            this.Controls.Add(this.text_CurrencyAdd);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_CurrencyAdd;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox text_CurrencyAdd;
        public System.Windows.Forms.TextBox text_dif;
        private System.Windows.Forms.Button button_Close;
    }
}