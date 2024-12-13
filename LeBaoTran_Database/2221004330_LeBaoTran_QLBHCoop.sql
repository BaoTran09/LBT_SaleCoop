create database QLBH_Coop
use  QLBH_Coop

create table COSO
(
MaCS nchar(5) primary key not null,
TenCS nvarchar(50) null,
DiaChiCS nvarchar(100) null,
)

create table LoaiHH
(
MaLoaiHH nchar(5) primary key not null,
TenLoai nvarchar(100) null,
)
create table DMHangHoa
(
MaHH nchar(5) primary key not null,
MaLoaiHH nchar(5) not null,
TenHH nvarchar(100) null,
MaCS nchar(5) not null,
SLTon int null,
DonGia float null,
HinhAnh nvarchar(100) null,
DVT nvarchar(20) null,
constraint FK_DMHH_MaLHH foreign key (MaLoaiHH) references LoaiHH(MaLoaiHH),
constraint FK_DMHH_MaCS foreign key (MaCS) references COSO(MaCS)
)

create table KhachHang
(
MaKH nchar(5) primary key not null,
TenKH nvarchar(50) null,
Nu bit,
Nam bit,
SDT_KH nchar(10) null,
DiaChi nvarchar(100) null,
HangKHTT nvarchar(30) null,
)

create table NhanVien
(
MaNV nchar(5) primary key not null,
TenNV nvarchar(50) null,
Nu bit,
Nam bit,
SDT_NV nchar(10) null,
DiaChiNV nvarchar(100) null,
ChucVu nvarchar(50) null,
MaCS nchar(5) not null,
UserName nchar(10) not null,
constraint FK_NhanVien_MaCS foreign key (MaCS) references COSO(MaCS),
constraint FK_NhanVien_UserName foreign key (UserName) references Account(UserName)
);


create table Account 
(
UserName nchar(10) primary key not null,
PassW nchar(10) not null,
)

create table HoaDon
(
MaHD nchar(5) primary key not null,
MaNV nchar(5) not null,
MaKH nchar(5) not null,
NgayinHD date,
constraint FK_HoaDon_MaNV foreign key (MaNV) references NhanVien (MaNV),
constraint FK_HoaDon_MaKH foreign key (MaKH) references KhachHang (MaKH)
)

create table CTHD
(
MaHD nchar(5)  not null,
MaHH nchar(5) not null,
SLban int null,
constraint PK_CTHD primary key (MaHD,MaHH),
constraint FK_CTHD_MaHD foreign key (MaHD) references HoaDon (MaHD),
constraint FK_CTHD_MaHH foreign key (MaHH) references DMHangHoa (MaHH)
)
create table PhieuThuTien
(
MaPT nchar(5) primary key not null,
MaHD nchar(5) not null,
TGThuTien datetime,
PTTT nvarchar(30) null,
TriGia float ,
TrangThaiTT nvarchar(50) null,
constraint FK_PhieuThuTien_MaHD foreign key (MaHD) references HoaDon (MaHD),
)
create table TKC1
(
MaTKC1 int primary key not null,
TenTKC1 nvarchar (50) null,
)
create table TKC2
(
MaTKC2 int primary key not null,
TenTKC2 nvarchar (50) null,
MaTKC1 int not null, 
constraint FK_TKC2_MaTKC1 foreign key (MaTKC1) references TKC1(MaTKC1)
)
create table TKCT
(
MaTKCT nchar(10) primary key not null,
TenTKCT nvarchar(100) null,
MaTKC2 int not null,
MoTa nvarchar(150) null,
constraint FK_TKCT_MaTKC2 foreign key (MaTKC2) references TKC2(MaTKC2)
)

create table SoDuDK
(
MaTKC2 int not null,
NgayDK date not null,
TenTKC2 nvarchar(100) null,
SoDuNo float null,
SoDuCo float null,
constraint PK_SoDuDK primary key (MaTKC2,NgayDK),
constraint FK_SoDuDK_MaTKC2 foreign key (MaTKC2) references TKC2(MaTKC2)
)

create table ButToan
(
MaBT nchar(10) primary key not null,
MaTKCT nchar(10) not null,
MaPT nchar(5) not null,
TKNo nchar(10) null,
TKCo nchar(10) null,
NgayLapBT date null,
DienGiai nvarchar(100) null,
Tong float null,
constraint FK_ButToan_MaTKCT foreign key (MaTKCT) references TKCT(MaTKCT),
constraint FK_ButToan_MaPT foreign key (MaPT) references PhieuThuTien(MaPT)
)
drop table ButToan
SELECT * FROM dbo.HoaDon
SELECT TABLE_SCHEMA, TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_NAME = 'HoaDon'
------------NHẬP LIỆU
-----CỞ SỞ 
SELECT * FROM COSO
INSERT INTO COSO (MaCS, TenCS, DiaChiCS)
VALUES
('CS001', N'Cơ sở Co.opmart Biên Hòa', N'121 Võ Thị Sáu, Biên Hòa, Đồng Nai'),
('CS002', N'Cơ sở Co.opmart Bình Dương', N'500 Đại Lộ Bình Dương, Thủ Dầu Một, Bình Dương');

------LOẠI HÀNG HÓA
INSERT INTO LoaiHH (MaLoaiHH, TenLoai)
VALUES
('LHH01', N'Thực phẩm tươi sống'),
('LHH02', N'Đồ uống'),
('LHH03', N'Hóa mỹ phẩm'),
('LHH04', N'Thực phẩm khô'),
('LHH05', N'Sữa và các sản phẩm từ sữa'),
('LHH06', N'Đồ gia dụng'),
('LHH07', N'Quần áo và thời trang'),
('LHH08', N'Điện gia dụng'),
('LHH09', N'Sách và văn phòng phẩm'),
('LHH10', N'Đồ chơi trẻ em');
------DANH MỤC HÀNG HÓA
INSERT INTO DMHangHoa (MaHH, MaLoaiHH, TenHH, MaCS, SLTon, DonGia, DVT, HinhAnh) 
VALUES
('HH001', 'LHH01', N'Thịt heo ba rọi', 'CS001', 100, 150000, N'Kg', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\thit_heo_ba_roi.jpg'),
('HH002', 'LHH02', N'Nước ngọt Coca-Cola', 'CS001', 200, 10000, N'Chai', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\coca_cola.jpg'),
('HH003', 'LHH03', N'Bột giặt OMO 3kg', 'CS001', 50, 95000, N'Kg', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\bot_giat_omo.jpg'),
('HH004', 'LHH04', N'Mì gói Hảo Hảo', 'CS001', 300, 3000, N'Gói', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\mi_goi_hao_hao.jpg'),
('HH005', 'LHH05', N'Sữa Vinamilk 1L', 'CS001', 100, 30000, N'Chai', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\sua_vinamilk.jpg'),
('HH006', 'LHH06', N'Nồi cơm điện Sharp', 'CS001', 20, 1500000, N'Cái', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\noi_com_dien_sharp.jpg'),
('HH007', 'LHH07', N'Áo sơ mi nam', 'CS001', 50, 200000, N'Cái', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\ao_so_mi_nam.jpg'),
('HH008', 'LHH08', N'Quạt điện Toshiba', 'CS001', 30, 1200000, N'Cái', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\quat_dien_toshiba.jpg'),
('HH009', 'LHH09', N'Sách giáo khoa lớp 12', 'CS001', 200, 50000, N'Cuốn', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\sach_giao_khoa_lop_12.jpg'),
('HH010', 'LHH10', N'Lego Creator 3in1', 'CS001', 15, 1200000, N'Bộ', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\lego_creator.jpg'),
('HH011', 'LHH01', N'Cá hồi phi lê', 'CS002', 60, 250000, N'Kg', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\ca_hoi_phi_le.jpg'),
('HH012', 'LHH02', N'Nước tăng lực Red Bull', 'CS002', 150, 12000, N'Lon', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\red_bull.jpg'),
('HH013', 'LHH03', N'Kem đánh răng Colgate', 'CS002', 200, 25000, N'Tuýp', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\kem_danh_rang_colgate.jpg'),
('HH014', 'LHH04', N'Đậu phộng rang muối', 'CS002', 80, 45000, N'Gói', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\dau_phong_rang_muoi.jpg'),
('HH015', 'LHH05', N'Phô mai con bò cười', 'CS002', 90, 40000, N'Hộp', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\pho_mai_con_bo_cuoi.jpg'),
('HH016', 'LHH06', N'Chảo chống dính Sunhouse', 'CS002', 40, 320000, N'Cái', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\chao_chong_dinh_sunhouse.jpg'),
('HH017', 'LHH07', N'Áo khoác nữ mùa đông', 'CS002', 30, 500000, N'Cái', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\ao_khoac_nu_mua_dong.jpg'),
('HH018', 'LHH08', N'Máy ép trái cây Panasonic', 'CS002', 25, 2700000, N'Cái', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\may_ep_trai_cay_panasonic.jpg'),
('HH019', 'LHH09', N'Bút bi Thiên Long', 'CS002', 500, 5000, N'Cái', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\but_bi_thien_long.jpg'),
('HH020', 'LHH10', N'Búp bê Barbie', 'CS002', 20, 450000, N'Cái', 'C:\\Users\\trann\\Downloads\\SaleCoop\\MediaCoop\\bup_be_barbie.jpg');

INSERT INTO KhachHang (MaKH, TenKH, Nu, Nam, SDT_KH, DiaChi, HangKHTT)
VALUES
('KH001', N'Nguyễn Văn An', 0, 1, '0909123456', N'12 Nguyễn Trãi, Q.1, TP.HCM', N'Vàng'),
('KH002', N'Trần Thị Bình', 1, 0, '0912123456', N'25 Lê Lợi, Q.3, TP.HCM', N'Bạc'),
('KH003', N'Lê Hoàng Công', 0, 1, '0903123456', N'56 Lý Tự Trọng, Q.1, TP.HCM', N'Vàng'),
('KH004', N'Phạm Ngọc Diễm', 1, 0, '0907123456', N'78 Nguyễn Đình Chiểu, Q.3, TP.HCM', N'Bạc'),
('KH005', N'Võ Thị Thảo', 1, 0, '0932123456', N'89 Điện Biên Phủ, Q.10, TP.HCM', N'Kim Cương'),
('KH006', N'Hoàng Văn Thắng', 0, 1, '0933123456', N'23 Cách Mạng Tháng Tám, Q.1, TP.HCM', N'Bạc'),
('KH007', N'Nguyễn Thị Giang', 1, 0, '0943123456', N'45 Võ Văn Tần, Q.3, TP.HCM', N'Vàng'),
('KH008', N'Đỗ Văn Hoàng', 0, 1, '0917123456', N'67 Nguyễn Văn Trỗi, Q.Phú Nhuận, TP.HCM', N'Bạc'),
('KH009', N'Phan Thị Thúy', 1, 0, '0908123456', N'89 Pasteur, Q.1, TP.HCM', N'Kim Cương'),
('KH010', N'Lý Văn Dũng', 0, 1, '0928123456', N'123 Nam Kỳ Khởi Nghĩa, Q.3, TP.HCM', N'Bạc');
--------ACCOUNT 

delete from Account where UserName='Admin'
delete from Account where UserName='ThuNgan'
delete from Account where UserName='KeToan'
delete from Account where UserName='QuanLy'

INSERT INTO Account (UserName, PassW)
VALUES
('QL_Mai','123'),
('TN_Tung','1234'),
('TN_Lan','1234'),
('TN_Huy','1234'),
('TN_Hanh','1234'),
('TN_Tai','1234'),
('TN_Tran','1234'),
('KT_An','12345'),
('AD_Huong','123456');
INSERT INTO Account (UserName, PassW)
VALUES
('TN_Khue','1234');
select * from Account
select *from NhanVien
----NHÂN VIÊN
INSERT INTO NhanVien (MaNV, TenNV, Nu, Nam, SDT_NV, DiaChiNV, ChucVu, MaCS, UserName)
VALUES
('NV001', N'Nguyễn Thị Mai', 1, 0, '0908234567', N'36 Lý Thái Tổ, Q.10, TP.HCM', N'Nhân viên thu ngân', 'CS001','QuanLy'),
('NV002', N'Trần Văn An', 0, 1, '0919234567', N'01 Nguyễn Kiệm, Q.Phú Nhuận, TP.HCM', N'Nhân viên thu ngân', 'CS001','KeToan'),
('NV003', N'Lê Thị Hương', 1, 0, '0931234567', N'189C Cống Quỳnh, Q.1, TP.HCM', N'Nhân viên thu ngân', 'CS001','Admin'),
('NV004', N'Phạm Văn Tùng', 0, 1, '0941234567', N'69 Đinh Tiên Hoàng, Q.Bình Thạnh, TP.HCM', N'Nhân viên thu ngân', 'CS001','ThuNgan'),
('NV005', N'Võ Thị Lan', 1, 0, '0951234567', N'191 Xa Lộ Hà Nội, Q.2, TP.HCM', N'Nhân viên thu ngân', 'CS001','ThuNgan'),
('NV006', N'Nguyễn Văn Huy', 0, 1, '0961234567', N'385 Nguyễn Ảnh Thủ, Q.12, TP.HCM', N'Quản lý', 'CS002','ThuNgan'),
('NV007', N'Đặng Thị Hạnh', 1, 0, '0971234567', N'97 Cách Mạng Tháng Tám, Bà Rịa', N'Kế toán', 'CS002','ThuNgan'),
('NV008', N'Hoàng Văn Tài', 0, 1, '0981234567', N'36 Nguyễn Thái Học, TP.Vũng Tàu', N'Nhân viên kỹ thuật', 'CS002','ThuNgan');
update NhanVien set UserName ='QL_Mai' where MaNV='NV001';
update NhanVien set UserName ='KT_An' where MaNV='NV002';
update NhanVien set UserName ='AD_Huong' where MaNV='NV003';
update NhanVien set UserName ='TN_Tung' where MaNV='NV004';
update NhanVien set UserName ='TN_Lan' where MaNV='NV005';
update NhanVien set UserName ='TN_Huy' where MaNV='NV006';
update NhanVien set UserName ='TN_Hanh' where MaNV='NV007';
update NhanVien set UserName ='TN_Tai' where MaNV='NV008';
update NhanVien set UserName ='TN_Tran' where MaNV='NV009';



update Account 
set UserName='ThuNgan_Hanh'
where UserName='ThuNgan'

----
INSERT INTO TKC1 (MaTKC1, TenTKC1)
VALUES
('111', N'Tiền mặt'),
('112', N'Tiền gửi ngân hàng'),
('113', N'Tiền đang chuyển'),
('131', N'Phải thu khách hàng'),
('133', N'Thuế GTGT được khấu trừ'),
('156', N'Hàng hóa'),
('157', N'Hàng gửi đi bán'),
('331', N'Phải trả người bán'),
('333', N'Thuế và các khoản phải nộp Nhà nước'),
('334', N'Phải trả người lao động'),
('335', N'Chi phí phải trả'),
('511', N'Doanh thu bán hàng và cung cấp dịch vụ'),
('515', N'Doanh thu hoạt động tài chính'),
('521', N'Các khoản giảm trừ doanh thu'),
('641', N'Chi phí bán hàng'),
('642', N'Chi phí quản lý doanh nghiệp'),
('711', N'Thu nhập khác'),
('811', N'Chi phí khác'),
('821', N'Chi phí thuế TNDN'),
('911', N'Xác định kết quả kinh doanh');

INSERT INTO TKC2 (MaTKC2, TenTKC2, MaTKC1)
VALUES
-- Tiền mặt (111)
('1111', N'Tiền Việt Nam', '111'),
('1112', N'Ngoại tệ', '111'),

-- Tiền gửi ngân hàng (112)
('1121', N'Tiền Việt Nam gửi ngân hàng', '112'),
('1122', N'Ngoại tệ gửi ngân hàng', '112'),

-- Tiền đang chuyển (113)
('1131', N'Tiền chuyển qua bưu điện', '113'),
('1132', N'Tiền chuyển qua ngân hàng', '113'),

-- Phải thu khách hàng (131)
('1311', N'Phải thu khách hàng ngắn hạn', '131'),
('1312', N'Phải thu khách hàng dài hạn', '131'),

-- Thuế GTGT được khấu trừ (133)
('1331', N'Thuế GTGT của hàng hóa, dịch vụ', '133'),

-- Hàng hóa (156)
('1561', N'Giá mua hàng hóa', '156'),

-- Hàng gửi đi bán (157)
('1571', N'Hàng gửi đi bán chưa thu tiền', '157'),
('1572', N'Hàng gửi đi bán đã thu tiền', '157'),

-- Phải trả người bán (331)
('3311', N'Phải trả nhà cung cấp ngắn hạn', '331'),
('3312', N'Phải trả nhà cung cấp dài hạn', '331'),

-- Thuế và các khoản phải nộp Nhà nước (333)
('3331', N'Thuế GTGT phải nộp', '333'),
('3332', N'Thuế thu nhập doanh nghiệp phải nộp', '333'),
('3333', N'Thuế khác phải nộp', '333'),

-- Phải trả người lao động (334)
('3341', N'Lương nhân viên', '334'),
('3343', N'Các khoản phải trả khác cho nhân viên', '334'),

-- Doanh thu bán hàng và cung cấp dịch vụ (511)
('5111', N'Doanh thu bán hàng hóa', '511'),
('5112', N'Doanh thu bán thành phẩm', '511'),
('5113', N'Doanh thu cung cấp dịch vụ', '511'),
('5118', N'Doanh thu khác', '511'),

-- Các khoản giảm trừ doanh thu (521)
('5211', N'Giảm giá hàng bán', '521'),
('5212', N'Chiết khấu thương mại', '521'),

-- Chi phí quản lý doanh nghiệp (642)
('6421', N'Chi phí nhân viên quản lý', '642'),
('6422', N'Chi phí văn phòng phẩm', '642'),

-- Xác định kết quả kinh doanh (911)
('9111', N'Doanh thu và thu nhập', '911');
------
INSERT INTO TKCT (MaTKCT, TenTKCT, MaTKC2, MoTa) VALUES
-- Tiền mặt (1111)
('1111.01', N'Tiền mặt tại quầy 1', '1111', N'Tiền mặt lưu tại quầy bán hàng 1'),
('1111.02', N'Tiền mặt tại quầy 2', '1111', N'Tiền mặt lưu tại quầy bán hàng 2'),

-- Tiền gửi ngân hàng (1121)
('1121.01', N'Tiền Việt Nam gửi tại Vietcombank', '1121', N'Tiền VNĐ gửi tại ngân hàng Vietcombank'),
('1121.02', N'Tiền Việt Nam gửi tại BIDV', '1121', N'Tiền VNĐ gửi tại ngân hàng BIDV'),
('1121.03', N'Tiền Việt Nam gửi tại Techcombank', '1121', N'Tiền VNĐ gửi tại ngân hàng Techcombank'),

-- Phải thu khách hàng trong nước (1311)
('1311.01', N'Phải thu khách hàng mua lẻ', '1311', N'Tiền phải thu từ khách hàng lẻ'),
-- Thuế GTGT được khấu trừ (1331)
('1331.01', N'Thuế GTGT của hàng hóa', '1331', N'Thuế GTGT được khấu trừ từ hàng hóa bán ra'),
('1331.02', N'Thuế GTGT của dịch vụ', '1331', N'Thuế GTGT được khấu trừ từ dịch vụ cung cấp'),

-- Hàng hóa (156)
('156.01', N'Hàng hóa bán ra', '1561', N'Hàng hóa đã bán cho khách hàng'),


-- Phải trả người bán (331)
('331.01', N'Phải trả người bán MaSan', '3311', N'Tiền phải trả cho nhà cung cấp MaSan'),
('331.02', N'Phải trả người bán Omaji', '3311', N'Tiền phải trả cho nhà cung cấp Omaji'),
('331.03', N'Phải trả người bán Vinamilk', '3311', N'Tiền phải trả cho nhà cung cấp Vinamilk'),

-- Doanh thu bán hàng và cung cấp dịch vụ (511)
('511.01', N'Doanh thu bán hàng hóa', '5111', N'Doanh thu từ việc bán hàng hóa'),
('511.02', N'Doanh thu cung cấp dịch vụ', '5113', N'Doanh thu từ việc cung cấp dịch vụ');
----------
insert into HoaDon(MaHD, MaNV, MaKH, NgayinHD) values
('HD001','NV001','KH001','2024-09-09'),
('HD002','NV001','KH002','2024-09-09'),
('HD003','NV002','KH003','2024-09-10'),
('HD004','NV002','KH004','2024-09-10'),
('HD005','NV003','KH005','2024-09-11'),
('HD006','NV003','KH006','2024-09-11'),
('HD007','NV004','KH007','2024-09-12'),
('HD008','NV004','KH008','2024-09-12'),
('HD009','NV005','KH009','2024-09-13'),
('HD010','NV005','KH010','2024-09-13');

-----
insert into CTHD(MaHD, MaHH, SLBan) values
('HD001','HH001',2),
('HD001','HH002',1),
('HD001','HH003',3),
('HD001','HH004',4),
('HD001','HH005',3),
-- Chi tiết hóa đơn HD002
('HD002','HH002',2),
('HD002','HH006',1),
('HD002','HH007',5),
('HD002','HH008',3),

-- Chi tiết hóa đơn HD003
('HD003','HH001',1),
('HD003','HH004',2),
('HD003','HH009',4),
('HD003','HH010',2),

-- Chi tiết hóa đơn HD004
('HD004','HH003',3),
('HD004','HH006',2),
('HD004','HH007',1),
('HD004','HH002',4),

-- Chi tiết hóa đơn HD005
('HD005','HH005',1),
('HD005','HH008',3),
('HD005','HH009',2),
('HD005','HH004',5),

-- Chi tiết hóa đơn HD006
('HD006','HH002',1),
('HD006','HH003',2),
('HD006','HH006',3),
('HD006','HH010',4),

-- Chi tiết hóa đơn HD007
('HD007','HH001',2),
('HD007','HH007',1),
('HD007','HH005',5),
('HD007','HH009',3),

-- Chi tiết hóa đơn HD008
('HD008','HH004',2),
('HD008','HH008',1),
('HD008','HH006',4),
('HD008','HH003',5),

-- Chi tiết hóa đơn HD009
('HD009','HH002',2),
('HD009','HH010',1),
('HD009','HH001',3),
('HD009','HH009',4),

-- Chi tiết hóa đơn HD010
('HD010','HH005',2),
('HD010','HH003',1),
('HD010','HH007',3),
('HD010','HH008',4);

----------------
insert into PhieuThuTien(MaPT, MaHD, TGThuTien, PTTT, TriGia, TrangThaiTT) values
('PT001', 'HD001', '2024-09-09', 'QR', 3000000, 'Đã thanh toán'),
('PT002', 'HD002', '2024-09-09', 'QR', 2500000, 'Đã thanh toán'),
('PT003', 'HD003', '2024-09-10', N'Tiền mặt', 2200000, 'Đã thanh toán'),
('PT004', 'HD004', '2024-09-10', 'QR', 2700000, 'Đã thanh toán'),
('PT005', 'HD005', '2024-09-11', N'Tiền mặt', 2900000, 'Đã thanh toán'),
('PT006', 'HD006', '2024-09-11', 'QR', 2000000, 'Đã thanh toán'),
('PT007', 'HD007', '2024-09-12', N'Tiền mặt', 3300000, 'Đã thanh toán'),
('PT008', 'HD008', '2024-09-12', 'QR', 2400000, 'Đã thanh toán'),
('PT009', 'HD009', '2024-09-13', 'QR', 3100000, 'Đã thanh toán'),
('PT010', 'HD010', '2024-09-13', N'Tiền mặt', 3200000, 'Đã thanh toán');
---------
select * from SoDuDK
insert into SoDuDK(MaTKC2, NgayDK, TenTKC2, SoDuNo, SoDuCo) values
-- Tiền mặt (111)
('1111', '2024-01-09', N'Tiền Việt Nam', 5000000,0),
-- Tiền gửi ngân hàng (112)
('1121', '2024-01-09', N'Tiền Việt Nam gửi ngân hàng', 15000000, 0),

-- Doanh thu bán hàng (511)
('5111', '2024-01-09', N'Doanh thu bán hàng hóa', 0, 0);
----------------
INSERT INTO ButToan (MaBT, MaTKCT, MaPT, TKNo, TKCo, NgayLapBT, DienGiai, Tong) VALUES
('BT001', '1111.01', 'PT001', '1111', '5111', '2024-09-09', N'Ghi nhận tiền mặt thu từ khách hàng KH001', 300000),
('BT002', '1111.02', 'PT002', '1111', '5111', '2024-09-09', N'Ghi nhận tiền mặt thu từ khách hàng KH002', 500000),
('BT003', '1111.01', 'PT003', '1111', '5111', '2024-09-10', N'Ghi nhận tiền mặt thu từ khách hàng KH003', 200000),
('BT004', '1121.01', 'PT004', '1121', '5111', '2024-09-10', N'Chuyển khoản ngân hàng từ khách hàng KH004', 1000000),
('BT005', '1121.02', 'PT005', '1121', '5111', '2024-09-11', N'Chuyển khoản ngân hàng từ khách hàng KH005', 800000),
('BT006', '1121.01', 'PT006', '1121', '5111', '2024-09-11', N'Chuyển khoản ngân hàng từ khách hàng KH006', 400000),
('BT007', '1111.01', 'PT007', '1111', '5111', '2024-09-12', N'Ghi nhận tiền mặt thu từ khách hàng KH007', 1200000),
('BT008', '1111.02', 'PT008', '1111', '5111', '2024-09-12', N'Ghi nhận tiền mặt thu từ khách hàng KH008', 600000),
('BT009', '1121.01', 'PT009', '1121', '5111', '2024-09-13', N'Chuyển khoản ngân hàng từ khách hàng KH009', 1000000),
('BT010', '1121.02', 'PT010', '1121', '5111', '2024-09-13', N'Chuyển khoản ngân hàng từ khách hàng KH010', 1500000);
------------------
select * from DMHangHoa

update  DMHangHoa
set HinhAnh=''
where MaHH='HH001'


----------------------------TRIGGER
--1. SLBan của hàng hóa trong bảng CTHD luôn lớn hơn 0.
CREATE TRIGGER tg_SLB
ON CTHD
FOR INSERT, UPDATE 
AS
BEGIN
    -- Kiểm tra nếu có bất kỳ số lượng bán nào <= 0
    IF EXISTS (
        SELECT 1 
        FROM inserted 
        WHERE SLBan <= 0
    )
    BEGIN
        PRINT  N'Bạn nhớ thêm số lượng hàng hóa nhé!'
	ROLLBACK
	END
END 
-- KIỂM THỬ 
--Thêm thông tin hóa đơn 
insert into HoaDon(MaHD, MaNV, MaKH, NgayinHD) values
('HD011','NV005','KH010','2024-09-13');
-- Chi tiết hóa đơn HD011
insert into CTHD(MaHD, MaHH, SLBan) values
('HD011','HH005',2);
-- Chỉnh sửa chi tiết hóa đơn HD011
update CTHD
set SLBan = 0
where MaHD='HD011';
/*
delete from CTHD where MaHD='HD011';
delete from HoaDon where MaHD='HD011';
*/
-- 3. TẠO TRIGGER GIỚI HẠN SỐ LƯỢNG BÁN BẰNG HOẶC NHỎ HƠN SỐ LƯỢNG TỒN CỦA HÀNG HÓA
CREATE TRIGGER tg_uiSLBan_Ton
ON CTHD
FOR INSERT, UPDATE
AS
BEGIN
    -- Kiểm tra nếu số lượng bán vượt quá số lượng tồn kho
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN DMHangHoa h ON i.MaHH = h.MaHH
        WHERE i.SLBan > h.SLTon 
		)
    BEGIN
        PRINT N'Số lượng bán không được vượt quá số lượng tồn của hàng hóa.'
        ROLLBACK 
    END
END
---KIỂM THỬ
--THÔNG TIN CỦA HÀNG HÓA CÓ MÃ 'HH001'
INSERT INTO DMHangHoa (MaHH, MaLoaiHH, TenHH, MaCS, SLTon, DonGia, DVT, HinhAnh) 
VALUES
('HH001', 'LHH01', N'Thịt heo ba rọi', 'CS001', 100, 150000, N'Kg', 'thit_heo_ba_roi.jpg');
--Thêm thông tin hóa đơn 
insert into HoaDon(MaHD, MaNV, MaKH, NgayinHD) values
('HD011','NV005','KH010','2024-09-13');
-- Thêm Chi tiết hóa đơn HD011
insert into CTHD(MaHD, MaHH, SLBan) values
('HD011','HH001',2);
-- Chỉnh sửa chi tiết hóa đơn HD011
update CTHD
set SLBan = 101
where MaHD='HD011';
drop trigger tg_uiSLBan_Ton

-- 4. TẠO TRIGGER KIỂM TRA TRÙNG LẶP DỮ LIỆU CỦA KHÁCH HÀNG TRƯỚC KHI THÊM 
CREATE TRIGGER tg_KiemTraTrungLap
ON KhachHang
FOR INSERT
AS
BEGIN
    DECLARE  @SDT NVARCHAR(10);
    SELECT @SDT = SDT_KH FROM inserted;
    IF EXISTS (SELECT * FROM KhachHang WHERE SDT_KH = @SDT)
    BEGIN
		PRINT 'Khach hang da ton tai voi so dien thoai va email nay!'
		ROLLBACK
    END
    INSERT INTO KhachHang (MaKH, TenKH, Nu,Nam, SDT_KH, DiaChi, HangKHTT) 
    SELECT * FROM inserted
END

-- KIỂM THỬ 
-- TRƯỜNG HỢP KHÔNG TRÙNG SỐ ĐIỆN THOẠI 
INSERT INTO KhachHang (MaKH, TenKH, Nu, Nam, SDT_KH, DiaChi, HangKHTT)
VALUES
('KH011', N'Nguyễn Văn An', 0, 1, '0909123456', N'12 Nguyễn Trãi, Q.1, TP.HCM', N'Vàng'),



------------THÊM NHÂN VIÊN
create proc [dbo].[ThemNhanVien] 
@MaNV nchar(5),
@TenNV nvarchar(50),
@Nu bit, @Nam bit,
@SDT nchar(10),
@DiaChi nvarchar(100),
@ChucVu nvarchar(50),
@MaCS nchar(5),
@UserName nchar(10)
as 
begin 
insert into NhanVien (MaNV, TenNV, Nu, Nam,SDT_NV, DiaChiNV, ChucVu, MaCS, UserName)
values (@MaNV,@TenNV ,@Nu , @Nam ,@SDT ,@DiaChi,@ChucVu ,@MaCS ,@UserName )
end 
---------------SỬA NHÂN VIÊN
create proc [dbo].[SuaNhanVien] 
@MaNV nchar(5),
@TenNV nvarchar(50),
@Nu bit, @Nam bit,
@SDT nchar(10),
@DiaChi nvarchar(100),
@ChucVu nvarchar(50),
@MaCS nchar(5),
@UserName nchar(10)
as 
begin 
update  NhanVien
set TenNV=@TenNV, Nu=@Nu, Nam=@Nam, SDT_NV=@SDT, DiaChiNV=@DiaChi, ChucVu=@ChucVu, MaCS=@MaCS, UserName=@UserName
where MaNV=@MaNV
end 
-------
CREATE PROCEDURE [dbo].[GetTenHH]
    @MaHH nchar(5)
AS
BEGIN
    SELECT TenHH FROM DMHangHoa WHERE MaHH = @MaHH
END
-- Kiểm tra Stored Procedure
EXEC [dbo].[GetTenHH] @MaHH = 'HH001'
-----
create proc [dbo].[ThemHH]
@MaHH nchar(5),
@MaLoaiHH nchar(5),
@TenHH nvarchar (100),
@MaCS nchar(5),
@SLTon int ,
@DonGia float,
@HinhAnh nvarchar(100),
@DVT nvarchar(20)
as begin 
update DMHangHoa 
set 
@MaLoaiHH=MaLoaiHH,
@TenHH =TenHH,
@MaCS =MaCS,
@SLTon=SLTon,
@DonGia=DonGia,
@HinhAnh =HinhAnh,
@DVT =DVT
where  @MaHH =MaHH
end 



-----------------------show HangHang

SELECT C.MaHD, C.MaHH, D.TenHH, D.MaLoaiHH, D.DonGia, D.DVT
FROM CTHD C
INNER JOIN DMHangHoa D ON C.MaHH = D.MaHH
WHERE C.MaHD = @MaHD


-------------THÊM HÓA ĐƠN
create proc [dbo].[sp_ThemHoaDon] @MaHD nchar(5), @MaNV nchar(5), @MaKH nchar(5), @NgayinHD date
as 
begin
insert into HoaDon(MaHD, MaNV, MaKH, NgayinHD) values (@MaHD , @MaNV , @MaKH , @NgayinHD)
end 
-------------SỬA HÓA ĐƠN
create proc [dbo].[sp_SuaHoaDon] @MaHD nchar(5), @MaNV nchar(5), @MaKH nchar(5), @NgayinHD date
as 
begin
update  HoaDon 
set  MaNV=@MaNV, MaKH=@MaKH, NgayinHD=@NgayinHD
where MaHD=@MaHD
end 

----THÊM PHIẾU THU
SELECT * FROM PHIEUTHUTIEN
create proc [dbo].[sp_ThemPTT] @MaPT nchar(5), @MaHD nchar(5), @TGThuTien date, @PTTT nvarchar(30), @TriGia float , @TrangThaiTT nvarchar(50)
as 
begin 
insert into PhieuThuTien(MaPT,MaHD,TGThuTien,PTTT,TriGia,TrangThaiTT) values 
(@MaPT , @MaHD , @TGThuTien , @PTTT, @TriGia  , @TrangThaiTT)
end 
-----SƯA PHIẾU THU
create proc [dbo].[sp_SuaPTT] @MaPT nchar(5), @MaHD nchar(5), @TGThuTien date, @PTTT nvarchar(30), @TriGia float , @TrangThaiTT nvarchar(50)
as 
begin 
update  PhieuThuTien
set MaHD=@MaHD,TGThuTien=@TGThuTien,PTTT=@PTTT,TriGia=@TriGia,TrangThaiTT=@TrangThaiTT
where MaPT=@MaPT
end 
-----THÊM BÚT TOÁN
create proc [dbo].[sp_ThemBT] @MaBT nchar(5), @MaTKCT nchar(10), @MaPT nchar(5), @TKNo nchar(10), @TKCo nchar(10), @NgayLapBT date, @DienGiai nvarchar(100), @Tong float
as begin
insert into ButToan (MaBT, MaTKCT, MaPT, TKNo, TKCo,NgayLapBT, DienGiai,Tong)
values (@MaBT, @MaTKCT , @MaPT , @TKNo, @TKCo, @NgayLapBT , @DienGiai , @Tong)
end 

------SỬA BÚT TOÁN
create proc [dbo].[sp_SuaBT] @MaBT nchar(5), @MaTKCT nchar(10), @MaPT nchar(5), @TKNo nchar(10), @TKCo nchar(10), @NgayLapBT date, @DienGiai nvarchar(100), @Tong float
as begin
update ButToan
set MaTKCT=@MaTKCT,MaPT=@MaPT,TKNo=@TKNo,TKCo=@TKCo,NgayLapBT=@NgayLapBT,DienGiai=@DienGiai,Tong=@Tong
where MaBT=@MaBT
end 
-----
create proc sp_MaKH @MaKH nchar(5)
as begin 
select * from KhachHang
where MaKH=@MaKH
end 

exec sp_MaKH @MaKH='KH001'
select * from KhachHang

create proc sp_TGThuTien @Ngay date
as begin 
select * from PhieuThuTien
where TGThuTien=@Ngay
end 
---
create proc sp_MaDH @MaHD nchar(5)
as begin
SELECT *  FROM HoaDon WHERE MaHD = @MaHD
end 
drop proc sp_MaDH
exec sp_MaDH @MaHD='HD001'
-----
create proc sp_DienGiai @DienGiai nchar(100)
as begin 
SELECT * FROM ButToan WHERE DienGiai = @DienGiai
end 

----
create proc sp_ReportPTTT @MaHD nchar(5)
as begin
select kh.TenKH, kh.DiaChi, kh.SDT_KH, cs.TenCS, cs.DiaChiCS,pt.TriGia, pt.PTTT,pt.TrangThaiTT,nv.TenNV,bt.DienGiai,pt.MaPT,hd.MaHD,bt.TKNo,bt.TKCo
from HoaDon hd join KhachHang kh on hd.MaKH=kh.MaKH
join NhanVien nv on hd.MaNV = nv.MaNV
join COSO cs on cs.MaCS=nv.MaCS
join PhieuThuTien pt on hd.MaHD=pt.MaHD
join ButToan bt on pt.MaPT=bt.MaPT
where hd.MaHD=@MaHD
end 
exec sp_ReportPTTT @MaHD='HD001'
-----