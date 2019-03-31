using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colour_pallete
{
    public partial class Colour_Pallete : Form
    {
        ToolTip Tip = new ToolTip();

        public Colour_Pallete()
        {
            InitializeComponent();
            Clipboard.SetText($"#{RedBar.Value:X}{GreenBar.Value:X}{BlueBar.Value:X}");
        }

        private void RedChange(object sender, EventArgs e)
        {

            Pallete.BackColor = Color.FromArgb(RedBar.Value,GreenBar.Value,BlueBar.Value);
            Clipboard.Clear();
            Clipboard.SetText($"#{RedBar.Value:X}{GreenBar.Value:X}{BlueBar.Value:X}");
        }

        private void ShowColour(object sender, EventArgs e)
        {       
            Tip.SetToolTip(Pallete, Clipboard.GetText());            
        }
    }
}
