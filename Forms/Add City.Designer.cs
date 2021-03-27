using FontAwesome.Sharp;
namespace Coach_Form_UI
{
    partial class Add_City
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.miniBtn = new FontAwesome.Sharp.IconButton();
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            this.citiesLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listOfCities = new System.Windows.Forms.ListBox();
            this.longitude = new System.Windows.Forms.TextBox();
            this.cityName = new System.Windows.Forms.TextBox();
            this.latitude = new System.Windows.Forms.TextBox();
            this.stationName = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.addStationLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.TextBox();
            this.topPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.topPanel.Controls.Add(this.miniBtn);
            this.topPanel.Controls.Add(this.closeBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(2095, 89);
            this.topPanel.TabIndex = 1;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // miniBtn
            // 
            this.miniBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.miniBtn.FlatAppearance.BorderSize = 0;
            this.miniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.miniBtn.IconColor = System.Drawing.Color.White;
            this.miniBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.miniBtn.IconSize = 90;
            this.miniBtn.Location = new System.Drawing.Point(1939, 0);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.Size = new System.Drawing.Size(78, 89);
            this.miniBtn.TabIndex = 1;
            this.miniBtn.UseVisualStyleBackColor = true;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 90;
            this.closeBtn.Location = new System.Drawing.Point(2017, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(78, 89);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // citiesLabel
            // 
            this.citiesLabel.AutoSize = true;
            this.citiesLabel.Font = new System.Drawing.Font("Gadugi", 14.1F);
            this.citiesLabel.ForeColor = System.Drawing.Color.White;
            this.citiesLabel.Location = new System.Drawing.Point(391, 180);
            this.citiesLabel.Name = "citiesLabel";
            this.citiesLabel.Size = new System.Drawing.Size(139, 56);
            this.citiesLabel.TabIndex = 2;
            this.citiesLabel.Text = "Cities";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(938, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 1058);
            this.panel1.TabIndex = 3;
            // 
            // listOfCities
            // 
            this.listOfCities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.listOfCities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOfCities.Font = new System.Drawing.Font("Gadugi", 27.9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfCities.ForeColor = System.Drawing.Color.White;
            this.listOfCities.FormattingEnabled = true;
            this.listOfCities.ItemHeight = 111;
            this.listOfCities.Location = new System.Drawing.Point(186, 262);
            this.listOfCities.Margin = new System.Windows.Forms.Padding(10);
            this.listOfCities.Name = "listOfCities";
            this.listOfCities.Size = new System.Drawing.Size(605, 666);
            this.listOfCities.TabIndex = 4;
            // 
            // longitude
            // 
            this.longitude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.longitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.longitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitude.ForeColor = System.Drawing.Color.DimGray;
            this.longitude.Location = new System.Drawing.Point(1235, 666);
            this.longitude.Multiline = true;
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(605, 65);
            this.longitude.TabIndex = 16;
            this.longitude.Text = "Station Logitude";
            this.longitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.longitude.Enter += new System.EventHandler(this.longitude_Enter);
            this.longitude.Leave += new System.EventHandler(this.longitude_Leave);
            // 
            // cityName
            // 
            this.cityName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cityName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityName.ForeColor = System.Drawing.Color.DimGray;
            this.cityName.Location = new System.Drawing.Point(1235, 429);
            this.cityName.Multiline = true;
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(605, 65);
            this.cityName.TabIndex = 18;
            this.cityName.Text = "City Name";
            this.cityName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cityName.Enter += new System.EventHandler(this.cityName_Enter);
            this.cityName.Leave += new System.EventHandler(this.cityName_Leave);
            // 
            // latitude
            // 
            this.latitude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.latitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.latitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitude.ForeColor = System.Drawing.Color.DimGray;
            this.latitude.Location = new System.Drawing.Point(1235, 541);
            this.latitude.Multiline = true;
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(605, 65);
            this.latitude.TabIndex = 19;
            this.latitude.Text = "Station Latitude";
            this.latitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.latitude.Enter += new System.EventHandler(this.latitude_Enter);
            this.latitude.Leave += new System.EventHandler(this.latitude_Leave);
            // 
            // stationName
            // 
            this.stationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.stationName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationName.ForeColor = System.Drawing.Color.DimGray;
            this.stationName.Location = new System.Drawing.Point(1235, 304);
            this.stationName.Multiline = true;
            this.stationName.Name = "stationName";
            this.stationName.Size = new System.Drawing.Size(605, 65);
            this.stationName.TabIndex = 20;
            this.stationName.Text = "Station Name";
            this.stationName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stationName.Enter += new System.EventHandler(this.stationName_Enter);
            this.stationName.Leave += new System.EventHandler(this.stationName_Leave);
            // 
            // submitBtn
            // 
            this.submitBtn.FlatAppearance.BorderSize = 0;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(1193, 841);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(694, 55);
            this.submitBtn.TabIndex = 14;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(1184, 738);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(694, 1);
            this.panel7.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "label1";
            // 
            // addStationLabel
            // 
            this.addStationLabel.AutoSize = true;
            this.addStationLabel.Font = new System.Drawing.Font("Gadugi", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStationLabel.ForeColor = System.Drawing.Color.White;
            this.addStationLabel.Location = new System.Drawing.Point(1407, 201);
            this.addStationLabel.Name = "addStationLabel";
            this.addStationLabel.Size = new System.Drawing.Size(273, 56);
            this.addStationLabel.TabIndex = 13;
            this.addStationLabel.Text = "Add Station";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(1184, 501);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(694, 1);
            this.panel5.TabIndex = 10;
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(1184, 612);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(694, 1);
            this.panel6.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(1184, 375);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(694, 1);
            this.panel4.TabIndex = 12;
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(135, 1065);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(694, 55);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(135, 1029);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 1);
            this.panel2.TabIndex = 12;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.deleteButton.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.DimGray;
            this.deleteButton.Location = new System.Drawing.Point(186, 958);
            this.deleteButton.Multiline = true;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(605, 65);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Delete Entry";
            this.deleteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteButton.Enter += new System.EventHandler(this.delete_Enter);
            this.deleteButton.Leave += new System.EventHandler(this.deleteButton_Leave);
            // 
            // Add_City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(2095, 1222);
            this.Controls.Add(this.longitude);
            this.Controls.Add(this.cityName);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.stationName);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.addStationLabel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.listOfCities);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.citiesLabel);
            this.Controls.Add(this.topPanel);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_City";
            this.Text = "Add_City";
            this.Load += new System.EventHandler(this.Add_City_Load);
            this.topPanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Panel topPanel;
        private IconButton closeBtn;
        private IconButton miniBtn;
        private System.Windows.Forms.Label citiesLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listOfCities;
        private System.Windows.Forms.TextBox longitude;
        private System.Windows.Forms.TextBox cityName;
        private System.Windows.Forms.TextBox latitude;
        private System.Windows.Forms.TextBox stationName;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label addStationLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox deleteButton;
    }
}