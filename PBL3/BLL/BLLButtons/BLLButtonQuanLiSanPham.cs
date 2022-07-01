using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLButtonQuanLiSanPham
    {
        private static BLLButtonQuanLiSanPham instance;
        public static BLLButtonQuanLiSanPham Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLButtonQuanLiSanPham();
                return instance;
            }
        }
        public List<ViewSanPham_QuanTriVien> SearchSanPham(string tuKhoa)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.ToLower().Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewSanPham_QuanTriVien> list = Model.Instance.SanPhams.AsEnumerable().Where(sp => sp.DaXoa == false && (sp.MaSanPham.ToLower().Contains(temp) || sp.LoaiSanPham.ToLower().Contains(temp) || sp.TenSanPham.ToLower().Contains(temp) || sp.TenHang.ToLower().Contains(temp)))
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

        public List<ViewSanPham_QuanTriVien> SortSanPham(List<ViewSanPham_QuanTriVien> sanPhams, string kieuSapXep, bool ascending)
        {
            if (ascending == true)
            {
                return sanPhams.OrderBy(sp => sp.GetType().GetProperty(kieuSapXep).GetValue(sp, null)).ToList();
            }
            else
            {
                return sanPhams.OrderByDescending(sp => sp.GetType().GetProperty(kieuSapXep).GetValue(sp, null)).ToList();
            }
        }

        public List<ViewSanPham_QuanTriVien> GetSanPhams(string kieuSapXep, string tuKhoa, bool ascending)
        {
            return SortSanPham(SearchSanPham(tuKhoa), kieuSapXep, ascending);
        }
    }
}
