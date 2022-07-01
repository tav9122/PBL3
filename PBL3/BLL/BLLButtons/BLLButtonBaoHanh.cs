using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLButtonBaoHanh
    {
        private static BLLButtonBaoHanh instance;
        public static BLLButtonBaoHanh Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLButtonBaoHanh();
                return instance;
            }
        }
        public List<ViewBaoHanh> SearchBaoHanh(string tuKhoa)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.ToLower().Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewBaoHanh> list = Model.Instance.BaoHanhs.AsEnumerable().Where(bh => bh.MaBaoHanh.ToLower().Contains(temp) || bh.SoSeri.Contains(temp) || bh.VatPham.HoaDon.KhachHang.TenKhachHang.ToLower().Contains(temp) || bh.VatPham.SanPham.TenSanPham.ToLower().Contains(temp) || bh.VatPham.HoaDon.KhachHang.SoDienThoai.Contains(temp) || bh.TrangThai.ToString().ToLower().Contains(temp) || bh.GhiChu.ToLower().Contains(temp) || bh.ThoiGianTaoPhieuBaoHanh.ToString("dd/MM/yyyy h:m tt").ToLower().Contains(temp))
                .Select(bh => new ViewBaoHanh { MaBaoHanh = bh.MaBaoHanh, SoSeri = bh.SoSeri, TenKhachHang = bh.VatPham.HoaDon.KhachHang.TenKhachHang, TenSanPham = bh.VatPham.SanPham.TenSanPham, SoDienThoai = bh.VatPham.HoaDon.KhachHang.SoDienThoai, TrangThai = bh.TrangThai, GhiChu = bh.GhiChu, ThoiGianTaoPhieuBaoHanh = bh.ThoiGianTaoPhieuBaoHanh })
                .ToList();
            foreach (string s in cacTuKhoa)
            {
                if (s != temp)
                {
                    list = list.Where(bh => bh.MaBaoHanh.ToLower().Contains(s) || bh.SoSeri.Contains(s) || bh.SoDienThoai.Contains(s) || bh.TenSanPham.ToLower().Contains(s) || bh.TenKhachHang.ToLower().Contains(s) || bh.TrangThai.ToString().ToLower().Contains(s) || bh.GhiChu.ToLower().Contains(s) || bh.ThoiGianTaoPhieuBaoHanh.ToString("dd/MM/yyyy h:m tt").ToLower().Contains(s)).ToList();
                }
            }
            return list;
        }

        public List<ViewBaoHanh> SortBaoHanh(List<ViewBaoHanh> baoHanhs, string kieuSapXep, bool ascending)
        {
            if (ascending == true)
            {
                if (kieuSapXep == "MaBaoHanh")
                    return baoHanhs.OrderBy(bh => Convert.ToInt32(bh.MaBaoHanh.Substring(2))).ToList();
                return baoHanhs.OrderBy(bh => bh.GetType().GetProperty(kieuSapXep).GetValue(bh, null)).ToList();
            }
            else
            {
                if (kieuSapXep == "MaBaoHanh")
                    return baoHanhs.OrderByDescending(bh => Convert.ToInt32(bh.MaBaoHanh.Substring(2))).ToList();
                return baoHanhs.OrderByDescending(bh => bh.GetType().GetProperty(kieuSapXep).GetValue(bh, null)).ToList();
            }
        }

        public List<ViewBaoHanh> GetBaoHanhs(string kieuSapXep, string tuKhoa, bool ascending)
        {
            return SortBaoHanh(SearchBaoHanh(tuKhoa), kieuSapXep, ascending);
        }

        public int DaysExceedWarrantyPeriod(string soSeri)
        {
            var thoiGianGiaoDich = Model.Instance.VatPhams.FirstOrDefault(vp => vp.SoSeri == soSeri).HoaDon.ThoiGianGiaoDich;
            var thoiGianBaoHanh = Model.Instance.VatPhams.FirstOrDefault(vp => vp.SoSeri == soSeri).SanPham.ThoiGianBaoHanh.Substring(0, 1);
            if ((DateTime.Now - thoiGianGiaoDich).Days > 365 * Convert.ToInt32(thoiGianBaoHanh))
            {
                return (DateTime.Now - thoiGianGiaoDich).Days - 365 * Convert.ToInt32(thoiGianBaoHanh);
            }
            else
            {
                return 0;
            }
        }
    }
}
