using System;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace LakeridgeCommunityHospital
{
	internal class PatientDB
	{
		#region DVG DATA

		

		/// <summary>
		/// List for a collection of patients
		/// </summary>
		public static List<PatientDB> patientsList = new List<PatientDB>();

		public PatientDB()
		{
			PatientDB patientDB = this;
			patientDB.PatientNumber = patientDB.ToString();
			patientDB.PatientName = patientDB.ToString();
			patientDB.DateAdmitted = patientDB.ToString();
			patientDB.DateDischarge = patientDB.ToString();
			patientDB.AdmiNum = patientDB.ToString();
			patientDB.Location = patientDB.ToString();
		}

		public PatientDB(string patientNumber, string patientName,string dateAdmitted ,string dateDischarge, string admiNum, string location)
		{
			PatientNumber = patientNumber;
			PatientName = patientName;

			DateAdmitted = dateAdmitted;
			DateDischarge = dateDischarge;
			AdmiNum = admiNum;
			Location = location;
		}
		/// <summary>
		/// Variables for getting data for DVG on PhysicianDashboard
		/// </summary>
		public string PatientNumber { get; set; }
		public string PatientName { get; set; }
		public string DateAdmitted { get; set; }
		public string DateDischarge { get; set; }
		public string AdmiNum { get; set; }
		public string Location { get; set; }

		#endregion

		#region SQL
		
		/// <summary>
		/// Method for connection string
		/// </summary>
		/// <returns></returns>
		private static string GetConnectionString()
		{
			string returnValue = null;

			// Look for myConnectionString in the connectionStrings section.
			ConnectionStringSettings myConnectionString = ConfigurationManager.ConnectionStrings[1];

			//// If found, return the connection string.
			if (true)
				returnValue = myConnectionString.ConnectionString;

			//YEY CONNECTION!
			return returnValue;
		}
		#endregion

#region PHYSICIAN DASHBOARD MEDTHODS

		/// <summary>
		/// Method for obtaining patient's number from patient object
		/// </summary>
		/// <param name="patient"></param>
		/// <returns></returns>
		public static string GetPatientNumber(PatientDB patient)
		{
			string number = "";
			number = patient.PatientNumber;

			return number;
		}

		/// <summary>
		/// Method for adding patients to a list object
		/// </summary>
		/// <returns></returns>
		public static List<PatientDB> GetPatientListData()
		{
			List<PatientDB> patients = new List<PatientDB>();
			string connectionStr =  GetConnectionString();
			SqlConnection connection = new SqlConnection(connectionStr);
			connection.Open();
			string sqlStatement = "SELECT p.PATIENT_NUMBER,  p.PATIENT_NAME, a.DATE_DISCHARGED, a.ADMISSION_NUMBER, a.DATE_ADMITTED, CONCAT( a.ROOM_NUMBER , a.BED_CHAR) AS LOCATION FROM LakeRidgeHospital.dbo.ADMISSION AS a, LakeRidgeHospital.dbo.PATIENT AS p WHERE p.PATIENT_NUMBER = a.PATIENT_NUMBER;";
			SqlCommand command = new SqlCommand(sqlStatement, connection);
			SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
			while (reader.Read())
			{
				PatientDB patient = new PatientDB
				{
					PatientName = reader["PATIENT_NAME"].ToString(),
					PatientNumber = reader["PATIENT_NUMBER"].ToString(),
					DateDischarge = reader["DATE_DISCHARGED"].ToString(),
					AdmiNum = reader["ADMISSION_NUMBER"].ToString(),
					DateAdmitted = reader["DATE_ADMITTED"].ToString(),
					Location = reader["LOCATION"].ToString()
				};
				//add retreived patient to list
				patients.Add(patient);
			}

			return patients;
		}

		/// <summary>
		/// Method for inserting new note entry
		/// for patient
		/// </summary>
		/// <param name="admissionNum"></param>
		/// <param name="note"></param>
		public static void SetPatientNote(int admissionNum, RichTextBox note)
		{
			string newNote = note.ToString();
			string insertNote = @"INSERT INTO LakeRidgeHospital.dbo.NOTE (ADMISSION_NUMBER, ENTRY) VALUES" + admissionNum + "," + newNote + ")";
			string connection = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
			// set a variable for current patient viewed & get  admission number
			SqlConnection cn = new SqlConnection(connection);
			cn.Open();
			SqlCommand command = new SqlCommand(insertNote, cn);
			command.ExecuteNonQuery();
			cn.Close();

		}


		public static void GetPatientDetails(int patientNumber)
		{
			//string sqlStatement = "Select p.* , f.Provider, a.Date_admitted, a.Date_Discharged, a.Room_Number, a.Bed_Char  " +
			//    "From  Patient p , Admission a ,Financial_Status f " +
			//    "Where "
		}


		public static void GetPatientNote(string admissionNumber)
		{
			string connection = GetConnectionString();
			SqlParameter admissParameter = new SqlParameter("@ADDMISSION_NUMBER", admissionNumber);
			string sqlStatement = "Select  a.DATE_ADMITTED, n.ENTRY  FROM LakeRidgeHospital.dbo.NOTE AS n , LakeRidgeHospital.dbo.ADMISSION AS a WHERE n.ADMISSION_Number = @ADDMISSION_NUMBER";
			using SqlConnection cn = new SqlConnection(connection);
			using SqlCommand command = new SqlCommand(sqlStatement, cn);
			command.Parameters.Add(admissParameter);
			cn.Open();
			SqlDataAdapter thisAdapter = new SqlDataAdapter(command);
			DataTable data = new DataTable("fill ME");
			thisAdapter.Fill(data);

			for (int i = 0; i < data.Rows.Count; i++)
			{
				DataRow datRow = data.Rows[i];
				ListViewItem datItem = new ListViewItem(datRow["ADMISSION_NUMBER"].ToString());
				datItem.SubItems.Add(datRow["DATE_ADMITTED"].ToString());
				datItem.SubItems.Add(datRow["ENTRY"].ToString());
			}

			cn.Close();


		}


#endregion







	}
}