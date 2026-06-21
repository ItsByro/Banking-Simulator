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
				MessageBox.Show("Invalid, input a number.");
				return;
			}
			else if (DepositedMoney <= 0)
			{
				MessageBox.Show("Input must be greater than 0.");
				return;
			}
			
			double anticipitatedBalance = Session.Balance + DepositedMoney;
			
			try 
			{	
				Session.Balance = anticipitatedBalance;	
				UserDataBase.UpdateBalance(Session.Email, Session.Balance);			
							
				MessageBox.Show("Money Deposited to your Account.");
				tbxDepositMoney.Clear();
				this.Close();
			} 
			catch (Exception ex) 
			{
				MessageBox.Show(string.Format("Transaction failed. Could not connect to the database. Please try again. {0}", ex.Message));
			}
		}
	}
}
