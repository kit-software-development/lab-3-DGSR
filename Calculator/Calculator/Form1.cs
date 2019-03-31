using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Input;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            this.ActiveControl = button17;
        }
        public double a=0,b=0;//Операнды
        public bool a1=false, b1=false;// Включена ли дробная часть операнд
        public string op1="";//Операция

        private void OperandToZero(object sender, EventArgs e)//Кнопка CE
        {
            if (op1 == "")
            {
                a = 0;
                label1.Text = a.ToString();
                a1 = false;
            }
            else
            {
                b = 0;
                label1.Text = b.ToString();
                b1 = false;
            }
            this.ActiveControl = button17;
        }

        private void OperationClick(object sender, EventArgs e)//Нажатие на кнопку операций
        {
            op1 = Convert.ToString((sender as Button).Tag);
            label1.Text = b.ToString();
            this.ActiveControl = button17;
        }

        private void DecimalSeparator(object sender, EventArgs e)//Нажатие на кнопку "."
        {
            if (op1 == "")
            {
                a1 = true;
                label1.Text = a.ToString();
            }
            else
            {
                b1 = true;
                label1.Text = b.ToString();
            }
            this.ActiveControl = button17;
        }

        private void Calculate(object sender, EventArgs e)//Нажатие на "="
        {
            switch (op1)
            {
                case "+":
                    a = a + b;
                    break;
                case "-":
                    a = a - b;
                    break;
                case "/":
                    a = a / b;
                    break;
                case "*":
                    a = a * b;
                    break;
            }
            Clipboard.SetText(a.ToString());
            op1 = "";b = 0; b1 = false;
            label1.Text = a.ToString();
            this.ActiveControl = button17;
        } 

        private void NumberClick(object sender, EventArgs e)//Нажатие на кнопку цифры
        {
            if (op1 == "")
            {
                if (a1 == true)
                    if (a.ToString().Contains(","))
                        a = Double.Parse(a.ToString()+ Convert.ToString((sender as Button).Tag));
                    else
                        a = Double.Parse(a.ToString()+','+Convert.ToString((sender as Button).Tag));
                else
                {
                    if (a == 0)
                        a =Double.Parse((sender as Button).Tag.ToString());
                    else
                        a = a * 10 + Convert.ToDouble((sender as Button).Tag);
                }
                label1.Text = a.ToString();
            }
            else {
                if (b1 == true)
                    if (b.ToString().Contains(","))
                        b = Double.Parse(b.ToString() + Convert.ToString((sender as Button).Tag));
                    else
                        b = Double.Parse(b.ToString() + ',' + Convert.ToString((sender as Button).Tag));
                else
                {
                    if (b == 0)
                        b = Convert.ToDouble((sender as Button).Tag);
                    else
                        b = b * 10 + Convert.ToDouble((sender as Button).Tag);
                }
                label1.Text = b.ToString();
            }
            this.ActiveControl = button17;
        }
        private void KeyBoard(object sender, KeyEventArgs e)//Обраюотка нажатия клавиш 
        {
            Button bu = new Button();
            //MessageBox.Show(e.KeyValue.ToString());
            switch (e.KeyValue)
            {
                case (char)Keys.Oemcomma:
                    //se (char)Keys
                    DecimalSeparator(sender, e);
                    break;
                case (char)Keys.C:
                    OperandToZero(sender, e);
                    break;
                case (char)Keys.OemMinus:
                case (char)Keys.Subtract:
                    bu.Tag = "-";
                    OperationClick(bu, e);
                    break;
                case (char)Keys.Oemplus:
                case (char)Keys.Add:
                    bu.Tag = "+";
                    OperationClick(bu, e);
                    break;
                case (char)Keys.Divide:
                    bu.Tag = "/";
                    OperationClick(bu, e);
                    break;
                case (char)Keys.Multiply:
                    bu.Tag = "*";
                    OperationClick(bu, e);
                    break;
                case (char)Keys.Enter:
                    Calculate(sender, e);
                    break;
                case (char)Keys.D1:
                case (char)Keys.NumPad1:
                    bu.Tag = "1";
                    NumberClick(bu, e);
                    break;

                case (char)Keys.D2:
                case (char)Keys.NumPad2:
                    bu.Tag = "2";
                    NumberClick(bu, e);
                    break;
                case (char)Keys.D3:
                case (char)Keys.NumPad3:
                    bu.Tag = "3";
                    NumberClick(bu, e);
                    break;
                case (char)Keys.D4:
                case (char)Keys.NumPad4:
                    bu.Tag = "4";
                    NumberClick(bu, e);
                    break;
                case (char)Keys.D5:
                case (char)Keys.NumPad5:
                    bu.Tag = "5";
                    NumberClick(bu, e);
                    break;
                case (char)Keys.D6:
                case (char)Keys.NumPad6:
                    bu.Tag = "6";
                    NumberClick(bu, e);
                    break;
                case (char)Keys.D7:
                case (char)Keys.NumPad7:
                    bu.Tag = "7";
                    NumberClick(bu, e);
                    break;
                case (char)Keys.D8:
                case (char)Keys.NumPad8:
                    bu.Tag = "8";
                    NumberClick(bu, e);
                    break;
                case (char)Keys.D9:
                case (char)Keys.NumPad9:
                    bu.Tag = "9";
                    NumberClick(bu, e);
                    break;
                case (char)Keys.D0:
                case (char)Keys.NumPad0:
                    bu.Tag = "0";
                    NumberClick(bu, e);
                    break;
            }
        }
    }
}
