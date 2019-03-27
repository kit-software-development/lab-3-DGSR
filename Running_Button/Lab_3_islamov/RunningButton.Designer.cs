namespace Lab_3_islamov
{
    partial class Running_Button
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
            this.RunButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RunButton.Location = new System.Drawing.Point(255, 269);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "Push Me";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.OnButton_Click);
            this.RunButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnButton_Click);
            this.RunButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Runbutton_MouseMove);
            // 
            // Running_Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.RunButton);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Running_Button";
            this.Text = "Running Button";
            this.ClientSizeChanged += new System.EventHandler(this.FormChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunButton;
    }
}

