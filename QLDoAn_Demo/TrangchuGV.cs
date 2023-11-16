using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConfig;
using DTO;

namespace QLDoAn_Demo
{
	public partial class TrangchuGV : Form
	{
		Detai detai = new Detai();
		LoginForm Loginform;
		string MaGV = "";
		public TrangchuGV()
		{
			InitializeComponent();
		}
		public TrangchuGV(LoginForm loginForm,string magv)
		{
			InitializeComponent();
			MaGV = magv;
			Loginform = loginForm;
		}
		public void LoadAllListView()
		{
			DbConfig dbConfig = new DbConfig();
			dbConfig.Connection.Open();
			dbConfig.ReadAllCTDT(string.Format("Select Detai.MasoDetai, Detai.TenDetai, Detai.MaloaiDoAn, Chitiet_GiaoVien_Detai.Trangthai from Chitiet_GiaoVien_Detai join Detai on Detai.MasoDetai = Chitiet_GiaoVien_Detai.MasoDetai where Chitiet_GiaoVien_Detai.MaGV = '{0}'", MaGV), dbConfig.Connection, lvDetai);
			dbConfig.Connection.Close();
			dbConfig.Connection.Open();
			dbConfig.ReadAllQuyenDoAnHaveGV(MaGV, dbConfig.Connection, lvQuyenDoAn);
			dbConfig.Connection.Close();
			dbConfig.Connection.Open();
			dbConfig.ReadAllNhomHuongDan(MaGV, dbConfig.Connection, lvNhom);
			dbConfig.Connection.Close();
		}
		private void btnNopDeTai_Click(object sender, EventArgs e)
		{
			if (txtTendetai.Text != "" && cbbLoaiDoan.Text != "" && detai.YeucauDetai != null && detai.Tailieu != null)
			{
				detai.TenDetai = txtTendetai.Text;
				detai.TenFileYeucau = txtNoidung.Text;
				detai.TenFileTailieu = txtTailieu.Text;
				detai.LoaiDoAn = cbbLoaiDoan.Text;
				DbConfig dbConfig = new DbConfig();
				dbConfig.Connection.Open();
				if(dbConfig.UploadDetai(detai, dbConfig.Connection))
				{
					int MasoDetai = dbConfig.ReadLastSTT(dbConfig.Connection);
					detai.MaDetai = MasoDetai.ToString();
					if(dbConfig.UploadData(string.Format("Insert into Chitiet_Giaovien_Detai values ('{0}', '{1}', N'Đang chờ duyệt')", MaGV, detai.MaDetai), dbConfig.Connection))
					{
						MessageBox.Show("Nộp đề tài thành công");
						txtTendetai.Text = string.Empty;
						txtNoidung.Text = string.Empty;
						txtTailieu.Text = string.Empty;
						LoadAllListView();
					}
				}
				else
				{
					MessageBox.Show("Đã xảy ra lỗi khi nộp đề tài !");
				}
				dbConfig.Connection.Close();
			}
			else
			{
				MessageBox.Show("Không được bỏ trống thông tin đề tài !");
			}
		}

		private void RaDetaiForm_Load(object sender, EventArgs e)
		{
			LoadAllListView();
		}

		private void RaDetaiForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Loginform.Show();
			Loginform.BringToFront();
		}

		private void btnChoDiem_Click(object sender, EventArgs e)
		{
			if (lvQuyenDoAn.SelectedItems.Count == 0)
			{
				MessageBox.Show("Chưa chọn quyển đồ án để cho điểm");
			}
			else
			{
				if(txtDiem.Text == "")
				{
					MessageBox.Show("Chưa nhập điểm cho quyển đồ án !");
				}
				else
				{
					DbConfig dbConfig = new DbConfig();
					dbConfig.Connection.Open();
					dbConfig.UploadData(string.Format("Update QuyenDoan set QuyenDoan.Diem = {0} where QuyenDoan.STT = {1}", txtDiem.Text.Replace(",", "."), lvQuyenDoAn.SelectedItems[0].Text), dbConfig.Connection);
					dbConfig.Connection.Close();
					MessageBox.Show("Chấm điểm quyển đồ án thành công !");
					LoadAllListView();
				}
			}
		}

		private void btnNopketqua_Click(object sender, EventArgs e)
		{
			if(lvQuyenDoAn.SelectedItems.Count == 0)
			{
				MessageBox.Show("Chưa chọn quyển đồ án để nộp kết quả");
			}
			else
			{
				if(lvQuyenDoAn.SelectedItems[0].SubItems[3].Text == "")
				{
					MessageBox.Show("Giáo viên chưa chấm điểm quyển đồ án này !");
				}
                else
                {
					DbConfig dbConfig = new DbConfig();
					dbConfig.Connection.Open();
					int Manhom = dbConfig.ReadNhomOfQuyenDoAn(lvQuyenDoAn.SelectedItems[0].Text, dbConfig.Connection);
					dbConfig.Connection.Close();
					dbConfig.Connection.Open();
					dbConfig.UploadData(string.Format("Update SinhVien set SinhVien.Diem = {0} where SinhVien.Manhom = {1}", lvQuyenDoAn.SelectedItems[0].SubItems[3].Text.Replace(',', '.'), Manhom), dbConfig.Connection);
					dbConfig.Connection.Close();
					MessageBox.Show("Nộp kết quả quyển đồ án thành công !");
					LoadAllListView();
				}
			}
		}

		private void btnDownload_Click(object sender, EventArgs e)
		{
			if(lvQuyenDoAn.SelectedItems.Count == 0)
			{
				MessageBox.Show("Chưa chọn quyển đồ án để tải !");
			}
			else
			{
				QuyenDoAn quyenDoAn = new QuyenDoAn();
				DbConfig dbConfig = new DbConfig();
				dbConfig.Connection.Open();
				quyenDoAn.TenFile = dbConfig.ReadTenFileDoAn(lvQuyenDoAn.SelectedItems[0].Text, dbConfig.Connection);
				dbConfig.Connection.Close();
				dbConfig.Connection.Open();
				quyenDoAn.Noidung = dbConfig.ReadNoidungDoan(lvQuyenDoAn.SelectedItems[0].Text, dbConfig.Connection);
				dbConfig.Connection.Close();
				if (quyenDoAn.Noidung != null)
				{
					Stream stream;
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					saveFileDialog.FileName = quyenDoAn.TenFile;
					saveFileDialog.Filter = "Portable Document Format|*.pdf";
					saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
					saveFileDialog.FilterIndex = 0;
					saveFileDialog.RestoreDirectory = true;
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						stream = saveFileDialog.OpenFile();
						stream.Write(quyenDoAn.Noidung, 0, quyenDoAn.Noidung.Length);
						stream.Close();
						MessageBox.Show("Tải file thành công !");
					}
				}
				else
				{
					MessageBox.Show("Nhóm này chưa nộp nội dung quyển đồ án !");
				}
			}
		}

		private void btnBrowseYeuCau_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Portable Document Format|*.pdf";
			openFileDialog.Multiselect = false;
			openFileDialog.FilterIndex = 0;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				txtNoidung.Text = openFileDialog.SafeFileName;
				detai.YeucauDetai = File.ReadAllBytes(openFileDialog.FileName);
			}
		}

		private void btnBrowseTailieu_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Portable Document Format|*.pdf";
			openFileDialog.Multiselect = false;
			openFileDialog.FilterIndex = 0;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				txtTailieu.Text = openFileDialog.SafeFileName;
				detai.Tailieu = File.ReadAllBytes(openFileDialog.FileName);
			}
		}
	}
}
