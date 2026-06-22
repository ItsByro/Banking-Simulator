/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 13/6/2026
 * Time: 8:23 pm
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banking_Simulator_App
{
	public partial class DashBoard_Menu : Form
	{
		public DashBoard_Menu()
		{
			InitializeComponent();
		}
		
		void RefreshBoardData()
		{
			lblGreet.Text = "Hello " + string.Format("[{0}]", Session.Username);
			lblBalance.Text = "Balance : "+ string.Format("₱{0}",Session.Balance.ToString("F2"));
		}
		
		void BtnDepositClick(object sender, EventArgs e)
		{
			this.Hide();
			DepositForm Deposit_form = new DepositForm();
			Deposit_form.ShowDialog();
			this.Show();
			RefreshBoardData();
		}
		
		void BtnWithdrawClick(object sender, EventArgs e)
		{
			this.Hide();
			WithdrawForm Withdraw_Form = new WithdrawForm();
			Withdraw_Form.ShowDialog();
			this.Show();
			RefreshBoardData();
		}
		
		void DashBoard_MenuLoad(object sender, EventArgs e)
		{
			RefreshBoardData();
		}
		
		void BtnTransferFundsClick(object sender, EventArgs e)
		{
			this.Hide();
			TransferFundForm TransferFund_Form = new TransferFundForm();
			TransferFund_Form.ShowDialog();
			this.Show();
			RefreshBoardData();
		}
	}
}
