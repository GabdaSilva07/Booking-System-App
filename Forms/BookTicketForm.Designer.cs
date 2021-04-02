
namespace Coach_Form_UI
{
    partial class BookTicketForm
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
            this.Arrival = new System.Windows.Forms.Label();
            this.arrivalListBooking = new System.Windows.Forms.ComboBox();
            this.departure = new System.Windows.Forms.Label();
            this.departureListBooking = new System.Windows.Forms.ComboBox();
            this.listViewJourneys = new System.Windows.Forms.ListView();
            this.searchJourney = new System.Windows.Forms.Button();
            this.bookTicketBtn = new System.Windows.Forms.Button();
            this.DateBox = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Arrival
            // 
            this.Arrival.AutoSize = true;
            this.Arrival.Font = new System.Drawing.Font("Nirmala UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arrival.ForeColor = System.Drawing.Color.White;
            this.Arrival.Location = new System.Drawing.Point(1109, 69);
            this.Arrival.Name = "Arrival";
            this.Arrival.Size = new System.Drawing.Size(192, 65);
            this.Arrival.TabIndex = 4;
            this.Arrival.Text = "Arrival:";
            // 
            // arrivalListBooking
            // 
            this.arrivalListBooking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arrivalListBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arrivalListBooking.Font = new System.Drawing.Font("Nirmala UI", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalListBooking.FormattingEnabled = true;
            this.arrivalListBooking.Location = new System.Drawing.Point(1316, 80);
            this.arrivalListBooking.Name = "arrivalListBooking";
            this.arrivalListBooking.Size = new System.Drawing.Size(431, 106);
            this.arrivalListBooking.TabIndex = 2;
            // 
            // departure
            // 
            this.departure.AutoSize = true;
            this.departure.Font = new System.Drawing.Font("Nirmala UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departure.ForeColor = System.Drawing.Color.White;
            this.departure.Location = new System.Drawing.Point(334, 69);
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(269, 65);
            this.departure.TabIndex = 5;
            this.departure.Text = "Departure:";
            // 
            // departureListBooking
            // 
            this.departureListBooking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departureListBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departureListBooking.Font = new System.Drawing.Font("Nirmala UI", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureListBooking.FormattingEnabled = true;
            this.departureListBooking.Location = new System.Drawing.Point(624, 80);
            this.departureListBooking.Name = "departureListBooking";
            this.departureListBooking.Size = new System.Drawing.Size(431, 106);
            this.departureListBooking.TabIndex = 3;
            // 
            // listViewJourneys
            // 
            this.listViewJourneys.HideSelection = false;
            this.listViewJourneys.Location = new System.Drawing.Point(120, 459);
            this.listViewJourneys.MultiSelect = false;
            this.listViewJourneys.Name = "listViewJourneys";
            this.listViewJourneys.Size = new System.Drawing.Size(1880, 390);
            this.listViewJourneys.TabIndex = 6;
            this.listViewJourneys.UseCompatibleStateImageBehavior = false;
            // 
            // searchJourney
            // 
            this.searchJourney.FlatAppearance.BorderSize = 0;
            this.searchJourney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchJourney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchJourney.ForeColor = System.Drawing.Color.White;
            this.searchJourney.Location = new System.Drawing.Point(760, 355);
            this.searchJourney.Name = "searchJourney";
            this.searchJourney.Size = new System.Drawing.Size(694, 55);
            this.searchJourney.TabIndex = 14;
            this.searchJourney.Text = "Search Journey";
            this.searchJourney.UseVisualStyleBackColor = true;
            this.searchJourney.Click += new System.EventHandler(this.searchJourney_Click);
            // 
            // bookTicketBtn
            // 
            this.bookTicketBtn.FlatAppearance.BorderSize = 0;
            this.bookTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookTicketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTicketBtn.ForeColor = System.Drawing.Color.White;
            this.bookTicketBtn.Location = new System.Drawing.Point(760, 935);
            this.bookTicketBtn.Name = "bookTicketBtn";
            this.bookTicketBtn.Size = new System.Drawing.Size(694, 55);
            this.bookTicketBtn.TabIndex = 14;
            this.bookTicketBtn.Text = "Book Ticket";
            this.bookTicketBtn.UseVisualStyleBackColor = true;
            this.bookTicketBtn.Click += new System.EventHandler(this.bookTicketBtn_Click);
            // 
            // DateBox
            // 
            this.DateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DateBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateBox.Font = new System.Drawing.Font("Nirmala UI", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBox.FormattingEnabled = true;
            this.DateBox.Location = new System.Drawing.Point(1316, 231);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(431, 106);
            this.DateBox.TabIndex = 2;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Nirmala UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(1109, 220);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(147, 65);
            this.Date.TabIndex = 4;
            this.Date.Text = "Date:";
            // 
            // BookTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(2122, 1383);
            this.Controls.Add(this.bookTicketBtn);
            this.Controls.Add(this.searchJourney);
            this.Controls.Add(this.listViewJourneys);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Arrival);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.arrivalListBooking);
            this.Controls.Add(this.departure);
            this.Controls.Add(this.departureListBooking);
            this.Name = "BookTicketForm";
            this.Text = "BookTicketForm";
            this.Load += new System.EventHandler(this.BookTicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Arrival;
        private System.Windows.Forms.ComboBox arrivalListBooking;
        private System.Windows.Forms.Label departure;
        private System.Windows.Forms.ComboBox departureListBooking;
        private System.Windows.Forms.ListView listViewJourneys;
        private System.Windows.Forms.Button searchJourney;
        private System.Windows.Forms.Button bookTicketBtn;
        private System.Windows.Forms.ComboBox DateBox;
        private System.Windows.Forms.Label Date;
    }
}