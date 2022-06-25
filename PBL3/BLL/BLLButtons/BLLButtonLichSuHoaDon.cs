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
            List<ViewHoaDon> list = Model.Instance.HoaDons.AsEnumerable().Where(hd => hd.MaHoaDon.ToLower().Contains(temp) || hd.MaKhachHang.ToLower().Contains(temp) || hd.MaNhanVien.ToLower().Contains(temp) || hd.NhanVien.HoVaTen.ToLower().Contains(temp) || hd.KhachHang.SoDienThoai.ToLower().Contains(temp) || hd.ThoiGianGiaoDich.ToString("dd/MM/yyyy h:m tt").Contains(temp))
                .Select(hd => new ViewHoaDon { MaHoaDon = hd.MaHoaDon, MaNhanVien = hd.MaNhanVien, TenNhanVien = hd.NhanVien.HoVaTen, MaKhachHang = hd.MaKhachHang, SoDienThoai = hd.KhachHang.SoDienThoai, ThoiGianGiaoDich = hd.ThoiGianGiaoDich, ThanhTien = hd.ThanhTien })
                .ToList();
            foreach (string s in cacTuKhoa)
            {
                if (s != temp)
                {
                    list = list.Where(hd => hd.MaHoaDon.ToLower().Contains(s) || hd.MaKhachHang.ToLower().Contains(s) || hd.MaNhanVien.ToLower().Contains(s) || hd.SoDienThoai.ToLower().Contains(s) || hd.ThoiGianGiaoDich.ToString("dd/MM/yyyy h:m tt").Contains(s)).ToList();
                }
            }
            return list;
        }

        public List<ViewHoaDon> SortHoaDon(List<ViewHoaDon> hoaDons, string kieuSapXep)
        {
            if (kieuSapXep == "MaHoaDon")
                return hoaDons.OrderBy(hd => Convert.ToInt32(hd.MaHoaDon.Substring(2))).ToList();
            return hoaDons.OrderBy(hd => hd.GetType().GetProperty(kieuSapXep).GetValue(hd, null)).ToList();
        }

        public List<ViewHoaDon> GetHoaDons(string kieuSapXep, string tuKhoa)
        {
            return SortHoaDon(SearchHoaDon(tuKhoa), kieuSapXep);
        }
    }
}
