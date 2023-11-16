using DatabaseConfig;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDoAn_Demo
{
	public partial class TrangchuSVForm : Form
	{
		QuyenDoAn quyendoan;
		string Manhom;
		LoginForm Login;
		public TrangchuSVForm()
		{
			InitializeComponent();
		}
		public TrangchuSVForm(string manhom)
		{
			InitializeComponent();
			Manhom = manhom;
		}
		public TrangchuSVForm(string manhom, LoginForm loginForm)
		{
			InitializeComponent();
			Manhom = manhom;
			Login = loginForm;
		}

		private void TrangchuSVForm_Load(object sender, EventArgs e)
		{
			DbConfig dbConfig = new DbConfig();
			dbConfig.Connection.Open();
			quyendoan = dbConfig.ReadQuyenDoAn(Manhom, dbConfig.Connection);
			dbConfig.Connection.Close();
			if (quyendoan != null)
			{
				txtSTT.Text = quyendoan.STT;
				txtTenDeTai.Text = quyendoan.TenDetai;
				txtTenNhom.Text = quyendoan.Tennhom;
				txtNoidung.Text = quyendoan.TenFile;
				dbConfig.Connection.Open();
				txtTenYeucau.Text = dbConfig.ReadTenFileYeuCau(quyendoan.MasoDetai, dbConfig.Connection);
				dbConfig.Connection.Close();
				dbConfig.Connection.Open();
				txtTentailieu.Text = dbConfig.ReadTenFileTaiLieu(quyendoan.MasoDetai, dbConfig.Connection);
				dbConfig.Connection.Close();
			}
		}
		private void btnNop_Click(object sender, EventArgs e)
		{
			if (quyendoan.Noidung == null)
			{
				MessageBox.Show("Không được bỏ trống nội dung quyển đồ án !");
			}
			else
			{
				DbConfig dbConfig = new DbConfig();
				dbConfig.Connection.Open();
				dbConfig.UploadNoidung(quyendoan.Noidung,quyendoan.TenFile, Manhom, dbConfig.Connection);
				dbConfig.Connection.Close();
				MessageBox.Show("Nộp quyển đồ án thành công !"); 
			}
		}

		private void TrangchuSVForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Login != null)
			{
				Login.Show();
				Login.BringToFront();
			}
		}

		private void btnBrowseFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Portable Document Format|*.pdf";
			openFileDialog.Multiselect = false;
			openFileDialog.FilterIndex = 0;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				txtNoidung.Text = openFileDialog.SafeFileName;
				quyendoan.TenFile = openFileDialog.SafeFileName;
				quyendoan.Noidung = File.ReadAllBytes(openFileDialog.FileName);
			}
		}

		private void btnTaiYeucau_Click(object sender, EventArgs e)
		{
			byte[] Noidung;
			DbConfig dbConfig = new DbConfig();
			dbConfig.Connection.Open();
			Noidung = dbConfig.ReadYeucauDetai(quyendoan.MasoDetai, dbConfig.Connection);
			dbConfig.Connection.Close();
			if (Noidung != null)
			{
				Stream stream;
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.FileName = txtTenYeucau.Text;
				saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
				saveFileDialog.Filter = "Portable Document Format|*.pdf";
				saveFileDialog.FilterIndex = 0;
				saveFileDialog.RestoreDirectory = true;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					stream = saveFileDialog.OpenFile();
					stream.Write(Noidung, 0, Noidung.Length);
					stream.Close();
					MessageBox.Show("Tải file thành công !");
				}
			}
		}

		private void btnTaiTailieu_Click(object sender, EventArgs e)
		{
			byte[] Noidung;
			DbConfig dbConfig = new DbConfig();
			dbConfig.Connection.Open();
			Noidung = dbConfig.ReadTailieu(quyendoan.MasoDetai, dbConfig.Connection);
			dbConfig.Connection.Close();
			if (Noidung != null)
			{
				Stream stream;
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.FileName = txtTentailieu.Text;
				saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
				saveFileDialog.Filter = "Portable Document Format|*.pdf";
				saveFileDialog.FilterIndex = 0;
				saveFileDialog.RestoreDirectory = true;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					stream = saveFileDialog.OpenFile();
					stream.Write(Noidung, 0, Noidung.Length);
					stream.Close();
					MessageBox.Show("Tải file thành công !");
				}
			}
		}
	}
}
