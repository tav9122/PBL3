using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLButtonLichSuHoaDon
    {
        private static BLLButtonLichSuHoaDon instance;
        public static BLLButtonLichSuHoaDon Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLButtonLichSuHoaDon();
                return instance;
            }
        }

        public List<ViewHoaDon> SearchHoaDon(string tuKhoa)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.ToLower().Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewHoaDon> list = Model.Instance.HoaDons.AsEnumerable().Where(hd => hd.MaHoaDon.ToLower().Contains(temp) || hd.MaKhachHang.ToLower().Contains(temp) || hd.MaNhanVien.ToLower().Contains(temp) || hd.NhanVien.HoVaTen.ToLower().Contains(temp) || hd.KhachHang.SoDienThoai.Contains(temp) || hd.ThoiGianGiaoDich.ToString("dd/MM/yyyy hh:mm tt").ToLower().Contains(temp))
                .Select(hd => new ViewHoaDon { MaHoaDon = hd.MaHoaDon, MaNhanVien = hd.MaNhanVien, TenNhanVien = hd.NhanVien.HoVaTen, MaKhachHang = hd.MaKhachHang, SoDienThoai = hd.KhachHang.SoDienThoai, ThoiGianGiaoDich = hd.ThoiGianGiaoDich, ThanhTien = hd.ThanhTien })
                .ToList();
            foreach (string s in cacTuKhoa)
            {
                if (s != temp)
                {
                    list = list.Where(hd => hd.MaHoaDon.ToLower().Contains(s) || hd.MaKhachHang.ToLower().Contains(s) || hd.MaNhanVien.ToLower().Contains(s) || hd.SoDienThoai.Contains(s) || hd.ThoiGianGiaoDich.ToString("dd/MM/yyyy hh:mm tt").ToLower().Contains(s)).ToList();
                }
            }
            return list;
        }

        public List<ViewHoaDon> SortHoaDon(List<ViewHoaDon> hoaDons, string kieuSapXep, bool ascending)
        {
            if (ascending == true)
            {
                if (kieuSapXep == "MaHoaDon")
                    return hoaDons.OrderBy(hd => Convert.ToInt32(hd.MaHoaDon.Substring(2))).ToList();
                return hoaDons.OrderBy(hd => hd.GetType().GetProperty(kieuSapXep).GetValue(hd, null)).ToList();
            }
            else
            {
                if (kieuSapXep == "MaHoaDon")
                    return hoaDons.OrderByDescending(hd => Convert.ToInt32(hd.MaHoaDon.Substring(2))).ToList();
                return hoaDons.OrderByDescending(hd => hd.GetType().GetProperty(kieuSapXep).GetValue(hd, null)).ToList();
            }
        }

        public List<ViewHoaDon> GetHoaDons(string kieuSapXep, string tuKhoa, bool ascending)
        {
            return SortHoaDon(SearchHoaDon(tuKhoa), kieuSapXep, ascending);
        }
    }
}
