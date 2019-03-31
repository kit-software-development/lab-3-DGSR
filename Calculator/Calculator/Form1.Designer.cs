namespace Calculator
{
    partial class Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button17 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.UseMnemonic = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 55);
            this.button1.TabIndex = 1;
            this.button1.Tag = "7";
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumberClick);
            this.button1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBoard);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.Location = new System.Drawing.Point(89, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 55);
            this.button2.TabIndex = 2;
            this.button2.Tag = "8";
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumberClick);
            this.button2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBoard);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button3.Location = new System.Drawing.Point(178, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 55);
            this.button3.TabIndex = 3;
            this.button3.Tag = "9";
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumberClick);
            this.button3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBoard);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSize = true;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button4.Location = new System.Drawing.Point(267, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 55);
            this.button4.TabIndex = 4;
            this.button4.Tag = "+";
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OperationClick);
            this.button4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBoard);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button5.Location = new System.Drawing.Point(267, 55);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 55);
            this.button5.TabIndex = 8;
            this.button5.Tag = "-";
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.OperationClick);
            this.button5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBoard);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.AutoSize = true;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button6.Location = new System.Drawing.Point(178, 55);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 55);
            this.button6.TabIndex = 7;
            this.button6.Tag = "6";
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumberClick);
            this.button6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBoard);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.AutoSize = true;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button7.Location = new System.Drawing.Point(89, 55);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 55);
            this.button7.TabIndex = 6;
            this.button7.Tag = "5";
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumberClick);
            this.button7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBoard);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.AutoSize = true;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button8.Location = new System.Drawing.Point(0, 55);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 55);
            this.button8.TabIndex = 5;
            this.button8.Tag = "4";
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumberClick);
            this.button8.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBoard);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.AutoSize = true;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button9.Location = new System.Drawing.Point(267, 110);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 55);
            this.button9.TabIndex = 12;
            this.button9.Tag = "*";
            this.button9.Text = "*";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.OperationClick);
            this.button9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBoard);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.AutoSize = true;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button10.Location = new System.Drawing.Point(178, 110);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 55);
            this.button10.TabIndex = 11;
            this.button10.Tag = "3";
            this.button10.Text = "3";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.NumberClick);
            this.button10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBoard);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.AutoSize = true;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button11.Location = new System.Drawing.Point(89, 110);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(89, 55);
            this.button11.TabIndex = 10;
            this.button11.Tag = "2";
            this.button11.Text = "2";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.NumberClick);
            this.button11.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBoard);
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.AutoSize = true;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button12.Location = new System.Drawing.Point(0, 110);
            this.button12.Margin = new System.Windows.Forms.Padding(0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(89, 55);
            this.button12.TabIndex = 9;
            this.button12.Tag = "1";
            this.button12.Text = "1";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.NumberClick);
            this.button12.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBoard);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.AutoSize = true;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button13.Location = new System.Drawing.Point(267, 165);
            this.button13.Margin = new System.Windows.Forms.Padding(0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(92, 55);
            this.button13.TabIndex = 16;
            this.button13.Tag = "/";
            this.button13.Text = "/";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.OperationClick);
            this.button13.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBoard);
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.AutoSize = true;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button14.Location = new System.Drawing.Point(178, 165);
            this.button14.Margin = new System.Windows.Forms.Padding(0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(89, 55);
            this.button14.TabIndex = 15;
            this.button14.Text = ".";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.DecimalSeparator);
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.AutoSize = true;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button15.Location = new System.Drawing.Point(89, 165);
            this.button15.Margin = new System.Windows.Forms.Padding(0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(89, 55);
            this.button15.TabIndex = 14;
            this.button15.Tag = "0";
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.NumberClick);
            this.button15.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBoard);
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.AutoSize = true;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button16.Location = new System.Drawing.Point(0, 165);
            this.button16.Margin = new System.Windows.Forms.Padding(0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(89, 55);
            this.button16.TabIndex = 13;
            this.button16.Text = "CE";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.OperandToZero);
            this.button16.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBoard);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button13, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button14, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button15, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button16, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button9, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button11, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button17, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 279);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.button17, 4);
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button17.Location = new System.Drawing.Point(0, 220);
            this.button17.Margin = new System.Windows.Forms.Padding(0);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(359, 59);
            this.button17.TabIndex = 17;
            this.button17.Text = "=";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Calculate);
            this.button17.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBoard);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 311);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 0);
            this.panel1.TabIndex = 20;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(375, 350);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBoard);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Panel panel1;
    }
}

