using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLLichSuHoaDon
    {
        private static BLLLichSuHoaDon instance;
        public static BLLLichSuHoaDon Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLLichSuHoaDon();
                return instance;
            }
        }

        public List<String> GetMaHoaDons()
        {
            if (Model.Instance.HoaDons.Select(x => x.MaHoaDon).ToList() == null)
                return new List<string> { "HD0" };
            else
                return Model.Instance.HoaDons.Select(x => x.MaHoaDon).ToList();
        }

        public double GetTongSoTien()
        {
            return Model.Instance.SanPhams.Where(hd => hd.SoLuongTrongTuiHang > 0).Sum(hd => hd.GiaBan * hd.SoLuongTrongTuiHang);
        }

        public void AddHoaDon(string maHoaDon, string maNhanVien, string maKhachHang, DateTime thoiGianGiaoDich, double thanhTien)
        {
            Model.Instance.HoaDons.Add(new HoaDon { MaHoaDon = maHoaDon, MaNhanVien = maNhanVien, MaKhachHang = maKhachHang, ThoiGianGiaoDich = thoiGianGiaoDich, ThanhTien = thanhTien });
            Model.Instance.SaveChanges();
        }

        public List<ViewHoaDon> SearchHoaDon(string tuKhoa)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.ToLower().Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewHoaDon> list = Model.Instance.HoaDons.AsEnumerable().Where(hd => hd.DaXoa == false && (hd.MaHoaDon.ToLower().Contains(temp) || hd.MaKhachHang.ToLower().Contains(temp) || hd.MaNhanVien.ToLower().Contains(temp) || hd.KhachHang.SoDienThoai.ToLower().Contains(temp) || hd.ThoiGianGiaoDich.ToString("dd/MM/yyyy h:m tt").Contains(temp)))
                .Select(hd => new ViewHoaDon { MaHoaDon = hd.MaHoaDon, MaNhanVien = hd.MaNhanVien, MaKhachHang = hd.MaKhachHang, SoDienThoai = hd.KhachHang.SoDienThoai, ThoiGianGiaoDich = hd.ThoiGianGiaoDich, ThanhTien = hd.ThanhTien })
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
            try { return hoaDons.OrderBy(hd => hd.GetType().GetProperty(kieuSapXep).GetValue(hd, null)).ToList(); }
            catch { return hoaDons; }
        }

        public List<ViewHoaDon> GetHoaDons(string kieuSapXep, string tuKhoa)
        {
            return SortHoaDon(SearchHoaDon(tuKhoa), kieuSapXep);
        }

        public void DeleteHoaDon(string maHoaDon)
        {
            Model.Instance.HoaDons.Where(hd => hd.MaHoaDon == maHoaDon).FirstOrDefault().DaXoa = true;
            Model.Instance.SaveChanges();
        }

        public HoaDon GetHoaDon(string maHoaDon)
        {
            return Model.Instance.HoaDons.FirstOrDefault(hd => hd.MaHoaDon == maHoaDon);
        }

        public List<ViewVatPham> GetVatPhamsByMaHoaDon(string maHoaDon)
        {
            List<ViewVatPham> vatPhams = new List<ViewVatPham>();
            foreach (ViewVatPham vatPham in Model.Instance.VatPhams.Where(vp => vp.MaHoaDon == maHoaDon).Select(vp => new ViewVatPham { SoSeri = vp.SoSeri, MaSanPham = vp.MaSanPham, TenSanPham = vp.SanPham.TenSanPham, GiaBan = vp.SanPham.GiaBan, MaHoaDon = vp.MaHoaDon }))
            {
                vatPhams.Add(vatPham);
            }
            return vatPhams;
        }
    }
}
