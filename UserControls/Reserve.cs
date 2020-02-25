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
        public Control Parrent { get; private set; }
        public Reserve()
        {
            InitializeComponent();
            panel6.Controls.Add(checkBox6);
            panel6.Controls.Add(metroButton5);
            materialLabel12.Text += $"{panel6.TabIndex}";
        }

        private void Reserve_Load(object sender, EventArgs e)
        {
            Parent = panel6;
        }
    }
}
