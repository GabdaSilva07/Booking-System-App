using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Coach_Form_UI
{
    public partial class Add_City : Form, IEditText
    {
        Label title = new Label();
        SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=COACH DATABASE FINAL;Trusted_Connection=true");

        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=COACH DATABASE FINAL;Trusted_Connection=true";
        public Add_City()
        {
            InitializeComponent();
            title.Text = "Add City";
            topPanel.Controls.Add(title);
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Add_City_Load(object sender, EventArgs e)
        {
            populateList();
        }

        private void populateList()
        {
            using (connection)
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Stations", connection))
            {
                connection.Open();

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                listOfCities.DisplayMember = "Station_Name";
                listOfCities.ValueMember = "Station_Name";
                listOfCities.DataSource = dataTable;
            }

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

        private void stationName_Leave(object sender, EventArgs e)
        {
            LeaveHint(stationName, "Station Name");
        }
        private void stationName_Enter(object sender, EventArgs e)
        {
            EnterHint(stationName);
        }

        private void cityName_Leave(object sender, EventArgs e)
        {
            LeaveHint(cityName, "City Name");
        }

        private void cityName_Enter(object sender, EventArgs e)
        {
            EnterHint(cityName);
        }

        private void latitude_Enter(object sender, EventArgs e)
        {
            EnterHint(latitude);
        }

        private void latitude_Leave(object sender, EventArgs e)
        {
            LeaveHint(latitude, "Station Latitude");
        }

        private void longitude_Enter(object sender, EventArgs e)
        {
            EnterHint(longitude);
        }

        private void longitude_Leave(object sender, EventArgs e)
        {
            LeaveHint(longitude, "Station Longitude");
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (stationName.Text.Contains("Station Name") || cityName.Text.Contains("City Name") || latitude.Text.Contains("Station Latitude") || longitude.Text.Contains("Station Longitude"))
            {
                MessageBox.Show("One or more fields are empty, please try again", "Error");
                return;

            }

            string station = stringValidation(stationName, "Station Name");
            string city = stringValidation(cityName, "City Name");
            double latitudeStore = doubleValidation(latitude, "Latitude");
            double longitudeStore = doubleValidation(longitude, "Longitude");


            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Stations WHERE Station_Name = '" + station + "'", connection))
            {
                connection.Open();
                MessageBox.Show(connection.State.ToString());

                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataSet);
                int i = dataSet.Tables[0].Rows.Count;

                if (i >= 1)
                {
                    MessageBox.Show("Station with that name already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {

                    string query = "INSERT INTO Stations VALUES(@Station_Name, @City_Name, @Latitude, @Longitude)";
                    try
                    {

                        using (SqlCommand commandAccount = new SqlCommand(query, connection))
                        {


                            commandAccount.Parameters.AddWithValue("@Station_Name", station);
                            commandAccount.Parameters.AddWithValue("@City_Name", city);
                            commandAccount.Parameters.AddWithValue("@Latitude", latitudeStore);
                            commandAccount.Parameters.AddWithValue("@Longitude", longitudeStore);


                            commandAccount.ExecuteNonQuery();

                            connection.Close();
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                    MessageBox.Show("Station " + station + "has been added.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }

            }
        }

        private string stringValidation(TextBox textBox, string errorLocation)
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

        private double doubleValidation(TextBox textBox, string errorLocation)
        {
            double result;

            if (!double.TryParse(textBox.Text, out result))
            {
                MessageBox.Show("Invalid " + errorLocation, "Invalid Input");
                result = 0;
            }

            return result;


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string deleteEntry = stringValidation(deleteButton, "Delete Entry");


            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("DELETE FROM Stations WHERE Station_Name = '" + deleteEntry + "'", connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Station_Name", deleteEntry);

                int a = command.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Item Deleted");
                    connection.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Error", "Error");

                    connection.Close();
                    return;
                }


            }


        }

        private void delete_Enter(object sender, EventArgs e)
        {
            EnterHint(deleteButton);
        }

        private void deleteButton_Leave(object sender, EventArgs e)
        {
            LeaveHint(deleteButton, "Delete Entry");
        }
    }
}
