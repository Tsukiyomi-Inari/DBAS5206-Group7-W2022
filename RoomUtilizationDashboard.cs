using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;

namespace LakeridgeCommunityHospital
{
	public partial class RoomUtilizationDashboard : MaterialForm
	{
		
		public RoomUtilizationDashboard()
		{
			InitializeComponent();

			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo400, Primary.Indigo700, Primary.Indigo200, Accent.LightBlue200, TextShade.WHITE);



		}

		#region Singleton Pattern
		// Singleton Pattern
		/// <summary>
		/// variable for form instance
		/// </summary>
		private static RoomUtilizationDashboard roomInstance;
		/// <summary>
		/// Method for form to get current instance of form (aka null or new)
		/// </summary>
		public static RoomUtilizationDashboard Instance
		{
			get
			{
				if (roomInstance == null)
				{
					roomInstance = new RoomUtilizationDashboard();
				}
				else
				{
					//nothing
				}
				return roomInstance;
			}
		}
		#endregion



		

		private void RoomUtilizationDashboard_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'lakeRidgeHospitalDataSet.BED' table. You can move, or remove it, as needed.
			this.bEDTableAdapter.Fill(this.lakeRidgeHospitalDataSet.BED);
			// TODO: This line of code loads data into the 'lakeRidgeHospitalDataSet.ROOM_TYPE' table. You can move, or remove it, as needed.
			this.rOOM_TYPETableAdapter.Fill(this.lakeRidgeHospitalDataSet.ROOM_TYPE);
			// TODO: This line of code loads data into the 'lakeRidgeHospitalDataSet.USER_TYPE' table. You can move, or remove it, as needed.
			try
			{
				string connection = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

				string sqlStatement = "SELECT DISTINCT CONCAT(r.ROOM_NUMBER , b.BED_CHAR) AS  BED_LOCATION, r.ROOM_TYPE_NUMBER, a.PATIENT_NUMBER , p.PATIENT_NAME, a.DATE_ADMITTED FROM LakeRidgeHospital.dbo.ROOM r, LakeRidgeHospital.dbo.BED b, LakeRidgeHospital.dbo.ADMISSION a,LakeRidgeHospital.dbo.PATIENT p WHERE r.ROOM_NUMBER = a.ROOM_NUMBER AND a.PATIENT_NUMBER = p.PATIENT_NUMBER" ;
				SqlConnection cn = new SqlConnection(connection);
				cn.Open();
				SqlCommand command = new SqlCommand(sqlStatement, cn);
				SqlDataAdapter thisAdapter = new SqlDataAdapter(command);

				DataTable data = new DataTable("Temp Data Query");
				thisAdapter.Fill(data);
				dataGridView1.DataSource = data.DefaultView;

				cn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}




	}
}
