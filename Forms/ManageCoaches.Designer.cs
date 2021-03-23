
namespace Coach_Form_UI
{
    partial class ManageCoaches
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
            this.addCity = new FontAwesome.Sharp.IconButton();
            this.editUserBookingBtn = new FontAwesome.Sharp.IconButton();
            this.addJourneyBtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // addCity
            // 
            this.addCity.FlatAppearance.BorderSize = 0;
            this.addCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCity.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.addCity.ForeColor = System.Drawing.Color.White;
            this.addCity.IconChar = FontAwesome.Sharp.IconChar.City;
            this.addCity.IconColor = System.Drawing.Color.White;
            this.addCity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addCity.IconSize = 342;
            this.addCity.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addCity.Location = new System.Drawing.Point(159, 325);
            this.addCity.Name = "addCity";
            this.addCity.Size = new System.Drawing.Size(530, 322);
            this.addCity.TabIndex = 1;
            this.addCity.Text = "Add City";
            this.addCity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addCity.UseVisualStyleBackColor = true;
            this.addCity.Click += new System.EventHandler(this.addCity_Click);
            // 
            // editUserBookingBtn
            // 
            this.editUserBookingBtn.FlatAppearance.BorderSize = 0;
            this.editUserBookingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUserBookingBtn.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.editUserBookingBtn.ForeColor = System.Drawing.Color.White;
            this.editUserBookingBtn.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.editUserBookingBtn.IconColor = System.Drawing.Color.White;
            this.editUserBookingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editUserBookingBtn.IconSize = 342;
            this.editUserBookingBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editUserBookingBtn.Location = new System.Drawing.Point(821, 325);
            this.editUserBookingBtn.Name = "editUserBookingBtn";
            this.editUserBookingBtn.Size = new System.Drawing.Size(530, 322);
            this.editUserBookingBtn.TabIndex = 1;
            this.editUserBookingBtn.Text = "Edit Booking";
            this.editUserBookingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editUserBookingBtn.UseVisualStyleBackColor = true;
            // 
            // addJourneyBtn
            // 
            this.addJourneyBtn.FlatAppearance.BorderSize = 0;
            this.addJourneyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addJourneyBtn.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.addJourneyBtn.ForeColor = System.Drawing.Color.White;
            this.addJourneyBtn.IconChar = FontAwesome.Sharp.IconChar.Road;
            this.addJourneyBtn.IconColor = System.Drawing.Color.White;
            this.addJourneyBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addJourneyBtn.IconSize = 342;
            this.addJourneyBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addJourneyBtn.Location = new System.Drawing.Point(1467, 325);
            this.addJourneyBtn.Name = "addJourneyBtn";
            this.addJourneyBtn.Size = new System.Drawing.Size(530, 322);
            this.addJourneyBtn.TabIndex = 1;
            this.addJourneyBtn.Text = "Add Journey";
            this.addJourneyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addJourneyBtn.UseVisualStyleBackColor = true;
            // 
            // ManageCoaches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(2216, 1220);
            this.Controls.Add(this.addJourneyBtn);
            this.Controls.Add(this.editUserBookingBtn);
            this.Controls.Add(this.addCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCoaches";
            this.Text = "ManageCoaches";
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton addCity;
        private FontAwesome.Sharp.IconButton editUserBookingBtn;
        private FontAwesome.Sharp.IconButton addJourneyBtn;
    }
}