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
                new KhachHang { MaKhachHang = "KH3", TenKhachHang = "Đinh Văn Cao", DiaChi = "Hải Châu, Đà Nẵng", SoDienThoai = "098106744"},
                new KhachHang { MaKhachHang = "KH4", TenKhachHang = "Nguyễn Văn A", DiaChi = "Quang Nam", SoDienThoai = "0385574644"},
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

            //Tạo nhân viên
            context.NhanViens.AddRange(new NhanVien[]
                {
                    new NhanVien {MaNhanVien = "NV1", HoVaTen = "Trần Ngọc Tín", SoDienThoai = "0999888777", Email = "tranngoctin77@gmail.com", DiaChi = "Quảng Nam", NgaySinh = new DateTime(2002, 6, 21), GioiTinh = true, MucLuong = 1200000 },
                    new NhanVien {MaNhanVien = "NV2", HoVaTen = "Nguyễn Hoàng Anh", SoDienThoai = "0888777666", Email = "tranngoctin77@gmail.com", DiaChi = "Đà Nẵng", NgaySinh = new DateTime(2002, 7, 10), GioiTinh = true, MucLuong = 1200000 },
                    new NhanVien {MaNhanVien = "NV3", HoVaTen = "Trần Anh Vũ", SoDienThoai = "0777666555", Email = "tav.9122@gmail.com", DiaChi = "Huế", NgaySinh = new DateTime(2002, 10, 9), GioiTinh = false, MucLuong = 1000000 },
                    new NhanVien {MaNhanVien = "QTV", HoVaTen = "QUẢN TRỊ VIÊN", SoDienThoai = "", Email = "NULL", DiaChi = "", NgaySinh = new DateTime(2022, 02, 22), GioiTinh = true, MucLuong = 0},
                });


            //Tạo tài khoản
            context.TaiKhoans.Add(new TaiKhoan { MaTaiKhoan = "TK1", TenDangNhap = "TK1", MatKhau = "tk1", MaNhanVien = "NV1" });
            context.TaiKhoans.Add(new TaiKhoan { MaTaiKhoan = "TK2", TenDangNhap = "TK2", MatKhau = "tk2", MaNhanVien = "NV2" });
            context.TaiKhoans.Add(new TaiKhoan { MaTaiKhoan = "TK3", TenDangNhap = "TK3", MatKhau = "tk3", MaNhanVien = "NV3" });
            context.TaiKhoans.Add(new TaiKhoan { MaTaiKhoan = "QTV", TenDangNhap = "QTV", MatKhau = "qtv", MaNhanVien = "QTV" });

            //Tạo lô hàng
            context.LoHangs.Add(new LoHang { MaLoHang = "LH1", ThoiGianNhapHang = DateTime.Now, TongTien = 1499500000 });

            //Tạo sản phẩm
            context.SanPhams.AddRange(new SanPham[]
            {
                new SanPham {MaSanPham = "TN1", TenSanPham = "Tai nghe Airpod 2", TenHang = "Apple", GiaBan = 3300000, GiaMua = 3000000, LoaiSanPham = "Tai nghe",  SoLuongNhap = 15, SoLuongHienTai = 15, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "TN2", TenSanPham = "Tai nghe Airpod Pro", TenHang = "Apple", GiaBan = 5400000, GiaMua = 5000000, LoaiSanPham = "Tai nghe",  SoLuongNhap = 20, SoLuongHienTai = 20, ThoiGianBaoHanh = "2 năm"},
                new SanPham {MaSanPham = "TN3", TenSanPham = "Tai nghe Airpod 3", TenHang = "Apple", GiaBan = 4500000, GiaMua = 4100000, LoaiSanPham = "Tai nghe",  SoLuongNhap = 15, SoLuongHienTai = 15, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "TN4", TenSanPham = "Tai nghe Galaxy Bus Pro", TenHang = "Samsung", GiaBan = 2500000, GiaMua = 2200000, LoaiSanPham = "Tai nghe",  SoLuongNhap = 20, SoLuongHienTai = 20, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "DT1", TenSanPham = "Samsung Galaxy A03", TenHang = "Samsung", GiaBan = 3000000, GiaMua = 2700000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 15, SoLuongHienTai = 14, ThoiGianBaoHanh = "2 năm"},
                new SanPham {MaSanPham = "DT2", TenSanPham = "Samsung Galaxy S22 Ultra", TenHang = "Samsung", GiaBan = 30000000, GiaMua = 29000000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 20, SoLuongHienTai = 20, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "DT3", TenSanPham = "Iphone 12 Pro Max", TenHang = "Apple", GiaBan = 30000000, GiaMua = 29500000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 15, SoLuongHienTai = 15, ThoiGianBaoHanh = "1 năm"},
                new SanPham {MaSanPham = "DT4", TenSanPham = "Oppo Reno 6", TenHang = "Oppo", GiaBan = 10000000, GiaMua = 9300000, LoaiSanPham = "Điện thoại",  SoLuongNhap = 20, SoLuongHienTai = 20, ThoiGianBaoHanh = "1 năm"}

            });
            context.SaveChanges();

            //Tạo vật phẩm dựa trên số lượng nhập của sản phẩm
            int count = context.VatPhams.Count();
            foreach (SanPham i in context.SanPhams)
            {
                for (int j = 0; j < i.SoLuongNhap; j++)
                {
                    context.VatPhams.Add(new VatPham
                    {
                        SoSeri = DateTime.Now.ToString("yyyyMMdd") + count.ToString().PadLeft(6, '0'),
                        MaSanPham = i.MaSanPham,
                        MaLoHang = "LH1",
                        GiaBan = i.GiaBan,
                        GiaMua = i.GiaMua,
                    });
                    count++;
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
            context.HoaDons.Add(new HoaDon { MaHoaDon = "HD1", MaNhanVien = "NV1", MaKhachHang = "KH1", ThoiGianGiaoDich = new DateTime(2022, 5, 20, 18, 50, 0), ThanhTien = 3000000 });
            context.SaveChanges();

            //Gán vật phẩm vào hoá đơn
            var x = context.VatPhams.FirstOrDefault(vp => vp.MaSanPham == "DT1").MaHoaDon = "HD1";
            context.SaveChanges();

            //Tạo bảo hành
            context.BaoHanhs.Add(new BaoHanh { MaBaoHanh = "BH1", SoSeri = DateTime.Now.ToString("yyyyMMdd") + "000000", TrangThai = false, GhiChu = "Hư loa", ThoiGianTaoPhieuBaoHanh = new DateTime(2022, 5, 20, 18, 50, 0) });
            context.SaveChanges();

        }
    }
}
