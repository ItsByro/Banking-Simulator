/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 13/6/2026
 * Time: 8:23 pm
 */
namespace Banking_Simulator_App
{
	partial class DashBoard_Menu
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
			this.lblGreet = new System.Windows.Forms.Label();
			this.btnWithdraw = new System.Windows.Forms.Button();
			this.btnDeposit = new System.Windows.Forms.Button();
			this.btnTransaction = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblBalance = new System.Windows.Forms.Label();
			this.btnTransferFunds = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblGreet
			// 
			this.lblGreet.AutoSize = true;
			this.lblGreet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblGreet.Cursor = System.Windows.Forms.Cursors.PanNW;
			this.lblGreet.Font = new System.Drawing.Font("MS Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGreet.Location = new System.Drawing.Point(59, 32);
			this.lblGreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblGreet.Name = "lblGreet";
			this.lblGreet.Size = new System.Drawing.Size(2, 46);
			this.lblGreet.TabIndex = 0;
			this.lblGreet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnWithdraw
			// 
			this.btnWithdraw.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnWithdraw.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnWithdraw.Location = new System.Drawing.Point(59, 158);
			this.btnWithdraw.Name = "btnWithdraw";
			this.btnWithdraw.Size = new System.Drawing.Size(151, 102);
			this.btnWithdraw.TabIndex = 1;
			this.btnWithdraw.Text = "Withdraw";
			this.btnWithdraw.UseVisualStyleBackColor = false;
			this.btnWithdraw.Click += new System.EventHandler(this.BtnWithdrawClick);
			// 
			// btnDeposit
			// 
			this.btnDeposit.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnDeposit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeposit.Location = new System.Drawing.Point(257, 158);
			this.btnDeposit.Name = "btnDeposit";
			this.btnDeposit.Size = new System.Drawing.Size(151, 102);
			this.btnDeposit.TabIndex = 2;
			this.btnDeposit.Text = "Deposit";
			this.btnDeposit.UseVisualStyleBackColor = false;
			this.btnDeposit.Click += new System.EventHandler(this.BtnDepositClick);
			// 
			// btnTransaction
			// 
			this.btnTransaction.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnTransaction.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTransaction.Location = new System.Drawing.Point(257, 298);
			this.btnTransaction.Name = "btnTransaction";
			this.btnTransaction.Size = new System.Drawing.Size(151, 102);
			this.btnTransaction.TabIndex = 4;
			this.btnTransaction.Text = "History";
			this.btnTransaction.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(-39, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1075, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "=================================================================================" +
			"==============================================================================";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(-293, 429);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1075, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "=================================================================================" +
			"==============================================================================";
			// 
			// lblBalance
			// 
			this.lblBalance.AutoSize = true;
			this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblBalance.Cursor = System.Windows.Forms.Cursors.PanNW;
			this.lblBalance.Font = new System.Drawing.Font("MS Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBalance.Location = new System.Drawing.Point(59, 88);
			this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBalance.Name = "lblBalance";
			this.lblBalance.Size = new System.Drawing.Size(2, 46);
			this.lblBalance.TabIndex = 7;
			this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnTransferFunds
			// 
			this.btnTransferFunds.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnTransferFunds.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTransferFunds.Location = new System.Drawing.Point(59, 298);
			this.btnTransferFunds.Name = "btnTransferFunds";
			this.btnTransferFunds.Size = new System.Drawing.Size(151, 102);
			this.btnTransferFunds.TabIndex = 8;
			this.btnTransferFunds.Text = "Transfer Funds";
			this.btnTransferFunds.UseVisualStyleBackColor = false;
			this.btnTransferFunds.Click += new System.EventHandler(this.BtnTransferFundsClick);
			// 
			// DashBoard_Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(466, 461);
			this.Controls.Add(this.btnTransferFunds);
			this.Controls.Add(this.lblBalance);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnTransaction);
			this.Controls.Add(this.btnDeposit);
			this.Controls.Add(this.btnWithdraw);
			this.Controls.Add(this.lblGreet);
			this.Cursor = System.Windows.Forms.Cursors.PanNW;
			this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "DashBoard_Menu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ShinyBills Dashboard";
			this.Load += new System.EventHandler(this.DashBoard_MenuLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnTransferFunds;
		private System.Windows.Forms.Label lblBalance;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnTransaction;
		private System.Windows.Forms.Button btnDeposit;
		private System.Windows.Forms.Button btnWithdraw;
		private System.Windows.Forms.Label lblGreet;
	}
}
