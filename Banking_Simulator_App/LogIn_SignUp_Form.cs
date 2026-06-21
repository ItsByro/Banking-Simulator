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
		
		void BtnSignUpClick(object sender, EventArgs e)
		{
			Sign_Up_Form SignUp = new Sign_Up_Form();
			SignUp.FormClosed += (s, args) => this.Show();
			SignUp.Show();
			this.Hide();
		}
		
		void BtnLogInClick(object sender, EventArgs e)
		{
			string email = txtEmailAddress.Text;
			string password = txtPassword.Text;
			
			if (email == "") 
			{
				MessageBox.Show("Enter your email.");
				return;
			}
			else if (password == "")
			{
				MessageBox.Show("Enter your password.");
				return;
			}
			else if (!email.Contains("@"))
			{
				MessageBox.Show("Incorrect Format of Email [Missing '@'].");
				return;
			}
			else if (!UserDataBase.UserExists(email))
			{
				MessageBox.Show("Cannot Verify Sign Up First");
				return;
			}
			else if (!UserDataBase.LogInUser(email, password))
			{
				MessageBox.Show("Incorrect Password / Email");
				return;
			}
			
			MessageBox.Show("Welcome back!");
			DashBoard_Menu Dashboard = new DashBoard_Menu();
			Dashboard.FormClosed += (s, args) => this.Show();
			Dashboard.Show();
			this.Hide();
			txtPassword.Clear();
			txtEmailAddress.Clear();
		}
	}
}
