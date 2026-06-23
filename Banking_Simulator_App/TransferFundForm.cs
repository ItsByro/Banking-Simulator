/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 22/6/2026
 * Time: 5:05 pm
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banking_Simulator_App
{
	/// <summary>
	/// Description of TransferFundForm.
	/// </summary>
	public partial class TransferFundForm : Form
	{
		public TransferFundForm()
		{
			InitializeComponent();
			
		}

		
		
		void LblTermsConditionsClick(object sender, EventArgs e)
		{
			MessageBox.Show(
				//this is the text, long text for entire message 
				"TERMS AND CONDITIONS - FUND TRANSFER FROM SHINY BILLS\n" +
				"1. Sufficient Balance - \n"+
				"	Must have sufficient balance for transfer, if\n"+
				"	insufficent, the machine shall declined its offer.\n" +
				"2. Irreversibility - \n" +
				"	Once it transfer, it cannot be cancelled or refund\n"+
				"\n"+
				"DISCLAIMER:\n"+
				"ShinyBills is a Banking Simulation App - \n"+
				"NO REAL MONEY IS BEING INVOLVED", 
				//title page
				"Terms and Conditions",
				//optional button and icons
				MessageBoxButtons.OK,
				MessageBoxIcon.Information 
			);
						
		}
		
		void BtnTransferFundsClick(object sender, EventArgs e)
		{
			string RecipientEmail = tbxRecipientEmail.Text;
			double TransferAmount;
			
			//checks if there is empty spaces of textbox
			if (string.IsNullOrWhiteSpace(RecipientEmail) || string.IsNullOrWhiteSpace(tbx_AmountInputted.Text)) 
			{
				MessageBox.Show("Input First the Recipient Email / Amount to transfer");
				return;
			}
			//checks if the terms and condition is checked
			if (!checkboxTermsCondition.Checked) 
			{
				MessageBox.Show("You must read the Terms and Conditions.", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//checks if the inputted is number not a string
			if(!double.TryParse(tbx_AmountInputted.Text, out TransferAmount))
			{
				MessageBox.Show("Invalid: Input a Number.", "WARNING",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//checks if the inputed number is 0 or even -
			if(TransferAmount <= 0)
			{
				MessageBox.Show("Invalid: Must be greater than 0","WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//checks if the recipients is the same, if yes, provide a message
			if(RecipientEmail == Session.Email)
			{
				MessageBox.Show("Invalid: Cannot Transfer To yourself","WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//checks if the recipient is already have an account, if not, provide a message
			if(!UserDataBase.UserExists(RecipientEmail))
			{
				MessageBox.Show("Recipient Cannot Found.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//checks if the transferrer have sufficient balance
			if(TransferAmount > Session.Balance)
			{
				MessageBox.Show("Insufficient Funds","WARNING" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}			
			

			
			//if nothing and all correct it will proceeds
		}
	}
}
