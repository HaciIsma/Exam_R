using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_R
{
    public partial class SignInControl : UserControl
    {
        public event EventHandler<EventArgs> SignInClick = delegate { };
        public SignInControl()
        {
            InitializeComponent();
        }

        protected void materialLabel3_Click(object sender, EventArgs e)
        {
            AppDBContect appDB = new AppDBContect();
            try
            {
                User user = appDB.Users.FirstOrDefault(u => u.Email == emailbox.Text);
                SignInClick.Invoke(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Not Found");
            }
        }
    }
}
