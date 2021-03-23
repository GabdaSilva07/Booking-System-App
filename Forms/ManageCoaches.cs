using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Configuration;
using System.Data.SqlClient;
namespace Coach_Form_UI
{
    public partial class ManageCoaches : Form
    {

        private Form windowForm;
        public ManageCoaches()
        {
            InitializeComponent();


            //Btn Colors
            addCity.IconColor = MainForm.RGBColors.color6;
            addCity.ForeColor = MainForm.RGBColors.color6;

            editUserBookingBtn.ForeColor = MainForm.RGBColors.color7;
            editUserBookingBtn.IconColor = MainForm.RGBColors.color7;

            addJourneyBtn.IconColor = MainForm.RGBColors.color8;
            addJourneyBtn.ForeColor = MainForm.RGBColors.color8;
        }

        private void openNewForm(Form form)
        {
            
            

            //Form Design
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            form.Show();
            form.BackColor = Color.FromArgb(46, 51, 73);
            

        }
        private void closeBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void miniBtn_Click (object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void addCity_Click(object sender, EventArgs e)
        {
            openNewForm(new Add_City());
        }
    }
}
