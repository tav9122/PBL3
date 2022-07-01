using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLButtonQuanLiNhanVien
    {
        private static BLLButtonQuanLiNhanVien instance;
        public static BLLButtonQuanLiNhanVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLButtonQuanLiNhanVien();
                return instance;
            }
        }
        public List<ViewNhanVien> SearchNhanVien(string tuKhoa)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.ToLower().Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewNhanVien> list = Model.Instance.NhanViens.AsEnumerable().Where(nv => nv.DaXoa == false && nv.VaiTro != true && (nv.MaNhanVien.ToLower().Contains(temp) || nv.HoVaTen.ToLower().Contains(temp) || nv.SoDienThoai.Contains(temp) || nv.Email.ToLower().Contains(temp) || nv.DiaChi.ToLower().Contains(temp) || nv.NgaySinh.ToString("dd/MM/yyyy").Contains(temp) || Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.MaNhanVien == nv.MaNhanVien).TenDangNhap.ToLower().Contains(temp)))
                .Select(nv => new ViewNhanVien { MaNhanVien = nv.MaNhanVien, HoVaTen = nv.HoVaTen, SoDienThoai = nv.SoDienThoai, Email = nv.Email, DiaChi = nv.DiaChi, NgaySinh = Convert.ToDateTime(nv.NgaySinh.ToString("dd/MM/yyyy")), GioiTinh = nv.GioiTinh, TenDangNhap = Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.MaNhanVien == nv.MaNhanVien).TenDangNhap, MucLuong = nv.MucLuong, NgayBatDauLamViec = Convert.ToDateTime(nv.NgayBatDauLamViec.ToString("dd/MM/yyyy")), LichLamViecs = BLLNhanVienLichLamViec.Instance.GetMaLichLamViecsOfNhanVien(nv.MaNhanVien) })
                .ToList();
            foreach (string s in cacTuKhoa)
            {
                if (s != temp)
                {
                    list = list.Where(nv => nv.MaNhanVien.ToLower().Contains(s) || nv.HoVaTen.ToLower().Contains(s) || nv.SoDienThoai.Contains(s) || nv.Email.ToLower().Contains(s) || nv.DiaChi.ToLower().Contains(s) || nv.NgaySinh.ToString("dd/MM/yyyy").Contains(s) || nv.TenDangNhap.ToLower().Contains(s)).ToList();
                }
            }
            return list;
        }

        public List<ViewNhanVien> SortNhanVien(List<ViewNhanVien> nhanViens, string kieuSapXep, bool ascending)
        {
            if (ascending == true)
            {
                if (kieuSapXep == "MaNhanVien")
                    return nhanViens.OrderBy(nv => Convert.ToInt32(nv.MaNhanVien.Substring(2))).ToList();
                return nhanViens.OrderBy(nv => nv.GetType().GetProperty(kieuSapXep).GetValue(nv, null)).ToList();
            }
            else
            {
                if (kieuSapXep == "MaNhanVien")
                    return nhanViens.OrderByDescending(nv => Convert.ToInt32(nv.MaNhanVien.Substring(2))).ToList();
                return nhanViens.OrderByDescending(nv => nv.GetType().GetProperty(kieuSapXep).GetValue(nv, null)).ToList();
            }
        }

        public List<ViewNhanVien> GetNhanViens(string kieuSapXep, string tuKhoa, bool ascending)
        {
            return SortNhanVien(SearchNhanVien(tuKhoa), kieuSapXep, ascending);
        }
    }
}
