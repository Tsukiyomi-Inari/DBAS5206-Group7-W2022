using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;

namespace LakeridgeCommunityHospital
{
	public partial class mdiParentMain : MaterialForm
	{
		//private int childFormNumber = 0;

		public mdiParentMain()
		{
			InitializeComponent();
			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo400, Primary.Indigo700, Primary.Indigo200, Accent.LightBlue200, TextShade.WHITE);

			statusChange.Text = @"Application Started";
		}


		private void OpenFile(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = openFileDialog.FileName;
			}
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = saveFileDialog.FileName;
			}
		}

		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}


	
		private void menuEditCut_Click(object sender, EventArgs e)
		{
			Form1.Instance.CutText();
		}

		private void menuEditCopy_Click(object sender, EventArgs e)
		{
			Form1.Instance.CopyText();
		}

		private void menuEditPaste_Click(object sender, EventArgs e)
		{
			Form1.Instance.PasteText();
		}

		private void menuEditSelectAll_Click(object sender, EventArgs e)
		{
			Form1.Instance.SelectAllText();
		}

		//private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
		//{
		//	toolStrip.Visible = toolBarToolStripMenuItem.Checked;
		//}

		private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			statusStrip.Visible = statusBarToolStripMenuItem.Checked;
		}

		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Form childForm in MdiChildren)
			{
				childForm.Close();
			}
		}

		private void btnPatientClick(object sender, EventArgs e)
		{
			Form1 frm = Form1.Instance;
			frm.MdiParent = this;
			frm.Show();
			frm.Focus();
			statusChange.Text = "Physician-Patient Dashboard loaded";
		}

		private void btnRoomClick(object sender, EventArgs e)
		{
			RoomUtilizationDashboard frm = RoomUtilizationDashboard.Instance;
			frm.MdiParent = this;
			frm.Show();
			frm.Focus();

			statusChange.Text = "Room Utilization Dashboard loaded";
		}



		/// <summary>
		/// Cascades all open windows inside parent form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuWindowCascade_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
		}
		/// <summary>
		/// Tile all open windows horizontally
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuWindowTileHorizontal_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
		}
		/// <summary>
		///   Tile all open windows vertically
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuWindowTileVertical_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
		}


		/// <summary>
		/// Prompts for SaveAsFile if there is no FileName.
		/// </summary>
		private void SaveFile()
		{
			if (Form1.Instance.FileNameCurrent == string.Empty || Form1.Instance.FileNameCurrent == "Untitled")
			{
				SaveAsFile();
			}
			else // if the current file is not empty use the current filename in memory / global variable
			{
				string fileName = Form1.Instance.FileNameCurrent;
				Document.FileWrite(Document.TextFile, fileName);
				MessageBox.Show("Save was Complete", "Save Confirmation", MessageBoxButtons.OK);
			
			}
		}

		/// <summary>
		/// Opens save file dialog, writes it to file for current instance of Text Editor
		/// </summary>
		private void SaveAsFile()
		{
			String fileName = string.Empty;
			SaveFileDialog saveAs = new SaveFileDialog();
			if (saveAs.ShowDialog() == DialogResult.OK)
			{
				fileName = saveAs.FileName;
				Document.TextFile.FileName = fileName;
				// save the information
				Document.FileWrite(Document.TextFile, Document.TextFile.FileName);
				MessageBox.Show("Save was Complete", "Save Confirmation", MessageBoxButtons.OK);
				Form1.Instance.Update();
				//filename = Path.GetFileName(filename);
			};
		}


		#region Menu Options
		/// <summary>
		/// Calls for the LoadFile method from the document class.
		/// </summary>
		private void OpenFile()
		{
			OpenFileDialog openDialog = new OpenFileDialog();
			if (openDialog.ShowDialog() == DialogResult.OK)
			{
				// Load from a file, have to show dialog first
				Document.LoadFile(openDialog.FileName);
				Form1 frm = Form1.Instance;
				frm.MdiParent = this;
				// when loading the list of troops, force the update form (it is a public method) before show/focus
				frm.Update();
				frm.Show();
				frm.Focus();
				//Instance.FileNameCurrent.Text = Path.GetFileName(openFileDialog1.FileName);
			}
		}

		#endregion

		private void frmParentLoad(object sender, EventArgs e)
		{
			SaveFileDialog saveAs = new SaveFileDialog();
			OpenFileDialog openDialog = new OpenFileDialog();
			saveAs.Filter = "Text Documents (*.txt)|*.txt";
			openDialog.Filter = "Text Documents (*.txt)|*.txt";
		}

		private void physicianPatientDashboard_Toolbar_Click(object sender, EventArgs e)
		{
			Form1 frm = Form1.Instance;
			frm.MdiParent = this;
			frm.Show();
			frm.Focus();
			statusChange.Text = "Physician-Patient Dashboard loaded";
		}

		private void roomUtilizationDashboard_Toolbar_Click(object sender, EventArgs e)
		{
			RoomUtilizationDashboard frm = RoomUtilizationDashboard.Instance;
			frm.MdiParent = this;
			frm.Show();
			frm.Focus();

			statusChange.Text = "Room Utilization Dashboard loaded";
		}
	}
}
