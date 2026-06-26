/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 11/6/2026
 * Time: 5:33 pm
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Banking_Simulator_App
{
	public partial class LogIn_SignUp_Form : Form
	{
		public LogIn_SignUp_Form()
		{
			InitializeComponent();
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			MessageBox.Show("E4sT3r_=3qq :p");
		}
		
		//Whenever the btn click, puts user to another window form and let user sign up for a new account
		void BtnSignUpClick(object sender, EventArgs e)
		{
			Sign_Up_Form SignUp = new Sign_Up_Form();
			SignUp.FormClosed += (s, args) => this.Show();
			SignUp.Show();
			this.Hide();
		}
		
		//checks user if their email/password was in the "UserDatabase.txt"
		void BtnLogInClick(object sender, EventArgs e)
		{
			string email = txtEmailAddress.Text;
			string password = txtPassword.Text;
			
			//checks if user has no email written
			if (string.IsNullOrWhiteSpace(email))
			{
				MessageBox.Show("Enter your email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//checks if user password was not written
			if (string.IsNullOrWhiteSpace(password))
			{
				MessageBox.Show("Enter your password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//chekcs if email doesn't even have an '@'.
			else if (!email.Contains("@"))
			{
				MessageBox.Show("Incorrect Format of Email [Missing '@'].", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//checks if user email doesnt exist in the "UserDatabase.txt"
			else if (!UserDataBase.UserExists(email))
			{
				MessageBox.Show("Cannot Verify Sign Up First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//checks if the written email/password has a typo/incorrect.
			else if (!UserDataBase.LogInUser(email, password))
			{
				MessageBox.Show("Incorrect Password / Email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			//if all was pass, auto direct to another windows form named: "DashBoard_Menu.cs"
			MessageBox.Show("Welcome back!", "Welcome Back!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			DashBoard_Menu Dashboard = new DashBoard_Menu();
			Dashboard.FormClosed += (s, args) => this.Show();
			Dashboard.Show();
			this.Hide();
			txtPassword.Clear();
			txtEmailAddress.Clear();
		}
		
		void BtnExitPageClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
