using Exam_R.UserControls;
using MetroFramework.Forms;
using System.Drawing;
using System;
using Exam_R.Class;

namespace Exam_R
{
    public partial class Form1 : MetroForm
    {
        SignUpControl signUp = new SignUpControl();
        SignInControl signIn = new SignInControl();

        MenuControl menu = new MenuControl();
        FoodsControl foods = new FoodsControl();
        ReserveControl reserve = new ReserveControl();
        UserInfoControl userInfo = new UserInfoControl();

        public Form1()
        {
            InitializeComponent();
        }

        #region Subscribing

        private void Menu_AppInfoEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Menu_UserInfoEvent(object sender, EventArgs e)
        {
            foods.Hide();
            reserve.Hide();
            this.Controls.Add(userInfo);
            userInfo.Location = new Point(193, 25);
            userInfo.Visible = true;
        }

        private void Menu_ReserveEvent(object sender, EventArgs e)
        {
            foods.Hide();
            userInfo.Hide();
            this.Controls.Add(reserve);
            reserve.Location = new Point(193, 20);
            reserve.Visible = true;
        }

        private void Menu_FoodsEvent(object sender, EventArgs e)
        {
            reserve.Hide();
            userInfo.Hide();
            this.Controls.Add(foods);
            foods.Location = new Point(193, 25);
            foods.Visible = true;
        }

        #endregion

        private void FooClear()
        {
            SignInLabel.Hide();
            SignUpLabel.Hide();
            signIn.Hide();
            signUp.Hide();
        }

        private void FooCreat()
        {
            this.flowLayoutPanel1.Controls.Add(menu);
        }

        #region Metods


        #endregion

        #region Events

        private void SignIn_SignInClick(object sender, EventArgs e)
        {
            FooClear();
            FooCreat();
        }

        private void SignUp_SignUpClick(object sender, EventArgs e)
        {
            FooClear();
            FooCreat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region DBCreate
            using (var db = new UserDBContect())
            {
                db.Database.EnsureCreated();
            }
            using (var db = new OrderDBContect())
            {
                db.Database.EnsureCreated();
            }
            using (var db = new ReservationDBContect())
            {
                db.Database.EnsureCreated();
            }
            #endregion
            #region Subscribe
            signUp.SignUpClick += SignUp_SignUpClick;
            signIn.SignInClick += SignIn_SignInClick;
            menu.FoodsEvent += Menu_FoodsEvent;
            menu.ReserveEvent += Menu_ReserveEvent;
            menu.UserInfoEvent += Menu_UserInfoEvent;
            menu.AppInfoEvent += Menu_AppInfoEvent;
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
