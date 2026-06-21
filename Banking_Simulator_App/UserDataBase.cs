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
		public static void SaveUser(string Username, string Email, string Phone_Number, string Password)
		{
			//Formatting [Username|EMAIL|PN|Pass|Balancw]										always start at 0 when creating new account
			string line = Username + "|" + Email + "|" + Phone_Number + "|" + Password + "|" + "0.00";
			
			File.AppendAllText("UserDatabase.txt", line + Environment.NewLine);
		}
		
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
		
		public static bool LogInUser(string email, string password)
		{
			if (File.Exists("UserDatabase.txt") == false)
			{
				return false;
			}
			
			string[] lines = File.ReadAllLines("UserDatabase.txt");
			
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
	}
}
