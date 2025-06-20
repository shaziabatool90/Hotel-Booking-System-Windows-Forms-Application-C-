using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DP_Project
{
    public partial class RoomDetails : Form
    {
        public string Username = string.Empty;
        public RoomDetails()
        {
            InitializeComponent();
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            // Configure grid properties
            dataGridViewRoomDetails.AutoGenerateColumns = false;
            dataGridViewRoomDetails.Columns.Clear();
            dataGridViewRoomDetails.AllowUserToAddRows = false;
            dataGridViewRoomDetails.ReadOnly = true;
            dataGridViewRoomDetails.RowHeadersVisible = false;
            dataGridViewRoomDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Add columns
            AddColumn("RoomID", "ID", visible: false);
            AddColumn("RoomType", "Room Type", 150);
            AddColumn("Description", "Description", 250);
            AddCurrencyColumn("Cost", "Price", 100);
            AddCheckBoxColumn("HasWiFi", "WiFi", 60);
            AddCheckBoxColumn("HasMinibar", "Minibar", 70);
            AddCheckBoxColumn("HasRoomService", "Service", 70);
            AddColumn("CreatedDate", "Created On", 120);
        }
        private void AddColumn(string name, string headerText, int? width = null, bool visible = true)
        {
            var column = new DataGridViewTextBoxColumn
            {
                Name = name,
                DataPropertyName = name,
                HeaderText = headerText,
                Visible = visible,
                AutoSizeMode = width.HasValue ? DataGridViewAutoSizeColumnMode.None
                                            : DataGridViewAutoSizeColumnMode.Fill
            };

            if (width.HasValue) column.Width = width.Value;
            dataGridViewRoomDetails.Columns.Add(column);
        }
        private void AddCheckBoxColumn(string name, string headerText, int width)
        {
            dataGridViewRoomDetails.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = name,
                DataPropertyName = name,
                HeaderText = headerText,
                Width = width,
                ReadOnly = true,
                FlatStyle = FlatStyle.Flat
            });
        }
        private void AddCurrencyColumn(string name, string headerText, int width)
        {
            var column = new DataGridViewTextBoxColumn
            {
                Name = name,
                DataPropertyName = name,
                HeaderText = headerText,
                Width = width,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    BackColor = Color.LightGoldenrodYellow
                }
            };
            dataGridViewRoomDetails.Columns.Add(column);
        }
        private async Task LoadRoomData()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string query = @"SELECT 
                       RoomID, RoomType, Description, Cost,
                       HasWiFi, HasMinibar, HasRoomService,
                       FORMAT(CreatedDate, 'dd-MMM-yyyy') AS CreatedDate
                       FROM Rooms
                       ORDER BY RoomType";

                var db = DatabaseConn.Instance;
                DataTable dt = await db.ExecuteQueryAsync(query);

                this.Invoke((MethodInvoker)delegate
                {
                    dataGridViewRoomDetails.DataSource = dt;
                    //ApplyRowStyling();

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No rooms found in database.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rooms: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private async void RoomDetails_Load(object sender, EventArgs e)
        {
            await LoadRoomData();
            labelUsername.Text = Username;
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

        private void buttonBookingDetails_Click_1(object sender, EventArgs e)
        {
            MovePanel(buttonBookingDetails);
            BookingDetails clients = new BookingDetails();
            clients.Show();
            this.Hide();
        }

        private void buttonRoomDetails_Click_1(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            RoomDetails room = new RoomDetails();
            room.Show();
            this.Hide();
        }

        private void buttonReservation_Click_1(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            BookingForm booking = new BookingForm();
            booking.Show();
            this.Hide();
        }
    }
}