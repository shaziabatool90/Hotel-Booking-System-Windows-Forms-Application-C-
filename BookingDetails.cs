using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace DP_Project
{
    public partial class BookingDetails : Form
    {
        public string Username = string.Empty;
        public BookingDetails()
        {
            InitializeComponent();
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            // Disable auto-generation for more control
            dataGridViewBookings.AutoGenerateColumns = false;
            dataGridViewBookings.Columns.Clear();

            // Add columns manually with proper configuration
            AddColumn("BookingID", "ID", visible: false);
            AddColumn("Name", "Guest Name", 150);
            AddColumn("Phone", "Phone", 100);
            AddColumn("CNIC", "CNIC", 120);
            AddColumn("RoomType", "Room Type", 120);
            AddCurrencyColumn("Price", "Base Price");
            AddCurrencyColumn("AdditionalFeaturesPrice", "Extra Features");
            AddCurrencyColumn("TotalPrice", "Total Price");
            AddColumn("BookingStatus", "Status", 80);
            AddColumn("CheckIn", "Check-In", 100);
            AddColumn("CheckOut", "Check-Out", 100);
            AddColumn("RoomDescription", "Description", 200);

            // Configure grid behavior
            dataGridViewBookings.RowHeadersVisible = true;
            dataGridViewBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBookings.AllowUserToResizeColumns = true;
            dataGridViewBookings.ReadOnly = true;
        }


        private void AddColumn(string name, string headerText, int? width = null, bool visible = true)
        {
            var column = new DataGridViewTextBoxColumn
            {
                Name = name,
                DataPropertyName = name,
                HeaderText = headerText,
                Visible = visible
            };

            if (width.HasValue)
            {
                column.Width = width.Value;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
            else
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridViewBookings.Columns.Add(column);
        }
        private void AddCurrencyColumn(string name, string headerText)
        {
            var column = new DataGridViewTextBoxColumn
            {
                Name = name,
                DataPropertyName = name,
                HeaderText = headerText,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                },
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridViewBookings.Columns.Add(column);
        }
        private async void BookingDetails_Load(object sender, EventArgs e)
        {
            await LoadBookingsAsync();
            labelUsername.Text = Username;
        }
        private async Task LoadBookingsAsync()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var db = DatabaseConn.Instance;

                string query = @"SELECT 
                               BookingID, Name, Phone, CNIC, RoomType, 
                               Price, AdditionalFeaturesPrice, 
                               (Price + AdditionalFeaturesPrice) AS TotalPrice,
                               BookingStatus, 
                               CONVERT(varchar, CheckIn, 103) AS CheckIn, 
                               CONVERT(varchar, CheckOut, 103) AS CheckOut,
                               RoomDescription
                               FROM Bookings
                               ORDER BY CheckIn DESC";

                // Using the adapter pattern to get data
                DataTable dt = await db.ExecuteQueryAsync(query);

                // UI updates must be on the UI thread
                this.Invoke((MethodInvoker)delegate
                {
                    dataGridViewBookings.DataSource = dt;
                    dataGridViewBookings.Refresh();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bookings: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void dataGridViewBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                this.Close();
            }
        }
        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            HomePage dashboard = new HomePage();
            dashboard.Show();
            this.Hide();
        }

        private void buttonBookingDetails_Click(object sender, EventArgs e)
        {
            MovePanel(buttonBookingDetails);
            BookingDetails clients = new BookingDetails();
            clients.Show();
            this.Hide();
        }

        private void buttonRoomDetails_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            RoomDetails room = new RoomDetails();
            room.Show();
            this.Hide();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            BookingForm booking = new BookingForm();
            booking.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}