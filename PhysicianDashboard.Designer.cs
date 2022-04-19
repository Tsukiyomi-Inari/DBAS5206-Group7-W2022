
using System.Runtime.CompilerServices;
using MaterialSkin.Controls;

namespace LakeridgeCommunityHospital
{
	public partial class Form1 : MaterialForm
	{


		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("2022-03-01 6:00AM , Confirmation diagnosis");
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2022-02-25 7:00AM        Culture Results");
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("2022-01-05                         new investigation");
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("2021-12-20 2:00PM     Follow up set");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.dvgPatientListTable = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbAddNewNote = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.rtboxSelectedNote = new System.Windows.Forms.RichTextBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.btnAddNote = new MaterialSkin.Controls.MaterialButton();
			this.rtboxNewNote = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lstViewPatientNoteLog = new MaterialSkin.Controls.MaterialListView();
			this.lstBoxColDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.lblPatientDetails = new System.Windows.Forms.GroupBox();
			this.btnAddTreatment = new MaterialSkin.Controls.MaterialButton();
			this.lblStripStatus = new System.Windows.Forms.Label();
			this.statusChange = new System.Windows.Forms.ToolStripStatusLabel();
			this.sStrpStatusBar = new System.Windows.Forms.StatusStrip();
			this.dvgColAdmitted = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dvgColAdmittion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date_Discharged = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dvgColAppointment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dvgColPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tboxDetails = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dvgPatientListTable)).BeginInit();
			this.panel1.SuspendLayout();
			this.tbAddNewNote.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.lblPatientDetails.SuspendLayout();
			this.sStrpStatusBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// dvgPatientListTable
			// 
			this.dvgPatientListTable.AllowUserToOrderColumns = true;
			this.dvgPatientListTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dvgPatientListTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dvgPatientListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvgPatientListTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgColAdmitted,
            this.dvgColAdmittion,
            this.Date_Discharged,
            this.dvgColAppointment,
            this.dvgColPatient,
            this.location});
			this.dvgPatientListTable.GridColor = System.Drawing.Color.Azure;
			this.dvgPatientListTable.Location = new System.Drawing.Point(6, 65);
			this.dvgPatientListTable.Name = "dvgPatientListTable";
			this.dvgPatientListTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dvgPatientListTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dvgPatientListTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dvgPatientListTable.Size = new System.Drawing.Size(766, 303);
			this.dvgPatientListTable.TabIndex = 4;
			this.dvgPatientListTable.SelectionChanged += new System.EventHandler(this.GetCurrentPatientSelection);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tbAddNewNote);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lstViewPatientNoteLog);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(778, 75);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(712, 697);
			this.panel1.TabIndex = 0;
			// 
			// tbAddNewNote
			// 
			this.tbAddNewNote.Controls.Add(this.tabPage3);
			this.tbAddNewNote.Controls.Add(this.tabPage4);
			this.tbAddNewNote.Location = new System.Drawing.Point(343, 50);
			this.tbAddNewNote.Name = "tbAddNewNote";
			this.tbAddNewNote.SelectedIndex = 0;
			this.tbAddNewNote.Size = new System.Drawing.Size(351, 635);
			this.tbAddNewNote.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.rtboxSelectedNote);
			this.tabPage3.Location = new System.Drawing.Point(4, 27);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(343, 604);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.Text = "Selected Note View";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// rtboxSelectedNote
			// 
			this.rtboxSelectedNote.Location = new System.Drawing.Point(3, 0);
			this.rtboxSelectedNote.Name = "rtboxSelectedNote";
			this.rtboxSelectedNote.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rtboxSelectedNote.Size = new System.Drawing.Size(337, 604);
			this.rtboxSelectedNote.TabIndex = 0;
			this.rtboxSelectedNote.Text = "";
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.btnAddNote);
			this.tabPage4.Controls.Add(this.rtboxNewNote);
			this.tabPage4.Location = new System.Drawing.Point(4, 27);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(343, 604);
			this.tabPage4.TabIndex = 1;
			this.tabPage4.Text = "Add New Note";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// btnAddNote
			// 
			this.btnAddNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnAddNote.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.btnAddNote.Depth = 0;
			this.btnAddNote.HighEmphasis = true;
			this.btnAddNote.Icon = null;
			this.btnAddNote.Location = new System.Drawing.Point(131, 547);
			this.btnAddNote.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnAddNote.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnAddNote.Name = "btnAddNote";
			this.btnAddNote.NoAccentTextColor = System.Drawing.Color.Empty;
			this.btnAddNote.Size = new System.Drawing.Size(92, 36);
			this.btnAddNote.TabIndex = 10;
			this.btnAddNote.Text = "Add Note";
			this.btnAddNote.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.btnAddNote.UseAccentColor = false;
			this.btnAddNote.UseVisualStyleBackColor = true;
			this.btnAddNote.Click += new System.EventHandler(this.AddNoteClick);
			// 
			// rtboxNewNote
			// 
			this.rtboxNewNote.Location = new System.Drawing.Point(6, 6);
			this.rtboxNewNote.Name = "rtboxNewNote";
			this.rtboxNewNote.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rtboxNewNote.Size = new System.Drawing.Size(331, 527);
			this.rtboxNewNote.TabIndex = 0;
			this.rtboxNewNote.Text = "2022-04-11 11:00AM     New Diagnosis\n\nResults of culture and imaging revelaed fib" +
    "roids";
			this.rtboxNewNote.TextChanged += new System.EventHandler(this.rtbCanvas_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(589, 13);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(0, 24);
			this.label2.TabIndex = 6;
			// 
			// lstViewPatientNoteLog
			// 
			this.lstViewPatientNoteLog.AutoSizeTable = false;
			this.lstViewPatientNoteLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.lstViewPatientNoteLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstViewPatientNoteLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstBoxColDate,
            this.columnHeader1});
			this.lstViewPatientNoteLog.Depth = 0;
			this.lstViewPatientNoteLog.FullRowSelect = true;
			this.lstViewPatientNoteLog.HideSelection = false;
			this.lstViewPatientNoteLog.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
			this.lstViewPatientNoteLog.Location = new System.Drawing.Point(13, 50);
			this.lstViewPatientNoteLog.MinimumSize = new System.Drawing.Size(200, 100);
			this.lstViewPatientNoteLog.MouseLocation = new System.Drawing.Point(-1, -1);
			this.lstViewPatientNoteLog.MouseState = MaterialSkin.MouseState.OUT;
			this.lstViewPatientNoteLog.Name = "lstViewPatientNoteLog";
			this.lstViewPatientNoteLog.OwnerDraw = true;
			this.lstViewPatientNoteLog.Size = new System.Drawing.Size(324, 635);
			this.lstViewPatientNoteLog.TabIndex = 2;
			this.lstViewPatientNoteLog.UseCompatibleStateImageBehavior = false;
			this.lstViewPatientNoteLog.View = System.Windows.Forms.View.Details;
			this.lstViewPatientNoteLog.SelectedIndexChanged += new System.EventHandler(this.GenerateNoteView);
			// 
			// lstBoxColDate
			// 
			this.lstBoxColDate.Text = "Date Recorded";
			this.lstBoxColDate.Width = 170;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Note Reason";
			this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader1.Width = 140;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(119, 13);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(218, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Patent Record Logs:";
			// 
			// lblPatientDetails
			// 
			this.lblPatientDetails.Controls.Add(this.tboxDetails);
			this.lblPatientDetails.Controls.Add(this.btnAddTreatment);
			this.lblPatientDetails.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPatientDetails.Location = new System.Drawing.Point(3, 374);
			this.lblPatientDetails.Name = "lblPatientDetails";
			this.lblPatientDetails.Size = new System.Drawing.Size(769, 398);
			this.lblPatientDetails.TabIndex = 6;
			this.lblPatientDetails.TabStop = false;
			this.lblPatientDetails.Text = "PatientDB Details";
			// 
			// btnAddTreatment
			// 
			this.btnAddTreatment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnAddTreatment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.btnAddTreatment.Depth = 0;
			this.btnAddTreatment.HighEmphasis = true;
			this.btnAddTreatment.Icon = null;
			this.btnAddTreatment.Location = new System.Drawing.Point(622, 359);
			this.btnAddTreatment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnAddTreatment.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnAddTreatment.Name = "btnAddTreatment";
			this.btnAddTreatment.NoAccentTextColor = System.Drawing.Color.Empty;
			this.btnAddTreatment.Size = new System.Drawing.Size(140, 36);
			this.btnAddTreatment.TabIndex = 8;
			this.btnAddTreatment.Text = "Add Treatment";
			this.btnAddTreatment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.btnAddTreatment.UseAccentColor = false;
			this.btnAddTreatment.UseVisualStyleBackColor = true;
			// 
			// lblStripStatus
			// 
			this.lblStripStatus.AutoSize = true;
			this.lblStripStatus.BackColor = System.Drawing.Color.Transparent;
			this.lblStripStatus.Location = new System.Drawing.Point(411, 775);
			this.lblStripStatus.Name = "lblStripStatus";
			this.lblStripStatus.Size = new System.Drawing.Size(0, 18);
			this.lblStripStatus.TabIndex = 8;
			// 
			// statusChange
			// 
			this.statusChange.BackColor = System.Drawing.Color.Transparent;
			this.statusChange.Name = "statusChange";
			this.statusChange.Size = new System.Drawing.Size(103, 17);
			this.statusChange.Text = "Dashboard loaded";
			// 
			// sStrpStatusBar
			// 
			this.sStrpStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusChange});
			this.sStrpStatusBar.Location = new System.Drawing.Point(3, 775);
			this.sStrpStatusBar.Name = "sStrpStatusBar";
			this.sStrpStatusBar.Size = new System.Drawing.Size(1490, 22);
			this.sStrpStatusBar.TabIndex = 3;
			this.sStrpStatusBar.Text = "statusStrip1";
			// 
			// dvgColAdmitted
			// 
			this.dvgColAdmitted.DataPropertyName = "PatientName";
			this.dvgColAdmitted.HeaderText = "PATIENT NAME";
			this.dvgColAdmitted.MinimumWidth = 100;
			this.dvgColAdmitted.Name = "dvgColAdmitted";
			// 
			// dvgColAdmittion
			// 
			this.dvgColAdmittion.DataPropertyName = "PatientNumber";
			this.dvgColAdmittion.HeaderText = "PATIENT NUMBER";
			this.dvgColAdmittion.MinimumWidth = 100;
			this.dvgColAdmittion.Name = "dvgColAdmittion";
			// 
			// Date_Discharged
			// 
			this.Date_Discharged.DataPropertyName = "DateDischarge";
			this.Date_Discharged.HeaderText = "DISCHARGE DATE";
			this.Date_Discharged.MinimumWidth = 100;
			this.Date_Discharged.Name = "Date_Discharged";
			// 
			// dvgColAppointment
			// 
			this.dvgColAppointment.DataPropertyName = "AdmiNum";
			this.dvgColAppointment.HeaderText = "ADMISSION NUMBER";
			this.dvgColAppointment.MinimumWidth = 100;
			this.dvgColAppointment.Name = "dvgColAppointment";
			// 
			// dvgColPatient
			// 
			this.dvgColPatient.DataPropertyName = "DateAdmitted";
			this.dvgColPatient.HeaderText = "DATE ADMITTED";
			this.dvgColPatient.MinimumWidth = 100;
			this.dvgColPatient.Name = "dvgColPatient";
			// 
			// location
			// 
			this.location.DataPropertyName = "LOCATION";
			this.location.HeaderText = "LOCATION";
			this.location.Name = "location";
			// 
			// tboxDetails
			// 
			this.tboxDetails.Location = new System.Drawing.Point(16, 44);
			this.tboxDetails.Multiline = true;
			this.tboxDetails.Name = "tboxDetails";
			this.tboxDetails.Size = new System.Drawing.Size(733, 306);
			this.tboxDetails.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(1496, 800);
			this.Controls.Add(this.lblStripStatus);
			this.Controls.Add(this.lblPatientDetails);
			this.Controls.Add(this.dvgPatientListTable);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.sStrpStatusBar);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Sizable = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lakeridge Community Hospital";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClosed);
			this.Load += new System.EventHandler(this.PatientListGenerate);
			((System.ComponentModel.ISupportInitialize)(this.dvgPatientListTable)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tbAddNewNote.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.lblPatientDetails.ResumeLayout(false);
			this.lblPatientDetails.PerformLayout();
			this.sStrpStatusBar.ResumeLayout(false);
			this.sStrpStatusBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dvgPatientListTable;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private MaterialListView lstViewPatientNoteLog;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColumnHeader lstBoxColDate;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.GroupBox lblPatientDetails;
        private MaterialButton btnAddTreatment;
		private System.Windows.Forms.Label lblStripStatus;
		private System.Windows.Forms.ToolStripStatusLabel statusChange;
		private System.Windows.Forms.StatusStrip sStrpStatusBar;
		
		private System.Windows.Forms.TabControl tbAddNewNote;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private MaterialButton btnAddNote;
		private System.Windows.Forms.RichTextBox rtboxNewNote;
		private System.Windows.Forms.RichTextBox rtboxSelectedNote;
		private System.Windows.Forms.DataGridViewTextBoxColumn dvgColAdmitted;
		private System.Windows.Forms.DataGridViewTextBoxColumn dvgColAdmittion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date_Discharged;
		private System.Windows.Forms.DataGridViewTextBoxColumn dvgColAppointment;
		private System.Windows.Forms.DataGridViewTextBoxColumn dvgColPatient;
		private System.Windows.Forms.DataGridViewTextBoxColumn location;
		private System.Windows.Forms.TextBox tboxDetails;
	}
}

