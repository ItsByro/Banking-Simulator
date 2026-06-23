/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 12/6/2026
 * Time: 3:06 pm
 */
using System;
using System.IO;
using System.Collections.Generic;

namespace Banking_Simulator_App
{
	public class UserDataBase
	{
		/*Saves user in a  ".txt" file
		 * always used in "Sign In Form"
		 */
		public static void SaveUser(string Username, string Email, string Phone_Number, string Password)
		{
			//Formatting [Username|Email|PhoneNumber|Password|Balance]						   always start at 0 when creating new account
			string line = Username + "|" + Email + "|" + Phone_Number + "|" + Password + "|" + "0.00";
			
			File.AppendAllText("UserDatabase.txt", line + Environment.NewLine);
		}
		
		//checks for user if exist 
		public static bool UserExists(string Email)
		{
			if (File.Exists("UserDatabase.txt") == false) 
			{
				return false;	
			}
			
			string[] lines = File.ReadAllLines("UserDatabase.txt");
			
			foreach (string line in lines) 
			{
				string[] parts = line.Split('|');
				if (parts[1] == Email)
				{
					return true;
				}
			}
			return false;
		}
		
		/*checks if user is in, more like an authentication check
 		 *so checks the email and password if it exists in the "UserDatabase.txt",
		 *if so, updates the session class with the user's data
		 */
		public static bool LogInUser(string email, string password)
		{
			if (File.Exists("UserDatabase.txt") == false)
			{
				return false;
			}
			
			string[] lines = File.ReadAllLines("UserDatabase.txt");
			
			//checks each line in "UserDatabase.txt"
			foreach (string line in lines) 
			{
				string[] parts = line.Split('|');
				if (parts[1] == email && parts[3] == password) 
				{
					Session.Username = parts[0];
					Session.Email = parts[1];
					Session.Balance = double.Parse(parts[4]);
					return true;
				}
			}
			return false;
		}
		
		//update balances based on changes from the session class
		public static void UpdateBalance(string email, double newBalance)
		{
			if (File.Exists("UserDatabase.txt") == false)
			{
				return;
			}
			
			string[] lines = File.ReadAllLines("UserDatabase.txt");
			
			for (int i = 0; i < lines.Length; i++) 
			{
				string[] parts = lines[i].Split('|');
				if (parts[1] == email) 
				{
					lines[i] = parts[0] + '|' + email + '|' + parts[2] + '|' + parts[3] + '|' + newBalance.ToString("F2");
				}
			}
			File.WriteAllLines("UserDatabase.txt", lines);
		}
		
		public static double GetBalance(string email)
		{
			if (!File.Exists("UserDatabase.txt"))
			{
				return -1;
			}
			
			string[] lines = File.ReadAllLines("UserDatabase.txt");
			
			foreach (string line in lines) 
			{
				string[] parts = line.Split('|');
				if (parts[1] == email) 
				{
					return double.Parse(parts[4]);
				}
			}
			return -1;
		}
	}
}
