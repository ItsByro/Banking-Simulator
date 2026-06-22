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
	}
}
