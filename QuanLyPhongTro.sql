CREATE DATABASE QuanLyPhongTro;
GO

USE QuanLyPhongTro;
GO

CREATE TABLE TaiKhoan (
    MaTK INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap VARCHAR(50) NOT NULL UNIQUE,
    MatKhau VARCHAR(100) NOT NULL,
    Quyen NVARCHAR(30)
);

CREATE TABLE DIENNUOC (
    MaDienNuoc INT IDENTITY(1,1) PRIMARY KEY,
    MaPhong INT NOT NULL,
    Thang DATE NOT NULL,
    ChiSoDienCu INT,
    ChiSoDienMoi INT,
    ChiSoNuocCu INT,
    ChiSoNuocMoi INT,
    TienDien DECIMAL(18,2),
    TienNuoc DECIMAL(18,2),

    FOREIGN KEY (MaPhong) REFERENCES PHONG(MaPhong)
);

CREATE TABLE Phong (
    MaPhong INT IDENTITY(1,1) PRIMARY KEY,
    TenPhong NVARCHAR(20) NOT NULL,
    LoaiPhong NVARCHAR(50),
    GiaPhong DECIMAL(18,2),
    TrangThai NVARCHAR(30)
);

CREATE TABLE NguoiThue (
    MaNguoiThue INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    CCCD VARCHAR(20),
    SDT VARCHAR(15),
    QueQuan NVARCHAR(100)
);

CREATE TABLE HopDong (
    MaHopDong INT IDENTITY(1,1) PRIMARY KEY,
    MaPhong INT NOT NULL,
    MaNguoiThue INT NOT NULL,
    NgayBatDau DATE,
    NgayKetThuc DATE,
    TienCoc DECIMAL(18,2),

    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong),
    FOREIGN KEY (MaNguoiThue) REFERENCES NguoiThue(MaNguoiThue)
);

CREATE TABLE HoaDon (
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    MaHopDong INT NOT NULL,
    Thang DATE,
    TienPhong DECIMAL(18,2),
    TienDien DECIMAL(18,2),
    TienNuoc DECIMAL(18,2),
    TienDichVu DECIMAL(18,2),
    TongTien DECIMAL(18,2),
    TrangThai NVARCHAR(30),

    FOREIGN KEY (MaHopDong) REFERENCES HopDong(MaHopDong)
);

INSERT INTO Taikhoan (TenDangNhap, MatKhau, Quyen)
VALUES
('admin', '123456', N'Quản trị'),
('nhanvien01', '123456', N'Nhân viên'),
('nhanvien02', '123456', N'Nhân viên');

INSERT INTO Phong (TenPhong, LoaiPhong, GiaPhong, TrangThai)
VALUES
(N'P101', N'Phòng đơn', 2500000, N'Đang thuê'),
(N'P102', N'Phòng đơn', 2500000, N'Trống'),
(N'P103', N'Phòng đơn', 2800000, N'Đang thuê'),
(N'P201', N'Phòng đôi', 3500000, N'Đang thuê'),
(N'P202', N'Phòng đôi', 3500000, N'Trống'),
(N'P203', N'Phòng đôi', 3800000, N'Trống');

INSERT INTO Nguoithue (HoTen, CCCD, SDT, QueQuan)
VALUES
(N'Nguyễn Văn An', '012345678901', '0987654321', N'Hà Nội'),
(N'Trần Thị Bình', '012345678902', '0987654322', N'Nam Định'),
(N'Lê Văn Cường', '012345678903', '0987654323', N'Hải Phòng'),
(N'Phạm Thị Dung', '012345678904', '0987654324', N'Ninh Bình'),
(N'Hoàng Văn Nam', '012345678905', '0987654325', N'Thái Bình');

INSERT INTO Hopdong 
(MaPhong, MaNguoiThue, NgayBatDau, NgayKetThuc, TienCoc)
VALUES
(1, 1, '2026-01-01', '2026-12-31', 2500000),
(3, 2, '2026-02-01', '2027-01-31', 2800000),
(4, 3, '2026-03-01', '2027-02-28', 3500000),
(1, 4, '2026-06-01', '2027-05-31', 2500000);

INSERT INTO DIENNUOC
(MaPhong, Thang, ChiSoDienCu, ChiSoDienMoi,
 ChiSoNuocCu, ChiSoNuocMoi, TienDien, TienNuoc)
VALUES
(1, '2026-09-01', 1200, 1350, 300, 315, 450000, 150000),
(3, '2026-09-01', 800, 940, 200, 218, 420000, 180000),
(4, '2026-09-01', 1500, 1660, 400, 420, 480000, 200000),
(1, '2026-10-01', 1350, 1490, 315, 330, 420000, 150000);
