using Geolocation;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Coach_Form_UI
{
    public partial class Journey : Form, IEditText
    {

        SqlConnection connection = new SqlConnection();
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=COACH DATABASE FINAL;Trusted_Connection=true";

        public Journey()
        {

            InitializeComponent();

        }

        private void Journey_Load(object sender, EventArgs e)
        {
            populateDeparture();
            populateArrival();
        }

        private void populateDeparture()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Stations", connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                departureList.DataSource = dataTable;
                departureList.DisplayMember = "Station_Name";
                departureList.ValueMember = "Station_Name";

            }
        }

        private void populateArrival()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Stations", connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                arrivalList.DataSource = dataTable;
                arrivalList.DisplayMember = "Station_Name";
                arrivalList.ValueMember = "Station_Name";
            }

        }

        private void journeyMinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void journeyCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void depatureTime_Leave(object sender, EventArgs e)
        {
            LeaveHint(depatureTime, "Depature Time:");
        }

        private void depatureTime_Enter(object sender, EventArgs e)
        {
            EnterHint(depatureTime);
        }

        private void arrivalTime_Leave(object sender, EventArgs e)
        {
            LeaveHint(arrivalTime, "Arrival Time:");
        }

        private void arrivalTime_Enter(object sender, EventArgs e)
        {
            EnterHint(arrivalTime);
        }

        private void createJourneyBtn_Click(object sender, EventArgs e)
        {

            if (depatureTime.Text.Contains("Departure Time:") || arrivalTime.Text.Contains("Arrival Time:"))
            {
                MessageBox.Show("One or more fields are empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string journeyID = "JOUR" + getRandomID();
            string depatureStation = departureList.GetItemText(departureList.SelectedItem).ToString();
            string arrivalStation = arrivalList.GetItemText(arrivalList.SelectedItem).ToString();
            string arrivalTimeStore = timeValidation(arrivalTime, "Arrival Time");
            string departureTimeStore = timeValidation(depatureTime, "Departure Time");
            string ticketPrice = getTicketPrice(depatureStation, arrivalStation);

            MessageBox.Show(ticketPrice.ToString());


            



            if (arrivalTimeStore == "Incorrect Format" || departureTimeStore == "Incorrect Format")
            {
                return;
            }

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Journeys WHERE JourneyID = '" + journeyID + "'", connection))
            {

                connection.Open();

                int i;
                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataSet);
                i = dataSet.Tables[0].Rows.Count;

                if (i >= 1)
                {
                    MessageBox.Show("ID already Exist");
                }
                else
                {

                    string query = (string) "INSERT INTO Journeys VALUES(@JourneyID, @StationDeparture, @StationArrival, @DepartureTime, @ArrivalTime, @TicketPrice)";

                    try
                    {

                        using (SqlCommand command1 = new SqlCommand(query, connection))
                        {

                            command1.Parameters.AddWithValue("@JourneyID", journeyID);
                            command1.Parameters.AddWithValue("@StationDeparture", depatureStation);
                            command1.Parameters.AddWithValue("@StationArrival", arrivalStation);
                            command1.Parameters.AddWithValue("@DepartureTime", departureTimeStore);
                            command1.Parameters.AddWithValue("@ArrivalTime", arrivalTimeStore);
                            command1.Parameters.AddWithValue("@TicketPrice", ticketPrice.Trim());

                            command1.ExecuteNonQuery();

                            MessageBox.Show(journeyID + "\n" + depatureStation + "\n" + arrivalStation + "\n" + ticketPrice + "\n" + departureTimeStore + "\n" + arrivalTimeStore);
                            connection.Close();

                        }
                    }
                    catch (Exception error)
                    {

                        MessageBox.Show(error.StackTrace.ToString());
                    }
                }


            }
        }

        private string getRandomID()
        {
            Random random = new Random();
            return random.Next(0, 100000).ToString();

        }

        private string getTicketPrice(string depatureStation, string arrivalStation)
        {

            double departureLat, departureLong, arrivalLat, arrivalLong;



            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Stations WHERE Station_Name = '" + depatureStation.Trim() + "'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                departureLat = double.Parse(reader["Latitude"].ToString());
                departureLong = double.Parse(reader["Longitude"].ToString());


                connection.Close();

            }

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command1 = new SqlCommand("SELECT * FROM Stations WHERE Station_Name = '" + arrivalStation.Trim() + "'", connection))
            {
                connection.Open();

                SqlDataReader reader = command1.ExecuteReader();

                reader.Read();

                arrivalLat = double.Parse(reader["Latitude"].ToString());
                arrivalLong = double.Parse(reader["Longitude"].ToString());




                connection.Close();
            }

            double distance = GeoCalculator.GetDistance(departureLat, departureLong, arrivalLat, arrivalLong, 1);

            decimal ticketPrice = ((decimal)distance) * 0.55m;
            ticketPrice = Math.Round(ticketPrice, 2);

            return ticketPrice.ToString();
        }

        private string timeValidation(TextBox textBox, string error)
        {
            DateTime time = new DateTime();


            if (DateTime.TryParse(textBox.Text, out time))
            {
                time.GetDateTimeFormats();

                return time.ToString("HH:mm");


            }
            else
            {
                MessageBox.Show(error + " is in the incorrect format");
                return "Incorrect Format";

            }

        }


    }
}
