
namespace Coach_Form_UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPannel = new System.Windows.Forms.Panel();
            this.manageAccount = new FontAwesome.Sharp.IconButton();
            this.settingBtn = new FontAwesome.Sharp.IconButton();
            this.BookTicketBtn = new FontAwesome.Sharp.IconButton();
            this.HomeBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.TopMenuPanel = new System.Windows.Forms.Panel();
            this.signOutBtn = new FontAwesome.Sharp.IconButton();
            this.ChildLabel = new System.Windows.Forms.Label();
            this.IconChild = new FontAwesome.Sharp.IconPictureBox();
            this.MiniBtn = new FontAwesome.Sharp.IconButton();
            this.CloseBtn = new FontAwesome.Sharp.IconButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainPannel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.TopMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconChild)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPannel
            // 
            this.MainPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MainPannel.Controls.Add(this.manageAccount);
            this.MainPannel.Controls.Add(this.settingBtn);
            this.MainPannel.Controls.Add(this.BookTicketBtn);
            this.MainPannel.Controls.Add(this.HomeBtn);
            this.MainPannel.Controls.Add(this.panel2);
            this.MainPannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainPannel.Location = new System.Drawing.Point(0, 0);
            this.MainPannel.Name = "MainPannel";
            this.MainPannel.Size = new System.Drawing.Size(391, 1117);
            this.MainPannel.TabIndex = 0;
            // 
            // manageAccount
            // 
            this.manageAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.manageAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.manageAccount.FlatAppearance.BorderSize = 0;
            this.manageAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageAccount.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.manageAccount.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.manageAccount.IconColor = System.Drawing.Color.White;
            this.manageAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.manageAccount.IconSize = 80;
            this.manageAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageAccount.Location = new System.Drawing.Point(0, 897);
            this.manageAccount.Name = "manageAccount";
            this.manageAccount.Size = new System.Drawing.Size(391, 110);
            this.manageAccount.TabIndex = 6;
            this.manageAccount.Text = "Manage Account";
            this.manageAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.manageAccount.UseVisualStyleBackColor = false;
            this.manageAccount.Visible = false;
            this.manageAccount.Click += new System.EventHandler(this.manageAccount_Click);
            // 
            // settingBtn
            // 
            this.settingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.settingBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.settingBtn.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.settingBtn.IconColor = System.Drawing.Color.White;
            this.settingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingBtn.IconSize = 80;
            this.settingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingBtn.Location = new System.Drawing.Point(0, 1007);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(391, 110);
            this.settingBtn.TabIndex = 5;
            this.settingBtn.Text = "Manage Coaches";
            this.settingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.settingBtn.UseVisualStyleBackColor = false;
            this.settingBtn.Visible = false;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // BookTicketBtn
            // 
            this.BookTicketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BookTicketBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookTicketBtn.FlatAppearance.BorderSize = 0;
            this.BookTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookTicketBtn.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTicketBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BookTicketBtn.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.BookTicketBtn.IconColor = System.Drawing.Color.White;
            this.BookTicketBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BookTicketBtn.IconSize = 80;
            this.BookTicketBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookTicketBtn.Location = new System.Drawing.Point(0, 406);
            this.BookTicketBtn.Name = "BookTicketBtn";
            this.BookTicketBtn.Size = new System.Drawing.Size(391, 110);
            this.BookTicketBtn.TabIndex = 2;
            this.BookTicketBtn.Text = "Book Ticket";
            this.BookTicketBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BookTicketBtn.UseVisualStyleBackColor = false;
            this.BookTicketBtn.Click += new System.EventHandler(this.BookTicketBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.HomeBtn.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.HomeBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.HomeBtn.IconColor = System.Drawing.Color.White;
            this.HomeBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.HomeBtn.IconSize = 80;
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.Location = new System.Drawing.Point(0, 296);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(391, 110);
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.UserNameLabel);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 296);
            this.panel2.TabIndex = 0;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserNameLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(249)))));
            this.UserNameLabel.Location = new System.Drawing.Point(106, 232);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(165, 41);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "User Name";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 196;
            this.iconPictureBox1.Location = new System.Drawing.Point(88, 29);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(196, 200);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // TopMenuPanel
            // 
            this.TopMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TopMenuPanel.Controls.Add(this.signOutBtn);
            this.TopMenuPanel.Controls.Add(this.ChildLabel);
            this.TopMenuPanel.Controls.Add(this.IconChild);
            this.TopMenuPanel.Controls.Add(this.MiniBtn);
            this.TopMenuPanel.Controls.Add(this.CloseBtn);
            this.TopMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMenuPanel.Location = new System.Drawing.Point(391, 0);
            this.TopMenuPanel.Name = "TopMenuPanel";
            this.TopMenuPanel.Size = new System.Drawing.Size(2114, 89);
            this.TopMenuPanel.TabIndex = 1;
            this.TopMenuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopMenuPanel_MouseDown);
            // 
            // signOutBtn
            // 
            this.signOutBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.signOutBtn.FlatAppearance.BorderSize = 0;
            this.signOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOutBtn.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.signOutBtn.ForeColor = System.Drawing.Color.White;
            this.signOutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.signOutBtn.IconColor = System.Drawing.Color.White;
            this.signOutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.signOutBtn.IconSize = 50;
            this.signOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signOutBtn.Location = new System.Drawing.Point(1732, 0);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(226, 89);
            this.signOutBtn.TabIndex = 4;
            this.signOutBtn.Text = "Sign Out";
            this.signOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.signOutBtn.UseVisualStyleBackColor = true;
            // 
            // ChildLabel
            // 
            this.ChildLabel.AutoSize = true;
            this.ChildLabel.Font = new System.Drawing.Font("Nirmala UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ChildLabel.Location = new System.Drawing.Point(94, 19);
            this.ChildLabel.Name = "ChildLabel";
            this.ChildLabel.Size = new System.Drawing.Size(116, 46);
            this.ChildLabel.TabIndex = 3;
            this.ChildLabel.Text = "Home";
            // 
            // IconChild
            // 
            this.IconChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.IconChild.Dock = System.Windows.Forms.DockStyle.Left;
            this.IconChild.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.IconChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconChild.IconColor = System.Drawing.Color.White;
            this.IconChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconChild.IconSize = 88;
            this.IconChild.Location = new System.Drawing.Point(0, 0);
            this.IconChild.Name = "IconChild";
            this.IconChild.Size = new System.Drawing.Size(88, 89);
            this.IconChild.TabIndex = 2;
            this.IconChild.TabStop = false;
            // 
            // MiniBtn
            // 
            this.MiniBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MiniBtn.FlatAppearance.BorderSize = 0;
            this.MiniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiniBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MiniBtn.IconColor = System.Drawing.Color.White;
            this.MiniBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MiniBtn.IconSize = 90;
            this.MiniBtn.Location = new System.Drawing.Point(1958, 0);
            this.MiniBtn.Name = "MiniBtn";
            this.MiniBtn.Size = new System.Drawing.Size(78, 89);
            this.MiniBtn.TabIndex = 1;
            this.MiniBtn.UseVisualStyleBackColor = true;
            this.MiniBtn.Click += new System.EventHandler(this.MiniBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.CloseBtn.IconColor = System.Drawing.Color.White;
            this.CloseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseBtn.IconSize = 90;
            this.CloseBtn.Location = new System.Drawing.Point(2036, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(78, 89);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(391, 89);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(2114, 1028);
            this.MainPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(2505, 1117);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopMenuPanel);
            this.Controls.Add(this.MainPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MainPannel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.TopMenuPanel.ResumeLayout(false);
            this.TopMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconChild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPannel;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton HomeBtn;
        private System.Windows.Forms.Label UserNameLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton BookTicketBtn;
        private System.Windows.Forms.Panel TopMenuPanel;
        private FontAwesome.Sharp.IconButton CloseBtn;
        private FontAwesome.Sharp.IconButton MiniBtn;
        private FontAwesome.Sharp.IconPictureBox IconChild;
        private System.Windows.Forms.Label ChildLabel;
        private System.Windows.Forms.Panel MainPanel;
        private FontAwesome.Sharp.IconButton settingBtn;
        private FontAwesome.Sharp.IconButton signOutBtn;
        private FontAwesome.Sharp.IconButton manageAccount;
    }
}

