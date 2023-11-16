using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class Detai
	{
		public string MaDetai;
		public string TenDetai;
		public string TenFileYeucau;
		public byte[] YeucauDetai;
		public string TenFileTailieu;
		public byte[] Tailieu;
		public string TenGV;
		public string LoaiDoAn;
		public string Trangthai;
		public Detai()
		{

		}
		public Detai(string madetai, string tendetai, string tengv, string loaidoan, string trangthai) 
		{ 
			MaDetai = madetai;
			TenDetai = tendetai;
			TenGV = tengv;
			LoaiDoAn = loaidoan;
			Trangthai = trangthai;
		}
		public Detai(string maDetai, string tenDetai, string tenFileYeucau, byte[] yeucauDetai, string tenFileTailieu, byte[] tailieu, string tenGV, string loaiDoAn, string trangthai)
		{
			MaDetai = maDetai;
			TenDetai = tenDetai;
			TenFileYeucau = tenFileYeucau;
			YeucauDetai = yeucauDetai;
			TenFileTailieu = tenFileTailieu;
			Tailieu = tailieu;
			TenGV = tenGV;
			LoaiDoAn = loaiDoAn;
			Trangthai = trangthai;
		}
	}
	public class NhomSV
	{
		public string MaNhom;
		public string TenNhom;
		public string TenGV;
		public string TenDeTai;
		public NhomSV(string maNhom, string tenNhom, string tenGV, string tenDeTai)
		{
			MaNhom = maNhom;
			TenNhom = tenNhom;
			TenGV = tenGV;
			TenDeTai = tenDeTai;
		}
		public NhomSV(string maNhom) {
			MaNhom = maNhom;
		}
		public void SetMaNhom(string manhom)
		{
			MaNhom = manhom;
		}
	}
	public class SinhVien
	{
		public string MSSV;
		public string TenSV;
		public string NgaySinh;
		public string GioiTinh;
		public string Tennhom;
		public double Diem;
		public SinhVien()
		{

		}
		public SinhVien(string mSSV, string tenSV, string ngaySinh, string gioiTinh, string tennhom, double diem)
		{
			MSSV = mSSV;
			TenSV = tenSV;
			NgaySinh = ngaySinh;
			GioiTinh = gioiTinh;
			Tennhom = tennhom;
			Diem=diem;
		}
	}
	public class GiaoVien
	{
		public string MaGV;
		public string Hoten;
		public string NgaySinh;
		public string GioiTinh;
		public GiaoVien(string maGV, string hoten, string ngaySinh, string gioiTinh)
		{
			MaGV = maGV;
			Hoten = hoten;
			NgaySinh = ngaySinh;
			GioiTinh = gioiTinh;
		}
	}
	public class QuyenDoAn
	{
		public string STT;
		public string MasoDetai;
		public string TenDetai;
		public string TenFile;
		public byte[] Noidung;
		public string Tennhom;
		public string TenGV;
		public string Ngaynop;
		public string Diem;
		public QuyenDoAn()
		{
		}
		public QuyenDoAn(string sTT, string tenDetai, string tennhom, string tenGV, string ngaynop, string diem)
		{
			STT = sTT;
			TenDetai = tenDetai;
			Tennhom = tennhom;
			TenGV = tenGV;
			Ngaynop = ngaynop;
			Diem = diem;
		}
		public QuyenDoAn(string sTT, string tenDetai, string tennhom, string tenGV, string diem)
		{
			STT = sTT;
			TenDetai = tenDetai;
			Tennhom = tennhom;
			TenGV = tenGV;
			Diem = diem;
		}
		public QuyenDoAn(string sTT, string tenDetai, string tenFile, byte[] noidung, string tennhom, string tenGV, string ngaynop, string diem)
		{
			STT = sTT;
			TenDetai = tenDetai;
			TenFile = tenFile;
			Noidung = noidung;
			Tennhom = tennhom;
			TenGV = tenGV;
			Ngaynop = ngaynop;
			Diem = diem;
		}
	}
}
