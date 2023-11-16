namespace QLDoAn_Demo
{
	partial class ThemTVForm
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
			this.lvSV = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvTV = new System.Windows.Forms.ListView();
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txtTenNhom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnThemTV = new System.Windows.Forms.Button();
			this.btnXoaTV = new System.Windows.Forms.Button();
			this.btnXacNhan = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lvSV
			// 
			this.lvSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvSV.FullRowSelect = true;
			this.lvSV.GridLines = true;
			this.lvSV.HideSelection = false;
			this.lvSV.Location = new System.Drawing.Point(12, 91);
			this.lvSV.MultiSelect = false;
			this.lvSV.Name = "lvSV";
			this.lvSV.Size = new System.Drawing.Size(405, 380);
			this.lvSV.TabIndex = 0;
			this.lvSV.UseCompatibleStateImageBehavior = false;
			this.lvSV.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "MSSV";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Họ tên";
			this.columnHeader2.Width = 120;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Ngày sinh";
			this.columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Giới tính";
			this.columnHeader4.Width = 80;
			// 
			// lvTV
			// 
			this.lvTV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
			this.lvTV.FullRowSelect = true;
			this.lvTV.GridLines = true;
			this.lvTV.HideSelection = false;
			this.lvTV.Location = new System.Drawing.Point(613, 182);
			this.lvTV.MultiSelect = false;
			this.lvTV.Name = "lvTV";
			this.lvTV.Size = new System.Drawing.Size(404, 75);
			this.lvTV.TabIndex = 0;
			this.lvTV.UseCompatibleStateImageBehavior = false;
			this.lvTV.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "MSSV";
			this.columnHeader5.Width = 100;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Họ tên";
			this.columnHeader6.Width = 120;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Ngày sinh";
			this.columnHeader7.Width = 100;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Giới tính";
			this.columnHeader8.Width = 80;
			// 
			// txtTenNhom
			// 
			this.txtTenNhom.Location = new System.Drawing.Point(613, 127);
			this.txtTenNhom.Name = "txtTenNhom";
			this.txtTenNhom.Size = new System.Drawing.Size(235, 20);
			this.txtTenNhom.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(610, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tên nhóm";
			// 
			// btnThemTV
			// 
			this.btnThemTV.BackColor = System.Drawing.Color.LightCyan;
			this.btnThemTV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnThemTV.Location = new System.Drawing.Point(444, 186);
			this.btnThemTV.Name = "btnThemTV";
			this.btnThemTV.Size = new System.Drawing.Size(137, 41);
			this.btnThemTV.TabIndex = 3;
			this.btnThemTV.Text = "Thêm thành viên";
			this.btnThemTV.UseVisualStyleBackColor = false;
			this.btnThemTV.Click += new System.EventHandler(this.btnThemTV_Click);
			// 
			// btnXoaTV
			// 
			this.btnXoaTV.BackColor = System.Drawing.Color.LightCyan;
			this.btnXoaTV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnXoaTV.Location = new System.Drawing.Point(855, 298);
			this.btnXoaTV.Name = "btnXoaTV";
			this.btnXoaTV.Size = new System.Drawing.Size(162, 41);
			this.btnXoaTV.TabIndex = 3;
			this.btnXoaTV.Text = "Xóa thành viên";
			this.btnXoaTV.UseVisualStyleBackColor = false;
			this.btnXoaTV.Click += new System.EventHandler(this.btnXoaTV_Click);
			// 
			// btnXacNhan
			// 
			this.btnXacNhan.BackColor = System.Drawing.Color.LightCyan;
			this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnXacNhan.Location = new System.Drawing.Point(613, 298);
			this.btnXacNhan.Name = "btnXacNhan";
			this.btnXacNhan.Size = new System.Drawing.Size(162, 41);
			this.btnXacNhan.TabIndex = 3;
			this.btnXacNhan.Text = "Xác nhận đăng ký nhóm";
			this.btnXacNhan.UseVisualStyleBackColor = false;
			this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(389, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(280, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "THÊM THÀNH VIÊN NHÓM";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(175, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Danh sách sinh viên chưa có nhóm";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(610, 166);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Danh sách thành viên";
			// 
			// ThemTVForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1033, 483);
			this.Controls.Add(this.btnXacNhan);
			this.Controls.Add(this.btnXoaTV);
			this.Controls.Add(this.btnThemTV);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTenNhom);
			this.Controls.Add(this.lvTV);
			this.Controls.Add(this.lvSV);
			this.Name = "ThemTVForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ThemTVForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThemTVForm_FormClosed);
			this.Load += new System.EventHandler(this.ThemTVForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lvSV;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ListView lvTV;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.TextBox txtTenNhom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnThemTV;
		private System.Windows.Forms.Button btnXoaTV;
		private System.Windows.Forms.Button btnXacNhan;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}