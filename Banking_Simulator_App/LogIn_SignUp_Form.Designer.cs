/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 11/6/2026
 * Time: 5:33 pm
 */
namespace Banking_Simulator_App
{
	partial class LogIn_SignUp_Form
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEmailAddress = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnSignUp = new System.Windows.Forms.Button();
			this.btnLogIn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.Color.White;
			this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTitle.Font = new System.Drawing.Font("MS Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.Black;
			this.lblTitle.Location = new System.Drawing.Point(90, 35);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(450, 44);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Welcome to ShinyBills";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(199, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Email Address";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(25, 221);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(151, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password";
			// 
			// txtEmailAddress
			// 
			this.txtEmailAddress.BackColor = System.Drawing.Color.Bisque;
			this.txtEmailAddress.Location = new System.Drawing.Point(25, 159);
			this.txtEmailAddress.Name = "txtEmailAddress";
			this.txtEmailAddress.Size = new System.Drawing.Size(560, 26);
			this.txtEmailAddress.TabIndex = 3;
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.Color.Bisque;
			this.txtPassword.Location = new System.Drawing.Point(25, 256);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(560, 26);
			this.txtPassword.TabIndex = 4;
			// 
			// btnSignUp
			// 
			this.btnSignUp.BackColor = System.Drawing.Color.LemonChiffon;
			this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSignUp.ForeColor = System.Drawing.Color.Black;
			this.btnSignUp.Location = new System.Drawing.Point(90, 329);
			this.btnSignUp.Name = "btnSignUp";
			this.btnSignUp.Size = new System.Drawing.Size(184, 96);
			this.btnSignUp.TabIndex = 5;
			this.btnSignUp.Text = "Sign Up";
			this.btnSignUp.UseVisualStyleBackColor = false;
			this.btnSignUp.Click += new System.EventHandler(this.BtnSignUpClick);
			// 
			// btnLogIn
			// 
			this.btnLogIn.BackColor = System.Drawing.Color.LemonChiffon;
			this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogIn.ForeColor = System.Drawing.Color.Black;
			this.btnLogIn.Location = new System.Drawing.Point(356, 329);
			this.btnLogIn.Name = "btnLogIn";
			this.btnLogIn.Size = new System.Drawing.Size(184, 96);
			this.btnLogIn.TabIndex = 6;
			this.btnLogIn.Text = "Log In";
			this.btnLogIn.UseVisualStyleBackColor = false;
			this.btnLogIn.Click += new System.EventHandler(this.BtnLogInClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(-6, 438);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "ItsByro";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// LogIn_SignUp_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaShell;
			this.ClientSize = new System.Drawing.Size(623, 458);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnLogIn);
			this.Controls.Add(this.btnSignUp);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtEmailAddress);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblTitle);
			this.Cursor = System.Windows.Forms.Cursors.PanNW;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "LogIn_SignUp_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bank ShinyBills Log-In Menu";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnLogIn;
		private System.Windows.Forms.Button btnSignUp;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtEmailAddress;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTitle;
	}
}
