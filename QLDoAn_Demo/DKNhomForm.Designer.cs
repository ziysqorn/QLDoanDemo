namespace QLDoAn_Demo
{
	partial class DKNhomForm
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
			this.lvNhom = new System.Windows.Forms.ListView();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnTaoNhom = new System.Windows.Forms.Button();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// lvNhom
			// 
			this.lvNhom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvNhom.FullRowSelect = true;
			this.lvNhom.GridLines = true;
			this.lvNhom.HideSelection = false;
			this.lvNhom.Location = new System.Drawing.Point(69, 75);
			this.lvNhom.MultiSelect = false;
			this.lvNhom.Name = "lvNhom";
			this.lvNhom.Size = new System.Drawing.Size(680, 317);
			this.lvNhom.TabIndex = 0;
			this.lvNhom.UseCompatibleStateImageBehavior = false;
			this.lvNhom.View = System.Windows.Forms.View.Details;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightCyan;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(204, 422);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(137, 45);
			this.button1.TabIndex = 1;
			this.button1.Text = "Yêu cầu tham gia";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(307, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "ĐĂNG KÝ NHÓM";
			// 
			// btnTaoNhom
			// 
			this.btnTaoNhom.BackColor = System.Drawing.Color.LightCyan;
			this.btnTaoNhom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnTaoNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTaoNhom.Location = new System.Drawing.Point(449, 422);
			this.btnTaoNhom.Name = "btnTaoNhom";
			this.btnTaoNhom.Size = new System.Drawing.Size(137, 45);
			this.btnTaoNhom.TabIndex = 1;
			this.btnTaoNhom.Text = "Tạo nhóm mới";
			this.btnTaoNhom.UseVisualStyleBackColor = false;
			this.btnTaoNhom.Click += new System.EventHandler(this.btnTaoNhom_Click);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã nhóm";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên nhóm";
			this.columnHeader2.Width = 150;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên giáo viên hướng dẫn";
			this.columnHeader3.Width = 150;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Tên đề tài";
			this.columnHeader4.Width = 315;
			// 
			// DKNhomForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 479);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnTaoNhom);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lvNhom);
			this.Name = "DKNhomForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DKNhomForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DKNhomForm_FormClosed);
			this.Load += new System.EventHandler(this.DKNhomForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lvNhom;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnTaoNhom;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
	}
}