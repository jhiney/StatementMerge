﻿using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace StatementMerge
{
    class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			Program program = new Program();
			DataTable InitialTable;
			DataTable MatchTable;
			List<string> accounts = new List<string>();
			List<string> paths = new List<string>();
			int j = 0;

			optionForm oform = new optionForm();
			oform.ShowDialog();

			string asofstring = oform.asofString;

			string subjectString = oform.subjectString;

			string qtrFolder = oform.statementFolder;

			string csvFile = oform.listFile;

			InitialTable = program.csvToDataTable(csvFile);
			MatchTable = program.MatcherTable(InitialTable);

			//This loop deletes any entires with a duplicate email from table
			foreach (DataRow r1 in InitialTable.Rows.Cast<DataRow>().ToArray()) // save rows to array
			{
				foreach (DataRow r2 in MatchTable.Rows)
				{
					if (r1.Field<string>("name") == r2.Field<string>("name"))
					{
						r1.Delete();
						break; // break inner loop
					}
				}
			}

			//This loop creates a mail item for each unique email address
			foreach (DataRow dataRow in InitialTable.Rows)
			{
				string recip = dataRow["name"].ToString();
				string email = dataRow["E-mail Address"].ToString();
				string entity = dataRow["Account Name"].ToString();
				string designation= dataRow["Desig"].ToString();

				if (designation.Length < 5)
				{
					//makes up for Excel CSV dropping leading zeros
					designation = "0" + designation;
				}
				
				program.CreateMailItem(email, recip, entity, program.GetPath(designation,qtrFolder),asofstring, subjectString);

			}
			
			//Selects destinct names and emails from the CSV using LINQ
			var distinctIds = MatchTable.AsEnumerable().Select(row => row.Field<string>("Name")).Distinct().ToList();
			var distinctEmail = MatchTable.AsEnumerable().Select(row => row.Field<string>("E-mail Address")).Distinct().ToList();
			
			foreach (var item in distinctIds)
			{
				string sendName = item;

				accounts.Clear();
				paths.Clear();
				for (int i = 0; i < MatchTable.Rows.Count; i++)
				{
					
					string recip = MatchTable.Rows[i]["name"].ToString();
					string email = MatchTable.Rows[i]["E-mail Address"].ToString();
					string entity = MatchTable.Rows[i]["Account Name"].ToString();
					string designation = (MatchTable.Rows[i]["Desig"].ToString());

					if (designation.Length < 5)
					{
						//makes up for Excel CSV dropping leading zeros
						designation = "0" + designation;
					}

					if (item.Equals(recip))
					{
						accounts.Add(entity);
						paths.Add(designation);
					}

					if (i == MatchTable.Rows.Count-1)
					{
						string sendEmail = distinctEmail[j];
						program.CreateMultipleMailItem(sendEmail, sendName, accounts, program.GetPaths(paths, qtrFolder), asofstring, subjectString);
						j = j+1;
					}	
				}
			}
			//Signifies the process was successful
			Console.WriteLine("Process Completed. Press any key to exit.");
			Console.ReadKey();
		}

		private void CreateMultipleMailItem(string subject, string recipient, List<string> accounts, List<string> filepath, string asof, string title)
		{
			Outlook.Application app = new Outlook.Application();
			Outlook.MailItem mailItem = app.CreateItem(Outlook.OlItemType.olMailItem);
			
			mailItem.Subject = title + " Quarterly Statements";
			mailItem.To = subject;
			
			string body = recipient + ", <br/> Attached is the quarterly statement for period ended " +asof+ " for the following accounts: <br/>";

			foreach (var item in accounts)
			{
				string account = item + "<br/>";
				body = body + account;
			}

			mailItem.HTMLBody = body + 
								"<br/>" +
								ReadSignature();

			foreach (var item in filepath)
			{
				if (item.Length > 0)
				{
					mailItem.Attachments.Add(item, Outlook.OlAttachmentType.olByValue, 1, Path.GetFileName(item));
				}
			}

			mailItem.Importance = Outlook.OlImportance.olImportanceLow;
			mailItem.Save();
			mailItem.UnRead = true;

			Console.WriteLine("Mail Item created for: " + recipient + ", Email: " + subject);
		}

		private void CreateMailItem(string subject, string recipient, string account, string filepath, string asof, string title)
		{
			Outlook.Application app = new Outlook.Application();

			Outlook.MailItem mailItem = app.CreateItem(Outlook.OlItemType.olMailItem);

			mailItem.Subject = account + " "+ title+" Quarterly Statements";
			mailItem.To = subject;
			string body = recipient + ", <br/> Attached is the quarterly statement for period ended "+asof+" for the " + account + " account. Please let me know if you have any questions or concerns. <br/>";

			mailItem.HTMLBody = body + ReadSignature();

			if (filepath.Length > 0)
			{
				mailItem.Attachments.Add(filepath, Outlook.OlAttachmentType.olByValue, 1, Path.GetFileName(filepath.ToString()));
			}

			mailItem.Importance = Outlook.OlImportance.olImportanceLow;
			mailItem.Save();
			mailItem.UnRead = true;

			Console.WriteLine("Mail Item created for: " + recipient + ", Email: " + subject);
		}

		private DataTable csvToDataTable(string file)
		{
			StreamReader sr = new StreamReader(file);
			string myStringRow = sr.ReadLine();
			var rows = myStringRow.Split(',');
			DataTable CsvData = new DataTable();
			foreach (string column in rows)
			{
				//creates the columns of new datatable based on first row of csv
				CsvData.Columns.Add(column);
			}

			myStringRow = sr.ReadLine();
			while (myStringRow != null)
			{
				//runs until string reader returns null and adds rows to dt 
				rows = myStringRow.Split(',');
				CsvData.Rows.Add(rows);
				myStringRow = sr.ReadLine();
			}
			sr.Close();
			sr.Dispose();
			return CsvData;
		}

		private DataTable MatcherTable(DataTable table)
		{
			DataTable matchTable = table.Rows.Cast<DataRow>()
						   .GroupBy(x => x["E-mail Address"])
						   .Where(g => g.Count() > 1)
						   .SelectMany(k => k)
						   .CopyToDataTable();
			
			return matchTable;
		}

		//THis is for people who have a singular statement
		private string GetPath(string designation, string folder)
		{
			string path = null;

			string partialName = designation;
			DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(folder);
			FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + partialName + "*.*");

			foreach (FileInfo foundFile in filesInDir)
			{
				string fullName = foundFile.FullName;
				path = fullName;
				return path;
				//Console.WriteLine(fullName);
			}
			return path;
		}

		//This is for people who have multiple statements going to them
		private List<string> GetPaths(List<string> designation, string folder)
		{
			List<string> paths = new List<string>();

			foreach (var item in designation)
			{
				string partialName = item;
				DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(folder);
				FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + partialName + "*.*");

				foreach (FileInfo foundFile in filesInDir)
				{
					string fullName = foundFile.FullName;
					paths.Add(fullName);
				}
			}
			return paths;
		}

		//this string is the user who runs the script's default signature
		private string ReadSignature()
		{
			string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Signatures";
			string signature = string.Empty;
			DirectoryInfo diInfo = new DirectoryInfo(appDataDir);

			if (diInfo.Exists)
			{
				FileInfo[] fiSignature = diInfo.GetFiles("*.htm");

				if (fiSignature.Length > 0)
				{
					StreamReader sr = new StreamReader(fiSignature[0].FullName, Encoding.Default);
					signature = sr.ReadToEnd();

					if (!string.IsNullOrEmpty(signature))
					{
						string fileName = fiSignature[0].Name.Replace(fiSignature[0].Extension, string.Empty);
						signature = signature.Replace(fileName + "_files/", appDataDir + "/" + fileName + "_files/");
					}
				}
			}
			return signature;
		}
	}
}
