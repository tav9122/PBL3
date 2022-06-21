using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLButtonThongKeTheoBang
    {
        private static BLLButtonThongKeTheoBang instance;
        public static BLLButtonThongKeTheoBang Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLButtonThongKeTheoBang();
                return instance;
            }
        }

        public List<ViewSanPham_QuanTriVien_ThongKeTheoBang_TongTien> SearchTongTienSanPham(string tuKhoa, DateTime date1, DateTime date2)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.ToLower().Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewSanPham_QuanTriVien_ThongKeTheoBang_TongTien> list = Model.Instance.SanPhams.AsEnumerable().Where(sp => sp.DaXoa == false && (sp.MaSanPham.ToLower().Contains(temp) || sp.LoaiSanPham.ToLower().Contains(temp) || sp.TenSanPham.ToLower().Contains(temp) || sp.TenHang.ToLower().Contains(temp)))
                .Select(sp => new ViewSanPham_QuanTriVien_ThongKeTheoBang_TongTien { MaSanPham = sp.MaSanPham, TenSanPham = sp.TenSanPham, TenHang = sp.TenHang, LoaiSanPham = sp.LoaiSanPham, TongTienNhap = GetTongTienNhap(sp.MaSanPham, date1, date2), TongDoanhThu = GetTongDoanhThu(sp.MaSanPham, date1, date2) })
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

        public List<ViewSanPham_QuanTriVien_ThongKeTheoBang_TongTien> SortTongTienSanPham(List<ViewSanPham_QuanTriVien_ThongKeTheoBang_TongTien> sanPhams, string kieuSapXep)
        {
            try { return sanPhams.OrderBy(sp => sp.GetType().GetProperty(kieuSapXep).GetValue(sp, null)).ToList(); }
            catch { return sanPhams; }
        }

        public List<ViewSanPham_QuanTriVien_ThongKeTheoBang_TongTien> GetTongTienSanPhams(string kieuSapXep, string tuKhoa, DateTime date1, DateTime date2)
        {
            return SortTongTienSanPham(SearchTongTienSanPham(tuKhoa, date1, date2), kieuSapXep);
        }

        public List<ViewSanPham_QuanTriVien_ThongKeTheoBang_SoLuong> SearchSoLuongSanPham(string tuKhoa, DateTime date1, DateTime date2)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.ToLower().Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewSanPham_QuanTriVien_ThongKeTheoBang_SoLuong> list = Model.Instance.SanPhams.AsEnumerable().Where(sp => sp.DaXoa == false && (sp.MaSanPham.ToLower().Contains(temp) || sp.LoaiSanPham.ToLower().Contains(temp) || sp.TenSanPham.ToLower().Contains(temp) || sp.TenHang.ToLower().Contains(temp)))
                .Select(sp => new ViewSanPham_QuanTriVien_ThongKeTheoBang_SoLuong { MaSanPham = sp.MaSanPham, TenSanPham = sp.TenSanPham, TenHang = sp.TenHang, LoaiSanPham = sp.LoaiSanPham, SoLuongNhap = GetSoLuongNhap(sp.MaSanPham, date1, date2), SoLuongBan = GetSoLuongBan(sp.MaSanPham, date1, date2) })
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

        public List<ViewSanPham_QuanTriVien_ThongKeTheoBang_SoLuong> SortSoLuongSanPham(List<ViewSanPham_QuanTriVien_ThongKeTheoBang_SoLuong> sanPhams, string kieuSapXep)
        {
            try { return sanPhams.OrderBy(sp => sp.GetType().GetProperty(kieuSapXep).GetValue(sp, null)).ToList(); }
            catch { return sanPhams; }
        }

        public List<ViewSanPham_QuanTriVien_ThongKeTheoBang_SoLuong> GetSoLuongSanPhams(string kieuSapXep, string tuKhoa, DateTime date1, DateTime date2)
        {
            return SortSoLuongSanPham(SearchSoLuongSanPham(tuKhoa, date1, date2), kieuSapXep);
        }

        public double GetTongTienNhap(string maSanPham, DateTime date1, DateTime date2)
        {
            var x = Model.Instance.VatPhams.Where(vp => vp.MaSanPham == maSanPham && vp.LoHang.ThoiGianNhapHang >= date1 && vp.LoHang.ThoiGianNhapHang <= date2);
            if (x.Count() > 0)
            {
                return x.Sum(vp => vp.GiaMua);
            }
            else
                return 0;
        }

        public double GetTongDoanhThu(string maSanPham, DateTime date1, DateTime date2)
        {
            var x = Model.Instance.VatPhams.Where(vp => vp.MaSanPham == maSanPham && vp.HoaDon != null && vp.HoaDon.ThoiGianGiaoDich >= date1 && vp.HoaDon.ThoiGianGiaoDich <= date2);
            if (x.Count() > 0)
            {
                return x.Sum(vp => vp.GiaBan);
            }
            else
                return 0;
        }

        public int GetSoLuongNhap(string maSanPham, DateTime date1, DateTime date2)
        {
            return Model.Instance.VatPhams.Where(vp => vp.MaSanPham == maSanPham && vp.LoHang.ThoiGianNhapHang >= date1 && vp.LoHang.ThoiGianNhapHang <= date2).Count();
        }

        public int GetSoLuongBan(string maSanPham, DateTime date1, DateTime date2)
        {
            return Model.Instance.VatPhams.Where(vp => vp.MaSanPham == maSanPham && vp.HoaDon != null && vp.HoaDon.ThoiGianGiaoDich >= date1 && vp.HoaDon.ThoiGianGiaoDich <= date2).Count();
        }
    }
}
