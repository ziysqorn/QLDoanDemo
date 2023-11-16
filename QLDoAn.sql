create database QLDoAnNienLuan
go
use QLDoAnNienLuan
go
create table GiaoVien(
MaGV varchar(10) primary key,
Hoten nvarchar(50),
Ngaysinh date,
Phai bit,
Chucdanh varchar(20)
)
go
create table LoaiDoAn(
MaloaiDoAn varchar(10) primary key,
Sotinchi int
)
go
create table Detai(
MasoDetai int primary key IDENTITY(1,1),
TenDetai nvarchar(100),
TenFileNoidung nvarchar(50),
NoidungDetai varbinary(max),
TenFileTailieu nvarchar(50),
Tailieu varbinary(max),
MaloaiDoAn varchar(10)
foreign key (MaloaiDoAn) references LoaiDoAn(MaloaiDoAn)
)
go
create table NhomSinhVien(
Manhom int primary key IDENTITY(1,1),
Tennhom nvarchar(20),
MaGV varchar(10),
foreign key (MaGV) references GiaoVien(MaGV)
)
go
create table QuyenDoan(
STT int primary key IDENTITY(1,1),
Ngaynop datetime,
TenFile nvarchar(50),
Noidung varbinary(max),
Diem float,
MaGV varchar(10),
MasoDetai int,
Manhom int,
foreign key (MaGV) references GiaoVien(MaGV),
foreign key (MasoDetai) references Detai(MasoDetai),
foreign key (Manhom) references NhomSinhVien(Manhom)
)
go
create table SinhVien(
MSSV varchar(10) primary key,
Hoten nvarchar(50),
Ngaysinh date, 
Gioitinh bit,
Diem float,
Manhom int,
HSXuatSac bit,
foreign key (Manhom) references NhomSinhVien(Manhom),
)
go
create table Chitiet_GiaoVien_Detai(
MaGV varchar(10),
MasoDetai int,
Trangthai nvarchar(20)
foreign key (MaGV) references GiaoVien(MaGV),
foreign key (MasoDetai) references Detai(MasoDetai)
)
go
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104169', N'Trần Duy Quân', '2003-07-12', 0, 1)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104059', N'Mai Thành Danh', '2003-05-04', 0, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104071', N'Lưu Anh Dũng', '2003-12-15', 0, 1)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac)values('4701104148', N'Phạm Thành Nhân', '2003-06-20', 0, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac)values('4701104243', N'Lê Văn Vũ', '2003-03-02', 0, 1)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104177', N'Nguyễn Ngọc Quý', '2003-01-03', 0, 1)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104064', N'Phạm Thành Đạt', '2003-09-14', 0, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104002', N'Trần Thị Bích', '2003-07-14', 1, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104010', N'Lê Hoàng Cường', '2003-09-21', 0, 1)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104015', N'Phạm Thị Diệu Linh', '2003-03-03', 1, 1)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104013', N'Hoàng Minh Đức', '2003-12-25', 0, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac)values('4701104012', N'Đặng Văn Dũng', '2003-12-02', 0, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104020', N'Võ Thị Giang', '2003-11-20', 1, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104025', N'Lý Hồng Hạnh', '2003-05-14', 1, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104027', N'Đỗ Thị Hương', '2003-12-14', 1, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104030', N'Trương Văn Kiên', '2003-06-23', 0, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104016', N'Mai Thị Lan', '2003-08-15', 1, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104033', N'Bùi Văn Mạnh', '2003-02-05', 0, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104038', N'Đào Thị Nga', '2003-11-13', 1, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104040', N'Ngô Văn Oanh', '2003-09-27', 1, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104045', N'Huỳnh Thị Phương', '2003-01-14', 1, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104048', N'Lê Văn Quốc', '2003-04-15', 0, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104055', N'Phan Thị Thủy', '2003-08-28', 1, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104057', N'Dương Văn Tiến', '2002-03-12', 0, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104060', N'Vũ Thị Trang', '2003-05-03', 1, 0)
insert into SinhVien(MSSV, Hoten, Ngaysinh, Gioitinh, HSXuatSac) values('4701104090', N'Ngô Xuân Uyên', '2001-10-29', 1, 0)

insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV001', N'Nguyễn Văn A', '1979-01-01', 0)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV002', N'Trần Thị Ngọc B', '1985-09-28', 1)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV003', N'Lê Văn C', '1980-11-13', 0)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV004', N'Lương Thị Tú D', '1990-10-25', 1)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV005', N'Trần Ngọc Tú N', '1997-01-18', 1)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV006', N'Trần Duy T', '1987-10-30', 0)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV007', N'Trần Văn Lê Phú', '1993-04-02', 0)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV008', N'Nguyễn Thị Bình', '1992-04-02', 1)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV009', N'Trần Minh Châu', '1993-05-11', 1)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV010', N'Lê Thị Dung', '1990-08-22', 1)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV011', N'Phạm Văn Duy', '1987-11-11', 0)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV012', N'Hoàng Thị Hoa', '1988-12-22', 1)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV013', N'Đặng Văn Hùng', '1989-07-19', 0)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV014', N'Võ Thị Kim Anh', '1992-06-17', 1)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV015', N'Lý Quang Linh', '1994-02-13', 0)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV016', N'Đỗ Văn Nam', '1990-11-09', 0)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV017', N'Trương Thị Oanh', '1986-05-18', 1)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV018', N'Mai Văn Phú', '1991-09-08', 0)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV019', N'Bùi Thị Quỳnh', '1993-03-23', 1)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV020', N'Đào Văn Sơn', '1997-01-17', 0)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV021', N'Ngô Thị Thuận', '1995-10-30', 0)
insert into GiaoVien(MaGV, Hoten, Ngaysinh, Phai) values ('GV022', N'Huỳnh Văn Uyên', '1994-12-27', 1)

insert into LoaiDoAn values('LDA1', 2)
insert into LoaiDoAn values('LDA2', 3)
insert into LoaiDoAn values('LDA3', 3)

insert into Detai(TenDetai, MaloaiDoAn) values (N'Xác thực 2 yếu tố sử dụng Twilio', 'LDA2')
insert into Detai(TenDetai, MaloaiDoAn) values (N'Chart Control trong ASP.NET Core', 'LDA2')
insert into Detai(TenDetai, MaloaiDoAn) values (N'Cơ chế lưu cache trong .NET Core', 'LDA1')
insert into Detai(TenDetai, MaloaiDoAn) values (N'RethinkDB-real time database', 'LDA2')
insert into Detai(TenDetai, MaloaiDoAn) values (N'Report trong ASP.NET Core MVC', 'LDA1')
insert into Detai(TenDetai, MaloaiDoAn) values (N'SOLID Principles', 'LDA2')
insert into Detai(TenDetai, MaloaiDoAn) values (N'Quản lý thư viện sử dụng ASP.NET Core', 'LDA3')
insert into Detai(TenDetai, MaloaiDoAn) values (N'Quản lý phân phát báo tạp chí sử dụng ASP.NET Core', 'LDA3')
insert into Detai(TenDetai, MaloaiDoAn) values (N'Quản lý nhà hàng - khách sạn sử dụng ASP.NET Core', 'LDA3')
insert into Detai(TenDetai, MaloaiDoAn) values (N'Quản lý tuyển sinh đại học sử dụng ASP.NET Core', 'LDA3')

insert into Chitiet_GiaoVien_Detai values ('GV002', '1', N'Đang chờ duyệt')
insert into Chitiet_GiaoVien_Detai values ('GV002', '2', N'Đang chờ duyệt')
insert into Chitiet_GiaoVien_Detai values ('GV001', '5', N'Đang chờ duyệt')
insert into Chitiet_GiaoVien_Detai values ('GV003', '1', N'Đang chờ duyệt')
insert into Chitiet_GiaoVien_Detai values ('GV001', '3', N'Đang chờ duyệt')
insert into Chitiet_GiaoVien_Detai values ('GV004', '4', N'Đang chờ duyệt')
insert into Chitiet_GiaoVien_Detai values ('GV005', '4', N'Đang chờ duyệt')
insert into Chitiet_GiaoVien_Detai values ('GV001', '8', N'Đang chờ duyệt')
insert into Chitiet_GiaoVien_Detai values ('GV003', '10', N'Đang chờ duyệt')
insert into Chitiet_GiaoVien_Detai values ('GV006', '9', N'Đang chờ duyệt')
insert into Chitiet_GiaoVien_Detai values ('GV002', '10', N'Đã đăng tải')

insert into NhomSinhVien(Tennhom, MaGV) values (N'Sigma', 'GV001')
insert into NhomSinhVien(Tennhom, MaGV) values (N'3-Turtles', 'GV003')
insert into NhomSinhVien(Tennhom, MaGV) values (N'The Champions', 'GV002')
insert into NhomSinhVien(Tennhom, MaGV) values (N'The Boys', 'GV004')
insert into NhomSinhVien(Tennhom, MaGV) values (N'Chillies', 'GV002')
insert into NhomSinhVien(Tennhom, MaGV) values (N'Bros', 'GV003')

dbcc checkident('NhomSinhVien', reseed, 1)
dbcc checkident('QuyenDoan', reseed, 1)
dbcc checkident('Detai', reseed, 1)


delete from SinhVien
delete from QuyenDoan
delete from Chitiet_GiaoVien_Detai
delete from Detai
delete from NhomSinhVien


drop table GiaoVien
drop table NhomSinhVien
drop table QuyenDoan
drop table Detai
drop table Chitiet_GiaoVien_Detai
drop table SinhVien