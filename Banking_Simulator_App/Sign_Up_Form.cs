/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 12/6/2026
 * Time: 2:42 pm
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banking_Simulator_App
{
	public partial class Sign_Up_Form : Form
	{
		public Sign_Up_Form()
		{
			InitializeComponent();
		}
		
		void BtnSignUpClick(object sender, EventArgs e)
		{
			string username = txbUsername.Text;
			string email = txbEmail.Text;
			string phonenumber = txbPhoneNumber.Text; 
			string password = txbPassword.Text;
			string ConfirmPass = txbConfirmPass.Text;
			long number = 0;
			
			if (email == "") 
			{
				MessageBox.Show("No email Given.");
				return;
			}
			else if (username == "")
			{
				MessageBox.Show("No username Given.");
				return;
			}
			else if (phonenumber == "")
			{
				MessageBox.Show("No Phone Number Given.");
				return;
			}
			else if (password == "")
			{
				MessageBox.Show("No Password Given.");
				return;
			}
			else if (email.Contains("@") == false)
			{
				MessageBox.Show("Incorrect Email.");
				return;
			}
			else if (UserDataBase.UserExists(email))
			{
				MessageBox.Show("User Exist, maybe you type wrong?.");
				return;
			}
			else if(password != ConfirmPass)
			{
				MessageBox.Show("Password Incorrect [Different to the one you input].");
				return;
			}
			else if(!long.TryParse(phonenumber, out number))
			{
				MessageBox.Show("Error not a phone number.");
				return;
			}
			
			UserDataBase.SaveUser(username, email, phonenumber, password);
			MessageBox.Show("Account created!");
			this.Close();
		}
		
		void HelpFuncClick(object sender, EventArgs e)
		{
			MessageBox.Show("Username:\nYour username that will be used in the Bank Simulator\n\nEmail:\nEnter your email address\n\nPhone Number:\nEnter your Phone Number\n\nPassword:\nEnter your password\n(Recommended at 8 characters)\n\nConfirm your Password:\nJust repeat the password you write:}");
		}
		
		void TxbPhoneNumberKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
		    {
		        e.Handled = true; //prevents user to type a string/symbols >.<
		    }
		}
	}
}
