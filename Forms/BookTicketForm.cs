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
    public partial class BookTicketForm : Form, IPopulate
    {

        SqlConnection connection = new SqlConnection();
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=COACH DATABASE FINAL;Trusted_Connection=true";
        public BookTicketForm()
        {
            InitializeComponent();
        }

        private void BookTicketForm_Load(object sender, EventArgs e)
        {
            PopulateDeparture();
            PopulateArrival();
        }

        public void PopulateArrival()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Stations", connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                arrivalListBooking.DataSource = dataTable;
                arrivalListBooking.DisplayMember = "Station_Name";
                arrivalListBooking.ValueMember = "Station_Name";
            }
        }

        public void PopulateDeparture()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Stations", connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                departureListBooking.DataSource = dataTable;
                departureListBooking.DisplayMember = "Station_Name";
                departureListBooking.ValueMember = "Station_Name";

            }
        }

        private void searchJourney_Click(object sender, EventArgs e)
        {
            listViewJourneys.Clear();

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string departureStationChosen = departureListBooking.GetItemText(departureListBooking.SelectedItem);
                string arrivalStationChosen = arrivalListBooking.GetItemText(arrivalListBooking.SelectedItem);
                DataTable dataTable;
                SqlDataAdapter dataAdapter;
                DataSet dataSet;
                listViewJourneys.Columns.Add("Journey ID", 250, HorizontalAlignment.Left);
                listViewJourneys.Columns.Add("Departure", 420, HorizontalAlignment.Left);
                listViewJourneys.Columns.Add("Arrival", 420, HorizontalAlignment.Left);
                listViewJourneys.Columns.Add("Depature Time", 200, HorizontalAlignment.Right);
                listViewJourneys.Columns.Add("Arrival Time", 190, HorizontalAlignment.Right);
                listViewJourneys.Columns.Add("Ticket Price", 170, HorizontalAlignment.Right);
                listViewJourneys.View = View.Details;
                  

                using (SqlCommand command1 = new SqlCommand("SELECT * FROM Journeys WHERE StationDeparture = '" + departureStationChosen + "' AND " +
                    "StationArrival = '" + arrivalStationChosen + "'", connection))
                {
                    dataAdapter = new SqlDataAdapter(command1);
                    dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "Journey Table");
                    connection.Close();

                    dataTable = dataSet.Tables["Journey Table"];
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        listViewJourneys.Items.Add(dataTable.Rows[i].ItemArray[0].ToString());
                        listViewJourneys.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[1].ToString());
                        listViewJourneys.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[2].ToString());
                        listViewJourneys.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[3].ToString());
                        listViewJourneys.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[4].ToString());
                        listViewJourneys.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[5].ToString());

                    }
                }
            
            
            }
        }
    }
}
