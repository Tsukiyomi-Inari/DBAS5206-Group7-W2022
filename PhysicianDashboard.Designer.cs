﻿
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ListBox lstBoxPatientDetailsView;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.dvgPatientListTable = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbAddNewNote = new MaterialSkin.Controls.MaterialTabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.mtlTextBoxNoteSelect = new MaterialSkin.Controls.MaterialMultiLineTextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tbxNewNote = new System.Windows.Forms.RichTextBox();
			this.btnAddNote = new MaterialSkin.Controls.MaterialButton();
			this.label2 = new System.Windows.Forms.Label();
			this.lstViewPatientNoteLog = new MaterialSkin.Controls.MaterialListView();
			this.lstBoxColDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.lblPatientDetails = new System.Windows.Forms.GroupBox();
			this.btnAddTreatment = new MaterialSkin.Controls.MaterialButton();
			this.dvgColAdmittion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dvgColAdmitted = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dvgColDischarged = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dvgColAppointment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dvgColPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
			lstBoxPatientDetailsView = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.dvgPatientListTable)).BeginInit();
			this.panel1.SuspendLayout();
			this.tbAddNewNote.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.lblPatientDetails.SuspendLayout();
			this.SuspendLayout();
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(3, 775);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1490, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// dvgPatientListTable
			// 
			this.dvgPatientListTable.AllowUserToOrderColumns = true;
			this.dvgPatientListTable.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dvgPatientListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvgPatientListTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgColAdmittion,
            this.dvgColAdmitted,
            this.dvgColDischarged,
            this.dvgColAppointment,
            this.dvgColPatient});
			this.dvgPatientListTable.GridColor = System.Drawing.Color.Azure;
			this.dvgPatientListTable.Location = new System.Drawing.Point(5, 65);
			this.dvgPatientListTable.Name = "dvgPatientListTable";
			this.dvgPatientListTable.Size = new System.Drawing.Size(769, 303);
			this.dvgPatientListTable.TabIndex = 4;
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
			this.panel1.TabIndex = 5;
			// 
			// tbAddNewNote
			// 
			this.tbAddNewNote.Controls.Add(this.tabPage1);
			this.tbAddNewNote.Controls.Add(this.tabPage2);
			this.tbAddNewNote.Depth = 0;
			this.tbAddNewNote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.tbAddNewNote.Location = new System.Drawing.Point(343, 40);
			this.tbAddNewNote.MouseState = MaterialSkin.MouseState.HOVER;
			this.tbAddNewNote.Multiline = true;
			this.tbAddNewNote.Name = "tbAddNewNote";
			this.tbAddNewNote.SelectedIndex = 0;
			this.tbAddNewNote.Size = new System.Drawing.Size(354, 645);
			this.tbAddNewNote.TabIndex = 7;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.tabPage1.Controls.Add(this.mtlTextBoxNoteSelect);
			this.tabPage1.Location = new System.Drawing.Point(4, 27);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(346, 614);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Selected  Note View";
			// 
			// mtlTextBoxNoteSelect
			// 
			this.mtlTextBoxNoteSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.mtlTextBoxNoteSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mtlTextBoxNoteSelect.Depth = 0;
			this.mtlTextBoxNoteSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.mtlTextBoxNoteSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.mtlTextBoxNoteSelect.Location = new System.Drawing.Point(9, 6);
			this.mtlTextBoxNoteSelect.MouseState = MaterialSkin.MouseState.HOVER;
			this.mtlTextBoxNoteSelect.Name = "mtlTextBoxNoteSelect";
			this.mtlTextBoxNoteSelect.Size = new System.Drawing.Size(331, 608);
			this.mtlTextBoxNoteSelect.TabIndex = 0;
			this.mtlTextBoxNoteSelect.Text = "";
			// 
			// tabPage2
			// 
			this.tabPage2.AllowDrop = true;
			this.tabPage2.BackColor = System.Drawing.Color.Gray;
			this.tabPage2.Controls.Add(this.tbxNewNote);
			this.tabPage2.Controls.Add(this.btnAddNote);
			this.tabPage2.Location = new System.Drawing.Point(4, 27);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tabPage2.Size = new System.Drawing.Size(346, 614);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Add New Note";
			// 
			// tbxNewNote
			// 
			this.tbxNewNote.Location = new System.Drawing.Point(6, 3);
			this.tbxNewNote.Name = "tbxNewNote";
			this.tbxNewNote.Size = new System.Drawing.Size(337, 564);
			this.tbxNewNote.TabIndex = 0;
			this.tbxNewNote.Text = "";
			// 
			// btnAddNote
			// 
			this.btnAddNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnAddNote.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.btnAddNote.Depth = 0;
			this.btnAddNote.HighEmphasis = true;
			this.btnAddNote.Icon = null;
			this.btnAddNote.Location = new System.Drawing.Point(138, 574);
			this.btnAddNote.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnAddNote.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnAddNote.Name = "btnAddNote";
			this.btnAddNote.NoAccentTextColor = System.Drawing.Color.Empty;
			this.btnAddNote.Size = new System.Drawing.Size(92, 36);
			this.btnAddNote.TabIndex = 2;
			this.btnAddNote.Text = "Add Note";
			this.btnAddNote.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.btnAddNote.UseAccentColor = false;
			this.btnAddNote.UseVisualStyleBackColor = true;
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
			this.lstBoxColDate.Width = 200;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Note Reason";
			this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader1.Width = 200;
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
			this.lblPatientDetails.Controls.Add(lstBoxPatientDetailsView);
			this.lblPatientDetails.Controls.Add(this.btnAddTreatment);
			this.lblPatientDetails.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPatientDetails.Location = new System.Drawing.Point(3, 365);
			this.lblPatientDetails.Name = "lblPatientDetails";
			this.lblPatientDetails.Size = new System.Drawing.Size(769, 407);
			this.lblPatientDetails.TabIndex = 6;
			this.lblPatientDetails.TabStop = false;
			this.lblPatientDetails.Text = "Patient Details";
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
			// lstBoxPatientDetailsView
			// 
			lstBoxPatientDetailsView.BackColor = System.Drawing.Color.LightSteelBlue;
			lstBoxPatientDetailsView.FormattingEnabled = true;
			lstBoxPatientDetailsView.ItemHeight = 25;
			lstBoxPatientDetailsView.Location = new System.Drawing.Point(18, 31);
			lstBoxPatientDetailsView.Name = "lstBoxPatientDetailsView";
			lstBoxPatientDetailsView.Size = new System.Drawing.Size(729, 304);
			lstBoxPatientDetailsView.TabIndex = 9;
			// 
			// dvgColAdmittion
			// 
			this.dvgColAdmittion.HeaderText = "Admittion Number";
			this.dvgColAdmittion.Name = "dvgColAdmittion";
			// 
			// dvgColAdmitted
			// 
			this.dvgColAdmitted.HeaderText = "Admitted ";
			this.dvgColAdmitted.Name = "dvgColAdmitted";
			// 
			// dvgColDischarged
			// 
			this.dvgColDischarged.HeaderText = "Discharged";
			this.dvgColDischarged.Name = "dvgColDischarged";
			// 
			// dvgColAppointment
			// 
			this.dvgColAppointment.HeaderText = "Appointment";
			this.dvgColAppointment.Name = "dvgColAppointment";
			// 
			// dvgColPatient
			// 
			this.dvgColPatient.HeaderText = "Patient Name";
			this.dvgColPatient.Name = "dvgColPatient";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(1496, 800);
			this.Controls.Add(this.lblPatientDetails);
			this.Controls.Add(this.dvgPatientListTable);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Sizable = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lakeridge Community Hospital";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dvgPatientListTable)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tbAddNewNote.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.lblPatientDetails.ResumeLayout(false);
			this.lblPatientDetails.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.DataGridView dvgPatientListTable;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private MaterialListView lstViewPatientNoteLog;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tabPage1;
		private MaterialMultiLineTextBox mtlTextBoxNoteSelect;
		private MaterialButton btnAddNote;
		private System.Windows.Forms.ColumnHeader lstBoxColDate;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.GroupBox lblPatientDetails;
        private MaterialButton btnAddTreatment;
        private System.Windows.Forms.RichTextBox tbxNewNote;
        public MaterialTabControl tbAddNewNote;
        public System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dvgColAdmittion;
		private System.Windows.Forms.DataGridViewTextBoxColumn dvgColAdmitted;
		private System.Windows.Forms.DataGridViewTextBoxColumn dvgColDischarged;
		private System.Windows.Forms.DataGridViewTextBoxColumn dvgColAppointment;
		private System.Windows.Forms.DataGridViewTextBoxColumn dvgColPatient;
	}
}

