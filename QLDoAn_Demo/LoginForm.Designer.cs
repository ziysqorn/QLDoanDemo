namespace QLDoAn_Demo
{
	partial class LoginForm
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
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.rdioBoMon = new System.Windows.Forms.RadioButton();
			this.rdioGiaoVien = new System.Windows.Forms.RadioButton();
			this.rdioSinhVien = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(64, 15);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(222, 20);
			this.txtUsername.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.rdioBoMon);
			this.panel1.Controls.Add(this.rdioGiaoVien);
			this.panel1.Controls.Add(this.rdioSinhVien);
			this.panel1.Location = new System.Drawing.Point(101, 55);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(308, 87);
			this.panel1.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Vai trò:";
			// 
			// rdioBoMon
			// 
			this.rdioBoMon.AutoSize = true;
			this.rdioBoMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdioBoMon.Location = new System.Drawing.Point(236, 14);
			this.rdioBoMon.Name = "rdioBoMon";
			this.rdioBoMon.Size = new System.Drawing.Size(67, 17);
			this.rdioBoMon.TabIndex = 0;
			this.rdioBoMon.Text = "Bộ môn";
			this.rdioBoMon.UseVisualStyleBackColor = true;
			// 
			// rdioGiaoVien
			// 
			this.rdioGiaoVien.AutoSize = true;
			this.rdioGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdioGiaoVien.Location = new System.Drawing.Point(148, 14);
			this.rdioGiaoVien.Name = "rdioGiaoVien";
			this.rdioGiaoVien.Size = new System.Drawing.Size(79, 17);
			this.rdioGiaoVien.TabIndex = 0;
			this.rdioGiaoVien.Text = "Giáo viên";
			this.rdioGiaoVien.UseVisualStyleBackColor = true;
			// 
			// rdioSinhVien
			// 
			this.rdioSinhVien.AutoSize = true;
			this.rdioSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdioSinhVien.Location = new System.Drawing.Point(64, 14);
			this.rdioSinhVien.Name = "rdioSinhVien";
			this.rdioSinhVien.Size = new System.Drawing.Size(78, 17);
			this.rdioSinhVien.TabIndex = 0;
			this.rdioSinhVien.Text = "Sinh viên";
			this.rdioSinhVien.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Username";
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.BackColor = System.Drawing.Color.LightCyan;
			this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangNhap.Location = new System.Drawing.Point(172, 177);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(162, 38);
			this.btnDangNhap.TabIndex = 0;
			this.btnDangNhap.Text = "Đăng nhập";
			this.btnDangNhap.UseVisualStyleBackColor = false;
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.txtUsername);
			this.panel2.Controls.Add(this.label1);
			this.panel2.ForeColor = System.Drawing.Color.Black;
			this.panel2.Location = new System.Drawing.Point(101, 93);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(308, 50);
			this.panel2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(191, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "ĐĂNG NHẬP";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(505, 227);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnDangNhap);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdioBoMon;
		private System.Windows.Forms.RadioButton rdioGiaoVien;
		private System.Windows.Forms.RadioButton rdioSinhVien;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnDangNhap;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
	}
}

