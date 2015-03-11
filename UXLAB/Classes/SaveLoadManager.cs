using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UXLAB.Classes
{
	public class SaveLoadManager
	{
		public SaveLoadManager()
		{

		}

		public void SetDocument(string Filepath)
		{
			filepath = Filepath;
		}
		public void CPReadAuthorization(ref AuthorizationInformation authInfo)
		{
			XElement xRoot = XElement.Load(filepath);

			XElement xAuthInfo = xRoot.Element("AuthInfo");

			authInfo.accessToken = xAuthInfo.Attribute("Token").Value;
			authInfo.parameters.AccessCode = xAuthInfo.Attribute("Code").Value;
			authInfo.parameters.AccessToken = authInfo.accessToken;
		}

		public void CPWriteAuthorization(AuthorizationInformation authInfo)
		{
			XDocument xDoc;

			try
			{
				xDoc = XDocument.Load(filepath);
			}
			catch(Exception)
			{
				xDoc = null;
			}


			if (xDoc != null)
			{
				XElement xRoot = xDoc.Element("Root");
				XElement xAuthInfo = new XElement("AuthInfo");
				xAuthInfo.Add(new XAttribute("Code", authInfo.parameters.AccessCode));
				xAuthInfo.Add(new XAttribute("Token", authInfo.accessToken));

				XElement xOldAuthInfo = xRoot.Element("AuthInfo");
				xOldAuthInfo.Remove();
				xRoot.Add(xAuthInfo);
			}
			else
			{
				xDoc = new XDocument();
				XElement xRoot = new XElement("Root");
				XElement xAuthInfo = new XElement("AuthInfo");
				xAuthInfo.Add(new XAttribute("Code", authInfo.parameters.AccessCode));
				xAuthInfo.Add(new XAttribute("Token", authInfo.accessToken));
				xRoot.Add(xAuthInfo);
				xDoc.Add(xRoot);
			}

			xDoc.Save(filepath);
		}

		public void ReadStudyComponents(ref ComponentsLocations studyComponents)
		{
			XDocument xDoc = XDocument.Load(filepath);
			XElement xRoot = xDoc.Element("Root");

			//Workbook
			XElement xWorkbook = xRoot.Element("Workbook");

			studyComponents.Workbook = xWorkbook.Attribute("value").Value;

			//Study Sheet
			XElement xStudy = xWorkbook.Element("StudySheet");
			XElement xNow = xStudy.Element("Now");
			XElement xDuration = xStudy.Element("Duration");
			XElement xName = xStudy.Element("Name");
			XElement xTotal = xStudy.Element("Total");
			XElement xComplete = xStudy.Element("Completed");
			XElement xDesired = xStudy.Element("Desired");

			studyComponents.StudySheet = xStudy.Attribute("value").Value;
			studyComponents.Now = xNow.Attribute("value").Value;
			studyComponents.Duration = xDuration.Attribute("value").Value;
			studyComponents.Name = xName.Attribute("value").Value;
			studyComponents.Completed = xComplete.Attribute("value").Value;
			studyComponents.Desired = xDesired.Attribute("value").Value;
			studyComponents.Total = xTotal.Attribute("value").Value;

			//Participant Sheet
			XElement xParticipant = xWorkbook.Element("ParticipantSheet");
			XElement xOffsets = xParticipant.Element("Offsets");
			XElement xTestTimes = xParticipant.Element("TestTimes");
			XElement xUseColumns = xParticipant.Element("UseColumns");

			studyComponents.ParticipantSheet = xParticipant.Attribute("value").Value;
			studyComponents.Offsets = xOffsets.Attribute("value").Value;
			studyComponents.TestTimes = xTestTimes.Attribute("value").Value;
			studyComponents.UseColumns = xUseColumns.Attribute("value").Value;
		}

		public void WriteStudyComponents(ComponentsLocations studyComponents)
		{
			XDocument xDoc = null;
			XElement xRoot = null;
			XElement xWorkbook = null;

			try
			{
				xDoc = XDocument.Load(filepath);
				xRoot = xDoc.Element("Root");
				xWorkbook = xRoot.Element("Workbook");
				xWorkbook.Remove();
				
			}
			catch (Exception)
			{
			}

			//Workbook
			xWorkbook = new XElement("Workbook");
			xWorkbook.Add(new XAttribute("value", studyComponents.Workbook));

			//Worksheet
			XElement xStudySheet = new XElement("StudySheet");
			xStudySheet.Add(new XAttribute("value", studyComponents.StudySheet));
			xWorkbook.Add(xStudySheet);

			XElement xParticipantSheet = new XElement("ParticipantSheet");
			xParticipantSheet.Add(new XAttribute("value", studyComponents.ParticipantSheet));
			xWorkbook.Add(xParticipantSheet);

			//Attach study sheet values
			xStudySheet.Add(AddWriteElement("Duration", studyComponents, Form1.FormComponents.Duration));
			xStudySheet.Add(AddWriteElement("Now", studyComponents, Form1.FormComponents.Now));
			xStudySheet.Add(AddWriteElement("Total", studyComponents, Form1.FormComponents.Total));
			xStudySheet.Add(AddWriteElement("Desired", studyComponents, Form1.FormComponents.Desired));
			xStudySheet.Add(AddWriteElement("Completed", studyComponents, Form1.FormComponents.Completed));
			xStudySheet.Add(AddWriteElement("Name", studyComponents, Form1.FormComponents.Name));

			//Attach participant sheet values
			xParticipantSheet.Add(AddWriteElement("Offsets", studyComponents, Form1.FormComponents.Offsets));
			xParticipantSheet.Add(AddWriteElement("TestTimes", studyComponents, Form1.FormComponents.TestTimes));
			xParticipantSheet.Add(AddWriteElement("UseColumns", studyComponents, Form1.FormComponents.UseColumns));

			xRoot.Add(xWorkbook);
			xDoc.Save(filepath);
		}

		private string filepath;

		private XElement AddWriteElement(string elementText, ComponentsLocations studyComponents, Form1.FormComponents component)
		{
			XElement element = new XElement(elementText);
			element.Add(new XAttribute("value", studyComponents.GetComponent(component)));
			return element;
		}
	}

}
