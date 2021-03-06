using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Geolocation;

namespace Coach_Form_UI
{
    public partial class MainForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBtnMenu;
        private Form childForm;
        static bool isAdmin;



        public MainForm(string userFirstName, string userEmail, string userSurname, int userAge, string userPassword)
        {
            InitializeComponent();
            leftBtnMenu = new Panel();
            leftBtnMenu.Size = new Size(7, 100);
            MainPannel.Controls.Add(leftBtnMenu);

            if (userEmail.Contains("@tripleg.com"))
            {
                isAdmin = true;
                settingBtn.Visible = true;
                settingBtn.Dock = DockStyle.Top;
                manageAccount.Visible = true;
                manageAccount.Dock = DockStyle.Top;
                BookTicketBtn.Visible = false;
            }

            //User Object
            UserModel currentUser = new UserModel(userEmail, userFirstName, userSurname, userAge, userPassword, isAdmin);


           
            UserNameLabel.Text = userFirstName + " " + userSurname;

            //Main form
            this.DoubleBuffered = true;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.openChildForm(new HomeForm());
            

        }

        public void openChildForm(Form aChildForm) 
        {

            if (childForm != null)
            {
                //Close a child form to have only one open
                childForm.Close();
            }

            childForm = aChildForm;
            aChildForm.TopLevel = false;
            aChildForm.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(aChildForm);
            MainPanel.Tag = aChildForm;
            aChildForm.Dock = DockStyle.Fill;
            aChildForm.BringToFront();
            aChildForm.Show();
            aChildForm.BackColor = Color.FromArgb(46, 51, 73);


        }

        public struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(48, 214, 17);
            public static Color color8 = Color.FromArgb(255, 7, 58);
        }

        private void activeBtn(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DeactivateBtn();
                // btn
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                

                //left btn color
                leftBtnMenu.BackColor = color;
                leftBtnMenu.Location = new Point(0, currentBtn.Location.Y);
                leftBtnMenu.Visible = true;
                leftBtnMenu.BringToFront();

                //child btn
                IconChild.IconChar = currentBtn.IconChar;
                IconChild.IconColor = color;
                ChildLabel.Text = currentBtn.Text;
                ChildLabel.ForeColor = color;

            }
        
        }

        private void DeactivateBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(24, 30, 54);
                currentBtn.ForeColor = Color.FromArgb(0, 126, 249);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
            

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            
            activeBtn(sender, RGBColors.color1);
            openChildForm(new HomeForm());

        }

        private void BookTicketBtn_Click(object sender, EventArgs e)
        {
            activeBtn(sender, RGBColors.color2);
            openChildForm(new BookTicketForm());
        }

 


        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Drag menu
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TopMenuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            activeBtn(sender, RGBColors.color5);
            openChildForm(new ManageCoaches());
        }

        private void manageAccount_Click(object sender, EventArgs e)
        {
            activeBtn(sender, RGBColors.color3);
            openChildForm(new Manage_User_Booking());
        }
    }
}
