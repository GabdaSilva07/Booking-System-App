using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;

namespace Coach_Form_UI
{
    public partial class AccountForm : Form
    {
        SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=Coach DATABASE;Trusted_Connection=true");

        Form userAccountForm;

        public AccountForm()
        {
            InitializeComponent();


        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {


            if (firstNameReg.Text == "First Name" || surNameReg.Text == "Surname" || emailReg.Text == "Email" || ageReg.Text == "Age" || passwordReg.Text == "Password" || confirmPasswordReg.Text == "Confirm Password")
            {
                MessageBox.Show("One or more fields are empty, please try again", "Error");
                return;

            }

            if (passwordReg.Text != confirmPasswordReg.Text)
            {
                MessageBox.Show("Password does not match, Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (passwordReg.Text.Length >= 8 && confirmPasswordReg.Text.Length >= 8)
            {
                MessageBox.Show("Password must contain at least 8 characters", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }


            string firstName = nameValidation(firstNameReg, "first name");
            string surname = nameValidation(surNameReg, "surname");
            string email = emailValidation(emailReg, "email");
            int age = ageValidation(ageReg, "age");
            string password = passwordValidation(passwordReg, "password");
            string confirmPassword = passwordValidation(confirmPasswordReg, "confirm password");


            if (firstName == "Invalid Input" || surname == "Invalid Input" || email == "Invalid Input" || age == 0 || password == "Invalid Input" || confirmPassword == "Invalid Password")
            {
                return;
            }



            using (connection)
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Email FROM Account WHERE Email = '" + email + "'", connection))
            {
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count >= 1)
                {
                    MessageBox.Show("Account with Email already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    string query = "INSERT INTO Account VALUES(@Firstname, @Surname, @Email, @Age, @Password)";
                    try
                    {

                        using (SqlCommand commandAccount = new SqlCommand(query, connection))
                        {
                            connection.Open();

                            commandAccount.Parameters.AddWithValue("@Firstname", firstName);
                            commandAccount.Parameters.AddWithValue("@Surname", surname);
                            commandAccount.Parameters.AddWithValue("@Email", email);
                            commandAccount.Parameters.AddWithValue("@Age", age);
                            commandAccount.Parameters.AddWithValue("@Password", password);

                            commandAccount.ExecuteNonQuery();

                            connection.Close();
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                    MessageBox.Show("Your account has been created");
                }
            
            }

        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            connection.ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Coach DATABASE;Trusted_Connection=true";

            connection.Open();
            command.Connection = connection;
            command.CommandText = "select * FROM Account";
            SqlDataReader sqlDataReader = command.ExecuteReader();

            if (sqlDataReader.Read())
            {
                if (LogInEmail.Text.Equals(sqlDataReader["Email"].ToString()) && txtPassword.Text.Equals(sqlDataReader["Password"].ToString()))
                {
                    MessageBox.Show("Login Successful", "LogIn");

                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Either email or password is incorrect", "Error");
                }
            }

            connection.Close(); 


        }

        public string nameValidation(TextBox textBox, string errorLocation)
        {

            string result = textBox.Text.ToString();
            bool validInput = true;

            for (int i = 0; i < result.Length; i++)
            {
                if (!char.IsLetter(result[i]))
                {
                    validInput = false;
                    result = "Invalid Input";

                }

            }
            if (validInput == false)
            {
                MessageBox.Show("Invalid " + errorLocation, "Invalid Input");

            }

            return result;

        }

        public string emailValidation(TextBox textBox, string errorLocation)
        {

            string result = textBox.Text.ToString();

            //Code dapted from StackOverFlow Lines 192 - 202 by Cogwheel
            try
            {
                new MailAddress(result);

            }
            catch (Exception error)
            {

                MessageBox.Show("Invalid " + errorLocation, "Invalid Input");
                result = "Invalid Input";

            }

            return result;

        }

        public int ageValidation(TextBox textBox, string errorLocation)
        {
            int result;

            if (!int.TryParse(textBox.Text, out result))
            {
                MessageBox.Show("Invalid " + errorLocation, "Invalid Input");
                result = 0;
            }

            return result;
        }

        public string passwordValidation(TextBox textBox, string errorLocation)
        {
            string result = textBox.Text.ToString();
            bool validInput = true;

            for (int i = 0; i < result.Length; i++)
            {
                if (!char.IsLetterOrDigit(result[i]))
                {
                    validInput = false;
                    result = "Invalid Input";

                }

            }
            if (validInput == false)
            {
                MessageBox.Show("Invalid " + errorLocation, "Invalid Input");

            }

            return result;

        }






        // Set default fields

        private void enterHint(TextBox text)
        {

            if (text.Text != "")
            {
                text.Text = "";
                text.ForeColor = Color.White;

            }

        }

        private void leaveHint(TextBox text, string message)
        {
            if (text.Text == "")
            {
                text.Text = message;
                text.ForeColor = Color.DimGray;
            }

        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            enterHint(LogInEmail);

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            enterHint(txtPassword);
        }

        private void LogInEmail_Leave(object sender, EventArgs e)
        {
            leaveHint(LogInEmail, "Email");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            leaveHint(txtPassword, "Password");
        }

        private void firstNameReg_Enter(object sender, EventArgs e)
        {
            enterHint(firstNameReg);
        }

        private void firstNameReg_Leave(object sender, EventArgs e)
        {
            leaveHint(firstNameReg, "First Name");
        }

        private void surNameReg_Enter(object sender, EventArgs e)
        {
            enterHint(surNameReg);
        }

        private void surNameReg_Leave(object sender, EventArgs e)
        {
            leaveHint(surNameReg, "Surname");
        }

        private void emailReg_Enter(object sender, EventArgs e)
        {
            enterHint(emailReg);
        }

        private void emailReg_Leave(object sender, EventArgs e)
        {
            leaveHint(emailReg, "Email");
        }

        private void ageReg_Enter(object sender, EventArgs e)
        {
            enterHint(ageReg);
        }

        private void ageReg_Leave(object sender, EventArgs e)
        {
            leaveHint(ageReg, "Age");
        }

        private void passwordReg_Enter(object sender, EventArgs e)
        {
            enterHint(passwordReg);
        }

        private void passwordReg_Leave(object sender, EventArgs e)
        {
            leaveHint(passwordReg, "Password");
        }

        private void confirmPasswordReg_Enter(object sender, EventArgs e)
        {
            enterHint(confirmPasswordReg);
        }

        private void confirmPasswordReg_Leave(object sender, EventArgs e)
        {
            leaveHint(confirmPasswordReg, "Confirm Password");
        }

        private void logInCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Drag menu
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
