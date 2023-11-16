using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;
using System.Collections;
using System.Data;

namespace DatabaseConfig
{
	public class DbConfig
	{
		private string ConnectionString = "";
		public SqlConnection Connection = null;
		public SqlCommand Command = null;
		public SqlDataReader Reader = null;
		public DbConfig() {
			ConnectionString = "Data Source=LAPTOP-BT49J3TI\\TRANDUYQUAN;Initial Catalog=QLDoAnNienLuan;Integrated Security=True";
			Connection = new SqlConnection(ConnectionString);
		}
		public void SetCommand(string query, SqlConnection connection)
		{
			if(connection!=null)
			Command = new SqlCommand(query, connection);
		}

		//Check if data is exist in data
		public bool ContainsData(string query, SqlConnection connection)
		{
			if (connection != null)
			{
				SetCommand(query, connection);
				if (Command != null)
				{
					Reader = Command.ExecuteReader();
					if (Reader.Read())
					{
						return true;
					}
				}
			}
			return false;
		}
		public void ReadAllDeTai(SqlConnection connection, ListView listView)
		{
			if(connection != null)
			{
				string query = "Select Detai.MasoDetai, Detai.TenDetai,GiaoVien.Hoten, Detai.MaloaiDoAn, Chitiet_GiaoVien_Detai.Trangthai from Chitiet_GiaoVien_Detai join Detai on Detai.MasoDetai = Chitiet_GiaoVien_Detai.MasoDetai join GiaoVien on GiaoVien.MaGV = Chitiet_GiaoVien_Detai.MaGV where Chitiet_GiaoVien_Detai.Trangthai = N'Đã đăng tải' order by Detai.MasoDetai ASC";
				SetCommand(query, connection);
				if (Command != null)
				{
					listView.Items.Clear();
					Reader = Command.ExecuteReader();
					int index = 0;
					string MasoDetai = "";
					while (Reader.Read())
					{
						if (Reader[0].ToString() == MasoDetai)
						{
							continue;
						}
						else
						{
                            Detai detai = new Detai(Reader[0].ToString(), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString());
							listView.Items.Add(detai.MaDetai);
							MasoDetai = detai.MaDetai;
							listView.Items[index].SubItems.Add(detai.TenDetai);
							listView.Items[index].SubItems.Add(detai.TenGV);
							listView.Items[index].SubItems.Add(detai.LoaiDoAn);
							listView.Items[index].SubItems.Add(detai.Trangthai);
							index++;
						}
					}
				}
			}
		}
		public void ReadAllDTChoDuyet(SqlConnection connection, ListView listView)
		{
			if (connection != null)
			{
				string query = "Select Detai.MasoDetai, Detai.TenDetai,GiaoVien.Hoten, Detai.MaloaiDoAn, Chitiet_GiaoVien_Detai.Trangthai from Chitiet_GiaoVien_Detai join Detai on Detai.MasoDetai = Chitiet_GiaoVien_Detai.MasoDetai join GiaoVien on GiaoVien.MaGV = Chitiet_GiaoVien_Detai.MaGV where Chitiet_GiaoVien_Detai.Trangthai = N'Đang chờ duyệt' order by Detai.MasoDetai ASC";
				SetCommand(query, connection);
				if (Command != null)
				{
					listView.Items.Clear();
					Reader = Command.ExecuteReader();
					int index = 0;
					string MasoDetai = "";
					while (Reader.Read())
					{
						if(Reader[0].ToString() == MasoDetai)
						{
							continue;
						}
						else
						{
                            Detai detai = new Detai(Reader[0].ToString(), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString());
							listView.Items.Add(detai.MaDetai);
							MasoDetai = detai.MaDetai;
							listView.Items[index].SubItems.Add(detai.TenDetai);
							listView.Items[index].SubItems.Add(detai.TenGV);
							listView.Items[index].SubItems.Add(detai.LoaiDoAn);
							listView.Items[index].SubItems.Add(detai.Trangthai);
							index++;
						}
					}
				}
			}
		}
		public void ReadAllDTDaDuyet(SqlConnection connection, ListView listView)
		{
			if (connection != null)
			{
				string query = "Select Detai.MasoDetai, Detai.TenDetai,GiaoVien.Hoten, Detai.MaloaiDoAn, Chitiet_GiaoVien_Detai.Trangthai from Chitiet_GiaoVien_Detai join Detai on Detai.MasoDetai = Chitiet_GiaoVien_Detai.MasoDetai join GiaoVien on GiaoVien.MaGV = Chitiet_GiaoVien_Detai.MaGV where Chitiet_GiaoVien_Detai.Trangthai = N'Đã được duyệt' order by Detai.MasoDetai ASC";
				SetCommand(query, connection);
				if (Command != null)
				{
					listView.Items.Clear();
					Reader = Command.ExecuteReader();
					int index = 0;
					string MasoDetai = "";
					while (Reader.Read())
					{
						if (Reader[0].ToString() == MasoDetai)
						{
							continue;
						}
						else
						{
                            Detai detai = new Detai(Reader[0].ToString(), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString());
							listView.Items.Add(detai.MaDetai);
							MasoDetai = detai.MaDetai;
							listView.Items[index].SubItems.Add(detai.TenDetai);
							listView.Items[index].SubItems.Add(detai.TenGV);
							listView.Items[index].SubItems.Add(detai.LoaiDoAn);
							listView.Items[index].SubItems.Add(detai.Trangthai);
							index++;
						}
					}
				}
			}
		}
		public void ReadAllCTDT(string query, SqlConnection connection, ListView listView)
		{
			if (connection != null && query != "")
			{
				SetCommand(query, connection);
				if (Command != null)
				{
					listView.Items.Clear();
					Reader = Command.ExecuteReader();
					int index = 0;
					while (Reader.Read())
					{
						listView.Items.Add(Reader[0].ToString());
						listView.Items[index].SubItems.Add(Reader[1].ToString());
						listView.Items[index].SubItems.Add(Reader[2].ToString());
						listView.Items[index].SubItems.Add(Reader[3].ToString());
						index++;
					}
				}
			}
		}
		public void ReadAllNhom(SqlConnection connection, ListView listView)
		{
			if (connection != null)
			{
				string query = "Select NhomSinhVien.Manhom, NhomSinhVien.Tennhom, Detai.TenDetai from NhomSinhVien join QuyenDoan on QuyenDoan.Manhom = NhomSinhVien.Manhom join Detai on QuyenDoan.MasoDetai = Detai.MasoDetai";
				SetCommand(query, connection);
				if (Command != null)
				{
					listView.Items.Clear();
					Reader = Command.ExecuteReader();
					int index = 0;
					while (Reader.Read())
					{
						NhomSV nhomsv = new NhomSV(Reader[0].ToString(), Reader[1].ToString(), "", Reader[2].ToString());
						listView.Items.Add(nhomsv.MaNhom);
						listView.Items[index].SubItems.Add(nhomsv.TenNhom);
						listView.Items[index].SubItems.Add(nhomsv.TenGV);
						listView.Items[index].SubItems.Add(nhomsv.TenDeTai);
						index++;
					}
				}
			}
		}
		public void ReadAllNhomHuongDan(string MaGV, SqlConnection connection, ListView listView)
		{
			if (connection != null)
			{
				string query = string.Format("Select NhomSinhVien.Manhom, NhomSinhVien.Tennhom, Detai.TenDetai from NhomSinhVien join QuyenDoan on QuyenDoan.Manhom = NhomSinhVien.Manhom join Detai on QuyenDoan.MasoDetai = Detai.MasoDetai where NhomSinhVien.MaGV = '{0}'", MaGV);
				SetCommand(query, connection);
				if (Command != null)
				{
					listView.Items.Clear();
					Reader = Command.ExecuteReader();
					int index = 0;
					while (Reader.Read())
					{
						NhomSV nhomsv = new NhomSV(Reader[0].ToString(), Reader[1].ToString(), "", Reader[2].ToString());
						listView.Items.Add(nhomsv.MaNhom);
						listView.Items[index].SubItems.Add(nhomsv.TenNhom);
						listView.Items[index].SubItems.Add(nhomsv.TenDeTai);
						index++;
					}
				}
			}
		}
		public string ReadGVHD(string manhom, SqlConnection connection)
		{
			if (connection != null)
			{
				string query = string.Format("Select GiaoVien.Hoten from NhomSinhVien join GiaoVien on GiaoVien.MaGV = NhomSinhVien.MaGV where NhomSinhVien.Manhom = {0}", manhom);
				SetCommand(query, connection);
				if (Command != null)
				{
					return (string)Command.ExecuteScalar();
				}
			}
			return "";
		}
		public string ReadGVCD(string stt, SqlConnection connection)
		{
			if (connection != null)
			{
				string query = string.Format("Select GiaoVien.Hoten from QuyenDoan join GiaoVien on GiaoVien.MaGV = QuyenDoan.MaGV where QuyenDoan.STT = {0}", stt);
				SetCommand(query, connection);
				if (Command != null)
				{
					return (string)Command.ExecuteScalar();
				}
			}
			return "";
		}
		public int ReadNhomOfSV(string MSSV, SqlConnection connection)
		{
			if (connection != null)
			{
				string query = string.Format("Select Manhom from SinhVien where SinhVien.MSSV = '{0}' and SinhVien.Manhom is not null", MSSV);
				SetCommand(query, connection);
				if (Command != null)
				{
					if (Command.ExecuteScalar() == null)
					{
						return -1;
					}
					else
					return (int)Command.ExecuteScalar();
				}
			}
			return -1;
		}
		public int ReadNhomOfQuyenDoAn(string STT,  SqlConnection connection)
		{
			if (connection != null)
			{
				string query = string.Format("Select Manhom from QuyenDoan where QuyenDoan.STT = {0} and QuyenDoan.Manhom is not null", STT);
				SetCommand(query, connection);
				if (Command != null)
				{
					if (Command.ExecuteScalar() == null)
					{
						return -1;
					}
					else
						return (int)Command.ExecuteScalar();
				}
			}
			return -1;
		}
		public bool CheckNhomHaveGV(string manhom, SqlConnection connection)
		{
			if (connection != null)
			{
				string query = string.Format("Select MaGV from NhomSinhVien where Manhom = {0} and MaGV is not null", manhom);
				SetCommand(query, connection);
				if (Command != null)
				{
					if ((string)Command.ExecuteScalar() != "")
					{
						return true;
					}
				}
			}
			return false;
		}
		public bool CheckQuyenDoAnHaveGV(string stt, SqlConnection connection)
		{
			if (connection != null)
			{
				string query = string.Format("Select MaGV from QuyenDoan where STT = {0} and MaGV is not null", stt);
				SetCommand(query, connection);
				if (Command != null)
				{
					if ((string)Command.ExecuteScalar() != "")
					{
						return true;
					}
				}
			}
			return false;
		}	
		public void ReadAllSVKhongNhom(SqlConnection connection, ListView listView)
		{
			if (connection != null)
			{
				string query = "Select MSSV, Hoten, Ngaysinh, Gioitinh from SinhVien where Manhom is null";
				SetCommand(query, connection);
				if (Command != null)
				{
					listView.Items.Clear();
					Reader = Command.ExecuteReader();
					int index = 0;
					while (Reader.Read())
					{
						string gioitinh = (Reader.GetBoolean(3) == false) ? "Nam" : "Nữ";
						DateTime ngaysinh = Reader.GetDateTime(2);
						SinhVien sv = new SinhVien(Reader[0].ToString(), Reader[1].ToString(), ngaysinh.ToString("dd-MM-yyyy"), gioitinh, "", 0);
						listView.Items.Add(sv.MSSV);
						listView.Items[index].SubItems.Add(sv.TenSV);
						listView.Items[index].SubItems.Add(sv.NgaySinh);
						listView.Items[index].SubItems.Add(gioitinh);
						index++;
					}
				}
			}
		}
		public void ReadAllSVKhongNhomExcept(string MSSV, SqlConnection connection, ListView listView)
		{
			if (connection != null)
			{
				string query = string.Format("Select MSSV, Hoten, Ngaysinh, Gioitinh from SinhVien where Manhom is null and MSSV <> '{0}'", MSSV);
				SetCommand(query, connection);
				if (Command != null)
				{
					listView.Items.Clear();
					Reader = Command.ExecuteReader();
					int index = 0;
					while (Reader.Read())
					{
						string gioitinh = (Reader.GetBoolean(3) == false) ? "Nam" : "Nữ";
						DateTime ngaysinh = Reader.GetDateTime(2);
						SinhVien sv = new SinhVien(Reader[0].ToString(), Reader[1].ToString(), ngaysinh.ToString("dd-MM-yyyy"), gioitinh, "", 0);
						listView.Items.Add(sv.MSSV);
						listView.Items[index].SubItems.Add(sv.TenSV);
						listView.Items[index].SubItems.Add(sv.NgaySinh);
						listView.Items[index].SubItems.Add(gioitinh);
						index++;
					}
				}
			}
		}
		public void ReadAllSV(SqlConnection connection, ListView listView)
		{
			if(connection != null)
			{
				//string query = "Select SinhVien.MSSV, SinhVien.Hoten, SinhVien.Ngaysinh, SinhVien.Gioitinh, NhomSinhVien.Tennhom, SinhVien.Diem from SinhVien join NhomSinhVien on NhomSinhVien.Manhom = SinhVien.Manhom";
				string query = "Select SinhVien.MSSV, SinhVien.Hoten, SinhVien.Ngaysinh, SinhVien.Gioitinh, SinhVien.Diem from SinhVien";
				SetCommand(query, connection);
				if (Command != null)
				{
					listView.Items.Clear();
					Reader = Command.ExecuteReader();
					int index = 0;
					while (Reader.Read())
					{
						string gioitinh = (Reader.GetBoolean(3) == false) ? "Nam" : "Nữ";
						DateTime ngaysinh = Reader.GetDateTime(2);
						double diem = (Reader.IsDBNull(4)) ? 0 : Reader.GetDouble(4);
						SinhVien sv = new SinhVien(Reader[0].ToString(), Reader[1].ToString(), ngaysinh.ToString("dd-MM-yyyy"), gioitinh, "", diem);
						listView.Items.Add(sv.MSSV);
						listView.Items[index].SubItems.Add(sv.TenSV);
						listView.Items[index].SubItems.Add(sv.NgaySinh);
						listView.Items[index].SubItems.Add(gioitinh);
						listView.Items[index].SubItems.Add(sv.Diem.ToString());
						index++;
					}
				}
			}
		}

		public void ReadAllQuyenDoAn(SqlConnection connection, ListView listView)
		{
			if (connection != null)
			{
				string query = "Select QuyenDoAn.STT, Detai.TenDetai, NhomSinhVien.Tennhom, QuyenDoan.Diem from QuyenDoan join Detai on QuyenDoan.MasoDetai=Detai.MasoDetai join NhomSinhVien on NhomSinhVien.Manhom = QuyenDoan.Manhom";
				SetCommand(query, connection);
				if (Command != null)
				{
					listView.Items.Clear();
					Reader = Command.ExecuteReader();
					int index = 0;
					while (Reader.Read())
					{
						QuyenDoAn quyenDoAn = new QuyenDoAn(Reader[0].ToString(), Reader[1].ToString(), Reader[2].ToString(), "", Reader[3].ToString());
						listView.Items.Add(quyenDoAn.STT);
						listView.Items[index].SubItems.Add(quyenDoAn.TenDetai);
						listView.Items[index].SubItems.Add(quyenDoAn.Tennhom);
						listView.Items[index].SubItems.Add(quyenDoAn.TenGV);
						listView.Items[index].SubItems.Add(quyenDoAn.Diem);
						index++;
					}
				}
			}
		}
		public void ReadAllQuyenDoAnHaveGV(string MaGV, SqlConnection connection, ListView listView)
		{
			if (connection != null)
			{
				string query = string.Format("Select QuyenDoAn.STT, Detai.TenDetai, NhomSinhVien.Tennhom, QuyenDoan.Diem from QuyenDoan join Detai on QuyenDoan.MasoDetai=Detai.MasoDetai join NhomSinhVien on NhomSinhVien.Manhom = QuyenDoan.Manhom where QuyenDoan.MaGV is not null and QuyenDoan.MaGV = '{0}'", MaGV);
				SetCommand(query, connection);
				if (Command != null)
				{
					listView.Items.Clear();
					Reader = Command.ExecuteReader();
					int index = 0;
					while (Reader.Read())
					{
						QuyenDoAn quyenDoAn = new QuyenDoAn(Reader[0].ToString(), Reader[1].ToString(), Reader[2].ToString(), "", Reader[3].ToString());
						listView.Items.Add(quyenDoAn.STT);
						listView.Items[index].SubItems.Add(quyenDoAn.TenDetai);
						listView.Items[index].SubItems.Add(quyenDoAn.Tennhom);
						listView.Items[index].SubItems.Add(quyenDoAn.Diem);
						index++;
					}
				}
			}
		}
		public QuyenDoAn ReadQuyenDoAn(string manhom, SqlConnection connection)
		{
			if (connection != null)
			{
				string query = string.Format("Select QuyenDoAn.STT, Detai.TenDetai, QuyenDoan.TenFile, QuyenDoan.Noidung, NhomSinhVien.Tennhom, Detai.MasoDetai from QuyenDoan join Detai on QuyenDoan.MasoDetai = Detai.MasoDetai join NhomSinhVien on NhomSinhVien.Manhom = QuyenDoan.Manhom where QuyenDoan.Manhom = {0}", manhom);
				SetCommand(query, connection);
				if (Command != null)
				{
					Reader = Command.ExecuteReader();
					if (Reader.Read())
					{
						byte[] noidung = null;
						if (!Reader.IsDBNull(3))
						{
							noidung = (byte[])Reader[3];
						}
						QuyenDoAn quyenDoAn = new QuyenDoAn(Reader[0].ToString(), Reader[1].ToString(), Reader[2].ToString(), noidung, Reader[4].ToString(), "", "", "");
						if (!Reader.IsDBNull(5))
						{
							quyenDoAn.MasoDetai = Reader[5].ToString();
						}
						return quyenDoAn;
					}
				}
			}
			return null;
		}
		public void ReadSVWithMSSV(SqlConnection connection, ListView listView, string MSSV)
		{
			if (connection != null)
			{
				string query = string.Format("Select MSSV, Hoten, Ngaysinh, Gioitinh from SinhVien where MSSV = '{0}'", MSSV);
				SetCommand(query, connection);
				if (Command != null)
				{
					listView.Items.Clear();
					Reader = Command.ExecuteReader();
					int index = 0;
					if (Reader.Read())
					{
						string gioitinh = (Reader.GetBoolean(3) == false) ? "Nam" : "Nữ";
						DateTime ngaysinh = Reader.GetDateTime(2);
						SinhVien sv = new SinhVien(Reader[0].ToString(), Reader[1].ToString(), ngaysinh.ToString("dd-MM-yyyy"), gioitinh, "", 0);
						listView.Items.Add(sv.MSSV);
						listView.Items[index].SubItems.Add(sv.TenSV);
						listView.Items[index].SubItems.Add(sv.NgaySinh);
						listView.Items[index].SubItems.Add(gioitinh);
						index++;
					}
				}
			}
		}
		public bool CheckSVXuatSac(string MSSV, SqlConnection connection)
		{
			if (connection != null)
			{
				string query = string.Format("Select HSXuatSac from SinhVien where MSSV = '{0}'", MSSV);
				SetCommand(query, connection);
				if (Command != null)
				{
					return (bool)Command.ExecuteScalar();
				}
			}
			return false;
		}
		public string ReadLoaiDoAn(string Masodetai, SqlConnection connection)
		{
			if (connection != null)
			{
				string query = string.Format("Select MaloaiDoAn from Detai where MasoDetai = '{0}'", Masodetai);
				SetCommand(query, connection);
				if (Command != null)
				{
					Reader = Command.ExecuteReader();
					if(Reader.Read())
					return Reader[0].ToString();
				}
			}
			return "";
		}
		public void ReadAllGV(SqlConnection connection, ListView listView)
		{
			string query = string.Format("Select MaGV, Hoten, Ngaysinh, Phai from GiaoVien");
			SetCommand(query, connection);
			if (Command != null)
			{
				listView.Items.Clear();
				Reader = Command.ExecuteReader();
				int index = 0;
				while (Reader.Read())
				{
					string gioitinh = (Reader.GetBoolean(3) == false) ? "Nam" : "Nữ";
					DateTime ngaysinh = Reader.GetDateTime(2);
					GiaoVien gv = new GiaoVien(Reader[0].ToString(), Reader[1].ToString(), ngaysinh.ToString("dd-MM-yyyy"), gioitinh);
					listView.Items.Add(gv.MaGV);
					listView.Items[index].SubItems.Add(gv.Hoten);
					listView.Items[index].SubItems.Add(gv.NgaySinh);
					listView.Items[index].SubItems.Add(gv.GioiTinh);
					index++;
				}
			}
		}
		public byte[] ReadNoidungDoan(string STT, SqlConnection connection)
		{
			string query = string.Format("Select Noidung from QuyenDoan where QuyenDoan.STT = {0}", STT);
			SetCommand(query, connection);
			if(Command != null)
			{
				if (Command.ExecuteScalar() != DBNull.Value)
				{
					return (byte[])Command.ExecuteScalar();
				}
				else return null;
			}
			return null;
		}
		public string ReadTenFileDoAn(string STT, SqlConnection connection)
		{
			string query = string.Format("Select TenFile from QuyenDoan where QuyenDoan.STT = {0}", STT);
			SetCommand(query, connection);
			if (Command != null)
			{
				if (Command.ExecuteScalar() != DBNull.Value)
				{
					return (string)Command.ExecuteScalar();
				}
				else return "";
			}
			return "";
		}
		public string ReadTenFileYeuCau(string MasoDetai, SqlConnection connection)
		{
			string query = string.Format("Select TenFileNoidung from Detai where Detai.MasoDetai = {0}", MasoDetai);
			SetCommand(query, connection);
			if (Command != null)
			{
				if (Command.ExecuteScalar() != DBNull.Value)
				{
					return (string)Command.ExecuteScalar();
				}
				else return "";
			}
			return "";
		}
		public string ReadTenFileTaiLieu(string MasoDetai, SqlConnection connection)
		{
			string query = string.Format("Select TenFileTailieu from Detai where Detai.MasoDetai = {0}", MasoDetai);
			SetCommand(query, connection);
			if (Command != null)
			{
				if (Command.ExecuteScalar() != DBNull.Value)
				{
					return (string)Command.ExecuteScalar();
				}
				else return "";
			}
			return "";
		}
		public byte[] ReadYeucauDetai(string MasoDetai, SqlConnection connection)
		{
			string query = string.Format("Select NoidungDetai from Detai where Detai.MasoDetai = {0}", MasoDetai);
			SetCommand(query, connection);
			if (Command != null)
			{
				if (Command.ExecuteScalar() != DBNull.Value)
				{
					return (byte[])Command.ExecuteScalar();
				}
				else return null;
			}
			return null;
		}
		public byte[] ReadTailieu(string MasoDetai, SqlConnection connection)
		{
			string query = string.Format("Select Tailieu from Detai where Detai.MasoDetai = {0}", MasoDetai);
			SetCommand(query, connection);
			if (Command != null)
			{
				if (Command.ExecuteScalar() != DBNull.Value)
				{
					return (byte[])Command.ExecuteScalar();
				}
				else return null;
			}
			return null;
		}
		public int ReadLastSTT(SqlConnection connection)
		{
			if (connection != null)
			{
				string query = "Select top 1 Detai.MasoDetai from Detai order by Detai.MasoDetai desc";
				SetCommand(query, connection);
				if (Command != null)
				{
					if(Command.ExecuteScalar() != DBNull.Value)
					{
						return (Int32)Command.ExecuteScalar();
					}
				}
			}
			return 0;
		}
		public int ReadLastNhom(SqlConnection connection)
		{
			if (connection != null)
			{
				string query = "Select top 1 NhomSinhVien.Manhom from NhomSinhVien order by NhomSinhVien.Manhom desc";
				SetCommand(query, connection);
				if (Command != null)
				{
					if (Command.ExecuteScalar() != DBNull.Value)
					{
						return (Int32)Command.ExecuteScalar();
					}
				}
			}
			return 0;
		}
		public int GetNumberOfRecords(string query, SqlConnection connection)
		{
			if (connection != null && query != "")
			{
				SetCommand(query, connection);
				if (Command != null)
				{
					Command.ExecuteScalar();
					return (Int32)Command.ExecuteScalar();
				}
			}
			return 0;
		}
		public bool UploadData(string query, SqlConnection connection)
		{
			if (connection != null && query != "")
			{
				SetCommand(query, connection);
				if (Command != null)
				{
					return Command.ExecuteNonQuery() > 0;
				}
			}
			return false;
		}
		public bool UploadNoidung(byte[] noidung,string tennoidung, string STT, SqlConnection connection)
		{
			string query = "Update QuyenDoan set QuyenDoan.Noidung = @noidung, QuyenDoan.TenFile = @tennoidung where QuyenDoan.Manhom = @stt";
			if (connection != null)
			{
				SetCommand(query, connection);
				if (Command != null)
				{
					Command.Parameters.Add("@noidung", SqlDbType.VarBinary, 2000000000).Value = noidung;
					Command.Parameters.Add("@stt", SqlDbType.Int).Value = STT;
					Command.Parameters.Add("@tennoidung", SqlDbType.NVarChar, 50).Value = tennoidung;
					return Command.ExecuteNonQuery() > 0;
				}
			}
			return false;
		}
		public bool UploadDetai(Detai detai, SqlConnection connection)
		{
			string query = "Insert into Detai (TenDetai, TenFileNoidung, NoidungDetai, TenFileTailieu, Tailieu, MaloaiDoan) values (@tendetai, @tenfilenoidung,@noidung, @tenfiletailieu, @tailieu, @maloaidoan)";
			if(connection != null)
			{
				SetCommand(query, connection);
				if(Command != null)
				{
					Command.Parameters.Add("@tendetai", SqlDbType.NVarChar, 100).Value = detai.TenDetai;
					Command.Parameters.Add("@tenfilenoidung", SqlDbType.NVarChar, 50).Value = detai.TenFileYeucau;
					Command.Parameters.Add("@noidung", SqlDbType.VarBinary, 2000000000).Value = detai.YeucauDetai;
					Command.Parameters.Add("@tenfiletailieu", SqlDbType.NVarChar, 50).Value = detai.TenFileTailieu;
					Command.Parameters.Add("@tailieu", SqlDbType.VarBinary, 2000000000).Value = detai.Tailieu;
					Command.Parameters.Add("@maloaidoan", SqlDbType.VarChar, 10).Value = detai.LoaiDoAn;
					Command.CommandTimeout = 0;
					return Command.ExecuteNonQuery() > 0;
				}
			}
			return false;
		}
	}
}
