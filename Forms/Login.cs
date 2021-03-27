using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;
using System.Threading;

namespace Coach_Form_UI
{
    public partial class AccountForm : Form, IEditText
    {
        SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=COACH DATABASE FINAL;Trusted_Connection=true");
        Thread thread;

        private static string userFirstName;
        private static string userSurname;
        private static string userEmail;
        private static int userAge;
        private static string userPassword;
        

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
            using (SqlCommand command = new SqlCommand("SELECT * FROM UserAccounts WHERE Email = '" + email + "'", connection))
            {
                connection.Open();

                
                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataSet);
                int i = dataSet.Tables[0].Rows.Count;

                if (i >= 1)
                {
                    MessageBox.Show("Account with Email already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {

                    string query = "INSERT INTO UserAccounts VALUES(@Email, @Firstname, @Surname, @Age, @Password)";
                    try
                    {

                        using (SqlCommand commandAccount = new SqlCommand(query, connection))
                        {


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
                    return;
                }

            }

        }

        private void signInBtn_Click(object sender, EventArgs e)
        {


            SqlCommand command = new SqlCommand();


            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM UserAccounts Where Email ='" + LogInEmail.Text + "'";
            SqlDataReader sqlDataReader = command.ExecuteReader();

            if (sqlDataReader.Read())
            {


                if (LogInEmail.Text.ToString().Equals(sqlDataReader["Email"].ToString()) && txtPassword.Text.ToString().Equals(sqlDataReader["Password"].ToString()))
                {
                    
                    userFirstName = sqlDataReader["Firstname"].ToString();
                    userSurname = sqlDataReader["Surname"].ToString();
                    userEmail = sqlDataReader["Email"].ToString();
                    userAge = int.Parse(sqlDataReader["Age"].ToString());
                    userPassword = sqlDataReader["Password"].ToString();

                    MessageBox.Show("Login Successful", "LogIn", MessageBoxButtons.OK);

                    thread = new Thread(openNewForm);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Either email or password is incorrect", "Error");
                }
            }

            connection.Close();


        }

        public void openNewForm()
        {
            Application.Run(new MainForm(userFirstName, userEmail, userSurname, userAge, userPassword));
        
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
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            EnterHint(LogInEmail);

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            EnterHint(txtPassword);
        }

        private void LogInEmail_Leave(object sender, EventArgs e)
        {
            LeaveHint(LogInEmail, "Email");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            LeaveHint(txtPassword, "Password");
        }

        private void firstNameReg_Enter(object sender, EventArgs e)
        {
            EnterHint(firstNameReg);
        }

        private void firstNameReg_Leave(object sender, EventArgs e)
        {
            LeaveHint(firstNameReg, "First Name");
        }

        private void surNameReg_Enter(object sender, EventArgs e)
        {
            EnterHint(surNameReg);
        }

        private void surNameReg_Leave(object sender, EventArgs e)
        {
            LeaveHint(surNameReg, "Surname");
        }

        private void emailReg_Enter(object sender, EventArgs e)
        {
            EnterHint(emailReg);
        }

        private void emailReg_Leave(object sender, EventArgs e)
        {
            LeaveHint(emailReg, "Email");
        }

        private void ageReg_Enter(object sender, EventArgs e)
        {
            EnterHint(ageReg);
        }

        private void ageReg_Leave(object sender, EventArgs e)
        {
            LeaveHint(ageReg, "Age");
        }

        private void passwordReg_Enter(object sender, EventArgs e)
        {
            EnterHint(passwordReg);
        }

        private void passwordReg_Leave(object sender, EventArgs e)
        {
            LeaveHint(passwordReg, "Password");
        }

        private void confirmPasswordReg_Enter(object sender, EventArgs e)
        {
            EnterHint(confirmPasswordReg);
        }

        private void confirmPasswordReg_Leave(object sender, EventArgs e)
        {
            LeaveHint(confirmPasswordReg, "Confirm Password");
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

        public void EnterHint(TextBox text)
        {

            if (text.Text != "")
            {
                text.Text = "";
                text.ForeColor = Color.White;

            }
        }

        public void LeaveHint(TextBox text, string message)
        {
            if (text.Text == "")
            {
                text.Text = message;
                text.ForeColor = Color.DimGray;
            }
        }
    }
}
