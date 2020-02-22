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
        public bool SignIn { get; private set; } = default;
        public event EventHandler UserControlChanged;
        public SignInControl()
        {
            InitializeComponent();
        }

        public void UserControlChange(EventArgs e)
        {
            UserControlChanged.Invoke(this, e);
        }

        protected void materialLabel3_Click(object sender, EventArgs e)
        {
            AppDBContect appDB = new AppDBContect();
            try
            {
                User user = appDB.Users.FirstOrDefault(u => u.Email == emailbox.Text);
                SignIn = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Not Found");
            }
        }

        private void SignInControl_Load(object sender, EventArgs e)
        {

        }
    }
}
