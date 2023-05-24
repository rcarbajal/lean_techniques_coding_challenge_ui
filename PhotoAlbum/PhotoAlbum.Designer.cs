namespace PhotoAlbum
{
	partial class PhotoAlbum
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
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.dgvPhotos = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblSearch = new System.Windows.Forms.Label();
			this.lblMessage = new System.Windows.Forms.Label();
			this.lblRecordCount = new System.Windows.Forms.Label();
			this.picPhoto = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.grpResults = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhotos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
			this.grpResults.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(12, 35);
			this.txtSearch.MaxLength = 5;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(112, 20);
			this.txtSearch.TabIndex = 1;
			this.txtSearch.WordWrap = false;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(130, 32);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// dgvPhotos
			// 
			this.dgvPhotos.AllowUserToAddRows = false;
			this.dgvPhotos.AllowUserToDeleteRows = false;
			this.dgvPhotos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvPhotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPhotos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.URL});
			this.dgvPhotos.Location = new System.Drawing.Point(6, 19);
			this.dgvPhotos.MultiSelect = false;
			this.dgvPhotos.Name = "dgvPhotos";
			this.dgvPhotos.ReadOnly = true;
			this.dgvPhotos.Size = new System.Drawing.Size(695, 337);
			this.dgvPhotos.TabIndex = 3;
			this.dgvPhotos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhotos_CellContentClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 43;
			// 
			// Title
			// 
			this.Title.HeaderText = "Title";
			this.Title.Name = "Title";
			this.Title.ReadOnly = true;
			this.Title.Width = 52;
			// 
			// URL
			// 
			this.URL.HeaderText = "URL";
			this.URL.Name = "URL";
			this.URL.ReadOnly = true;
			this.URL.Width = 54;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Location = new System.Drawing.Point(9, 18);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(102, 13);
			this.lblSearch.TabIndex = 4;
			this.lblSearch.Text = "Search By Album ID";
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.ForeColor = System.Drawing.Color.Red;
			this.lblMessage.Location = new System.Drawing.Point(211, 38);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(70, 13);
			this.lblMessage.TabIndex = 5;
			this.lblMessage.Text = "Message text";
			this.lblMessage.Visible = false;
			// 
			// lblRecordCount
			// 
			this.lblRecordCount.AutoSize = true;
			this.lblRecordCount.Location = new System.Drawing.Point(612, 359);
			this.lblRecordCount.Name = "lblRecordCount";
			this.lblRecordCount.Size = new System.Drawing.Size(89, 13);
			this.lblRecordCount.TabIndex = 6;
			this.lblRecordCount.Text = "Records found: 0";
			// 
			// picPhoto
			// 
			this.picPhoto.Location = new System.Drawing.Point(710, 71);
			this.picPhoto.Name = "picPhoto";
			this.picPhoto.Size = new System.Drawing.Size(219, 219);
			this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picPhoto.TabIndex = 7;
			this.picPhoto.TabStop = false;
			this.picPhoto.Visible = false;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoEllipsis = true;
			this.lblTitle.Location = new System.Drawing.Point(707, 19);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(222, 13);
			this.lblTitle.TabIndex = 8;
			this.lblTitle.Text = "Title";
			this.lblTitle.Visible = false;
			// 
			// grpResults
			// 
			this.grpResults.Controls.Add(this.dgvPhotos);
			this.grpResults.Controls.Add(this.lblRecordCount);
			this.grpResults.Controls.Add(this.lblTitle);
			this.grpResults.Controls.Add(this.picPhoto);
			this.grpResults.Location = new System.Drawing.Point(12, 73);
			this.grpResults.Name = "grpResults";
			this.grpResults.Size = new System.Drawing.Size(935, 379);
			this.grpResults.TabIndex = 9;
			this.grpResults.TabStop = false;
			this.grpResults.Text = "Search Results";
			this.grpResults.Visible = false;
			// 
			// PhotoAlbum
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(959, 464);
			this.Controls.Add(this.grpResults);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearch);
			this.Name = "PhotoAlbum";
			this.Text = "Lean Techniques Showcase: Photo Album";
			((System.ComponentModel.ISupportInitialize)(this.dgvPhotos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
			this.grpResults.ResumeLayout(false);
			this.grpResults.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.DataGridView dgvPhotos;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Title;
		private System.Windows.Forms.DataGridViewTextBoxColumn URL;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Label lblRecordCount;
		private System.Windows.Forms.PictureBox picPhoto;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.GroupBox grpResults;
	}
}

