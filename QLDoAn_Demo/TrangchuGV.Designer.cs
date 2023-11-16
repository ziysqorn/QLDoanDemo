namespace QLDoAn_Demo
{
	partial class TrangchuGV
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
			this.lvDetai = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label2 = new System.Windows.Forms.Label();
			this.txtTendetai = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTailieu = new System.Windows.Forms.TextBox();
			this.txtNoidung = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnNopDeTai = new System.Windows.Forms.Button();
			this.btnBrowseYeuCau = new System.Windows.Forms.Button();
			this.btnBrowseTailieu = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.cbbLoaiDoan = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnNopketqua = new System.Windows.Forms.Button();
			this.btnDownload = new System.Windows.Forms.Button();
			this.btnChoDiem = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.txtDiem = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lvQuyenDoAn = new System.Windows.Forms.ListView();
			this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label9 = new System.Windows.Forms.Label();
			this.lvNhom = new System.Windows.Forms.ListView();
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvDetai
			// 
			this.lvDetai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvDetai.FullRowSelect = true;
			this.lvDetai.GridLines = true;
			this.lvDetai.HideSelection = false;
			this.lvDetai.Location = new System.Drawing.Point(12, 58);
			this.lvDetai.Name = "lvDetai";
			this.lvDetai.Size = new System.Drawing.Size(652, 280);
			this.lvDetai.TabIndex = 1;
			this.lvDetai.UseCompatibleStateImageBehavior = false;
			this.lvDetai.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã đề tài";
			this.columnHeader1.Width = 80;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên đề tài";
			this.columnHeader2.Width = 400;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Loại đồ án";
			this.columnHeader3.Width = 73;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Trạng thái";
			this.columnHeader4.Width = 100;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Danh sách đề tài đã ra";
			// 
			// txtTendetai
			// 
			this.txtTendetai.Location = new System.Drawing.Point(797, 55);
			this.txtTendetai.Name = "txtTendetai";
			this.txtTendetai.Size = new System.Drawing.Size(331, 20);
			this.txtTendetai.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(735, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tên đề tài";
			// 
			// txtTailieu
			// 
			this.txtTailieu.Location = new System.Drawing.Point(797, 179);
			this.txtTailieu.Name = "txtTailieu";
			this.txtTailieu.ReadOnly = true;
			this.txtTailieu.Size = new System.Drawing.Size(187, 20);
			this.txtTailieu.TabIndex = 3;
			// 
			// txtNoidung
			// 
			this.txtNoidung.Location = new System.Drawing.Point(797, 108);
			this.txtNoidung.Name = "txtNoidung";
			this.txtNoidung.ReadOnly = true;
			this.txtNoidung.Size = new System.Drawing.Size(187, 20);
			this.txtNoidung.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(670, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Nội dung yêu cầu đề tài";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(697, 179);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Tài liệu tham khảo";
			// 
			// btnNopDeTai
			// 
			this.btnNopDeTai.BackColor = System.Drawing.Color.LightCyan;
			this.btnNopDeTai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnNopDeTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNopDeTai.Location = new System.Drawing.Point(454, 369);
			this.btnNopDeTai.Name = "btnNopDeTai";
			this.btnNopDeTai.Size = new System.Drawing.Size(210, 47);
			this.btnNopDeTai.TabIndex = 5;
			this.btnNopDeTai.Text = "Xóa đề tài";
			this.btnNopDeTai.UseVisualStyleBackColor = false;
			// 
			// btnBrowseYeuCau
			// 
			this.btnBrowseYeuCau.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnBrowseYeuCau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBrowseYeuCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBrowseYeuCau.Location = new System.Drawing.Point(797, 134);
			this.btnBrowseYeuCau.Name = "btnBrowseYeuCau";
			this.btnBrowseYeuCau.Size = new System.Drawing.Size(103, 26);
			this.btnBrowseYeuCau.TabIndex = 5;
			this.btnBrowseYeuCau.Text = "Đính kèm file";
			this.btnBrowseYeuCau.UseVisualStyleBackColor = false;
			this.btnBrowseYeuCau.Click += new System.EventHandler(this.btnBrowseYeuCau_Click);
			// 
			// btnBrowseTailieu
			// 
			this.btnBrowseTailieu.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnBrowseTailieu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBrowseTailieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBrowseTailieu.Location = new System.Drawing.Point(797, 205);
			this.btnBrowseTailieu.Name = "btnBrowseTailieu";
			this.btnBrowseTailieu.Size = new System.Drawing.Size(103, 26);
			this.btnBrowseTailieu.TabIndex = 5;
			this.btnBrowseTailieu.Text = "Đính kèm file";
			this.btnBrowseTailieu.UseVisualStyleBackColor = false;
			this.btnBrowseTailieu.Click += new System.EventHandler(this.btnBrowseTailieu_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.LightCyan;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(12, 369);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(210, 47);
			this.button4.TabIndex = 5;
			this.button4.Text = "Xem chi tiết";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// cbbLoaiDoan
			// 
			this.cbbLoaiDoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbLoaiDoan.FormattingEnabled = true;
			this.cbbLoaiDoan.Items.AddRange(new object[] {
            "LDA1",
            "LDA2",
            "LDA3"});
			this.cbbLoaiDoan.Location = new System.Drawing.Point(797, 261);
			this.cbbLoaiDoan.Name = "cbbLoaiDoan";
			this.cbbLoaiDoan.Size = new System.Drawing.Size(331, 21);
			this.cbbLoaiDoan.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(733, 261);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Loại đồ án";
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.LightCyan;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(974, 318);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(153, 47);
			this.button5.TabIndex = 5;
			this.button5.Text = "Sửa đề tài";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.LightCyan;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(755, 318);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(161, 47);
			this.button6.TabIndex = 5;
			this.button6.Text = "Nộp đề tài";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.btnNopDeTai_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(3, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1152, 448);
			this.tabControl1.TabIndex = 7;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button5);
			this.tabPage1.Controls.Add(this.cbbLoaiDoan);
			this.tabPage1.Controls.Add(this.btnNopDeTai);
			this.tabPage1.Controls.Add(this.btnBrowseTailieu);
			this.tabPage1.Controls.Add(this.button6);
			this.tabPage1.Controls.Add(this.btnBrowseYeuCau);
			this.tabPage1.Controls.Add(this.button4);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.lvDetai);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.txtTendetai);
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.txtTailieu);
			this.tabPage1.Controls.Add(this.txtNoidung);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1144, 422);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Ra đề tài";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.ForeColor = System.Drawing.Color.Red;
			this.label11.Location = new System.Drawing.Point(990, 182);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(137, 13);
			this.label11.TabIndex = 4;
			this.label11.Text = "Chỉ nhận file định dạng .pdf";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(990, 111);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(137, 13);
			this.label10.TabIndex = 4;
			this.label10.Text = "Chỉ nhận file định dạng .pdf";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnNopketqua);
			this.tabPage2.Controls.Add(this.btnDownload);
			this.tabPage2.Controls.Add(this.btnChoDiem);
			this.tabPage2.Controls.Add(this.textBox1);
			this.tabPage2.Controls.Add(this.txtDiem);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.lvQuyenDoAn);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1144, 422);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Chấm điểm đồ án";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnNopketqua
			// 
			this.btnNopketqua.BackColor = System.Drawing.Color.LightCyan;
			this.btnNopketqua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnNopketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNopketqua.Location = new System.Drawing.Point(499, 367);
			this.btnNopketqua.Name = "btnNopketqua";
			this.btnNopketqua.Size = new System.Drawing.Size(156, 39);
			this.btnNopketqua.TabIndex = 6;
			this.btnNopketqua.Text = "Nộp kết quả";
			this.btnNopketqua.UseVisualStyleBackColor = false;
			this.btnNopketqua.Click += new System.EventHandler(this.btnNopketqua_Click);
			// 
			// btnDownload
			// 
			this.btnDownload.BackColor = System.Drawing.Color.LightCyan;
			this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDownload.Location = new System.Drawing.Point(6, 367);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(210, 39);
			this.btnDownload.TabIndex = 6;
			this.btnDownload.Text = "Tải nội dung quyển đồ án";
			this.btnDownload.UseVisualStyleBackColor = false;
			this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// btnChoDiem
			// 
			this.btnChoDiem.BackColor = System.Drawing.Color.LightCyan;
			this.btnChoDiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnChoDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChoDiem.Location = new System.Drawing.Point(829, 108);
			this.btnChoDiem.Name = "btnChoDiem";
			this.btnChoDiem.Size = new System.Drawing.Size(134, 39);
			this.btnChoDiem.TabIndex = 6;
			this.btnChoDiem.Text = "Cho điểm";
			this.btnChoDiem.UseVisualStyleBackColor = false;
			this.btnChoDiem.Click += new System.EventHandler(this.btnChoDiem_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(521, 43);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(134, 20);
			this.textBox1.TabIndex = 5;
			// 
			// txtDiem
			// 
			this.txtDiem.Location = new System.Drawing.Point(788, 82);
			this.txtDiem.Name = "txtDiem";
			this.txtDiem.Size = new System.Drawing.Size(225, 20);
			this.txtDiem.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(460, 46);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Tên nhóm";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(785, 66);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(31, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Điểm";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(259, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Danh sách quyển đồ án được phân công chấm điểm";
			// 
			// lvQuyenDoAn
			// 
			this.lvQuyenDoAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader15});
			this.lvQuyenDoAn.FullRowSelect = true;
			this.lvQuyenDoAn.GridLines = true;
			this.lvQuyenDoAn.HideSelection = false;
			this.lvQuyenDoAn.Location = new System.Drawing.Point(6, 66);
			this.lvQuyenDoAn.MultiSelect = false;
			this.lvQuyenDoAn.Name = "lvQuyenDoAn";
			this.lvQuyenDoAn.Size = new System.Drawing.Size(649, 295);
			this.lvQuyenDoAn.TabIndex = 3;
			this.lvQuyenDoAn.UseCompatibleStateImageBehavior = false;
			this.lvQuyenDoAn.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "STT";
			this.columnHeader11.Width = 80;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Tên đề tài";
			this.columnHeader12.Width = 325;
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "Tên nhóm";
			this.columnHeader13.Width = 160;
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "Điểm";
			this.columnHeader15.Width = 80;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.lvNhom);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tabPage3.Size = new System.Drawing.Size(1144, 422);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Nhóm sinh viên hướng dẫn";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(309, 25);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(534, 25);
			this.label9.TabIndex = 2;
			this.label9.Text = "Danh sách nhóm sinh viên được phân công hướng dẫn";
			// 
			// lvNhom
			// 
			this.lvNhom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8});
			this.lvNhom.FullRowSelect = true;
			this.lvNhom.GridLines = true;
			this.lvNhom.HideSelection = false;
			this.lvNhom.Location = new System.Drawing.Point(314, 77);
			this.lvNhom.MultiSelect = false;
			this.lvNhom.Name = "lvNhom";
			this.lvNhom.Size = new System.Drawing.Size(529, 328);
			this.lvNhom.TabIndex = 1;
			this.lvNhom.UseCompatibleStateImageBehavior = false;
			this.lvNhom.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Mã nhóm";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Tên nhóm";
			this.columnHeader6.Width = 150;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Tên đề tài";
			this.columnHeader8.Width = 315;
			// 
			// TrangchuGV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1155, 467);
			this.Controls.Add(this.tabControl1);
			this.Name = "TrangchuGV";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Trang chủ";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RaDetaiForm_FormClosed);
			this.Load += new System.EventHandler(this.RaDetaiForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ListView lvDetai;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTendetai;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTailieu;
		private System.Windows.Forms.TextBox txtNoidung;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnNopDeTai;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button btnBrowseYeuCau;
		private System.Windows.Forms.Button btnBrowseTailieu;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ComboBox cbbLoaiDoan;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView lvQuyenDoAn;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.TextBox txtDiem;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnChoDiem;
		private System.Windows.Forms.Button btnNopketqua;
		private System.Windows.Forms.Button btnDownload;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.ListView lvNhom;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
	}
}