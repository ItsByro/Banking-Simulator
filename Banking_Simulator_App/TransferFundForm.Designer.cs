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
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblTermsConditions = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(114, 278);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(185, 79);
			this.button1.TabIndex = 1;
			this.button1.Text = "Transfer";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(23, 209);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(450, 63);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.UseVisualStyleBackColor = true;
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
			// TransferFundForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 379);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblTermsConditions);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "TransferFundForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transfer Fund Form";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblTermsConditions;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
	}
}
