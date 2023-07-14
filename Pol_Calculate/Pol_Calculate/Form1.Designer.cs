namespace Pol_Calculate
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
            this.Result = new System.Windows.Forms.Button();
            this.FunctionTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.DiffTextBox = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(2, 33);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(336, 53);
            this.Result.TabIndex = 0;
            this.Result.Text = "Результат";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.button1_Click);
            // 
            // FunctionTextBox
            // 
            this.FunctionTextBox.Location = new System.Drawing.Point(2, 5);
            this.FunctionTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.FunctionTextBox.Name = "FunctionTextBox";
            this.FunctionTextBox.Size = new System.Drawing.Size(678, 20);
            this.FunctionTextBox.TabIndex = 1;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(2, 92);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(336, 355);
            this.ResultTextBox.TabIndex = 4;
            // 
            // DiffTextBox
            // 
            this.DiffTextBox.Location = new System.Drawing.Point(344, 92);
            this.DiffTextBox.Multiline = true;
            this.DiffTextBox.Name = "DiffTextBox";
            this.DiffTextBox.Size = new System.Drawing.Size(336, 355);
            this.DiffTextBox.TabIndex = 5;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(344, 33);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(336, 53);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Очистить историю";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.DiffTextBox);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.FunctionTextBox);
            this.Controls.Add(this.Result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.TextBox FunctionTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TextBox DiffTextBox;
        private System.Windows.Forms.Button Clear;
    }
}

