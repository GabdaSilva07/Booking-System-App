using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coach_Form_UI
{
    public partial class PaymentForm : Form
    {
        static string bookingID;
        static string journeyID;

        SqlConnection connection = new SqlConnection();
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=COACH DATABASE;Trusted_Connection=true";

        public PaymentForm(string bookingId, string journeyId)
        {
            InitializeComponent();
            
            bookingID = bookingId;
            journeyID = journeyId;
        }


        private void payBtn_Click(object sender, EventArgs e)
        {
            if (nameOnCard.Text == "Name On Card" || accountNumber.Text == "Account Number" || sortCode.Text == "Sort Code" || CSC.Text == "CSC" || expiryDate.Text == "Expiry Date")
            {
                MessageBox.Show("One or more fields are empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string paymentNumber = "PAY" + Journey.getRandomID();
            string cardName = Add_City.stringValidation(nameOnCard, "Name On Card");
            string sort_Code = validateNumber(sortCode, 6, "Sort Code");
            string account_number = validateNumber(accountNumber, 8, "Account Number");
            string expiry_date = validateDate(expiryDate);
            string cSC = validateNumber(CSC, 3, "CSC");

            if (cardName == "Invalid Input" || sort_Code == "Invalid Input" || account_number == "Invalid Input" || expiry_date == "Invalid Input" || cSC == "Invalid Input")
            {
                return;
            }

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Payment WHERE PaymentNumber ='" + paymentNumber + "'", connection))
            {
                connection.Open();
                int i = command.ExecuteNonQuery();
                while (i == 1)
                {
                    paymentNumber = "PAY" + Journey.getRandomID().Trim();
                }
                connection.Close();
            }

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command1 = new SqlCommand("INSERT INTO Payment VALUES (@PaymentNumber, @NameOnCard, @SortCode, @AccountNumber, @ExpiryDate, @CSC)", connection))
            {
                connection.Open();

                command1.Parameters.AddWithValue("@PaymentNumber", paymentNumber);
                command1.Parameters.AddWithValue("@NameOnCard", cardName);
                command1.Parameters.AddWithValue("@SortCode", sort_Code);
                command1.Parameters.AddWithValue("@AccountNumber", account_number);
                command1.Parameters.AddWithValue("@ExpiryDate", expiry_date);
                command1.Parameters.AddWithValue("@CSC", cSC);

                command1.ExecuteNonQuery();
                connection.Close();

            }


            string userEmail = UserModel.Email;
            string timeCreated = DateTime.Now.ToString("HH:mm");

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command2 = new SqlCommand("SELECT * FROM Tickets WHERE TicketID ='" + bookingID + "'", connection))
            {
                connection.Open();
                int i = command2.ExecuteNonQuery();
                while (i == 1)
                {
                    bookingID = "BOOK" + Journey.getRandomID().Trim();
                }
                connection.Close();

            }


            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command3 = new SqlCommand("INSERT INTO Tickets VALUES (@TicketID, @JourneyID, @UserEmail, @PaymentID, @TimeCreated)", connection))
            {
                connection.Open();

                command3.Parameters.AddWithValue("@TicketID", bookingID);
                command3.Parameters.AddWithValue("@JourneyID", journeyID);
                command3.Parameters.AddWithValue("@UserEmail", userEmail);
                command3.Parameters.AddWithValue("@PaymentID", paymentNumber);
                command3.Parameters.AddWithValue("@TimeCreated", timeCreated);

                command3.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Purchased completed");
                return;
            }
        }

        private string validateDate(TextBox expiryDate)
        {
            DateTime date;
            string result;
            if (DateTime.TryParse(expiryDate.Text, out date))
            {

                result = date.ToString("MM/yyyy");

            }
            else
            {

                result = "Invalid Input";
            
            }

            return result;
        }

        private string validateNumber(TextBox textBox, int nDigits, string errorLocation)
        {
            string result;

            if (textBox.Text.Length < nDigits)
            {
                MessageBox.Show("Invalid " + errorLocation);

                result = "Invalid Input";
            }
            else
            {
                result = textBox.Text;
            }

            return result;
        }



        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void nameOnCard_Leave(object sender, EventArgs e)
        {
            BoxHints.LeaveHint(nameOnCard, "Name On Card");
        }

        private void nameOnCard_Enter(object sender, EventArgs e)
        {
            BoxHints.EnterHint(nameOnCard);
        }

        private void sortCode_Leave(object sender, EventArgs e)
        {
            BoxHints.LeaveHint(sortCode, "Sort Code");
        }

        private void sortCode_Enter(object sender, EventArgs e)
        {
            BoxHints.EnterHint(sortCode);
        }

        private void accountNumber_Leave(object sender, EventArgs e)
        {
            BoxHints.LeaveHint(accountNumber, "Account Number");
        }

        private void accountNumber_Enter(object sender, EventArgs e)
        {
            BoxHints.EnterHint(accountNumber);
        }

        private void expiryDate_Leave(object sender, EventArgs e)
        {
            BoxHints.LeaveHint(expiryDate, "Expiry Date");
        }

        private void CSC_Enter(object sender, EventArgs e)
        {
            BoxHints.EnterHint(CSC);
        }

        private void expiryDate_Enter(object sender, EventArgs e)
        {
            BoxHints.EnterHint(expiryDate);
        }

        private void CSC_Leave(object sender, EventArgs e)
        {
            BoxHints.LeaveHint(CSC, "CSC");
        }

       
    }
}
