using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Data.SqlClient;

namespace Coach_Form_UI
{
    public partial class Add_City : Form
    {
        Label title = new Label();
        SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=COACH DATABASE FINAL;Trusted_Connection=true");

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

        }

        private void populateList()
        {
            using (connection)
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT City_Names FROM Stations", connection))
            {
                connection.Open();

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                listOfCities.DisplayMember = "City_Names";
                listOfCities.DataSource = dataTable;
            }
        
        }
    }
}
