using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLHoaDon
    {
        private static BLLHoaDon instance;
        public static BLLHoaDon Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLHoaDon();
                return instance;
            }
        }

        public void AddHoaDon(string maHoaDon, string maNhanVien, string maKhachHang, DateTime thoiGianGiaoDich, double thanhTien)
        {
            Model.Instance.HoaDons.Add(new HoaDon { MaHoaDon = maHoaDon, MaNhanVien = maNhanVien, MaKhachHang = maKhachHang, ThoiGianGiaoDich = thoiGianGiaoDich, ThanhTien = thanhTien });
            Model.Instance.SaveChanges();
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

        public List<String> GetMaHoaDons()
        {
            if (Model.Instance.HoaDons.Select(x => x.MaHoaDon).ToList() == null)
                return new List<string> { "HD0" };
            else
                return Model.Instance.HoaDons.Select(x => x.MaHoaDon).ToList();
        }
    }
}
