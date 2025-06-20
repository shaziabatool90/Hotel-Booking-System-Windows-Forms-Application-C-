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
    public partial class PaymentForm : Form
    {
        public string Username = string.Empty;
        private readonly decimal _totalAmount;
        private readonly decimal _baseRoomPrice;
        private readonly decimal _additionalFeaturesPrice;
        private readonly string _roomDescription;
        private BookingSubject _bookingSubject;

        public PaymentForm(decimal totalAmount, decimal baseRoomPrice, decimal additionalFeaturesPrice, string roomDescription)
        {
            InitializeComponent();
            _totalAmount = totalAmount;
            _baseRoomPrice = baseRoomPrice;
            _additionalFeaturesPrice = additionalFeaturesPrice;
            _roomDescription = roomDescription;
            _bookingSubject = new BookingSubject();
            InitializeObservers();
            SetupForm();
        }

        private void InitializeObservers()
        {
            new EmailNotification(_bookingSubject);
            new SMSNotification(_bookingSubject);
        }

        private void SetupForm()
        {
            // Display payment details
            labelRoomDetails.Text = $"Total Amount is {_totalAmount:N2}\nBase Price of room is {_baseRoomPrice:N2}\nPrice of Additional Features {_additionalFeaturesPrice}\nRoom Description: {_roomDescription}";

            // Initialize payment method options
            comboBoxPaymentMethod.Items.AddRange(new string[] { "Cash", "Card", "Online Transfer" });
            comboBoxPaymentMethod.SelectedIndex = -1;

            // Set up card type options
            comboBoxCardType.Items.AddRange(new string[] { "Debit Card", "Credit Card" });

            // Initially disable both group boxes when Cash is selected
            groupBoxCardDetails.Enabled = false;
            groupBoxBankDetails.Enabled = false;

        }

        private void comboBoxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedMethod = comboBoxPaymentMethod.SelectedItem?.ToString() ?? string.Empty;

            switch (selectedMethod)
            {
                case "Cash":
                    // Disable both group boxes for cash payment
                    groupBoxCardDetails.Enabled = false;
                    groupBoxBankDetails.Enabled = false;
                    break;

                case "Card":
                    // Enable card details, disable bank details
                    groupBoxCardDetails.Enabled = true;
                    groupBoxBankDetails.Enabled = false;
                    // Clear bank details
                    ClearBankDetails();
                    break;

                case "Online Transfer":
                    // Enable bank details, disable card details
                    groupBoxCardDetails.Enabled = false;
                    groupBoxBankDetails.Enabled = true;
                    // Clear card details
                    ClearCardDetails();
                    break;
            }
        }

        private void ClearCardDetails()
        {
            textBoxCardNumber.Clear();
            textBoxCVV.Clear();
            comboBoxCardType.SelectedIndex = -1;
        }

        private void ClearBankDetails()
        {
            // Clear any bank-related textboxes you have
            if (textBoxBankName != null) textBoxBankName.Clear();
            if (textBoxIBAN != null) textBoxIBAN.Clear();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (comboBoxPaymentMethod.SelectedItem == null)
            {
                MessageBox.Show("Please select a payment method.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedMethod = comboBoxPaymentMethod.SelectedItem.ToString() ?? string.Empty;
            bool isValid = ValidatePayment(selectedMethod);

            if (isValid)
            {
                string successMessage = CreatePaymentSuccessMessage(selectedMethod);
                _bookingSubject.Message = successMessage;
                MessageBox.Show("Payment processed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate to home page
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Close();
            }
        }

        private bool ValidatePayment(string paymentMethod)
        {
            switch (paymentMethod)
            {
                case "Cash":
                    MessageBox.Show($"Amount Rs. {_totalAmount:N2} will be paid in cash.", "Cash Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Card":
                    if (string.IsNullOrWhiteSpace(textBoxCardNumber.Text) ||
                        string.IsNullOrWhiteSpace(textBoxCVV.Text) ||
                        comboBoxCardType.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please fill in all card details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    break;

                case "Online Transfer":
                    if (string.IsNullOrWhiteSpace(textBoxBankName?.Text) ||
                        string.IsNullOrWhiteSpace(textBoxIBAN?.Text))
                    {
                        MessageBox.Show("Please fill in all bank details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    break;
            }
            return true;
        }

        private string CreatePaymentSuccessMessage(string paymentMethod)
        {
            string message = $"Payment of Rs. {_totalAmount:N2} processed via {paymentMethod}";

            switch (paymentMethod)
            {
                case "Card":
                    message += $"\nCard Type: {comboBoxCardType.SelectedItem}" +
                              $"\nCard Number: ****{textBoxCardNumber.Text.Substring(Math.Max(0, textBoxCardNumber.Text.Length - 4))}";
                    break;

                case "Online Transfer":
                    message += $"\nBank Name: {textBoxBankName?.Text}" +
                              $"\nAccount Number: {textBoxIBAN?.Text}";
                    break;
            }

            return message;
        }

        private void textBoxCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            labelUsername.Text = Username;
        }
    }
}
