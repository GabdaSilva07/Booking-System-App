using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coach_Form_UI
{
    class Populate
    {
        static SqlConnection connection;
        static string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=COACH DATABASE;Trusted_Connection=true";

        public static void PopulateComboBox(ComboBox comboBox, string listName, string fieldName)
        {
            

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + listName, connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                comboBox.DataSource = dataTable;
                comboBox.DisplayMember = fieldName;
                comboBox.ValueMember = fieldName;
            }
        }

        public static void PopulateDatagrid(DataGridView dataGrid, string listName, string value)
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + listName + " WHERE Email ='" + value + "'", connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGrid.DataSource = dataTable;
                dataGrid.AutoResizeColumns();


            }
        }

    }
}
