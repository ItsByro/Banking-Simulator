/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 14/6/2026
 * Time: 2:32 pm
 */
namespace Banking_Simulator_App
{
	partial class DepositForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxDepositMoney = new System.Windows.Forms.TextBox();
			this.btnDeposit = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.PeachPuff;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(132, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 49);
			this.label1.TabIndex = 0;
			this.label1.Text = "DEPOSIT";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(387, 35);
			this.label2.TabIndex = 1;
			this.label2.Text = "Input how much would you deposit?";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbxDepositMoney
			// 
			this.tbxDepositMoney.BackColor = System.Drawing.Color.PeachPuff;
			this.tbxDepositMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbxDepositMoney.Cursor = System.Windows.Forms.Cursors.PanNW;
			this.tbxDepositMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxDepositMoney.Location = new System.Drawing.Point(25, 157);
			this.tbxDepositMoney.Name = "tbxDepositMoney";
			this.tbxDepositMoney.Size = new System.Drawing.Size(423, 39);
			this.tbxDepositMoney.TabIndex = 2;
			// 
			// btnDeposit
			// 
			this.btnDeposit.BackColor = System.Drawing.Color.NavajoWhite;
			this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeposit.Location = new System.Drawing.Point(25, 239);
			this.btnDeposit.Name = "btnDeposit";
			this.btnDeposit.Size = new System.Drawing.Size(263, 62);
			this.btnDeposit.TabIndex = 3;
			this.btnDeposit.Text = "Deposit ";
			this.btnDeposit.UseVisualStyleBackColor = false;
			this.btnDeposit.Click += new System.EventHandler(this.BtnDepositClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(-22, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(845, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = resources.GetString("label3.Text");
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(-191, 316);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(845, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = resources.GetString("label4.Text");
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.NavajoWhite;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(336, 239);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(121, 62);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// DepositForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Bisque;
			this.ClientSize = new System.Drawing.Size(479, 339);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnDeposit);
			this.Controls.Add(this.tbxDepositMoney);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Cursor = System.Windows.Forms.Cursors.PanNW;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "DepositForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Deposit Form";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnDeposit;
		private System.Windows.Forms.TextBox tbxDepositMoney;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
