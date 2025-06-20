using System;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DP_Project
{
    public partial class BookingForm : Form
    {

        public string Username = string.Empty;
        public decimal RoomBasePrice { get; private set; }
        public decimal RoomAdditionalFeaturesPrice { get; private set; }
        public string RoomType { get; private set; } = string.Empty;
        public string RoomDescription { get; private set; } = string.Empty;

        public BookingForm()
        {
            InitializeComponent();
            textBoxRoomType.Enabled = false;
            textBoxRoomP.Enabled = false;
        }


        private async void SaveBookingToDatabase()
        {
            var db = DatabaseConn.Instance;

            try
            {
                var parameters = new Dictionary<string, object>
                {
                    ["@Name"] = textBoxCusName.Text,
                    ["@Phone"] = textBoxCusPhone.Text,
                    ["@CNIC"] = textBoxCusCNIC.Text,
                    ["@RoomType"] = RoomType,
                    ["@Price"] = RoomBasePrice,
                    ["@AdditionalFeaturesPrice"] = RoomAdditionalFeaturesPrice,
                    ["@Status"] = comboBoxBookingStatus.SelectedItem?.ToString(),
                    ["@CheckIn"] = dateTimePickerCheck_In.Value,
                    ["@CheckOut"] = dateTimePickerCheck_Out.Value,
                    ["@RoomDescription"] = RoomDescription
                };

                string query = @"INSERT INTO Bookings 
                (Name, Phone, CNIC, RoomType, Price, AdditionalFeaturesPrice, 
                 BookingStatus, CheckIn, CheckOut, RoomDescription) 
                VALUES 
                (@Name, @Phone, @CNIC, @RoomType, @Price, @AdditionalFeaturesPrice, 
                 @Status, @CheckIn, @CheckOut, @RoomDescription)";

                int rowsAffected = await db.ExecuteNonQueryAsync(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Booking saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
            finally
            {
                await db.CloseConnectionAsync();
            }
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            comboBoxBookingStatus.Items.AddRange(new[] { "Pending", "Confirmed" });

            // Set minimum dates
            dateTimePickerCheck_In.MinDate = DateTime.Today;
            dateTimePickerCheck_Out.MinDate = DateTime.Today.AddDays(1);

            labelUsername.Text = Username;
        }

        private void buttonBookRoom_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxCusName.Text) ||
            string.IsNullOrWhiteSpace(textBoxCusPhone.Text) ||
            string.IsNullOrWhiteSpace(textBoxCusCNIC.Text) ||
            string.IsNullOrWhiteSpace(textBoxRoomType.Text))
            {
                MessageBox.Show("Please fill all the fields and configure the room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateTimePickerCheck_In.Value.Date > dateTimePickerCheck_Out.Value.Date)
            {
                MessageBox.Show("Check-Out Date must be after Check-In Date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate total amount based on number of days and room price
            int numberOfDays = (dateTimePickerCheck_Out.Value.Date - dateTimePickerCheck_In.Value.Date).Days;
            decimal totalRoomPrice = RoomBasePrice + RoomAdditionalFeaturesPrice;
            decimal totalAmount = totalRoomPrice * numberOfDays;

            SaveBookingToDatabase();

            // Message Box Summary
            string message = $"Booking Confirmed!\n\n" +
                             $"Name: {textBoxCusName.Text}\n" +
                             $"Phone: {textBoxCusPhone.Text}\n" +
                             $"CNIC: {textBoxCusCNIC.Text}\n" +
                             $"Room Type: {RoomType}\n" +
                             $"Base Price: {RoomBasePrice:N2}\n" +
                             $"Additional Features: {RoomAdditionalFeaturesPrice:N2}\n" +
                             $"Total Price per Night: {totalRoomPrice:N2}\n" +
                             $"Check-In: {dateTimePickerCheck_In.Value.ToShortDateString()}\n" +
                             $"Check-Out: {dateTimePickerCheck_Out.Value.ToShortDateString()}\n" +
                             $"Total Amount: {totalAmount:N2}";

            MessageBox.Show(message, "Booking Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Create PaymentForm with all details
            var paymentForm = new PaymentForm(
                totalAmount,
                RoomBasePrice,
                RoomAdditionalFeaturesPrice,
                RoomDescription);

            paymentForm.Show();
            this.Hide();

        }


        private void buttonConfigureRoom_Click(object sender, EventArgs e)
        {
            // Open the RoomForm as a dialog
            using (var roomForm = new RoomForm())
            {
                if (roomForm.ShowDialog() == DialogResult.OK)
                {
                    // Get the room configuration from RoomForm
                    RoomType = roomForm.comboBoxRoomType.SelectedItem?.ToString() ?? string.Empty;
                    RoomDescription = roomForm.RoomDescription;
                    RoomBasePrice = GetBaseRoomPrice(RoomType);
                    RoomAdditionalFeaturesPrice = roomForm.TotalRoomPrice - RoomBasePrice;

                    // Update the UI
                    textBoxRoomType.Text = RoomType;
                    textBoxRoomP.Text = roomForm.TotalRoomPrice.ToString("N2");
                    //textBoxRoomDescription.Text = RoomDescription;
                    //labelTotalCost.Text = RoomAdditionalFeaturesPrice.ToString("N2");
                }
            }
        }
        private decimal GetBaseRoomPrice(string? roomType)
        {
            if (string.IsNullOrEmpty(roomType))
            {
                throw new ArgumentNullException(nameof(roomType));
            }
            return roomType switch
            {
                "Standard Room" => 5000,
                "Deluxe Room" => 8000,
                "Suite Room" => 12000,
                _ => throw new ArgumentException("Invalid room type", nameof(roomType))
            };
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

        private void buttonDashboard_Click_1(object sender, EventArgs e)
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


    
