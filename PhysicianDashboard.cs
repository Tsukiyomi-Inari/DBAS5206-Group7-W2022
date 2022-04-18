using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
using System.IO;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using System.Runtime.CompilerServices;
using static LakeridgeCommunityHospital.PatientDB;

namespace LakeridgeCommunityHospital
{
	
	public partial class Form1 : MaterialForm
	{
		private PatientDB thisPatientDb = new PatientDB();
		public Form1()
		{
			InitializeComponent();
			

		 	var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo400, Primary.Indigo700, Primary.Indigo200, Accent.LightBlue200, TextShade.WHITE);

		}



		private void GenerateNoteView(object sender, EventArgs e)
		{
			// Use class method to populate currently selected patient's list of notes
			GetPatientNote(thisPatientDb.AdmiNum);
		}

		private void PatientListGenerate(object sender, EventArgs e)
		{
			try
			{
				
				//Use method for calling data from database as a list
				//Add data to DVG table
				dvgPatientListTable.DataSource =  GetPatientListData();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

		}
		#region Singleton Pattern
		// Singleton Pattern
		/// <summary>
		/// variable for form instance
		/// </summary>
		private static Form1 paientInstance;
		/// <summary>
		/// Method for form to get current instance of form (aka null or new)
		/// </summary>
		public static Form1 Instance
		{
			get
			{
				if (paientInstance == null)
				{
					paientInstance = new Form1();
					
				}
				else
				{
					//nothing
				}
				return paientInstance;
			}
		}
		#endregion



		#region GLOBAL VARS
		/// <summary>
		/// Method for getting and setting current filename
		/// </summary>
		public string FileNameCurrent { get; set; }

		#endregion


		private void frmNewNote_Load(object sender, EventArgs e)
		{
			//CurrentDocument.Text = rtbCanvas.Text;

			//.Filter = "Text Documents (*.txt)|*.txt";
			// openFileDialog.Filter = "Text Documents (*.txt)|*.txt";
			Document.TextFile.Text = rtboxNewNote.Text;
			Instance.FileNameCurrent = Document.TextFile.FileName;
			SetFileName();
			//SetChangeStatus(false);
		}
		/// <summary>
		/// Sets the file name on the text property of the form.
		/// </summary>
		/// <param name="str"></param>
		private void SetFileName()
		{
			if (Instance.FileNameCurrent == string.Empty)
			{
				this.Text = "Untitled";
			}
			else
			{
				//FilePath = openFileDialog.FileName;
				string thisText = null;
				thisText = Path.GetFileName(FileNameCurrent);
				this.Text = thisText + @"- PatientDB Note";
			}
		}
		///// <summary>
		///// Keeps track of changes in the textbox and counts the characters.
		///// </summary>
		///// <param name="sender"></param>
		///// <param name="e"></param>
		private void rtbCanvas_TextChanged(object sender, EventArgs e)
		{
			Document.TextFile.Text = rtboxNewNote.Text;
			int chars = rtboxNewNote.Text.Length;
			statusChange.Text = @"New note stated";
		}


		/// <summary>
		/// Method to set instance of form, upon close, to null
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmClosed(object sender, FormClosedEventArgs e)
		{
			paientInstance = null;
		}
		/// <summary>
		/// cuts the currently selected text within text editor
		/// </summary>
		public void CutText()
		{
			rtboxNewNote.Cut();
		}
		/// <summary>
		/// Pastes text from clipboard into text editor
		/// </summary>
		public void PasteText()
		{
			rtboxNewNote.Paste();
		}
		/// <summary>
		/// Copies the currently selected text in text editor
		/// </summary>
		public void CopyText()
		{
			rtboxNewNote.Copy();
		}
		/// <summary>
		/// Selects all text within Text editor
		/// </summary>
		public void SelectAllText()
		{
			rtboxNewNote.SelectAll();
		}

		private void AddNoteClick(object sender, EventArgs e)
		{
			//PatientDB.GetPatientNumber(_toPatient);
			PatientDB.SetPatientNote(int.Parse(thisPatientDb.AdmiNum), rtboxNewNote );
		}

		private void GetCurrentPatientSelection(object sender, EventArgs e)
		{
			try
			{
				if (dvgPatientListTable.CurrentRow != null)
				{
					thisPatientDb.PatientNumber = dvgPatientListTable.CurrentRow.Cells[0].ToString();
					thisPatientDb.PatientName = dvgPatientListTable.CurrentRow.Cells[1].ToString();
					thisPatientDb.DateDischarge = dvgPatientListTable.CurrentRow.Cells[2].ToString();
					thisPatientDb.AdmiNum = dvgPatientListTable.CurrentRow.Cells[3].ToString(); 
					thisPatientDb.DateAdmitted = dvgPatientListTable.CurrentRow.Cells[4].ToString(); 
					thisPatientDb.Location = dvgPatientListTable.CurrentRow.Cells[5].ToString();
				}
			}
			catch (NullReferenceException err)
			{
				statusChange.Text = @"Error encountered: " + err;
				//nothing!
			}
			GetPatientNote(thisPatientDb.AdmiNum);
			
		}
	}
	}
