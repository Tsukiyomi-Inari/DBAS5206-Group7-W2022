
namespace LakeridgeCommunityHospital
{
	partial class RoomUtilizationDashboard
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.gbxRoomStats = new System.Windows.Forms.GroupBox();
			this.rtBoxStats = new MaterialSkin.Controls.MaterialMultiLineTextBox();
			this.btnAssignRoom = new MaterialSkin.Controls.MaterialButton();
			this.btnDischargeRoom = new MaterialSkin.Controls.MaterialButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BedChar = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IsOccupied = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.DateFree = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lakeRidgeHospitalDataSet = new LakeridgeCommunityHospital.LakeRidgeHospitalDataSet();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.rOOMTYPEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rOOMTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.rOOM_TYPETableAdapter = new LakeridgeCommunityHospital.LakeRidgeHospitalDataSetTableAdapters.ROOM_TYPETableAdapter();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.rOOMNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bEDCHARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eXTENSIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bEDBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bEDTableAdapter = new LakeridgeCommunityHospital.LakeRidgeHospitalDataSetTableAdapters.BEDTableAdapter();
			this.gbxRoomStats.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lakeRidgeHospitalDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rOOMTYPEBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bEDBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(3, 809);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1156, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// gbxRoomStats
			// 
			this.gbxRoomStats.Controls.Add(this.rtBoxStats);
			this.gbxRoomStats.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxRoomStats.Location = new System.Drawing.Point(684, 89);
			this.gbxRoomStats.Name = "gbxRoomStats";
			this.gbxRoomStats.Size = new System.Drawing.Size(443, 475);
			this.gbxRoomStats.TabIndex = 2;
			this.gbxRoomStats.TabStop = false;
			this.gbxRoomStats.Text = "Room Statistics";
			// 
			// rtBoxStats
			// 
			this.rtBoxStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.rtBoxStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtBoxStats.Depth = 0;
			this.rtBoxStats.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtBoxStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.rtBoxStats.Location = new System.Drawing.Point(6, 22);
			this.rtBoxStats.MouseState = MaterialSkin.MouseState.HOVER;
			this.rtBoxStats.Name = "rtBoxStats";
			this.rtBoxStats.Size = new System.Drawing.Size(431, 447);
			this.rtBoxStats.TabIndex = 5;
			this.rtBoxStats.Text = "Total Number of Bed per Room type \nSP -  5\nIC - 1\nW3 - 6\nW4- 4\nPR-1\n\n\nRoom with O" +
    "pen bed\n328 -W3\n330-W4\n102 - SP";
			// 
			// btnAssignRoom
			// 
			this.btnAssignRoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnAssignRoom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.btnAssignRoom.Depth = 0;
			this.btnAssignRoom.HighEmphasis = true;
			this.btnAssignRoom.Icon = null;
			this.btnAssignRoom.Location = new System.Drawing.Point(986, 664);
			this.btnAssignRoom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnAssignRoom.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnAssignRoom.Name = "btnAssignRoom";
			this.btnAssignRoom.NoAccentTextColor = System.Drawing.Color.Empty;
			this.btnAssignRoom.Size = new System.Drawing.Size(119, 36);
			this.btnAssignRoom.TabIndex = 3;
			this.btnAssignRoom.Text = "Assign Room";
			this.btnAssignRoom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.btnAssignRoom.UseAccentColor = false;
			this.btnAssignRoom.UseVisualStyleBackColor = true;
			// 
			// btnDischargeRoom
			// 
			this.btnDischargeRoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnDischargeRoom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.btnDischargeRoom.Depth = 0;
			this.btnDischargeRoom.HighEmphasis = true;
			this.btnDischargeRoom.Icon = null;
			this.btnDischargeRoom.Location = new System.Drawing.Point(814, 664);
			this.btnDischargeRoom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnDischargeRoom.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnDischargeRoom.Name = "btnDischargeRoom";
			this.btnDischargeRoom.NoAccentTextColor = System.Drawing.Color.Empty;
			this.btnDischargeRoom.Size = new System.Drawing.Size(148, 36);
			this.btnDischargeRoom.TabIndex = 4;
			this.btnDischargeRoom.Text = "Discharge Room";
			this.btnDischargeRoom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.btnDischargeRoom.UseAccentColor = false;
			this.btnDischargeRoom.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.BedChar,
            this.RoomType,
            this.IsOccupied,
            this.DateFree});
			this.dataGridView1.Location = new System.Drawing.Point(15, 99);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(649, 465);
			this.dataGridView1.TabIndex = 0;
			// 
			// RoomNumber
			// 
			this.RoomNumber.DataPropertyName = "ROOM_NUMBER";
			this.RoomNumber.HeaderText = "Room #";
			this.RoomNumber.Name = "RoomNumber";
			this.RoomNumber.ReadOnly = true;
			this.RoomNumber.Width = 150;
			// 
			// BedChar
			// 
			this.BedChar.DataPropertyName = "BED_CHAR";
			this.BedChar.HeaderText = "Bed";
			this.BedChar.Name = "BedChar";
			this.BedChar.ReadOnly = true;
			this.BedChar.Width = 120;
			// 
			// RoomType
			// 
			this.RoomType.DataPropertyName = "ROOM_TYPE_NUMBER";
			this.RoomType.HeaderText = "Room Type";
			this.RoomType.Name = "RoomType";
			this.RoomType.ReadOnly = true;
			// 
			// IsOccupied
			// 
			this.IsOccupied.HeaderText = "Is Occupied";
			this.IsOccupied.Name = "IsOccupied";
			this.IsOccupied.ReadOnly = true;
			// 
			// DateFree
			// 
			this.DateFree.HeaderText = "Discharge Date";
			this.DateFree.Name = "DateFree";
			this.DateFree.ReadOnly = true;
			this.DateFree.Width = 150;
			// 
			// lakeRidgeHospitalDataSet
			// 
			this.lakeRidgeHospitalDataSet.DataSetName = "LakeRidgeHospitalDataSet";
			this.lakeRidgeHospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rOOMTYPEIDDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.rOOMTYPEBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(25, 587);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(255, 150);
			this.dataGridView2.TabIndex = 5;
			// 
			// rOOMTYPEIDDataGridViewTextBoxColumn
			// 
			this.rOOMTYPEIDDataGridViewTextBoxColumn.DataPropertyName = "ROOM_TYPE_ID";
			this.rOOMTYPEIDDataGridViewTextBoxColumn.HeaderText = "ROOM_TYPE_ID";
			this.rOOMTYPEIDDataGridViewTextBoxColumn.Name = "rOOMTYPEIDDataGridViewTextBoxColumn";
			this.rOOMTYPEIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dESCRIPTIONDataGridViewTextBoxColumn
			// 
			this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
			this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
			this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
			this.dESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// rOOMTYPEBindingSource
			// 
			this.rOOMTYPEBindingSource.DataMember = "ROOM_TYPE";
			this.rOOMTYPEBindingSource.DataSource = this.lakeRidgeHospitalDataSet;
			// 
			// rOOM_TYPETableAdapter
			// 
			this.rOOM_TYPETableAdapter.ClearBeforeFill = true;
			// 
			// dataGridView3
			// 
			this.dataGridView3.AllowUserToAddRows = false;
			this.dataGridView3.AllowUserToDeleteRows = false;
			this.dataGridView3.AutoGenerateColumns = false;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rOOMNUMBERDataGridViewTextBoxColumn,
            this.bEDCHARDataGridViewTextBoxColumn,
            this.eXTENSIONDataGridViewTextBoxColumn});
			this.dataGridView3.DataSource = this.bEDBindingSource;
			this.dataGridView3.Location = new System.Drawing.Point(375, 634);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.ReadOnly = true;
			this.dataGridView3.Size = new System.Drawing.Size(383, 150);
			this.dataGridView3.TabIndex = 6;
			// 
			// rOOMNUMBERDataGridViewTextBoxColumn
			// 
			this.rOOMNUMBERDataGridViewTextBoxColumn.DataPropertyName = "ROOM_NUMBER";
			this.rOOMNUMBERDataGridViewTextBoxColumn.HeaderText = "ROOM_NUMBER";
			this.rOOMNUMBERDataGridViewTextBoxColumn.Name = "rOOMNUMBERDataGridViewTextBoxColumn";
			this.rOOMNUMBERDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bEDCHARDataGridViewTextBoxColumn
			// 
			this.bEDCHARDataGridViewTextBoxColumn.DataPropertyName = "BED_CHAR";
			this.bEDCHARDataGridViewTextBoxColumn.HeaderText = "BED_CHAR";
			this.bEDCHARDataGridViewTextBoxColumn.Name = "bEDCHARDataGridViewTextBoxColumn";
			this.bEDCHARDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// eXTENSIONDataGridViewTextBoxColumn
			// 
			this.eXTENSIONDataGridViewTextBoxColumn.DataPropertyName = "EXTENSION";
			this.eXTENSIONDataGridViewTextBoxColumn.HeaderText = "EXTENSION";
			this.eXTENSIONDataGridViewTextBoxColumn.Name = "eXTENSIONDataGridViewTextBoxColumn";
			this.eXTENSIONDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bEDBindingSource
			// 
			this.bEDBindingSource.DataMember = "BED";
			this.bEDBindingSource.DataSource = this.lakeRidgeHospitalDataSet;
			// 
			// bEDTableAdapter
			// 
			this.bEDTableAdapter.ClearBeforeFill = true;
			// 
			// RoomUtilizationDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1162, 834);
			this.Controls.Add(this.dataGridView3);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnDischargeRoom);
			this.Controls.Add(this.btnAssignRoom);
			this.Controls.Add(this.gbxRoomStats);
			this.Controls.Add(this.statusStrip1);
			this.Name = "RoomUtilizationDashboard";
			this.Text = "Room Utilization Dashboard";
			this.Load += new System.EventHandler(this.RoomUtilizationDashboard_Load);
			this.gbxRoomStats.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lakeRidgeHospitalDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rOOMTYPEBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bEDBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.GroupBox gbxRoomStats;
        private MaterialSkin.Controls.MaterialButton btnAssignRoom;
        private MaterialSkin.Controls.MaterialButton btnDischargeRoom;
        private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn BedChar;
		private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
		private System.Windows.Forms.DataGridViewCheckBoxColumn IsOccupied;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateFree;
		private MaterialSkin.Controls.MaterialMultiLineTextBox rtBoxStats;
		private LakeRidgeHospitalDataSet lakeRidgeHospitalDataSet;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.BindingSource rOOMTYPEBindingSource;
		private LakeRidgeHospitalDataSetTableAdapters.ROOM_TYPETableAdapter rOOM_TYPETableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn rOOMTYPEIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.BindingSource bEDBindingSource;
		private LakeRidgeHospitalDataSetTableAdapters.BEDTableAdapter bEDTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn rOOMNUMBERDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bEDCHARDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn eXTENSIONDataGridViewTextBoxColumn;
	}
}