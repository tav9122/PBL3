using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLQuanLiSanPham
    {
        private static BLLQuanLiSanPham instance;
        public static BLLQuanLiSanPham Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLQuanLiSanPham();
                return instance;
            }
        }

        public List<ViewSanPham_QuanTriVien> GetSanPhams(string kieuSapXep, string tuKhoa)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            return Model.Instance.SanPhams.Where(sp => sp.DaXoa == false && (sp.MaSanPham.Contains(tuKhoa) || sp.LoaiSanPham.Contains(tuKhoa) || sp.TenSanPham.Contains(tuKhoa) || sp.TenHang.Contains(tuKhoa)))
                .Select(sp => new ViewSanPham_QuanTriVien { MaSanPham = sp.MaSanPham, TenSanPham = sp.TenSanPham, TenHang = sp.TenHang, LoaiSanPham = sp.LoaiSanPham, GiaMua = sp.GiaMua, GiaBan = sp.GiaBan, SoLuongNhap = sp.SoLuongNhap, SoLuongHienTai = sp.SoLuongHienTai, ThoiGianBaoHanh = sp.ThoiGianBaoHanh })
                .ToList().OrderBy(sp => sp.GetType().GetProperty(kieuSapXep)).ToList();
        }

        public SanPham GetSanPham(string maSanPham)
        {
            return Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham);
        }

        public List<string> GetLoaiSanPhams()
        {
            return Model.Instance.SanPhams.Select(sp => sp.LoaiSanPham).Distinct().ToList();
        }

        public List<string> GetMaSanPhams()
        {
            return Model.Instance.SanPhams.Select(sp => sp.MaSanPham).ToList();
        }
        public void Delete(string maSanPham)
        {
            Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham).DaXoa = true;
            Model.Instance.SaveChanges();
        }

        public void Add(string maSanPham, string tenSanPham, string tenHang, string loaiSanPham, double giaMua, double giaBan, int soLuongNhap, int soLuongHienTai, string thoiGianBaoHanh)
        {
            Model.Instance.SanPhams.Add(new SanPham { MaSanPham = maSanPham, TenSanPham = tenSanPham, TenHang = tenHang, LoaiSanPham = loaiSanPham, GiaMua = giaMua, GiaBan = giaBan, SoLuongNhap = soLuongNhap, SoLuongHienTai = soLuongHienTai, ThoiGianBaoHanh = thoiGianBaoHanh });
            Model.Instance.SaveChanges();
        }
        public void Update(string maSanPham, string tenSanPham, string tenHang, string loaiSanPham, double giaMua, double giaBan, int soLuongNhap, int soLuongHienTai, string thoiGianBaoHanh)
        {
            var sanpham = Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham);
            sanpham.MaSanPham = maSanPham;
            sanpham.TenSanPham = tenSanPham;
            sanpham.TenHang = tenHang;
            sanpham.LoaiSanPham = loaiSanPham;
            sanpham.GiaMua = giaMua;
            sanpham.GiaBan = giaBan;
            sanpham.SoLuongNhap = soLuongNhap;
            sanpham.SoLuongHienTai = soLuongHienTai;
            sanpham.ThoiGianBaoHanh = thoiGianBaoHanh;
            Model.Instance.SaveChanges();
        }

        public void InitializeNewSeri(int soLuongNhap, string maSanPham)
        {
            for (int i = Model.Instance.VatPhams.Count() + 1; i < soLuongNhap + Model.Instance.VatPhams.Count(); i++)
            {
                Model.Instance.VatPhams.Add(new VatPham { SoSeri = i, MaSanPham = maSanPham });
            }
            Model.Instance.SaveChanges();
        }
    }
}
