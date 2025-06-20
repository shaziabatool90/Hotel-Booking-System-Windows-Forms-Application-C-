using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP_Project
{
    public partial class HomePage : Form
    {
        public string Username = string.Empty;
        public HomePage()
        {
            InitializeComponent();
        }
        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }
        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                this.Close();
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

            labelUsername.Text = Username;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            HomePage dashboard = new HomePage();
            dashboard.Show();
            this.Hide();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            MovePanel(buttonBookingDetails);
            BookingDetails clients = new BookingDetails();
            clients.Show();
            this.Hide();
        }



        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            BookingForm booking = new BookingForm();
            booking.Show();
            this.Hide();

        }

        private void buttonRoomDetails_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            RoomDetails room = new RoomDetails();
            room.Show();
            this.Hide();
        }

    }
}
