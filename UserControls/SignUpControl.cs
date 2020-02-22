using System;
using System.Linq;
using System.Windows.Forms;

namespace Exam_R.UserControls
{
    public partial class SignUpControl : UserControl
    {
        public bool SignUp { get; private set; } = default;
        public SignUpControl()
        {
            InitializeComponent();
        }



        #region Metods

        void CheckBoxCheck()
        {
            if (checkBox1.Checked)
                checkBox1.Checked = false;
            else
                checkBox1.Checked = true;
        }

        #endregion

        #region Events

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            AppDBContect appDB = new AppDBContect();
            try
            {
                User user = appDB.Users.FirstOrDefault
                    (u => u.Email == emailbox.Text.ToLower());
                if (user == null)
                    throw new Exception();
            }
            catch (Exception)
            {
                appDB.Users.Add(new User { Email = emailbox.Text.ToLower(), Password = passwordbox.Text.ToLower() });
                if (passwordbox.Text != default && confirmPasswordBox.Text == passwordbox.Text)
                { 
                    appDB.SaveChanges();
                    SignUp = true;
                }
                else
                    MessageBox.Show("Invalid password");
                return;
            }
            MessageBox.Show("NO");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CheckBoxCheck();
            if (checkBox1.Checked)
            {
                passwordbox.PasswordChar = '●';
                confirmPasswordBox.PasswordChar = '●';
                passwordbox.UseSystemPasswordChar = true;
                confirmPasswordBox.UseSystemPasswordChar = true;
            }
            else
            {
                passwordbox.PasswordChar = default;
                confirmPasswordBox.PasswordChar = default;
                passwordbox.UseSystemPasswordChar = default;
                confirmPasswordBox.UseSystemPasswordChar = default;
            }
        }

        private void SignUpControl_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
