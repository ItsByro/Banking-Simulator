/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 11/6/2026
 * Time: 5:33 pm
 */
using System;
using System.Windows.Forms;

namespace Banking_Simulator_App
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LogIn_SignUp_Form());
		}
		
	}
}
