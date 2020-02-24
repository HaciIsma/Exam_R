using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam_R.UserControls;

namespace Exam_R
{
    public partial class MenuControl : UserControl
    {
        #region Notices
        public event EventHandler<EventArgs> FoodsEvent = delegate { };
        public event EventHandler<EventArgs> ReserveEvent = delegate { };
        public event EventHandler<EventArgs> UserInfoEvent = delegate { };
        public event EventHandler<EventArgs> AppInfoEvent = delegate { };
        #endregion

        public MenuControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FoodsEvent.Invoke(sender, e);
        }
    }
}
