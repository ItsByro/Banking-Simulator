/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 19/6/2026
 * Time: 9:14 pm
 */
namespace Banking_Simulator_App
{
	partial class WithdrawForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrawForm));
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbxWithdrawMoney = new System.Windows.Forms.TextBox();
			this.btnWithdraw = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(-180, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(845, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = resources.GetString("label3.Text");
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(-180, 295);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(845, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.PeachPuff;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(101, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(262, 49);
			this.label2.TabIndex = 7;
			this.label2.Text = "WITHDRAW";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(25, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(387, 35);
			this.label4.TabIndex = 8;
			this.label4.Text = "Input how much would you withdraw?";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbxWithdrawMoney
			// 
			this.tbxWithdrawMoney.BackColor = System.Drawing.Color.PeachPuff;
			this.tbxWithdrawMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbxWithdrawMoney.Cursor = System.Windows.Forms.Cursors.PanNW;
			this.tbxWithdrawMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxWithdrawMoney.Location = new System.Drawing.Point(25, 141);
			this.tbxWithdrawMoney.Name = "tbxWithdrawMoney";
			this.tbxWithdrawMoney.Size = new System.Drawing.Size(423, 39);
			this.tbxWithdrawMoney.TabIndex = 9;
			// 
			// btnWithdraw
			// 
			this.btnWithdraw.BackColor = System.Drawing.Color.NavajoWhite;
			this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnWithdraw.Location = new System.Drawing.Point(101, 213);
			this.btnWithdraw.Name = "btnWithdraw";
			this.btnWithdraw.Size = new System.Drawing.Size(263, 62);
			this.btnWithdraw.TabIndex = 10;
			this.btnWithdraw.Text = "Withdraw";
			this.btnWithdraw.UseVisualStyleBackColor = false;
			this.btnWithdraw.Click += new System.EventHandler(this.BtnWithdrawClick);
			// 
			// WithdrawForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Bisque;
			this.ClientSize = new System.Drawing.Size(467, 327);
			this.Controls.Add(this.btnWithdraw);
			this.Controls.Add(this.tbxWithdrawMoney);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Cursor = System.Windows.Forms.Cursors.PanNW;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "WithdrawForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WithdrawForm";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnWithdraw;
		private System.Windows.Forms.TextBox tbxWithdrawMoney;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
	}
}
