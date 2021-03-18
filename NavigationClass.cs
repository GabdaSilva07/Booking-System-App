using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coach_Form_UI
{
    class NavigationClass : Form
    {

        private Form childPanelForm;

        public NavigationClass()
        {

        }

        public void openChildForm(Form aChildForm)
        {
            if (childPanelForm != null)
            {
                //Close a child form to have only one open
                childPanelForm.Close();
            }

            childPanelForm = aChildForm;
            aChildForm.FormBorderStyle = FormBorderStyle.None;
            aChildForm.Dock = DockStyle.Fill;
            aChildForm.BringToFront();
            aChildForm.Show();


        }
    }
}
