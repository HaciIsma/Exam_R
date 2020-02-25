using Exam_R.Class;
using System.Linq;
using System;

namespace Exam_R.UserControls
{
    public partial class Reserve : System.Windows.Forms.UserControl
    {
        #region Events
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
                RemoveReservation();
            }
            else
            {
                cb.Checked = true;
                Button.Text = "Reserved";
                AddReservation();
            }
        }
        #endregion

        #region Metods
        private void AddReservation()
        {
            ReservationDBContect ReservationDB = new ReservationDBContect();
            ReservationDB.Reservations.Add(new Reservation { Email = Used.Email, TableId = int.Parse(materialLabel12.Text), Date = DateTime.Now });
            ReservationDB.SaveChanges();
        }
        private void RemoveReservation()
        {
            ReservationDBContect ReservationDB = new ReservationDBContect();
            Reservation reservation;
            try
            {
                reservation = ReservationDB.Reservations.FirstOrDefault(e => e.Email == Used.Email);
                if (reservation != null)
                {
                    ReservationDB.Reservations.Remove(reservation);
                    ReservationDB.SaveChanges();
                }
            }
            catch (Exception)
            {
            }
        }
        #endregion
    }
}
