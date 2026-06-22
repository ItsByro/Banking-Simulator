/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 19/6/2026
 * Time: 9:14 pm
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banking_Simulator_App
{
	public partial class WithdrawForm : Form
	{
		double WithdrawalMoney;
		
		public WithdrawForm()
		{
			InitializeComponent();
		}
		
		void BtnWithdrawClick(object sender, EventArgs e)
		{
			if (!double.TryParse(tbxWithdrawMoney.Text, out WithdrawalMoney)) 
			{
				MessageBox.Show("Invalid: Input a Number.");
				return;
			}
			if (WithdrawalMoney <= 0) 
			{
				MessageBox.Show("Number Input cannot processed.");
				return;
			}
			if (WithdrawalMoney > Session.Balance)
			{
				MessageBox.Show("Cannot processed due to insufficient funds");
				return;
			}
			
			double OldBalance = Session.Balance;
			double AnticipitatedMoney = Session.Balance - WithdrawalMoney;
			try 
			{
				//if no issue has been found, updates the balance via session class first before the disk
				Session.Balance = AnticipitatedMoney;
				UserDataBase.UpdateBalance(Session.Email, Session.Balance);
				
				MessageBox.Show("Balance has been deducted from your withdrawal.");
				tbxWithdrawMoney.Clear();
				this.Close();
			} 
			catch (Exception ex)
			{
				//if an issue confirms, revert to the last balance.
				Session.Balance = OldBalance;
				MessageBox.Show(string.Format("Transaction failed. Could not connect to the database. Please try again. {0}", ex.Message));
			}
		}
	}
}
