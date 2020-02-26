using Exam_R.Class;
using System;
using System.Linq;

namespace Exam_R.UserControls
{
    public partial class UserInfoControl : System.Windows.Forms.UserControl
    {
        ReservationDBContect ReservationDB = new ReservationDBContect();
        OrderDBContect OrderDB = new OrderDBContect();
        public UserInfoControl()
        {
            InitializeComponent();
        }

        private void UserInfoControl_Load(object sender, EventArgs e)
        {
            emailbox.Text = Used.Email;
            try
            {
                Reservation reservation = ReservationDB.Reservations.FirstOrDefault(u => u.Email == Used.Email && u.Date.Day == DateTime.Now.Day);
                tnumbox.Text = reservation.TableId.ToString();
            }
            catch (Exception)
            {
            }
            try
            {
                var meal = OrderDB.Orders.FirstOrDefault(m => m.Email == Used.Email);
                mnbox.Text = meal.MealName.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
