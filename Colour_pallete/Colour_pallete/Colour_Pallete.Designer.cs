namespace Colour_pallete
{
    partial class Colour_Pallete
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
            this.RedBar = new System.Windows.Forms.TrackBar();
            this.GreenBar = new System.Windows.Forms.TrackBar();
            this.BlueBar = new System.Windows.Forms.TrackBar();
            this.Pallete = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).BeginInit();
            this.SuspendLayout();
            // 
            // RedBar
            // 
            this.RedBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RedBar.LargeChange = 15;
            this.RedBar.Location = new System.Drawing.Point(270, 10);
            this.RedBar.Maximum = 255;
            this.RedBar.Name = "RedBar";
            this.RedBar.Size = new System.Drawing.Size(202, 45);
            this.RedBar.TabIndex = 0;
            this.RedBar.TickFrequency = 17;
            this.RedBar.Value = 125;
            this.RedBar.ValueChanged += new System.EventHandler(this.RedChange);
            // 
            // GreenBar
            // 
            this.GreenBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GreenBar.LargeChange = 14;
            this.GreenBar.Location = new System.Drawing.Point(270, 61);
            this.GreenBar.Maximum = 255;
            this.GreenBar.Name = "GreenBar";
            this.GreenBar.Size = new System.Drawing.Size(202, 45);
            this.GreenBar.TabIndex = 3;
            this.GreenBar.TickFrequency = 17;
            this.GreenBar.Value = 125;
            this.GreenBar.ValueChanged += new System.EventHandler(this.RedChange);
            // 
            // BlueBar
            // 
            this.BlueBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BlueBar.LargeChange = 14;
            this.BlueBar.Location = new System.Drawing.Point(270, 112);
            this.BlueBar.Maximum = 255;
            this.BlueBar.Name = "BlueBar";
            this.BlueBar.Size = new System.Drawing.Size(202, 45);
            this.BlueBar.TabIndex = 4;
            this.BlueBar.TickFrequency = 17;
            this.BlueBar.Value = 125;
            this.BlueBar.ValueChanged += new System.EventHandler(this.RedChange);
            // 
            // Pallete
            // 
            this.Pallete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Pallete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Pallete.Location = new System.Drawing.Point(12, 10);
            this.Pallete.Name = "Pallete";
            this.Pallete.Size = new System.Drawing.Size(211, 144);
            this.Pallete.TabIndex = 5;
            this.Pallete.MouseHover += new System.EventHandler(this.ShowColour);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Blue";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Green";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "255";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "255";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "255";
            // 
            // Colour_Pallete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pallete);
            this.Controls.Add(this.BlueBar);
            this.Controls.Add(this.GreenBar);
            this.Controls.Add(this.RedBar);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "Colour_Pallete";
            this.Text = "Color Picker";
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar RedBar;
        private System.Windows.Forms.TrackBar GreenBar;
        private System.Windows.Forms.TrackBar BlueBar;
        private System.Windows.Forms.Panel Pallete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

