using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coach_Form_UI
{
    public partial class Manage_User_Booking : Form
    {

        SqlConnection connection = new SqlConnection();
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=COACH DATABASE;Trusted_Connection=true";

        public Manage_User_Booking()
        {
            InitializeComponent();
        }



        private void searchBtn_Click(object sender, EventArgs e)
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM UserAccounts WHERE Email ='" + searchUser.Text + "'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    firstNameBox.Text = reader["Firstname"].ToString();
                    surnameBox.Text = reader["Surname"].ToString();
                    ageBox.Text = reader["Age"].ToString();
                }
                else
                {
                    MessageBox.Show("No information available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                connection.Close();
            }



        }

        private void searchUser_Enter(object sender, EventArgs e)
        {
            BoxHints.EnterHint(searchUser);
        }

        private void searchUser_Leave(object sender, EventArgs e)
        {
            BoxHints.LeaveHint(searchUser, "Insert User Email");
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("UPDATE UserAccounts SET Firstname = @Firstname, Surname = @Surname, Age = @Age WHERE Email ='" + UserModel.Email + "'", connection))
            {
                connection.Open();

                command.Parameters.Add(new SqlParameter("@Firstname", firstNameBox.Text));
                command.Parameters.Add(new SqlParameter("@Surname", surnameBox.Text));
                command.Parameters.Add(new SqlParameter("@Age", ageBox.Text));

                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Update completed", "Update completed", MessageBoxButtons.OK);
                return;
            }
        }

    }
}
