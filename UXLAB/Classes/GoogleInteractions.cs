﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.GData.Spreadsheets;
using Google.GData.Client;
using System.Xml.Linq;
using System.Windows.Forms;
using UXLAB;

namespace UXLAB.Classes
{
	//Class that handles the connections with Google and Google Spreadsheets in particular 
	public class GoogleInteractions
	{
		#region Enums
		public enum Worksheet { Study, Participant };
		public enum CellType { InputValue, NumericValue, DisplayedValue };		
		#endregion		
		public GoogleInteractions(ref SaveLoadManager SaveLoad)
		{
			authInfo = new AuthorizationInformation();
			studyCells = new CellEntry[(int)Form1.Cell.Max];

			bUseColumns = true;
			dimension = "B";
			offset = 1;
			saveLoad = SaveLoad;
		}

		#region Workbook
		public bool FindWorkbook(string workbook)
		{
			SpreadsheetQuery query = new SpreadsheetQuery();

			SpreadsheetFeed feed = service.Query(query);

			foreach (SpreadsheetEntry entry in feed.Entries)
			{
				if (entry.Title.Text == workbook)
				{
					workbookEntry = entry;
					return true;
				}
			}

			return false;
		}

		private SpreadsheetEntry workbookEntry;
		#endregion

		#region WorkSheet
		public bool FindWorksheet(string workbook, Worksheet sheetType)
		{
			WorksheetFeed feed = workbookEntry.Worksheets;

			foreach (WorksheetEntry entry in feed.Entries)
			{
				if (entry.Title.Text == workbook)
				{
					if (sheetType == Worksheet.Study)
						studyEntry = entry;
					else if (sheetType == Worksheet.Participant)
						participantEntry = entry;
					return true;
				}
			}

			return false;
		}
		#endregion

		#region Cell
		public bool FindCell(string cellLocation, Worksheet sheetType, Form1.Cell cellType = Form1.Cell.Max)
		{
			CellQuery cellQuery;
			
			if(sheetType == Worksheet.Study)
			{
				cellQuery = new CellQuery(studyEntry.CellFeedLink);
			}
			else if(sheetType == Worksheet.Participant)
			{
				cellQuery = new CellQuery(participantEntry.CellFeedLink);
			}
			else
			{
				return false;
			}

			CellFeed cellFeed = service.Query(cellQuery);

			foreach (CellEntry entry in cellFeed.Entries)
			{
				if (entry.Title.Text == cellLocation)
				{
					studyCells[(int)cellType] = entry;
					return true;
				}
			}

			return false;
		}

		public bool FindCell(int participantNumber, out CellEntry outEntry)
		{
			CellQuery cellQuery= new CellQuery(participantEntry.CellFeedLink);

			cellQuery.ReturnEmpty = ReturnEmptyCells.yes;

			CellFeed cellFeed = service.Query(cellQuery);
			string cellLocation;

			if(bUseColumns)
			{
				int row = participantNumber + offset + 1;
				cellLocation = Dimension + row.ToString();
				foreach (CellEntry entry in cellFeed.Entries)
				{
					if (entry.Title.Text == cellLocation)
					{
						outEntry = entry;
						return true;
					}
				}
			}
			else 
			{
				int column = participantNumber + offset;
				cellLocation = "R" + Dimension + "C" + column.ToString();
				foreach (CellEntry entry in cellFeed.Entries)
				{
					if (entry.Id.Uri.Content.Substring(cellFeed.Id.Uri.Content.LastIndexOf("/")+1) == cellLocation)
					{
						outEntry = entry;
						return true;
					}
				}			
			}

			outEntry = null;
			return false;
		}
		public bool FindColumn(string column)
		{
			return false;
		}
		public bool FindRow(string row)
		{
			return false;
		}

		public string ReadStudyCell(Form1.Cell cell, CellType cellType = CellType.DisplayedValue)
		{
			if(!ValidStudyCell(cell))
				return "";

			if (studyCells[(int)cell] == null)
				return "";

			studyCells[(int)cell].Update();

			string value;

			switch (cellType)
			{
				case CellType.DisplayedValue:
					{
						value = studyCells[(int)cell].Value;
						break;
					}
				case CellType.NumericValue:
					{
						value = studyCells[(int)cell].NumericValue;
						break;
					}
				case CellType.InputValue:
					{
						value = studyCells[(int)cell].InputValue;
						break;
					}
				default:
					{
						value = "";
						break;
					}
			}

			return value;
		}

		public bool RefreshandReadCell(CellEntry entry, CellType cellType, out string value)
		{
			try
			{
				entry.Update();
				switch (cellType)
				{
					case CellType.DisplayedValue:
						{
							value = entry.Value;
							break;
						}
					case CellType.NumericValue:
						{
							value = entry.NumericValue;
							break;
						}
					case CellType.InputValue:
						{
							value = entry.InputValue;
							break;
						}
					default:
						{
							value = "";
							break;
						}
				}
			}
			catch(Exception)
			{
				value = "";
				return false;
			}

			return true;
		}
		public bool WriteCell(CellEntry entry, CellType cellType, string value)
		{
			try
			{
				entry.Update();
				switch (cellType)
				{
					case CellType.DisplayedValue:
						{
							entry.Value = value;
							break;
						}
					case CellType.NumericValue:
						{
							entry.NumericValue = value;
							break;
						}
					case CellType.InputValue:
						{
							entry.InputValue = value;
							break;
						}
					default:
						{
							return false;
						}
				}
			}
			catch (Exception)
			{
				return false;
			}

			return true;
		}
		#endregion

		//TODO: Find a better method for Google authorization than the method below
		#region Copy-Paste method_FIND BETTER METHOD
		public void CPAuthorizationCode()
		{
			//Make an OAuth authorized request to Google
			requestFactory = new GOAuth2RequestFactory(null, "MySpreadsheetIntegeration-v1", authInfo.parameters);
			service = new SpreadsheetsService("MySpreadsheetIntegeration-v1");
			service.RequestFactory = requestFactory;
		}

		public string CPGetAuthorizationURL()
		{ return authInfo.authorizationUrl; }

		public void CPGetAuthorization(string authCode)
		{
				authInfo.parameters.AccessCode = authCode;

				OAuthUtil.GetAccessToken(authInfo.parameters);
				authInfo.accessToken = authInfo.parameters.AccessToken;
				Console.WriteLine("OAuth Access Token: " + authInfo.accessToken);

				SaveFileDialog dlgSave = new SaveFileDialog();
				dlgSave.Filter = "All Files|*.*|Xml Files|*.xml";
				dlgSave.FilterIndex = 2;
				dlgSave.DefaultExt = "xml";

				if (DialogResult.OK == dlgSave.ShowDialog())
				{
					saveLoad.SetDocument(dlgSave.FileName);
					saveLoad.CPWriteAuthorization(authInfo);
				}
				
			CPAuthorizationCode();
		}

		//Loads authorization code
		//Returns false if unsuccessful
		public bool CPReadAuthorization()
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "All Files|*.*|Xml Files|*.xml";
			dlg.FilterIndex = 2;

			DialogResult dlgResult = dlg.ShowDialog();

			if (DialogResult.OK == dlgResult)
			{
				saveLoad.SetDocument(dlg.FileName);
				saveLoad.CPReadAuthorization(ref authInfo);
			}
			else
			{
				return false;
			}
			CPAuthorizationCode();


			return true;
		}

		#endregion

		#region Variables and Accessors
		public AuthorizationInformation authInfo;
		private GOAuth2RequestFactory requestFactory;
		private SpreadsheetsService service;
		private WorksheetEntry studyEntry, participantEntry;
		private CellEntry[] studyCells;
		private bool bUseColumns;
		private string dimension;
		private int offset;
		private string filePath;
		SaveLoadManager saveLoad;

		public string Dimension
		{
			get { return dimension; }
			set { dimension = value; }
		}
		public int Offset
		{
			get { return offset; }
			set { offset = value; }
		}

		public bool BUseColumns
		{
			get { return bUseColumns; }
			set { bUseColumns = value; }
		}

		private bool ValidStudyCell(Form1.Cell cellType)
		{
			int cell = (int)cellType;
			return cell >= (int)Form1.Cell.Min && cell < (int)Form1.Cell.Max;
		}

		public SpreadsheetEntry WorkbookEntry
		{
			get { return workbookEntry; }
			set { workbookEntry = value; }
		}
	}
	
		#endregion

	//Information related to the Authorization of the use of the users Google spreadsheets
	public class AuthorizationInformation
	{
		public AuthorizationInformation()
		{
			CLIENT_ID = "996163863346-oqa81i7dk9qqfvv97bumtv81n1qnlc6c.apps.googleusercontent.com";
			ClIENT_SECRET = "HfMeWEg0ffUUmh_G_hni4oV0";
			SCOPE = "https://spreadsheets.google.com/feeds";
			REDIRECT_URI = "urn:ietf:wg:oauth:2.0:oob";

			parameters = new OAuth2Parameters();
			parameters.ClientId = CLIENT_ID;
			parameters.ClientSecret = ClIENT_SECRET;
			parameters.RedirectUri = REDIRECT_URI;
			parameters.Scope = SCOPE;
			authorizationUrl = OAuthUtil.CreateOAuth2AuthorizationUrl(parameters);
		}

		public string CLIENT_ID;
		public string ClIENT_SECRET;
		public string SCOPE;
		public string REDIRECT_URI;
		public OAuth2Parameters parameters;
		public string authorizationUrl;
		public string accessToken;
	}

}
