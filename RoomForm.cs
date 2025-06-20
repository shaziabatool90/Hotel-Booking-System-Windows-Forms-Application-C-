using System;
using System.Windows.Forms;
using System.Data;
using DP_Project.Properties;
namespace DP_Project
{
    public partial class RoomForm : Form
    {

        public string Username = string.Empty;
        public IRoom? SelectedRoomConfig { get; private set; }
        public decimal TotalRoomPrice { get; private set; }
        public string RoomDescription { get; private set; } = string.Empty;
        // Room factory instance
        private RoomFactory? _roomFactory;

        public RoomForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            //_roomFactory = new StandardRoomFactory();
            comboBoxRoomType.Items.AddRange(new[] { "Standard Room", "Deluxe Room", "Suite Room" });
            checkBoxWiFi.Checked = false;
            checkBoxMinibar.Checked = false;
            checkBoxRoomService.Checked = false;
            UpdateRoomDetails();
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRoomDetails();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRoomDetails();
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxRoomType.SelectedItem == null || SelectedRoomConfig == null)
            {
                MessageBox.Show("Please select a room type", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveRoomToDatabase();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private async Task SaveRoomToDatabase()
        {
            var db = DatabaseConn.Instance;
            try
            {
                var parameters = new Dictionary<string, object>
                {
                    ["@RoomType"] = comboBoxRoomType.SelectedItem?.ToString() ?? string.Empty,
                    ["@Description"] = SelectedRoomConfig?.GetDescription() ?? string.Empty,
                    ["@Cost"] = SelectedRoomConfig.GetCost(),
                    ["@HasWiFi"] = checkBoxWiFi.Checked,
                    ["@HasMinibar"] = checkBoxMinibar.Checked,
                    ["@HasRoomService"] = checkBoxRoomService.Checked
                };

                string sql = @"INSERT INTO Rooms 
                      (RoomType, Description, Cost, HasWiFi, HasMinibar, HasRoomService) 
                      VALUES 
                      (@RoomType, @Description, @Cost, @HasWiFi, @HasMinibar, @HasRoomService)";

                int rowsAffected = await db.ExecuteNonQueryAsync(sql, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Room saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                await db.CloseConnectionAsync();
            }
        }

        private void UpdateRoomDetails()
        {
            if (comboBoxRoomType.SelectedItem == null)
            {
                labelRoomDetails.Text = "Please select a room type";
                labelTotalCost.Text = "Total Cost: Rs. 0";
                return;
            }

            // Get the appropriate factory based on selection
            _roomFactory = GetRoomFactory(comboBoxRoomType.SelectedItem?.ToString() ?? string.Empty);

            // Create base room using factory method
            IRoom room = _roomFactory.CreateRoom();

            // Apply decorators based on checkboxes
            if (checkBoxWiFi.Checked) room = new WiFiDecorator(room);
            if (checkBoxMinibar.Checked) room = new MinibarDecorator(room);
            if (checkBoxRoomService.Checked) room = new RoomServiceDecorator(room);

            SelectedRoomConfig = room;
            TotalRoomPrice = room.GetCost();
            RoomDescription = room.GetDescription();

            labelRoomDetails.Text = RoomDescription;
            labelTotalCost.Text = $"Total Cost: Rs. {TotalRoomPrice:N2}";
        }

        private RoomFactory GetRoomFactory(string roomType)
        {
            switch (roomType)
            {
                case "Standard Room":
                    return new StandardRoomFactory();
                case "Deluxe Room":
                    return new DeluxeRoomFactory();
                case "Suite Room":
                    return new SuiteRoomFactory();
                default:
                    throw new ArgumentException("Invalid room type");
            }
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                this.Close();
            }
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            labelUsername.Text = Username;
        }
    }
}
