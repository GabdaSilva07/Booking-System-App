
namespace Coach_Form_UI
{
    partial class Journey
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
            this.departureList = new System.Windows.Forms.ComboBox();
            this.departure = new System.Windows.Forms.Label();
            this.arrivalList = new System.Windows.Forms.ComboBox();
            this.Arrival = new System.Windows.Forms.Label();
            this.arrivalTime = new System.Windows.Forms.TextBox();
            this.depatureTime = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.createJourneyBtn = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.journeyMinBtn = new FontAwesome.Sharp.IconPictureBox();
            this.journeyCloseBtn = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.departureDateBox = new System.Windows.Forms.TextBox();
            this.panel5.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journeyMinBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journeyCloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // departureList
            // 
            this.departureList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departureList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departureList.Font = new System.Drawing.Font("Nirmala UI", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureList.FormattingEnabled = true;
            this.departureList.Location = new System.Drawing.Point(420, 183);
            this.departureList.Name = "departureList";
            this.departureList.Size = new System.Drawing.Size(431, 106);
            this.departureList.TabIndex = 0;
            // 
            // departure
            // 
            this.departure.AutoSize = true;
            this.departure.Font = new System.Drawing.Font("Nirmala UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departure.ForeColor = System.Drawing.Color.White;
            this.departure.Location = new System.Drawing.Point(130, 172);
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(269, 65);
            this.departure.TabIndex = 1;
            this.departure.Text = "Departure:";
            // 
            // arrivalList
            // 
            this.arrivalList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arrivalList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arrivalList.Font = new System.Drawing.Font("Nirmala UI", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalList.FormattingEnabled = true;
            this.arrivalList.Location = new System.Drawing.Point(1325, 194);
            this.arrivalList.Name = "arrivalList";
            this.arrivalList.Size = new System.Drawing.Size(431, 106);
            this.arrivalList.TabIndex = 0;
            // 
            // Arrival
            // 
            this.Arrival.AutoSize = true;
            this.Arrival.Font = new System.Drawing.Font("Nirmala UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arrival.ForeColor = System.Drawing.Color.White;
            this.Arrival.Location = new System.Drawing.Point(1118, 183);
            this.Arrival.Name = "Arrival";
            this.Arrival.Size = new System.Drawing.Size(192, 65);
            this.Arrival.TabIndex = 1;
            this.Arrival.Text = "Arrival:";
            // 
            // arrivalTime
            // 
            this.arrivalTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.arrivalTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.arrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalTime.ForeColor = System.Drawing.Color.DimGray;
            this.arrivalTime.Location = new System.Drawing.Point(1151, 618);
            this.arrivalTime.Multiline = true;
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(605, 65);
            this.arrivalTime.TabIndex = 10;
            this.arrivalTime.Text = "Arrival Time:";
            this.arrivalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arrivalTime.Enter += new System.EventHandler(this.arrivalTime_Enter);
            this.arrivalTime.Leave += new System.EventHandler(this.arrivalTime_Leave);
            // 
            // depatureTime
            // 
            this.depatureTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.depatureTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.depatureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depatureTime.ForeColor = System.Drawing.Color.DimGray;
            this.depatureTime.Location = new System.Drawing.Point(183, 618);
            this.depatureTime.Multiline = true;
            this.depatureTime.Name = "depatureTime";
            this.depatureTime.Size = new System.Drawing.Size(605, 65);
            this.depatureTime.TabIndex = 12;
            this.depatureTime.Text = "Departure Time:";
            this.depatureTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.depatureTime.Enter += new System.EventHandler(this.depatureTime_Enter);
            this.depatureTime.Leave += new System.EventHandler(this.depatureTime_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(1100, 690);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(694, 1);
            this.panel5.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "label1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(132, 689);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(694, 1);
            this.panel4.TabIndex = 9;
            // 
            // createJourneyBtn
            // 
            this.createJourneyBtn.FlatAppearance.BorderSize = 0;
            this.createJourneyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createJourneyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createJourneyBtn.ForeColor = System.Drawing.Color.White;
            this.createJourneyBtn.Location = new System.Drawing.Point(598, 905);
            this.createJourneyBtn.Name = "createJourneyBtn";
            this.createJourneyBtn.Size = new System.Drawing.Size(694, 55);
            this.createJourneyBtn.TabIndex = 13;
            this.createJourneyBtn.Text = "Create Journey";
            this.createJourneyBtn.UseVisualStyleBackColor = true;
            this.createJourneyBtn.Click += new System.EventHandler(this.createJourneyBtn_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.topPanel.Controls.Add(this.journeyMinBtn);
            this.topPanel.Controls.Add(this.journeyCloseBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(2007, 72);
            this.topPanel.TabIndex = 14;
            // 
            // journeyMinBtn
            // 
            this.journeyMinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.journeyMinBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.journeyMinBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.journeyMinBtn.IconColor = System.Drawing.Color.White;
            this.journeyMinBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.journeyMinBtn.IconSize = 72;
            this.journeyMinBtn.Location = new System.Drawing.Point(1861, 0);
            this.journeyMinBtn.Name = "journeyMinBtn";
            this.journeyMinBtn.Size = new System.Drawing.Size(74, 72);
            this.journeyMinBtn.TabIndex = 1;
            this.journeyMinBtn.TabStop = false;
            this.journeyMinBtn.Click += new System.EventHandler(this.journeyMinBtn_Click);
            // 
            // journeyCloseBtn
            // 
            this.journeyCloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.journeyCloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.journeyCloseBtn.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.journeyCloseBtn.IconColor = System.Drawing.Color.White;
            this.journeyCloseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.journeyCloseBtn.IconSize = 72;
            this.journeyCloseBtn.Location = new System.Drawing.Point(1935, 0);
            this.journeyCloseBtn.Name = "journeyCloseBtn";
            this.journeyCloseBtn.Size = new System.Drawing.Size(72, 72);
            this.journeyCloseBtn.TabIndex = 0;
            this.journeyCloseBtn.TabStop = false;
            this.journeyCloseBtn.Click += new System.EventHandler(this.journeyCloseBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(636, 519);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 1);
            this.panel1.TabIndex = 9;
            // 
            // departureDateBox
            // 
            this.departureDateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.departureDateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departureDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureDateBox.ForeColor = System.Drawing.Color.DimGray;
            this.departureDateBox.Location = new System.Drawing.Point(687, 448);
            this.departureDateBox.Multiline = true;
            this.departureDateBox.Name = "departureDateBox";
            this.departureDateBox.Size = new System.Drawing.Size(605, 65);
            this.departureDateBox.TabIndex = 12;
            this.departureDateBox.Text = "Departure Date:";
            this.departureDateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.departureDateBox.Enter += new System.EventHandler(this.departureDateBox_Enter);
            this.departureDateBox.Leave += new System.EventHandler(this.departureDateBox_Leave);
            // 
            // Journey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(2007, 1289);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.createJourneyBtn);
            this.Controls.Add(this.arrivalTime);
            this.Controls.Add(this.departureDateBox);
            this.Controls.Add(this.depatureTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Arrival);
            this.Controls.Add(this.arrivalList);
            this.Controls.Add(this.departure);
            this.Controls.Add(this.departureList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Journey";
            this.Text = "Journey";
            this.Load += new System.EventHandler(this.Journey_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.journeyMinBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journeyCloseBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox departureList;
        private System.Windows.Forms.Label departure;
        private System.Windows.Forms.ComboBox arrivalList;
        private System.Windows.Forms.Label Arrival;
        private System.Windows.Forms.TextBox arrivalTime;
        private System.Windows.Forms.TextBox depatureTime;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button createJourneyBtn;
        private System.Windows.Forms.Panel topPanel;
        private FontAwesome.Sharp.IconPictureBox journeyMinBtn;
        private FontAwesome.Sharp.IconPictureBox journeyCloseBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox departureDateBox;
    }
}