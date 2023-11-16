using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConfig;

namespace QLDoAn_Demo
{
	public partial class QLDetaiForm : Form
	{
		LoginForm Loginform;
		public QLDetaiForm()
		{
			InitializeComponent();
		}

		public QLDetaiForm(LoginForm loginForm)
		{
			InitializeComponent();
			Loginform = loginForm;
		}

		private void QLDetaiForm_Load(object sender, EventArgs e)
		{
			LoadAllListView();
		}

		public void LoadAllListView()
		{
			DbConfig dbConfig = new DbConfig();
			dbConfig.Connection.Open();
			dbConfig.ReadAllDTChoDuyet(dbConfig.Connection, lvDTChoDuyet);
			dbConfig.Connection.Close();
			dbConfig.Connection.Open();
			dbConfig.ReadAllDTDaDuyet(dbConfig.Connection, lvDTDaDuyet);
			dbConfig.Connection.Close();
			dbConfig.Connection.Open();
			dbConfig.ReadAllQuyenDoAn(dbConfig.Connection, lvQuyenDoAn);
			dbConfig.Connection.Close();
			dbConfig.Connection.Open();
			if (lvQuyenDoAn.Items.Count > 0)
			{
				for(int i = 0; i<lvQuyenDoAn.Items.Count; ++i)
				{
					if (dbConfig.CheckQuyenDoAnHaveGV(lvQuyenDoAn.Items[i].Text, dbConfig.Connection))
					{
						lvQuyenDoAn.Items[i].SubItems[3].Text = dbConfig.ReadGVCD(lvQuyenDoAn.Items[i].Text, dbConfig.Connection);
					}
				}
			}
			dbConfig.Connection.Close();
			dbConfig.Connection.Open();
			dbConfig.ReadAllNhom(dbConfig.Connection, lvNhom);
			dbConfig.Connection.Close();
			dbConfig.Connection.Open();
			if (lvNhom.Items.Count > 0)
			{
				for (int i = 0; i < lvNhom.Items.Count; ++i)
				{
					if (dbConfig.CheckNhomHaveGV(lvNhom.Items[i].Text, dbConfig.Connection))
					{
						lvNhom.Items[i].SubItems[2].Text = dbConfig.ReadGVHD(lvNhom.Items[i].Text, dbConfig.Connection);
					}
				}
			}
			dbConfig.Connection.Close();
			dbConfig.Connection.Open();
			dbConfig.ReadAllSV(dbConfig.Connection, lvSV);
			dbConfig.Connection.Close();
		}

		private void QLDetaiForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Loginform.Show();
			Loginform.BringToFront();
		}

		private void btnDuyet_Click(object sender, EventArgs e)
		{
			if(lvDTChoDuyet.SelectedItems.Count == 0)
			{
				MessageBox.Show("Chưa chọn đề tài để duyệt !");
			}
			else
			{
				DbConfig dbConfig = new DbConfig();
				dbConfig.Connection.Open();
				dbConfig.UploadData(string.Format("Update Chitiet_GiaoVien_Detai set Trangthai = N'Đã được duyệt' where MasoDetai = {0}", lvDTChoDuyet.SelectedItems[0].Text), dbConfig.Connection);
				dbConfig.Connection.Close();
				MessageBox.Show("Duyệt dề tài thành công !");
				LoadAllListView();
			}
		}

		private void btnUpload_Click(object sender, EventArgs e)
		{
			if(lvDTDaDuyet.SelectedItems.Count == 0)
			{
				MessageBox.Show("Chưa chọn đề tài để đăng tải !");
			}
			else
			{
				DbConfig dbConfig = new DbConfig();
				dbConfig.Connection.Open();
				dbConfig.UploadData(string.Format("Update Chitiet_GiaoVien_Detai set Trangthai = N'Đã đăng tải' where MasoDetai = '{0}'", lvDTDaDuyet.SelectedItems[0].Text), dbConfig.Connection);
				dbConfig.Connection.Close();
				MessageBox.Show("Đăng tải đề tài thành công !");
				LoadAllListView();
			}
		}

		private void btnPhanCongHD_Click(object sender, EventArgs e)
		{
			if (lvNhom.SelectedItems.Count == 0)
			{
				MessageBox.Show("Chưa chọn nhóm để phân công !");
			}
			else
			{
				PhanCongGVForm phancong = new PhanCongGVForm(this, true, lvNhom.SelectedItems[0].Text, "");
				phancong.Show();
				phancong.BringToFront();
			}
		}

		private void btnPhanCongCD_Click(object sender, EventArgs e)
		{
			if (lvQuyenDoAn.SelectedItems.Count == 0)
			{
				MessageBox.Show("Chưa chọn quyển đồ án để phân công !");
			}
			else
			{
				PhanCongGVForm phancong = new PhanCongGVForm(this, false, "", lvQuyenDoAn.SelectedItems[0].Text);
				phancong.Show();
				phancong.BringToFront();
			}
		}
	}
}
