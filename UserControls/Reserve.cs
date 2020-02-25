using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_R.UserControls
{
    public partial class Reserve : UserControl
    {
        public Reserve(int num)
        {
            InitializeComponent();
            int tableCount = new Random().Next(1, 8);
            materialLabel12.Text += $"{num}";
            materialLabel11.Text += tableCount % 2 == 0 ? tableCount.ToString() : (++tableCount).ToString();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            if (cb.Checked)
            {
                cb.Checked = default;
                Button.Text = "Reserve";
            }
            else
            { 
                cb.Checked = true;
                Button.Text = "Reserved";
            }
        }
    }
}
