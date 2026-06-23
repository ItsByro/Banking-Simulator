/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 22/6/2026
 * Time: 5:05 pm
 */
namespace Banking_Simulator_App
{
	partial class TransferFundForm
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
			this.btnTransferFunds = new System.Windows.Forms.Button();
			this.checkboxTermsCondition = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblTermsConditions = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbxRecipientEmail = new System.Windows.Forms.TextBox();
			this.tbx_AmountInputted = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnTransferFunds
			// 
			this.btnTransferFunds.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTransferFunds.Location = new System.Drawing.Point(150, 288);
			this.btnTransferFunds.Name = "btnTransferFunds";
			this.btnTransferFunds.Size = new System.Drawing.Size(185, 79);
			this.btnTransferFunds.TabIndex = 1;
			this.btnTransferFunds.Text = "Transfer";
			this.btnTransferFunds.UseVisualStyleBackColor = true;
			this.btnTransferFunds.Click += new System.EventHandler(this.BtnTransferFundsClick);
			// 
			// checkboxTermsCondition
			// 
			this.checkboxTermsCondition.Location = new System.Drawing.Point(23, 209);
			this.checkboxTermsCondition.Name = "checkboxTermsCondition";
			this.checkboxTermsCondition.Size = new System.Drawing.Size(450, 63);
			this.checkboxTermsCondition.TabIndex = 2;
			this.checkboxTermsCondition.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(58, 216);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(329, 28);
			this.label1.TabIndex = 3;
			this.label1.Text = "By agreeing to ";
			// 
			// lblTermsConditions
			// 
			this.lblTermsConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
												| System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTermsConditions.Location = new System.Drawing.Point(203, 216);
			this.lblTermsConditions.Name = "lblTermsConditions";
			this.lblTermsConditions.Size = new System.Drawing.Size(270, 28);
			this.lblTermsConditions.TabIndex = 4;
			this.lblTermsConditions.Text = "Terms and Conditions";
			this.lblTermsConditions.Click += new System.EventHandler(this.LblTermsConditionsClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(58, 244);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(415, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Transfers cannot be reversed once sent.";
			// 
			// tbxRecipientEmail
			// 
			this.tbxRecipientEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxRecipientEmail.Location = new System.Drawing.Point(36, 44);
			this.tbxRecipientEmail.Name = "tbxRecipientEmail";
			this.tbxRecipientEmail.Size = new System.Drawing.Size(405, 44);
			this.tbxRecipientEmail.TabIndex = 6;
			// 
			// tbx_AmountInputted
			// 
			this.tbx_AmountInputted.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbx_AmountInputted.Location = new System.Drawing.Point(36, 142);
			this.tbx_AmountInputted.Name = "tbx_AmountInputted";
			this.tbx_AmountInputted.Size = new System.Drawing.Size(405, 44);
			this.tbx_AmountInputted.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(36, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(374, 28);
			this.label2.TabIndex = 8;
			this.label2.Text = "Enter the email you want to transfer:\r\n";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(36, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(374, 28);
			this.label4.TabIndex = 9;
			this.label4.Text = "Amount you want to input:";
			// 
			// TransferFundForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 379);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbx_AmountInputted);
			this.Controls.Add(this.tbxRecipientEmail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblTermsConditions);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkboxTermsCondition);
			this.Controls.Add(this.btnTransferFunds);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "TransferFundForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transfer Fund Form";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbx_AmountInputted;
		private System.Windows.Forms.TextBox tbxRecipientEmail;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblTermsConditions;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkboxTermsCondition;
		private System.Windows.Forms.Button btnTransferFunds;
	}
}
