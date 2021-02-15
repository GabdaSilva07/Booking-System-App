
namespace Coach_Form_UI
{
    partial class HomeForm
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
            this.Account = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Account)).BeginInit();
            this.SuspendLayout();
            // 
            // Account
            // 
            this.Account.BackColor = System.Drawing.SystemColors.Control;
            this.Account.IconChar = FontAwesome.Sharp.IconChar.User;
            this.Account.IconColor = System.Drawing.Color.White;
            this.Account.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Account.IconSize = 281;
            this.Account.Location = new System.Drawing.Point(229, 390);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(325, 281);
            this.Account.TabIndex = 0;
            this.Account.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(2109, 1146);
            this.Controls.Add(this.Account);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.Account)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox Account;
    }
}