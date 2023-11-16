namespace QLDoAn_Demo
{
	partial class TrangchuSVForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnNop = new System.Windows.Forms.Button();
			this.btnTaiTailieu = new System.Windows.Forms.Button();
			this.btnTaiYeucau = new System.Windows.Forms.Button();
			this.btnBrowseFile = new System.Windows.Forms.Button();
			this.txtSTT = new System.Windows.Forms.TextBox();
			this.txtTenNhom = new System.Windows.Forms.TextBox();
			this.txtTenDeTai = new System.Windows.Forms.TextBox();
			this.txtNoidung = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label10 = new System.Windows.Forms.Label();
			this.txtTenYeucau = new System.Windows.Forms.TextBox();
			this.txtTentailieu = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(346, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(251, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "TRANG CHỦ SINH VIÊN";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 55);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(919, 449);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.btnNop);
			this.tabPage1.Controls.Add(this.btnTaiTailieu);
			this.tabPage1.Controls.Add(this.btnTaiYeucau);
			this.tabPage1.Controls.Add(this.btnBrowseFile);
			this.tabPage1.Controls.Add(this.txtSTT);
			this.tabPage1.Controls.Add(this.txtTenYeucau);
			this.tabPage1.Controls.Add(this.txtTentailieu);
			this.tabPage1.Controls.Add(this.txtTenNhom);
			this.tabPage1.Controls.Add(this.txtTenDeTai);
			this.tabPage1.Controls.Add(this.txtNoidung);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(911, 423);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Quyển đồ án";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnNop
			// 
			this.btnNop.BackColor = System.Drawing.Color.LightCyan;
			this.btnNop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnNop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNop.Location = new System.Drawing.Point(371, 367);
			this.btnNop.Name = "btnNop";
			this.btnNop.Size = new System.Drawing.Size(175, 40);
			this.btnNop.TabIndex = 2;
			this.btnNop.Text = "Nộp quyển đồ án";
			this.btnNop.UseVisualStyleBackColor = false;
			this.btnNop.Click += new System.EventHandler(this.btnNop_Click);
			// 
			// btnTaiTailieu
			// 
			this.btnTaiTailieu.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnTaiTailieu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnTaiTailieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTaiTailieu.Location = new System.Drawing.Point(587, 193);
			this.btnTaiTailieu.Name = "btnTaiTailieu";
			this.btnTaiTailieu.Size = new System.Drawing.Size(141, 27);
			this.btnTaiTailieu.TabIndex = 2;
			this.btnTaiTailieu.Text = "Tải file";
			this.btnTaiTailieu.UseVisualStyleBackColor = false;
			this.btnTaiTailieu.Click += new System.EventHandler(this.btnTaiTailieu_Click);
			// 
			// btnTaiYeucau
			// 
			this.btnTaiYeucau.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnTaiYeucau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnTaiYeucau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTaiYeucau.Location = new System.Drawing.Point(587, 77);
			this.btnTaiYeucau.Name = "btnTaiYeucau";
			this.btnTaiYeucau.Size = new System.Drawing.Size(141, 27);
			this.btnTaiYeucau.TabIndex = 2;
			this.btnTaiYeucau.Text = "Tải file";
			this.btnTaiYeucau.UseVisualStyleBackColor = false;
			this.btnTaiYeucau.Click += new System.EventHandler(this.btnTaiYeucau_Click);
			// 
			// btnBrowseFile
			// 
			this.btnBrowseFile.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnBrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBrowseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBrowseFile.Location = new System.Drawing.Point(87, 280);
			this.btnBrowseFile.Name = "btnBrowseFile";
			this.btnBrowseFile.Size = new System.Drawing.Size(106, 27);
			this.btnBrowseFile.TabIndex = 2;
			this.btnBrowseFile.Text = "Đính kèm file";
			this.btnBrowseFile.UseVisualStyleBackColor = false;
			this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
			// 
			// txtSTT
			// 
			this.txtSTT.Enabled = false;
			this.txtSTT.Location = new System.Drawing.Point(87, 40);
			this.txtSTT.Name = "txtSTT";
			this.txtSTT.Size = new System.Drawing.Size(285, 20);
			this.txtSTT.TabIndex = 1;
			// 
			// txtTenNhom
			// 
			this.txtTenNhom.Enabled = false;
			this.txtTenNhom.Location = new System.Drawing.Point(87, 183);
			this.txtTenNhom.Name = "txtTenNhom";
			this.txtTenNhom.Size = new System.Drawing.Size(285, 20);
			this.txtTenNhom.TabIndex = 1;
			// 
			// txtTenDeTai
			// 
			this.txtTenDeTai.Enabled = false;
			this.txtTenDeTai.Location = new System.Drawing.Point(87, 113);
			this.txtTenDeTai.Name = "txtTenDeTai";
			this.txtTenDeTai.Size = new System.Drawing.Size(285, 20);
			this.txtTenDeTai.TabIndex = 1;
			// 
			// txtNoidung
			// 
			this.txtNoidung.Location = new System.Drawing.Point(87, 254);
			this.txtNoidung.Name = "txtNoidung";
			this.txtNoidung.ReadOnly = true;
			this.txtNoidung.Size = new System.Drawing.Size(142, 20);
			this.txtNoidung.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(457, 159);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(124, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "Tài liệu tham khảo";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(482, 41);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Yêu cầu đề tài";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(9, 183);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Tên nhóm";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 255);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Nội dung ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Tên đề tài";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(46, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "STT";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(911, 423);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Nhóm sinh viên";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(235, 257);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(137, 13);
			this.label10.TabIndex = 5;
			this.label10.Text = "Chỉ nhận file định dạng .pdf";
			// 
			// txtTenYeucau
			// 
			this.txtTenYeucau.Location = new System.Drawing.Point(587, 41);
			this.txtTenYeucau.Name = "txtTenYeucau";
			this.txtTenYeucau.ReadOnly = true;
			this.txtTenYeucau.Size = new System.Drawing.Size(196, 20);
			this.txtTenYeucau.TabIndex = 1;
			// 
			// txtTentailieu
			// 
			this.txtTentailieu.Location = new System.Drawing.Point(587, 159);
			this.txtTentailieu.Name = "txtTentailieu";
			this.txtTentailieu.ReadOnly = true;
			this.txtTentailieu.Size = new System.Drawing.Size(196, 20);
			this.txtTentailieu.TabIndex = 1;
			// 
			// TrangchuSVForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(943, 566);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label1);
			this.Name = "TrangchuSVForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TrangchuSVForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrangchuSVForm_FormClosed);
			this.Load += new System.EventHandler(this.TrangchuSVForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnBrowseFile;
		private System.Windows.Forms.TextBox txtSTT;
		private System.Windows.Forms.TextBox txtTenNhom;
		private System.Windows.Forms.TextBox txtTenDeTai;
		private System.Windows.Forms.TextBox txtNoidung;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnNop;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnTaiTailieu;
		private System.Windows.Forms.Button btnTaiYeucau;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtTenYeucau;
		private System.Windows.Forms.TextBox txtTentailieu;
	}
}