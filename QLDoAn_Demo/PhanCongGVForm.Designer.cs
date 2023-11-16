namespace QLDoAn_Demo
{
	partial class PhanCongGVForm
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
			this.lvGV = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.btnPhanCong = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lvGV
			// 
			this.lvGV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvGV.FullRowSelect = true;
			this.lvGV.GridLines = true;
			this.lvGV.HideSelection = false;
			this.lvGV.Location = new System.Drawing.Point(12, 64);
			this.lvGV.MultiSelect = false;
			this.lvGV.Name = "lvGV";
			this.lvGV.Size = new System.Drawing.Size(559, 330);
			this.lvGV.TabIndex = 0;
			this.lvGV.UseCompatibleStateImageBehavior = false;
			this.lvGV.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã GV";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Họ tên";
			this.columnHeader2.Width = 250;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Ngày sinh";
			this.columnHeader3.Width = 125;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Giới tính";
			this.columnHeader4.Width = 80;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(165, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(257, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "PHÂN CÔNG GIÁO VIÊN";
			// 
			// btnPhanCong
			// 
			this.btnPhanCong.BackColor = System.Drawing.Color.LightCyan;
			this.btnPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPhanCong.Location = new System.Drawing.Point(201, 423);
			this.btnPhanCong.Name = "btnPhanCong";
			this.btnPhanCong.Size = new System.Drawing.Size(173, 39);
			this.btnPhanCong.TabIndex = 2;
			this.btnPhanCong.Text = "Phân công";
			this.btnPhanCong.UseVisualStyleBackColor = false;
			this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
			// 
			// PhanCongGVForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 474);
			this.Controls.Add(this.btnPhanCong);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lvGV);
			this.Name = "PhanCongGVForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PhanCongGVForm";
			this.Load += new System.EventHandler(this.PhanCongGVForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lvGV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button btnPhanCong;
	}
}