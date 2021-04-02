
namespace Coach_Form_UI
{
    partial class PaymentForm
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
            this.paymentTopMenuPanel = new System.Windows.Forms.Panel();
            this.PaymentChildLabel = new System.Windows.Forms.Label();
            this.MiniBtn = new FontAwesome.Sharp.IconButton();
            this.CloseBtn = new FontAwesome.Sharp.IconButton();
            this.PaymentIconChild = new FontAwesome.Sharp.IconPictureBox();
            this.expiryDate = new System.Windows.Forms.TextBox();
            this.CSC = new System.Windows.Forms.TextBox();
            this.sortCode = new System.Windows.Forms.TextBox();
            this.accountNumber = new System.Windows.Forms.TextBox();
            this.nameOnCard = new System.Windows.Forms.TextBox();
            this.payBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.paymentTopMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentIconChild)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // paymentTopMenuPanel
            // 
            this.paymentTopMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.paymentTopMenuPanel.Controls.Add(this.PaymentChildLabel);
            this.paymentTopMenuPanel.Controls.Add(this.PaymentIconChild);
            this.paymentTopMenuPanel.Controls.Add(this.MiniBtn);
            this.paymentTopMenuPanel.Controls.Add(this.CloseBtn);
            this.paymentTopMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paymentTopMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.paymentTopMenuPanel.Name = "paymentTopMenuPanel";
            this.paymentTopMenuPanel.Size = new System.Drawing.Size(2184, 89);
            this.paymentTopMenuPanel.TabIndex = 2;
            // 
            // PaymentChildLabel
            // 
            this.PaymentChildLabel.AutoSize = true;
            this.PaymentChildLabel.Font = new System.Drawing.Font("Nirmala UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentChildLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PaymentChildLabel.Location = new System.Drawing.Point(94, 19);
            this.PaymentChildLabel.Name = "PaymentChildLabel";
            this.PaymentChildLabel.Size = new System.Drawing.Size(159, 46);
            this.PaymentChildLabel.TabIndex = 3;
            this.PaymentChildLabel.Text = "Payment";
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
            this.MiniBtn.Location = new System.Drawing.Point(2028, 0);
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
            this.CloseBtn.Location = new System.Drawing.Point(2106, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(78, 89);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // PaymentIconChild
            // 
            this.PaymentIconChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PaymentIconChild.Dock = System.Windows.Forms.DockStyle.Left;
            this.PaymentIconChild.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.PaymentIconChild.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.PaymentIconChild.IconColor = System.Drawing.Color.White;
            this.PaymentIconChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PaymentIconChild.IconSize = 88;
            this.PaymentIconChild.Location = new System.Drawing.Point(0, 0);
            this.PaymentIconChild.Name = "PaymentIconChild";
            this.PaymentIconChild.Size = new System.Drawing.Size(88, 89);
            this.PaymentIconChild.TabIndex = 2;
            this.PaymentIconChild.TabStop = false;
            // 
            // expiryDate
            // 
            this.expiryDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.expiryDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryDate.ForeColor = System.Drawing.Color.DimGray;
            this.expiryDate.Location = new System.Drawing.Point(697, 633);
            this.expiryDate.Multiline = true;
            this.expiryDate.Name = "expiryDate";
            this.expiryDate.Size = new System.Drawing.Size(605, 65);
            this.expiryDate.TabIndex = 16;
            this.expiryDate.Text = "Expiry Date";
            this.expiryDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.expiryDate.Enter += new System.EventHandler(this.expiryDate_Enter);
            this.expiryDate.Leave += new System.EventHandler(this.expiryDate_Leave);
            // 
            // CSC
            // 
            this.CSC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CSC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSC.ForeColor = System.Drawing.Color.DimGray;
            this.CSC.Location = new System.Drawing.Point(697, 732);
            this.CSC.Multiline = true;
            this.CSC.Name = "CSC";
            this.CSC.Size = new System.Drawing.Size(605, 65);
            this.CSC.TabIndex = 17;
            this.CSC.Text = "CSC";
            this.CSC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CSC.UseSystemPasswordChar = true;
            this.CSC.Enter += new System.EventHandler(this.CSC_Enter);
            this.CSC.Leave += new System.EventHandler(this.CSC_Leave);
            // 
            // sortCode
            // 
            this.sortCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.sortCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sortCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortCode.ForeColor = System.Drawing.Color.DimGray;
            this.sortCode.Location = new System.Drawing.Point(697, 409);
            this.sortCode.Multiline = true;
            this.sortCode.Name = "sortCode";
            this.sortCode.Size = new System.Drawing.Size(605, 65);
            this.sortCode.TabIndex = 18;
            this.sortCode.Text = "Sort Code";
            this.sortCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sortCode.Enter += new System.EventHandler(this.sortCode_Enter);
            this.sortCode.Leave += new System.EventHandler(this.sortCode_Leave);
            // 
            // accountNumber
            // 
            this.accountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.accountNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumber.ForeColor = System.Drawing.Color.DimGray;
            this.accountNumber.Location = new System.Drawing.Point(697, 525);
            this.accountNumber.Multiline = true;
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.Size = new System.Drawing.Size(605, 65);
            this.accountNumber.TabIndex = 19;
            this.accountNumber.Text = "Account Number";
            this.accountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.accountNumber.Enter += new System.EventHandler(this.accountNumber_Enter);
            this.accountNumber.Leave += new System.EventHandler(this.accountNumber_Leave);
            // 
            // nameOnCard
            // 
            this.nameOnCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.nameOnCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameOnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOnCard.ForeColor = System.Drawing.Color.DimGray;
            this.nameOnCard.Location = new System.Drawing.Point(697, 281);
            this.nameOnCard.Multiline = true;
            this.nameOnCard.Name = "nameOnCard";
            this.nameOnCard.Size = new System.Drawing.Size(605, 65);
            this.nameOnCard.TabIndex = 20;
            this.nameOnCard.Text = "Name";
            this.nameOnCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameOnCard.Enter += new System.EventHandler(this.nameOnCard_Enter);
            this.nameOnCard.Leave += new System.EventHandler(this.nameOnCard_Leave);
            // 
            // payBtn
            // 
            this.payBtn.FlatAppearance.BorderSize = 0;
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.Location = new System.Drawing.Point(646, 890);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(694, 55);
            this.payBtn.TabIndex = 14;
            this.payBtn.Text = "Pay";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(646, 705);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(749, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(503, 56);
            this.label3.TabIndex = 13;
            this.label3.Text = "INSERT CARD DETAILS";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(646, 803);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(694, 1);
            this.panel8.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(646, 476);
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
            this.panel6.Location = new System.Drawing.Point(646, 596);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(694, 1);
            this.panel6.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(646, 352);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(694, 1);
            this.panel4.TabIndex = 12;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(2184, 1211);
            this.Controls.Add(this.expiryDate);
            this.Controls.Add(this.CSC);
            this.Controls.Add(this.sortCode);
            this.Controls.Add(this.accountNumber);
            this.Controls.Add(this.nameOnCard);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.paymentTopMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentForm";
            this.ShowInTaskbar = false;
            this.Text = "Paying_Method";
            this.paymentTopMenuPanel.ResumeLayout(false);
            this.paymentTopMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentIconChild)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paymentTopMenuPanel;
        private System.Windows.Forms.Label PaymentChildLabel;
        private FontAwesome.Sharp.IconButton MiniBtn;
        private FontAwesome.Sharp.IconButton CloseBtn;
        private FontAwesome.Sharp.IconPictureBox PaymentIconChild;
        private System.Windows.Forms.TextBox expiryDate;
        private System.Windows.Forms.TextBox CSC;
        private System.Windows.Forms.TextBox sortCode;
        private System.Windows.Forms.TextBox accountNumber;
        private System.Windows.Forms.TextBox nameOnCard;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
    }
}