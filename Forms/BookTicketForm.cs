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
    public partial class BookTicketForm : Form
    {

        SqlConnection connection = new SqlConnection();
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=COACH DATABASE;Trusted_Connection=true";
        public BookTicketForm()
        {
            InitializeComponent();
        }

        private void BookTicketForm_Load(object sender, EventArgs e)
        {

            Populate.PopulateComboBox(arrivalListBooking, "Stations", "Station_Name");
            Populate.PopulateComboBox(departureListBooking, "Stations", "Station_Name");
            Populate.PopulateComboBox(DateBox, "Journeys", "DepartureDate");

        }

      

        private void searchJourney_Click(object sender, EventArgs e)
        {
            listViewJourneys.Clear();

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string departureStationChosen = departureListBooking.GetItemText(departureListBooking.SelectedItem);
                string arrivalStationChosen = arrivalListBooking.GetItemText(arrivalListBooking.SelectedItem);
                string departureDate = DateBox.GetItemText(DateBox.SelectedItem);
                DataTable dataTable;
                SqlDataAdapter dataAdapter;
                DataSet dataSet;
                listViewJourneys.Columns.Add("Journey ID", 250, HorizontalAlignment.Left);
                listViewJourneys.Columns.Add("Departure", 420, HorizontalAlignment.Left);
                listViewJourneys.Columns.Add("Arrival", 420, HorizontalAlignment.Left);
                listViewJourneys.Columns.Add("Departure Date", 200, HorizontalAlignment.Right);
                listViewJourneys.Columns.Add("Depature Time", 200, HorizontalAlignment.Right);
                listViewJourneys.Columns.Add("Arrival Time", 190, HorizontalAlignment.Right);
                listViewJourneys.Columns.Add("Ticket Price", 170, HorizontalAlignment.Right);
                listViewJourneys.View = View.Details;
                  

                using (SqlCommand command1 = new SqlCommand("SELECT * FROM Journeys WHERE StationDeparture = '" + departureStationChosen + "' AND " +
                    "StationArrival = '" + arrivalStationChosen + "' AND DepartureDate = '" + departureDate + "'", connection))
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
                        listViewJourneys.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[6].ToString());

                    }
                }
            
            
            }
        }

        private void bookTicketBtn_Click(object sender, EventArgs e)
        {

            if (listViewJourneys.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Journey Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            {
                string bookingID = "BOOK" + Journey.getRandomID().Trim();
                string journeyID = listViewJourneys.SelectedItems[0].Text;


                PaymentForm paymentForm = new PaymentForm(bookingID, journeyID);
                paymentForm.Show();

            }



            
        }


    }
}
