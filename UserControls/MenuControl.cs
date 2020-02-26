using System;
using System.Windows.Forms;

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

        private void label3_Click(object sender, EventArgs e)
        {
            ReserveEvent.Invoke(sender, e);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            UserInfoEvent.Invoke(sender, e);
        }
    }
}
