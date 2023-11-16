using DatabaseConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDoAn_Demo
{
	public partial class PhanCongGVForm : Form
	{
		QLDetaiForm Ql;
		bool IsPhanCongHuongDan = true;
		string Manhom;
		string STTQuyenDoAn;
		public PhanCongGVForm()
		{
			InitializeComponent();
		}

		public PhanCongGVForm(bool isphanconghuongdan)
		{
			InitializeComponent();
			IsPhanCongHuongDan=isphanconghuongdan;
		}

		public PhanCongGVForm(QLDetaiForm ql, bool isphanconghuongdan, string manhom, string stt) 
		{
			InitializeComponent();
			Ql = ql;
			IsPhanCongHuongDan = isphanconghuongdan;
			Manhom = manhom;
			STTQuyenDoAn = stt;
		}

		private void btnPhanCong_Click(object sender, EventArgs e)
		{
			if(lvGV.SelectedItems.Count == 0)
			{
				MessageBox.Show("Chưa chọn giáo viên để phân công !");
			}
			else
			{
				if (IsPhanCongHuongDan)
				{
					DbConfig dbconfig = new DbConfig();
					dbconfig.Connection.Open();
					dbconfig.UploadData(string.Format("Update NhomSinhVien set NhomSinhVien.MaGV = '{0}' where NhomSinhVien.Manhom = {1}", lvGV.SelectedItems[0].Text, Manhom), dbconfig.Connection);
					dbconfig.Connection.Close();
					MessageBox.Show("Phân công giáo viên hướng dẫn thành công !");
					Ql.LoadAllListView();
					this.Close();
				}
				else
				{
					DbConfig dbConfig = new DbConfig();
					dbConfig.Connection.Open();
					dbConfig.UploadData(string.Format("Update QuyenDoan set QuyenDoan.MaGV = '{0}' where QuyenDoan.STT = {1}", lvGV.SelectedItems[0].Text, STTQuyenDoAn), dbConfig.Connection);
					dbConfig.Connection.Close();
					MessageBox.Show("Phân công giáo viên chấm điểm thành công !");
					Ql.LoadAllListView();
					this.Close();
				}
			}
		}

		private void PhanCongGVForm_Load(object sender, EventArgs e)
		{
			DbConfig dbConfig = new DbConfig();
			dbConfig.Connection.Open();
			dbConfig.ReadAllGV(dbConfig.Connection, lvGV);
			dbConfig.Connection.Close();
		}
	}
}
