/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 12/6/2026
 * Time: 2:42 pm
 */
namespace Banking_Simulator_App
{
	partial class Sign_Up_Form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_Up_Form));
			this.lblGreet = new System.Windows.Forms.Label();
			this.txbUsername = new System.Windows.Forms.TextBox();
			this.txbPhoneNumber = new System.Windows.Forms.TextBox();
			this.txbEmail = new System.Windows.Forms.TextBox();
			this.txbPassword = new System.Windows.Forms.TextBox();
			this.txbConfirmPass = new System.Windows.Forms.TextBox();
			this.btnSignUp = new System.Windows.Forms.Button();
			this.HelpFunc = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblemail = new System.Windows.Forms.Label();
			this.lblpn = new System.Windows.Forms.Label();
			this.lblpassword = new System.Windows.Forms.Label();
			this.lblConfirmPassword = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblGreet
			// 
			this.lblGreet.BackColor = System.Drawing.Color.AntiqueWhite;
			this.lblGreet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblGreet.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGreet.Location = new System.Drawing.Point(80, 30);
			this.lblGreet.Name = "lblGreet";
			this.lblGreet.Size = new System.Drawing.Size(313, 47);
			this.lblGreet.TabIndex = 0;
			this.lblGreet.Text = "Welcome, New User!";
			this.lblGreet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txbUsername
			// 
			this.txbUsername.BackColor = System.Drawing.Color.Linen;
			this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbUsername.Location = new System.Drawing.Point(35, 121);
			this.txbUsername.Name = "txbUsername";
			this.txbUsername.Size = new System.Drawing.Size(394, 32);
			this.txbUsername.TabIndex = 1;
			// 
			// txbPhoneNumber
			// 
			this.txbPhoneNumber.BackColor = System.Drawing.Color.Linen;
			this.txbPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbPhoneNumber.Location = new System.Drawing.Point(35, 282);
			this.txbPhoneNumber.Name = "txbPhoneNumber";
			this.txbPhoneNumber.Size = new System.Drawing.Size(394, 32);
			this.txbPhoneNumber.TabIndex = 2;
			this.txbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbPhoneNumberKeyPress);
			// 
			// txbEmail
			// 
			this.txbEmail.BackColor = System.Drawing.Color.Linen;
			this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbEmail.Location = new System.Drawing.Point(35, 199);
			this.txbEmail.Name = "txbEmail";
			this.txbEmail.Size = new System.Drawing.Size(394, 32);
			this.txbEmail.TabIndex = 3;
			// 
			// txbPassword
			// 
			this.txbPassword.BackColor = System.Drawing.Color.Linen;
			this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbPassword.Location = new System.Drawing.Point(35, 366);
			this.txbPassword.Name = "txbPassword";
			this.txbPassword.Size = new System.Drawing.Size(394, 32);
			this.txbPassword.TabIndex = 4;
			// 
			// txbConfirmPass
			// 
			this.txbConfirmPass.BackColor = System.Drawing.Color.Linen;
			this.txbConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbConfirmPass.Location = new System.Drawing.Point(35, 449);
			this.txbConfirmPass.Name = "txbConfirmPass";
			this.txbConfirmPass.Size = new System.Drawing.Size(394, 32);
			this.txbConfirmPass.TabIndex = 5;
			// 
			// btnSignUp
			// 
			this.btnSignUp.BackColor = System.Drawing.Color.Wheat;
			this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSignUp.Location = new System.Drawing.Point(243, 510);
			this.btnSignUp.Name = "btnSignUp";
			this.btnSignUp.Size = new System.Drawing.Size(173, 78);
			this.btnSignUp.TabIndex = 6;
			this.btnSignUp.Text = "Sign Up";
			this.btnSignUp.UseVisualStyleBackColor = false;
			this.btnSignUp.Click += new System.EventHandler(this.BtnSignUpClick);
			// 
			// HelpFunc
			// 
			this.HelpFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HelpFunc.Location = new System.Drawing.Point(54, 510);
			this.HelpFunc.Name = "HelpFunc";
			this.HelpFunc.Size = new System.Drawing.Size(138, 78);
			this.HelpFunc.TabIndex = 7;
			this.HelpFunc.Text = "Stuck? \r\nLet me help you";
			this.HelpFunc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.HelpFunc.Click += new System.EventHandler(this.HelpFuncClick);
			// 
			// lblUsername
			// 
			this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.Location = new System.Drawing.Point(35, 95);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(394, 23);
			this.lblUsername.TabIndex = 8;
			this.lblUsername.Text = "Username";
			// 
			// lblemail
			// 
			this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblemail.Location = new System.Drawing.Point(35, 173);
			this.lblemail.Name = "lblemail";
			this.lblemail.Size = new System.Drawing.Size(394, 23);
			this.lblemail.TabIndex = 9;
			this.lblemail.Text = "Email Address";
			// 
			// lblpn
			// 
			this.lblpn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblpn.Location = new System.Drawing.Point(35, 256);
			this.lblpn.Name = "lblpn";
			this.lblpn.Size = new System.Drawing.Size(394, 23);
			this.lblpn.TabIndex = 10;
			this.lblpn.Text = "Phone Number";
			// 
			// lblpassword
			// 
			this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblpassword.Location = new System.Drawing.Point(35, 340);
			this.lblpassword.Name = "lblpassword";
			this.lblpassword.Size = new System.Drawing.Size(394, 23);
			this.lblpassword.TabIndex = 11;
			this.lblpassword.Text = "Password";
			// 
			// lblConfirmPassword
			// 
			this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConfirmPassword.Location = new System.Drawing.Point(35, 421);
			this.lblConfirmPassword.Name = "lblConfirmPassword";
			this.lblConfirmPassword.Size = new System.Drawing.Size(394, 25);
			this.lblConfirmPassword.TabIndex = 12;
			this.lblConfirmPassword.Text = "Confirm Your Password";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(-23, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(865, 23);
			this.label1.TabIndex = 13;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(-282, 591);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(865, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = resources.GetString("label3.Text");
			// 
			// Sign_Up_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PapayaWhip;
			this.ClientSize = new System.Drawing.Size(466, 606);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblConfirmPassword);
			this.Controls.Add(this.lblpassword);
			this.Controls.Add(this.lblpn);
			this.Controls.Add(this.lblemail);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.HelpFunc);
			this.Controls.Add(this.btnSignUp);
			this.Controls.Add(this.txbConfirmPass);
			this.Controls.Add(this.txbPassword);
			this.Controls.Add(this.txbEmail);
			this.Controls.Add(this.txbPhoneNumber);
			this.Controls.Add(this.txbUsername);
			this.Controls.Add(this.lblGreet);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.PanNW;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Sign_Up_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ShinyBills Sign Up Form";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblConfirmPassword;
		private System.Windows.Forms.Label lblpassword;
		private System.Windows.Forms.Label lblpn;
		private System.Windows.Forms.Label lblemail;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label HelpFunc;
		private System.Windows.Forms.Button btnSignUp;
		private System.Windows.Forms.TextBox txbConfirmPass;
		private System.Windows.Forms.TextBox txbPassword;
		private System.Windows.Forms.TextBox txbEmail;
		private System.Windows.Forms.TextBox txbPhoneNumber;
		private System.Windows.Forms.TextBox txbUsername;
		private System.Windows.Forms.Label lblGreet;
	}
}
