using Exam_R.UserControls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_R
{
    public partial class Form1 : MetroForm
    {
        SignUpControl signUp = new SignUpControl();
        SignInControl signIn = new SignInControl();

        public Form1()
        {
            InitializeComponent();
            signUp.SignUpClick += SignUp_SignUpClick;
            signIn.SignInClick += SignIn_SignInClick;
        }


        private void FooClear()
        {
            SignInLabel.Hide();
            SignUpLabel.Hide();
            signIn.Hide();
            signUp.Hide();
        }

        private void FooCreat()
        {
            
        }

        #region Metods


        #endregion

        #region Events

        private void SignIn_SignInClick(object sender, EventArgs e)
        {
            FooClear();
        }

        private void SignUp_SignUpClick(object sender, EventArgs e)
        {
            FooClear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region DBCreate
            using (var db = new AppDBContect())
            {
                db.Database.EnsureCreated();
            }
            #endregion
        }

        private void label2_Click(object sender, EventArgs e)
        {
            signIn.Hide();
            signUp.Location = new Point(391, 161);
            this.Controls.Add(signUp);
            signUp.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            signUp.Hide();
            signIn.Location = new Point(391, 161);
            this.Controls.Add(signIn);
            signIn.Visible = true;
        }

        #endregion

    }
}
