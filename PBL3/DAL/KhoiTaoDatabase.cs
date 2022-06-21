using System;
using System.Data.Entity;
using System.Linq;

namespace PBL3
{
    public class KhoiTaoDatabase : CreateDatabaseIfNotExists<Model>
    {
        protected override void Seed(Model context)
        {

            //Tạo khách hàng
            context.KhachHangs.AddRange(new KhachHang[]
            {
                new KhachHang { MaKhachHang = "KH1", TenKhachHang = "Nguyễn Văn A", DiaChi = "Liên Chiểu, Đà Nẵng", SoDienThoai = "0385574644"},
                new KhachHang { MaKhachHang = "KH2", TenKhachHang = "Nguyễn Tuấn Tú", DiaChi = "Thanh Khê, Đà Nẵng", SoDienThoai = "0876784644"},
                new KhachHang { MaKhachHang = "KH3", TenKhachHang = "Đinh Văn Cao", DiaChi = "Hải Châu, Đà Nẵng", SoDienThoai = "0981067444"},
                new KhachHang { MaKhachHang = "KH4", TenKhachHang = "Đặng Anh Vũ", DiaChi = "Quảng Nam", SoDienThoai = "0367751234"},
                new KhachHang { MaKhachHang = "KH5", TenKhachHang = "Nguyễn Thị Kiều Vy", DiaChi = "Liên Chiểu, Đà Nẵng", SoDienThoai = "0911381918"},
                new KhachHang { MaKhachHang = "KH6", TenKhachHang = "Lê Quốc Tài", DiaChi = "Thăng Bình, Quảng Nam", SoDienThoai = "0385174246"},
                new KhachHang { MaKhachHang = "KH7", TenKhachHang = "Nguyễn Quốc Danh", DiaChi = "Huế", SoDienThoai = "037664239"},
                new KhachHang { MaKhachHang = "KH8", TenKhachHang = "Thái Ngọc Vỹ", DiaChi = "Huế", SoDienThoai = "0799054910"},
                new KhachHang { MaKhachHang = "KH9", TenKhachHang = "Trần Thị Hoa", DiaChi = "Quảng Nam", SoDienThoai = "032788051"},
                new KhachHang { MaKhachHang = "KH10", TenKhachHang = "Lê Thị Thanh", DiaChi = "Quảng Ngãi", SoDienThoai = "080266355"},
                new KhachHang { MaKhachHang = "KH11", TenKhachHang = "Trần Văn Anh", DiaChi = "Đà Nẵng", SoDienThoai = "0379631244"},
            });
            context.SaveChanges();

            //Tạo lịch làm việc
            context.LichLamViecs.Add(new LichLamViec { MaLichLamViec = "LLV1", NgayLamViec = "Thứ 2", ThoiGianBatDau = "6:00", ThoiGianKetThuc = "14:00" });
            context.LichLamViecs.Add(new LichLamViec { MaLichLamViec = "LLV2", NgayLamViec = "Thứ 2", ThoiGianBatDau = "14:00", ThoiGianKetThuc = "22:00" });
            context.LichLamViecs.Add(new LichLamViec { MaLichLamViec = "LLV3", NgayLamViec = "Thứ 3", ThoiGianBatDau = "6:00", ThoiGianKetThuc = "14:00" });
            context.LichLamViecs.Add(new LichLamViec { MaLichLamViec = "LLV4", NgayLamViec = "Thứ 3", ThoiGianBatDau = "14:00", ThoiGianKetThuc = "22:00" });
            context.LichLamViecs.Add(new LichLamViec { MaLichLamViec = "LLV5", NgayLamViec = "Thứ 4", ThoiGianBatDau = "6:00", ThoiGianKetThuc = "14:00" });
            context.LichLamViecs.Add(new LichLamViec { MaLichLamViec = "LLV6", NgayLamViec = "Thứ 4", ThoiGianBatDau = "14:00", ThoiGianKetThuc = "22:00" });
            context.LichLamViecs.Add(new LichLamViec { MaLichLamViec = "LLV7", NgayLamViec = "Thứ 5", ThoiGianBatDau = "6:00", ThoiGianKetThuc = "14:00" });
            context.LichLamViecs.Add(new LichLamViec { MaLichLamViec = "LLV8", NgayLamViec = "Thứ 5", ThoiGianBatDau = "14:00", ThoiGianKetThuc = "22:00" });
            context.LichLamViecs.Add(new LichLamViec { MaLichLamViec = "LLV9", NgayLamViec = "Thứ 6", ThoiGianBatDau = "6:00", ThoiGianKetThuc = "14:00" });
            context.LichLamViecs.Add(new LichLamViec { MaLichLamViec = "LLV10", NgayLamViec = "Thứ 6", ThoiGianBatDau = "14:00", ThoiGianKetThuc = "22:00" });
            context.LichLamViecs.Add(new LichLamViec { MaLichLamViec = "LLV11", NgayLamViec = "Thứ 7", ThoiGianBatDau = "6:00", ThoiGianKetThuc = "14:00" });
            context.LichLamViecs.Add(new LichLamViec { MaLichLamViec = "LLV12", NgayLamViec = "Thứ 7", ThoiGianBatDau = "14:00", ThoiGianKetThuc = "22:00" });
            context.LichLamViecs.Add(new LichLamViec { MaLichLamViec = "LLV13", NgayLamViec = "Chủ nhật", ThoiGianBatDau = "6:00", ThoiGianKetThuc = "14:00" });
            context.LichLamViecs.Add(new LichLamViec { MaLichLamViec = "LLV14", NgayLamViec = "Chủ nhật", ThoiGianBatDau = "14:00", ThoiGianKetThuc = "22:00" });
            context.SaveChanges();

            //Tạo nhân viên
            context.NhanViens.AddRange(new NhanVien[]
                {
                    new NhanVien {MaNhanVien = "NV1", HoVaTen = "Trần Ngọc Tín", SoDienThoai = "0999888777", Email = "tranngoctin77@gmail.com", DiaChi = "Quảng Nam", NgaySinh = new DateTime(2002, 6, 21), GioiTinh = true, NgayBatDauLamViec = DateTime.Now, MucLuong = 1200000},
                    new NhanVien {MaNhanVien = "NV2", HoVaTen = "Nguyễn Hoàng Anh", SoDienThoai = "0888777666", Email = "tranngoctin7777@gmail.com", DiaChi = "Đà Nẵng", NgaySinh = new DateTime(2002, 7, 10), GioiTinh = true, NgayBatDauLamViec = DateTime.Now, MucLuong = 1200000},
                    new NhanVien {MaNhanVien = "NV3", HoVaTen = "Trần Anh Vũ", SoDienThoai = "0777666555", Email = "kunkute054@gmail.com", DiaChi = "Huế", NgaySinh = new DateTime(2002, 10, 9), GioiTinh = false, NgayBatDauLamViec = DateTime.Now, MucLuong = 1000000 },
                    new NhanVien {MaNhanVien = "NV4", HoVaTen = "Vũ Nhôm", SoDienThoai = "1111111111", Email = "tav.9122@gmail.com", DiaChi = "Huế", NgaySinh = new DateTime(2022, 02, 22), GioiTinh = true, MucLuong = 0, NgayBatDauLamViec = new DateTime(2022, 02, 22), VaiTro = true},
                    new NhanVien {MaNhanVien = "NV5", HoVaTen = "Hải Bánh", SoDienThoai = "2222222222", Email = "kunkute357@gmail.com", DiaChi = "Đà Nẵng", NgaySinh = new DateTime(2022, 02, 22), GioiTinh = true, MucLuong = 0, NgayBatDauLamViec = new DateTime(2022, 02, 22), VaiTro = true},
                });
            context.SaveChanges();

            //Tạo tài khoản
            context.TaiKhoans.Add(new TaiKhoan { MaTaiKhoan = "TK1", TenDangNhap = "nv", MatKhau = "nv", MaNhanVien = "NV1" });
            context.TaiKhoans.Add(new TaiKhoan { MaTaiKhoan = "TK2", TenDangNhap = "nv1", MatKhau = "nv1", MaNhanVien = "NV2" });
            context.TaiKhoans.Add(new TaiKhoan { MaTaiKhoan = "TK3", TenDangNhap = "nv2", MatKhau = "nv2", MaNhanVien = "NV3" });
            context.TaiKhoans.Add(new TaiKhoan { MaTaiKhoan = "TK4", TenDangNhap = "QTV", MatKhau = "qtv", MaNhanVien = "NV4" });
            context.TaiKhoans.Add(new TaiKhoan { MaTaiKhoan = "TK5", TenDangNhap = "QTV2", MatKhau = "qtv2", MaNhanVien = "NV5" });
            context.SaveChanges();

            //Tạo lô hàng
            context.LoHangs.Add(new LoHang { MaLoHang = "LH1", ThoiGianNhapHang = new DateTime(2022, 1, 15, 18, 50, 0), TongTien = 183000000 });
            context.LoHangs.Add(new LoHang { MaLoHang = "LH2", ThoiGianNhapHang = new DateTime(2022, 2, 16, 14, 30, 0), TongTien = 6630000000 });
            context.LoHangs.Add(new LoHang { MaLoHang = "LH3", ThoiGianNhapHang = new DateTime(2022, 3, 07, 07, 15, 0), TongTien = 4080000000 });
            context.LoHangs.Add(new LoHang { MaLoHang = "LH4", ThoiGianNhapHang = new DateTime(2022, 4, 02, 09, 23, 0), TongTien = 28400000 });
            context.LoHangs.Add(new LoHang { MaLoHang = "LH5", ThoiGianNhapHang = new DateTime(2022, 5, 06, 16, 40, 0), TongTien = 91800000 });
            context.SaveChanges();

            //Tạo sản phẩm
            context.SanPhams.AddRange(new SanPham[]
            {
                new SanPham {MaSanPham = "TN1", TenSanPham = "Tai nghe Airpod 2", TenHang = "Apple", GiaBan = 3300000, GiaMua = 3000000, LoaiSanPham = "Tai nghe",  SoLuongNhap = 20, SoLuongHienTai = 19, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "TN2", TenSanPham = "Tai nghe Airpod 3", TenHang = "Apple", GiaBan = 4500000, GiaMua = 4100000, LoaiSanPham = "Tai nghe",  SoLuongNhap = 20, SoLuongHienTai = 19, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "TN3", TenSanPham = "Tai nghe Galaxy Bus Pro", TenHang = "Samsung", GiaBan = 1500000, GiaMua = 1200000, LoaiSanPham = "Tai nghe",  SoLuongNhap = 20, SoLuongHienTai = 19, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "TN4", TenSanPham = "Tai nghe Bluetooth AVA DS200A", TenHang = "AVA", GiaBan = 390000, GiaMua = 300000, LoaiSanPham = "Tai nghe",  SoLuongNhap = 20, SoLuongHienTai = 19, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "TN5", TenSanPham = "Tai nghe Bluetooth TWS Haylou GT6", TenHang = "Haylou", GiaBan = 480000, GiaMua = 400000, LoaiSanPham = "Tai nghe",  SoLuongNhap = 20, SoLuongHienTai = 19, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "TN6", TenSanPham = "Tai nghe Mozard Flex4", TenHang = "Mozard", GiaBan = 210000, GiaMua = 150000, LoaiSanPham = "Tai nghe",  SoLuongNhap = 20, SoLuongHienTai = 19, ThoiGianBaoHanh = "1 năm"},

                new SanPham {MaSanPham = "DT1", TenSanPham = "Samsung Galaxy A03", TenHang = "Samsung", GiaBan = 3000000, GiaMua = 2700000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 49, ThoiGianBaoHanh = "2 năm"},
                new SanPham {MaSanPham = "DT2", TenSanPham = "Samsung Galaxy S22 Ultra", TenHang = "Samsung", GiaBan = 30000000, GiaMua = 28000000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 49, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "DT3", TenSanPham = "Iphone SE", TenHang = "Apple", GiaBan = 9490000, GiaMua = 7500000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 49, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "DT4", TenSanPham = "Iphone 11", TenHang = "Apple", GiaBan = 13790000, GiaMua = 11000000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 49, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "DT5", TenSanPham = "Iphone 12 Pro 512GB", TenHang = "Apple", GiaBan = 28490000, GiaMua = 25000000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 49, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "DT6", TenSanPham = "Oppo Reno 6", TenHang = "Oppo", GiaBan = 8500000, GiaMua = 7500000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 49, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "DT7", TenSanPham = "Oppo Reno 7", TenHang = "Oppo", GiaBan = 10000000, GiaMua = 9000000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 49, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "DT8", TenSanPham = "Oppo A55", TenHang = "Oppo", GiaBan = 4490000, GiaMua = 4000000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 50, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "DT9", TenSanPham = "Oppo A76", TenHang = "Oppo", GiaBan = 5990000, GiaMua = 5000000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 50, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "DT10", TenSanPham = "Vivo Y01", TenHang = "Vivo", GiaBan = 2790000, GiaMua = 2400000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 50, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "DT11", TenSanPham = "Vivo Y21 series", TenHang = "Vivo", GiaBan = 3090000, GiaMua = 2700000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 50, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "DT12", TenSanPham = "Vivo V21 5G", TenHang = "Vivo", GiaBan = 7890000, GiaMua = 7000000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 50, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "DT13", TenSanPham = "Xiaomi Redmi 9A", TenHang = "Xiaomi", GiaBan = 2390000, GiaMua = 2000000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 50, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "DT14", TenSanPham = "Xiaomi Redmi 10C", TenHang = "Xiaomi", GiaBan = 3490000, GiaMua = 3000000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 50, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "DT15", TenSanPham = "Xiaomi Redmi Note 10S", TenHang = "Xiaomi", GiaBan = 5990000, GiaMua = 5000000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 50, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "DT16", TenSanPham = "Xiaomi 11T", TenHang = "Xiaomi", GiaBan = 9700000, GiaMua = 9000000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 50, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "DT17", TenSanPham = "Nokia 105 Dual Sim", TenHang = "Nokia", GiaBan = 490000, GiaMua = 400000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 50, ThoiGianBaoHanh = "2 năm"},
                new SanPham {MaSanPham = "DT18", TenSanPham = "Nokia E72", TenHang = "Nokia", GiaBan = 600000, GiaMua = 500000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 50, ThoiGianBaoHanh = "2 năm"},
                new SanPham {MaSanPham = "DT19", TenSanPham = "Nokia C201", TenHang = "Nokia", GiaBan = 399000, GiaMua = 300000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 49, ThoiGianBaoHanh = "2 năm"},
                new SanPham {MaSanPham = "DT20", TenSanPham = "Itel it9210 4G", TenHang = "Itel", GiaBan = 680000, GiaMua = 600000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 50, SoLuongHienTai = 50, ThoiGianBaoHanh = "2 năm"},

                new SanPham {MaSanPham = "L1", TenSanPham = "Lenovo ThinkBook G4 R7 4700U", TenHang = "Lenovo", GiaBan = 17499000, GiaMua = 14000000, LoaiSanPham = "Laptop",  SoLuongNhap = 20, SoLuongHienTai = 20, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "L2", TenSanPham = "MSI Gamming i7 10500H", TenHang = "MSI", GiaBan = 21390000, GiaMua = 18000000, LoaiSanPham = "Laptop",  SoLuongNhap = 20, SoLuongHienTai = 20, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "L3", TenSanPham = "MacBook Pro M1 2020", TenHang = "Apple", GiaBan = 36490000, GiaMua = 33000000, LoaiSanPham = "Laptop",  SoLuongNhap = 20, SoLuongHienTai = 19, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "L4", TenSanPham = "Acer Nitro 5 Gamming R5 5600H", TenHang = "Acer", GiaBan = 23990000, GiaMua = 17000000, LoaiSanPham = "Laptop",  SoLuongNhap = 20, SoLuongHienTai = 19, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "L5", TenSanPham = "Asus TUF Gamming i5 10300H", TenHang = "Asus", GiaBan = 19699000, GiaMua = 15000000, LoaiSanPham = "Laptop",  SoLuongNhap = 20, SoLuongHienTai = 20, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "L6", TenSanPham = "Dell Vostro 3510 i5 1135G7", TenHang = "Dell", GiaBan = 22990000, GiaMua = 18000000, LoaiSanPham = "Laptop",  SoLuongNhap = 20, SoLuongHienTai = 20, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "L7", TenSanPham = "Asus TUFDell XPS 17 i7 11800H", TenHang = "Dell", GiaBan = 39000000, GiaMua = 35000000, LoaiSanPham = "Laptop",  SoLuongNhap = 20, SoLuongHienTai = 19, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "L8", TenSanPham = "MacBook Pro M2 2022", TenHang = "MacBook", GiaBan = 35990000, GiaMua = 30000000, LoaiSanPham = "Laptop",  SoLuongNhap = 20, SoLuongHienTai = 20, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "L9", TenSanPham = "HP 340S G7 i3 1005G1", TenHang = "HP", GiaBan = 11599000, GiaMua = 9000000, LoaiSanPham = "Laptop",  SoLuongNhap = 20, SoLuongHienTai = 20, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "L10", TenSanPham = "HP Pavilion 15 eg0505TU i5 1135G7", TenHang = "HP", GiaBan = 17690000, GiaMua = 15000000, LoaiSanPham = "Laptop",  SoLuongNhap = 20, SoLuongHienTai = 20, ThoiGianBaoHanh = "1 năm"},

                new SanPham {MaSanPham = "CMT1", TenSanPham = "Chuột không dây Silent Genius NX", TenHang = "Genius", GiaBan = 250000, GiaMua = 200000, LoaiSanPham = "Chuột máy tính",  SoLuongNhap = 20, SoLuongHienTai = 19, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "CMT2", TenSanPham = "Chuột không dây Gaming Asus TUF M4", TenHang = "Asus", GiaBan = 690000, GiaMua = 600000, LoaiSanPham = "Chuột máy tính",  SoLuongNhap = 20, SoLuongHienTai = 20, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "CMT3", TenSanPham = "Chuột có dây Dareu EM908", TenHang = "DareU", GiaBan = 420000, GiaMua = 370000, LoaiSanPham = "Chuột máy tính",  SoLuongNhap = 20, SoLuongHienTai = 19, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "CMT4", TenSanPham = "Chuột không dây A4Tech FG20", TenHang = "A4Tech", GiaBan = 300000, GiaMua = 250000, LoaiSanPham = "Chuột máy tính",  SoLuongNhap = 20, SoLuongHienTai = 20, ThoiGianBaoHanh = "1 năm"},

                new SanPham {MaSanPham = "BP1", TenSanPham = "Bàn phím có dây Gaming Asus TUF K1", TenHang = "Asus", GiaBan = 770000, GiaMua = 700000, LoaiSanPham = "Bàn phím",  SoLuongNhap = 20, SoLuongHienTai = 19, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "BP2", TenSanPham = "Bàn phím không dây A4Tech FG112", TenHang = "A4Tech", GiaBan = 455000, GiaMua = 390000, LoaiSanPham = "Bàn phím",  SoLuongNhap = 20, SoLuongHienTai = 20, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "BP3", TenSanPham = "Bàn phím cơ có dây Razer BlackWidow", TenHang = "BlackWidow", GiaBan = 3990000, GiaMua = 3000000, LoaiSanPham = "Bàn phím",  SoLuongNhap = 20, SoLuongHienTai = 19, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "BP4", TenSanPham = "Bàn phím Bluetooth Dareu EK868", TenHang = "DareU", GiaBan = 550000, GiaMua = 500000, LoaiSanPham = "Bàn phím",  SoLuongNhap = 20, SoLuongHienTai = 20, ThoiGianBaoHanh = "1 năm"},

            });
            context.SaveChanges();

            //Tạo vật phẩm dựa trên số lượng nhập của sản phẩm
            int count = context.VatPhams.Count();
            string key = DateTime.Now.ToString("yyyyMMdd");
            foreach (SanPham i in context.SanPhams)
            {
                if (i.LoaiSanPham == "Tai nghe")
                {
                    for (int j = 0; j < i.SoLuongNhap; j++)
                    {
                        context.VatPhams.Add(new VatPham
                        {
                            SoSeri = key + count.ToString().PadLeft(6, '0'),
                            MaSanPham = i.MaSanPham,
                            MaLoHang = "LH1",
                            GiaBan = i.GiaBan,
                            GiaMua = i.GiaMua,
                        });
                        count++;
                    }
                }
                else if (i.LoaiSanPham == "Điện thoại")
                {
                    for (int j = 0; j < i.SoLuongNhap; j++)
                    {
                        context.VatPhams.Add(new VatPham
                        {
                            SoSeri = key + count.ToString().PadLeft(6, '0'),
                            MaSanPham = i.MaSanPham,
                            MaLoHang = "LH2",
                            GiaBan = i.GiaBan,
                            GiaMua = i.GiaMua,
                        });
                        count++;
                    }
                }
                else if (i.LoaiSanPham == "Laptop")
                {
                    for (int j = 0; j < i.SoLuongNhap; j++)
                    {
                        context.VatPhams.Add(new VatPham
                        {
                            SoSeri = key + count.ToString().PadLeft(6, '0'),
                            MaSanPham = i.MaSanPham,
                            MaLoHang = "LH3",
                            GiaBan = i.GiaBan,
                            GiaMua = i.GiaMua,
                        });
                        count++;
                    }
                }
                else if (i.LoaiSanPham == "Chuột máy tính")
                {
                    for (int j = 0; j < i.SoLuongNhap; j++)
                    {
                        context.VatPhams.Add(new VatPham
                        {
                            SoSeri = key + count.ToString().PadLeft(6, '0'),
                            MaSanPham = i.MaSanPham,
                            MaLoHang = "LH4",
                            GiaBan = i.GiaBan,
                            GiaMua = i.GiaMua,
                        });
                        count++;
                    }
                }
                else if (i.LoaiSanPham == "Bàn phím")
                {
                    for (int j = 0; j < i.SoLuongNhap; j++)
                    {
                        context.VatPhams.Add(new VatPham
                        {
                            SoSeri = key + count.ToString().PadLeft(6, '0'),
                            MaSanPham = i.MaSanPham,
                            MaLoHang = "LH5",
                            GiaBan = i.GiaBan,
                            GiaMua = i.GiaMua,
                        });
                        count++;
                    }
                }
            }
            context.SaveChanges();

            //Tạo nhân viên - lịch làm việc theo mối quan hệ nhiều nhiều
            context.NhanVienLichLamViecs.Add(new NhanVienLichLamViec { MaNhanVien_LichLamViec = 3, MaLichLamViec = "LLV2", MaNhanVien = "NV3" });
            context.NhanVienLichLamViecs.Add(new NhanVienLichLamViec { MaNhanVien_LichLamViec = 4, MaLichLamViec = "LLV2", MaNhanVien = "NV2" });
            context.NhanVienLichLamViecs.Add(new NhanVienLichLamViec { MaNhanVien_LichLamViec = 5, MaLichLamViec = "LLV3", MaNhanVien = "NV3" });
            context.NhanVienLichLamViecs.Add(new NhanVienLichLamViec { MaNhanVien_LichLamViec = 6, MaLichLamViec = "LLV3", MaNhanVien = "NV1" });
            context.SaveChanges();

            //Tạo hoá đơn
            context.HoaDons.Add(new HoaDon { MaHoaDon = "HD1", MaNhanVien = "NV1", MaKhachHang = "KH1", ThoiGianGiaoDich = new DateTime(2022, 5, 2, 18, 50, 0), ThanhTien = 4200000 });
            context.HoaDons.Add(new HoaDon { MaHoaDon = "HD2", MaNhanVien = "NV2", MaKhachHang = "KH2", ThoiGianGiaoDich = new DateTime(2022, 5, 3, 8, 30, 0), ThanhTien = 34500000 });
            context.HoaDons.Add(new HoaDon { MaHoaDon = "HD3", MaNhanVien = "NV2", MaKhachHang = "KH3", ThoiGianGiaoDich = new DateTime(2022, 5, 4, 14, 20, 0), ThanhTien = 51890000 });
            context.HoaDons.Add(new HoaDon { MaHoaDon = "HD4", MaNhanVien = "NV3", MaKhachHang = "KH4", ThoiGianGiaoDich = new DateTime(2022, 5, 5, 16, 46, 0), ThanhTien = 24389000 });
            context.HoaDons.Add(new HoaDon { MaHoaDon = "HD5", MaNhanVien = "NV1", MaKhachHang = "KH5", ThoiGianGiaoDich = new DateTime(2022, 5, 6, 10, 57, 0), ThanhTien = 31790000 });
            context.HoaDons.Add(new HoaDon { MaHoaDon = "HD6", MaNhanVien = "NV1", MaKhachHang = "KH6", ThoiGianGiaoDich = new DateTime(2022, 6, 1, 13, 12, 0), ThanhTien = 390000 });
            context.HoaDons.Add(new HoaDon { MaHoaDon = "HD7", MaNhanVien = "NV3", MaKhachHang = "KH7", ThoiGianGiaoDich = new DateTime(2022, 6, 2, 15, 26, 0), ThanhTien = 39000000 });
            context.HoaDons.Add(new HoaDon { MaHoaDon = "HD8", MaNhanVien = "NV2", MaKhachHang = "KH8", ThoiGianGiaoDich = new DateTime(2022, 6, 3, 15, 33, 0), ThanhTien = 480000 });
            context.HoaDons.Add(new HoaDon { MaHoaDon = "HD9", MaNhanVien = "NV2", MaKhachHang = "KH9", ThoiGianGiaoDich = new DateTime(2022, 6, 4, 9, 47, 0), ThanhTien = 22500000 });
            context.HoaDons.Add(new HoaDon { MaHoaDon = "HD10", MaNhanVien = "NV1", MaKhachHang = "KH10", ThoiGianGiaoDich = new DateTime(2022, 6, 5, 7, 51, 0), ThanhTien = 10000000 });

            context.SaveChanges();

            //Gán vật phẩm vào hoá đơn
            var x1 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "DT1").MaHoaDon = "HD1";
            var x2 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "CMT1").MaHoaDon = "HD1";
            var x3 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "BP1").MaHoaDon = "HD1";

            var y1 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "TN2").MaHoaDon = "HD2";
            var y2 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "DT2").MaHoaDon = "HD2";

            var z1 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "TN3").MaHoaDon = "HD3";
            var z2 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "DT3").MaHoaDon = "HD3";
            var z3 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "L3").MaHoaDon = "HD3";
            var z4 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "CMT3").MaHoaDon = "HD3";
            var z5 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "BP3").MaHoaDon = "HD3";


            var w1 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "DT19").MaHoaDon = "HD4";
            var w2 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "L4").MaHoaDon = "HD4";

            var t1 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "TN1").MaHoaDon = "HD5";
            var t2 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "DT5").MaHoaDon = "HD5";

            var u1 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "TN4").MaHoaDon = "HD6";

            var v1 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "L7").MaHoaDon = "HD7";

            var m1 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "TN5").MaHoaDon = "HD8";

            var n1 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "TN6").MaHoaDon = "HD9";
            var n2 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "DT4").MaHoaDon = "HD9";
            var n3 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "DT6").MaHoaDon = "HD9";

            var o1 = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "DT7").MaHoaDon = "HD10";

            context.SaveChanges();

            //Tạo bảo hành
            context.BaoHanhs.Add(new BaoHanh { MaBaoHanh = "BH1", SoSeri = DateTime.Now.ToString("yyyyMMdd") + "000000", TrangThai = false, GhiChu = "Hư loa", ThoiGianTaoPhieuBaoHanh = new DateTime(2022, 5, 20, 18, 50, 0) });
            context.SaveChanges();
        }
    }
}
