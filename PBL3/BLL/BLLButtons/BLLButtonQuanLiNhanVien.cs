﻿using System;
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
            List<ViewNhanVien> list = Model.Instance.NhanViens.AsEnumerable().Where(nv => nv.DaXoa == false && nv.MaNhanVien != "QTV" && (nv.MaNhanVien.ToLower().Contains(temp) || nv.HoVaTen.ToLower().Contains(temp) || nv.SoDienThoai.ToLower().Contains(temp) || nv.DiaChi.ToLower().Contains(temp) || nv.NgaySinh.ToString("dd/MM/yyyy h:m tt").Contains(temp) || Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.MaNhanVien == nv.MaNhanVien).TenDangNhap.ToLower().Contains(temp)))
                .Select(nv => new ViewNhanVien { MaNhanVien = nv.MaNhanVien, HoVaTen = nv.HoVaTen, SoDienThoai = nv.SoDienThoai, DiaChi = nv.DiaChi, NgaySinh = Convert.ToDateTime(nv.NgaySinh.ToString("dd/MM/yyyy")), GioiTinh = nv.GioiTinh, TenDangNhap = Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.MaNhanVien == nv.MaNhanVien).TenDangNhap, MucLuong = nv.MucLuong, LichLamViecs = BLLNhanVienLichLamViec.Instance.GetMaLichLamViecsOfNhanVien(nv.MaNhanVien) })
                .ToList();
            foreach (string s in cacTuKhoa)
            {
                if (s != temp)
                {
                    list = list.Where(nv => nv.MaNhanVien.ToLower().Contains(s) || nv.HoVaTen.ToLower().Contains(s) || nv.SoDienThoai.ToLower().Contains(s) || nv.DiaChi.ToLower().Contains(s) || nv.NgaySinh.ToString("dd/MM/yyyy h:m tt").Contains(s) || nv.TenDangNhap.Contains(s)).ToList();
                }
            }
            return list;
        }

        public List<ViewNhanVien> SortNhanVien(List<ViewNhanVien> nhanViens, string kieuSapXep)
        {
            try { return nhanViens.OrderBy(nv => nv.GetType().GetProperty(kieuSapXep).GetValue(nv, null)).ToList(); }
            catch { return nhanViens; }
        }

        public List<ViewNhanVien> GetNhanViens(string kieuSapXep, string tuKhoa)
        {
            return SortNhanVien(SearchNhanVien(tuKhoa), kieuSapXep);
        }
    }
}
