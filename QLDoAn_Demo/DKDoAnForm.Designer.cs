namespace QLDoAn_Demo
{
	partial class DKDoAnForm
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
			this.lvDSDetai = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnChon = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTraCuu = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnChitiet = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lvDSDetai
			// 
			this.lvDSDetai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader5});
			this.lvDSDetai.FullRowSelect = true;
			this.lvDSDetai.GridLines = true;
			this.lvDSDetai.HideSelection = false;
			this.lvDSDetai.Location = new System.Drawing.Point(65, 99);
			this.lvDSDetai.MultiSelect = false;
			this.lvDSDetai.Name = "lvDSDetai";
			this.lvDSDetai.Size = new System.Drawing.Size(730, 343);
			this.lvDSDetai.TabIndex = 0;
			this.lvDSDetai.UseCompatibleStateImageBehavior = false;
			this.lvDSDetai.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã đề tài";
			this.columnHeader1.Width = 80;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên đề tài";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 315;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Tên giáo viên hướng dẫn";
			this.columnHeader4.Width = 150;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Loại đồ án";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 80;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Trạng thái";
			this.columnHeader5.Width = 100;
			// 
			// btnChon
			// 
			this.btnChon.BackColor = System.Drawing.Color.LightCyan;
			this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChon.Location = new System.Drawing.Point(618, 463);
			this.btnChon.Name = "btnChon";
			this.btnChon.Size = new System.Drawing.Size(177, 40);
			this.btnChon.TabIndex = 1;
			this.btnChon.Text = "Chọn đề tài";
			this.btnChon.UseVisualStyleBackColor = false;
			this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(354, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "ĐĂNG KÝ ĐỒ ÁN";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(62, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Danh sách đề tài";
			// 
			// txtTraCuu
			// 
			this.txtTraCuu.Location = new System.Drawing.Point(637, 76);
			this.txtTraCuu.Name = "txtTraCuu";
			this.txtTraCuu.Size = new System.Drawing.Size(158, 20);
			this.txtTraCuu.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(575, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tên đề tài";
			// 
			// btnChitiet
			// 
			this.btnChitiet.BackColor = System.Drawing.Color.LightCyan;
			this.btnChitiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnChitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChitiet.Location = new System.Drawing.Point(75, 463);
			this.btnChitiet.Name = "btnChitiet";
			this.btnChitiet.Size = new System.Drawing.Size(177, 40);
			this.btnChitiet.TabIndex = 1;
			this.btnChitiet.Text = "Xem chi tiết";
			this.btnChitiet.UseVisualStyleBackColor = false;
			// 
			// DKDoAnForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(861, 528);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtTraCuu);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnChitiet);
			this.Controls.Add(this.btnChon);
			this.Controls.Add(this.lvDSDetai);
			this.Name = "DKDoAnForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DKDoAnForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DKDoAnForm_FormClosed);
			this.Load += new System.EventHandler(this.DKDoAnForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lvDSDetai;
		private System.Windows.Forms.Button btnChon;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTraCuu;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button btnChitiet;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
	}
}