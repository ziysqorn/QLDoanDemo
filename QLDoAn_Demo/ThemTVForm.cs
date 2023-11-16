using DatabaseConfig;
using DTO;
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
	public partial class ThemTVForm : Form
	{
		SinhVien sinhvien = new SinhVien();
		public DKNhomForm dkNhom;
		public string MasoDetai;
		public string MSSV;
		public ThemTVForm()
		{
			InitializeComponent();
		}
		public ThemTVForm(DKNhomForm dkhhom, string masodetai, string mSSV)
		{
			InitializeComponent();
			dkNhom = dkhhom;
			MasoDetai = masodetai;
			MSSV = mSSV;
		}

		private void ThemTVForm_Load(object sender, EventArgs e)
		{
			DbConfig dbConfig = new DbConfig();
			dbConfig.Connection.Open();
			dbConfig.ReadAllSVKhongNhomExcept(MSSV, dbConfig.Connection, lvSV);
			dbConfig.Connection.Close();
			dbConfig.Connection.Open();
			dbConfig.ReadSVWithMSSV(dbConfig.Connection, lvTV, MSSV);
			dbConfig.Connection.Close();
		}

		private void ThemTVForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			dkNhom.Show();
			dkNhom.BringToFront();
		}

		private void btnThemTV_Click(object sender, EventArgs e)
		{
			DbConfig dbConfig=new DbConfig();
			dbConfig.Connection.Open();
			string LoaiDoAn = dbConfig.ReadLoaiDoAn(MasoDetai, dbConfig.Connection);
			dbConfig.Connection.Close();
			if(lvSV.SelectedItems.Count == 0)
			{
				MessageBox.Show("Chưa chọn sinh viên để thêm !");
			}
			else
			{
				if (LoaiDoAn == "LDA3")
				{
					if (lvTV.Items.Count == 1)
					{
						MessageBox.Show("Nhóm đã đạt số lượng tối đa !");
					}
					else
					{
						sinhvien.MSSV = lvSV.SelectedItems[0].Text;
						sinhvien.TenSV = lvSV.SelectedItems[0].SubItems[1].Text;
						sinhvien.NgaySinh = lvSV.SelectedItems[0].SubItems[2].Text;
						sinhvien.GioiTinh = lvSV.SelectedItems[0].SubItems[3].Text;
						lvTV.Items.Add(sinhvien.MSSV);
						lvTV.Items[lvTV.Items.Count - 1].SubItems.Add(sinhvien.TenSV);
						lvTV.Items[lvTV.Items.Count - 1].SubItems.Add(sinhvien.NgaySinh);
						lvTV.Items[lvTV.Items.Count - 1].SubItems.Add(sinhvien.GioiTinh);
						MessageBox.Show("Thêm thành viên thành công !");
						lvSV.Items.RemoveAt(lvSV.SelectedItems[0].Index);
					}
				}
				else
				{
					if (LoaiDoAn == "LDA1" || LoaiDoAn == "LDA2")
					{
						if (lvTV.Items.Count == 2)
						{
							MessageBox.Show("Nhóm đã đạt số lượng tối đa !");
						}
						else
						{
							sinhvien.MSSV = lvSV.SelectedItems[0].Text;
							sinhvien.TenSV = lvSV.SelectedItems[0].SubItems[1].Text;
							sinhvien.NgaySinh = lvSV.SelectedItems[0].SubItems[2].Text;
							sinhvien.GioiTinh = lvSV.SelectedItems[0].SubItems[3].Text;
							lvTV.Items.Add(sinhvien.MSSV);
							lvTV.Items[lvTV.Items.Count - 1].SubItems.Add(sinhvien.TenSV);
							lvTV.Items[lvTV.Items.Count - 1].SubItems.Add(sinhvien.NgaySinh);
							lvTV.Items[lvTV.Items.Count - 1].SubItems.Add(sinhvien.GioiTinh);
							MessageBox.Show("Thêm thành viên thành công !");
							lvSV.Items.RemoveAt(lvSV.SelectedItems[0].Index);
						}
					}
				}
			}
		}

		private void btnXoaTV_Click(object sender, EventArgs e)
		{
			if(lvTV.Items.Count <= 1)
			{
				MessageBox.Show("Không được xóa bản thân khỏi nhóm");
			}
			else
			{
				lvTV.Items.RemoveAt(lvTV.Items.Count - 1);
				MessageBox.Show("Xóa thành viên thành công !");
				DbConfig dbConfig = new DbConfig();
				dbConfig.Connection.Open();
				dbConfig.ReadAllSVKhongNhomExcept(MSSV, dbConfig.Connection, lvSV);
				dbConfig.Connection.Close();
			}
		}

		private void btnXacNhan_Click(object sender, EventArgs e)
		{
			if(txtTenNhom.Text != "" && lvTV.Items.Count > 0)
			{
				try
				{
					NhomSV nhom = new NhomSV("", txtTenNhom.Text, "", "");
					DbConfig dbConfig = new DbConfig();
					dbConfig.Connection.Open();
					dbConfig.UploadData(string.Format("Insert into NhomSinhVien(Tennhom) values (N'{0}')", nhom.TenNhom), dbConfig.Connection);
					dbConfig.Connection.Close();
					dbConfig.Connection.Open();
					nhom.SetMaNhom(dbConfig.ReadLastNhom(dbConfig.Connection).ToString());
					dbConfig.Connection.Close();
					for (int i = 0; i < lvTV.Items.Count; ++i)
					{
						dbConfig.Connection.Open();
						dbConfig.UploadData(string.Format("Update SinhVien set SinhVien.Manhom = '{0}' where SinhVien.MSSV = '{1}'", nhom.MaNhom, lvTV.Items[i].Text), dbConfig.Connection);
						dbConfig.Connection.Close();
					}
					dbConfig.Connection.Open();
					dbConfig.UploadData(string.Format("Insert into QuyenDoan(MasoDetai, Manhom) values ('{0}', '{1}')", MasoDetai, nhom.MaNhom), dbConfig.Connection);
					dbConfig.Connection.Close();
					MessageBox.Show("Đăng ký nhóm thành công !");
					this.Close();
					dkNhom.DKDoan.Close();
					dkNhom.Close();
					TrangchuSVForm trangchuSV = new TrangchuSVForm(nhom.MaNhom, dkNhom.DKDoan.Loginform);
					trangchuSV.Show();
					trangchuSV.BringToFront();
				}
				catch(Exception ex)
				{
					MessageBox.Show("Lỗi khi đăng ký nhóm !");
				}
			}
			else
			{
				MessageBox.Show("Không được bỏ trống thông tin nhóm !");
			}
		}
	}
}
