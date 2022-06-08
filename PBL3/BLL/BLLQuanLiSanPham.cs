using System;
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

        public List<ViewSanPham_QuanTriVien> SearchSanPham(string tuKhoa)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.ToLower().Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewSanPham_QuanTriVien> list = Model.Instance.SanPhams.Where(sp => sp.DaXoa == false && (sp.MaSanPham.ToLower().Contains(temp) || sp.LoaiSanPham.ToLower().Contains(temp) || sp.TenSanPham.ToLower().Contains(temp) || sp.TenHang.ToLower().Contains(temp)))
                .Select(sp => new ViewSanPham_QuanTriVien { MaSanPham = sp.MaSanPham, TenSanPham = sp.TenSanPham, TenHang = sp.TenHang, LoaiSanPham = sp.LoaiSanPham, GiaMua = sp.GiaMua, GiaBan = sp.GiaBan, SoLuongNhap = sp.SoLuongNhap, SoLuongHienTai = sp.SoLuongHienTai, ThoiGianBaoHanh = sp.ThoiGianBaoHanh })
                .ToList();
            foreach (string s in cacTuKhoa)
            {
                if (s != temp)
                {
                    list = list.Where(sp => sp.MaSanPham.ToLower().Contains(s) || sp.LoaiSanPham.ToLower().Contains(s) || sp.TenSanPham.ToLower().Contains(s) || sp.TenHang.ToLower().Contains(s)).ToList();
                }
            }
            return list;
        }

        public List<ViewSanPham_QuanTriVien> SortSanPham(List<ViewSanPham_QuanTriVien> sanPhams, string kieuSapXep)
        {
            try { return sanPhams.OrderBy(sp => sp.GetType().GetProperty(kieuSapXep).GetValue(sp, null)).ToList(); }
            catch { return sanPhams; }
        }

        public List<ViewSanPham_QuanTriVien> GetSanPhams(string kieuSapXep, string tuKhoa)
        {
            return SortSanPham(SearchSanPham(tuKhoa), kieuSapXep);
        }

        public SanPham GetSanPham(string maSanPham)
        {
            return Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham);
        }

        public List<string> GetMaSanPhams()
        {
            if (Model.Instance.SanPhams.Select(sp => sp.MaSanPham).ToList() == null)
                return new List<string> { "SP0" };
            else
                return Model.Instance.SanPhams.Select(sp => sp.MaSanPham).ToList();
        }

        public List<string> GetLoaiSanPhams()
        {
            return Model.Instance.SanPhams.Select(sp => sp.LoaiSanPham).Distinct().ToList();
        }

        public void DeleteSanPham(string maSanPham)
        {
            Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham).DaXoa = true;
            Model.Instance.SaveChanges();
        }

        public void AddSanPham(string maSanPham, string tenSanPham, string tenHang, string loaiSanPham, double giaMua, double giaBan, int soLuongNhap, int soLuongHienTai, string thoiGianBaoHanh)
        {
            Model.Instance.SanPhams.Add(new SanPham { MaSanPham = maSanPham, TenSanPham = tenSanPham, TenHang = tenHang, LoaiSanPham = loaiSanPham, GiaMua = giaMua, GiaBan = giaBan, SoLuongNhap = soLuongNhap, SoLuongHienTai = soLuongHienTai, ThoiGianBaoHanh = thoiGianBaoHanh });
            Model.Instance.SaveChanges();
        }
        public void UpdateSanPham(string maSanPham, string tenSanPham, string tenHang, string loaiSanPham, double giaMua, double giaBan, int soLuongNhap, int soLuongHienTai, string thoiGianBaoHanh)
        {
            var sanpham = Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham);
            sanpham.TenSanPham = tenSanPham;
            sanpham.TenHang = tenHang;
            sanpham.LoaiSanPham = loaiSanPham;
            sanpham.GiaMua = giaMua;
            sanpham.GiaBan = giaBan;
            sanpham.SoLuongNhap = soLuongNhap;
            sanpham.SoLuongHienTai = soLuongHienTai;
            sanpham.ThoiGianBaoHanh = thoiGianBaoHanh;

            foreach (VatPham vatPhams in Model.Instance.VatPhams.Where(vp => vp.MaSanPham == maSanPham))
            {
                if (vatPhams.MaHoaDon == null)
                {
                    vatPhams.GiaBan = giaBan;
                }
            }
            Model.Instance.SaveChanges();
        }

        public void InitializeNewVatPhams(int soLuongNhapThem, string maSanPham, string maLoHang)
        {
            int count = Model.Instance.VatPhams.Count();
            Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham).SoLuongHienTai += soLuongNhapThem;
            Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham).SoLuongNhap += soLuongNhapThem;
            for (int i = 0; i < soLuongNhapThem; i++)
            {
                Model.Instance.VatPhams.Add(new VatPham { SoSeri = DateTime.Now.ToString("yyyyMMdd") + count.ToString().PadLeft(6, '0'), MaSanPham = maSanPham, MaLoHang = maLoHang, GiaMua = Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham).GiaMua, GiaBan = Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham).GiaBan });
                count++;
            }
            Model.Instance.SaveChanges();
        }

        public void SetTempValue(string maSanPham, int soLuong)
        {
            Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham).Temp = soLuong;
            Model.Instance.SaveChanges();
        }

        public void ResetTemp()
        {
            foreach (SanPham sanPham in Model.Instance.SanPhams.Where(sp => sp.Temp > 0))
            {
                sanPham.Temp = 0;
            }
            Model.Instance.SaveChanges();
        }

        public List<SanPham> GetSanPhamWithTempValueGreaterThanZero()
        {
            return Model.Instance.SanPhams.Where(sp => sp.Temp > 0).ToList();
        }
    }
}
