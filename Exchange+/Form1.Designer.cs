namespace Exchange_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_In = new System.Windows.Forms.TextBox();
            this.label_Insert = new System.Windows.Forms.Label();
            this.text_Result = new System.Windows.Forms.TextBox();
            this.combo_In = new System.Windows.Forms.ComboBox();
            this.button_Result = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_In
            // 
            this.text_In.Location = new System.Drawing.Point(54, 46);
            this.text_In.Name = "text_In";
            this.text_In.Size = new System.Drawing.Size(100, 20);
            this.text_In.TabIndex = 0;
            // 
            // label_Insert
            // 
            this.label_Insert.AutoSize = true;
            this.label_Insert.Location = new System.Drawing.Point(51, 29);
            this.label_Insert.Name = "label_Insert";
            this.label_Insert.Size = new System.Drawing.Size(30, 13);
            this.label_Insert.TabIndex = 1;
            this.label_Insert.Text = "UAH";
            // 
            // text_Result
            // 
            this.text_Result.Location = new System.Drawing.Point(187, 84);
            this.text_Result.Name = "text_Result";
            this.text_Result.Size = new System.Drawing.Size(100, 20);
            this.text_Result.TabIndex = 2;
            // 
            // combo_In
            // 
            this.combo_In.FormattingEnabled = true;
            this.combo_In.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "HUF"});
            this.combo_In.Location = new System.Drawing.Point(187, 45);
            this.combo_In.Name = "combo_In";
            this.combo_In.Size = new System.Drawing.Size(100, 21);
            this.combo_In.TabIndex = 4;
            // 
            // button_Result
            // 
            this.button_Result.Location = new System.Drawing.Point(54, 84);
            this.button_Result.Name = "button_Result";
            this.button_Result.Size = new System.Drawing.Size(75, 23);
            this.button_Result.TabIndex = 5;
            this.button_Result.Text = "Result";
            this.button_Result.UseVisualStyleBackColor = true;
            this.button_Result.Click += new System.EventHandler(this.button_Result_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(54, 113);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 6;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(313, 43);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 7;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 357);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Result);
            this.Controls.Add(this.combo_In);
            this.Controls.Add(this.text_Result);
            this.Controls.Add(this.label_Insert);
            this.Controls.Add(this.text_In);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_In;
        private System.Windows.Forms.Label label_Insert;
        private System.Windows.Forms.TextBox text_Result;
        private System.Windows.Forms.ComboBox combo_In;
        private System.Windows.Forms.Button button_Result;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Add;
    }
}

