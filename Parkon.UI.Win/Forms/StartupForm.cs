using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prkn.UI.Win.Forms
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
            this.Opacity = 100;
            //this.BackColor = Color.LimeGreen;
            //this.TransparencyKey = Color.LimeGreen;

            //panel1.BackColor = Color.FromArgb(10, 255, 255, 255);
        }

        private void svgImageBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //panel1.BackColor = Color.Black;
            //this.BackColor = Color.Black;
            //this.TransparencyKey = Color.Black; // I had to add this to get it to work.
            this.Opacity = 0.7;
            //panel1.BackColor = Color.FromArgb(255, 255, 255, 255);
        }

        private void StartupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (double i = 0; i < 1; i = i + 0.001)
            {
                double trnsparentVal = 1.0 - i;

                this.Opacity = trnsparentVal;
                
            }
        }
    }
}
