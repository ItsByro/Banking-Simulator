/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 14/6/2026
 * Time: 2:32 pm
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banking_Simulator_App
{
	public partial class DepositForm : Form
	{
		double DepositedMoney;
		
		public DepositForm()
		{
			InitializeComponent();
		}
		
		void BtnDepositClick(object sender, EventArgs e)
		{
			if (!double.TryParse(tbxDepositMoney.Text, out DepositedMoney)) 
			{
				MessageBox.Show("Invalid, input a number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (DepositedMoney <= 0)
			{
				MessageBox.Show("Input must be greater than 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			double OldBalance = Session.Balance;
			double anticipitatedBalance = Session.Balance + DepositedMoney;
			
			try 
			{	
				//if no issue has been found, updates the balance via session class first before the disk
				Session.Balance = anticipitatedBalance;	
				UserDataBase.UpdateBalance(Session.Email, Session.Balance);			
							
				MessageBox.Show("Money Deposited to your Account.", "Balance Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
				tbxDepositMoney.Clear();
				this.Close();
			} 
			catch (Exception ex) 
			{
				//if an issue confirms, revert to the last balance.
				Session.Balance = OldBalance;
				MessageBox.Show(string.Format("Transaction failed. Could not connect to the database. Please try again. {0}", ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error));
			}
		}
	}
}
