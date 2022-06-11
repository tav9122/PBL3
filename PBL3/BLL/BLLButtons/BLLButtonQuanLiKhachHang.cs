using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLButtonQuanLiKhachHang
    {
        private static BLLButtonQuanLiKhachHang instance;
        public static BLLButtonQuanLiKhachHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLButtonQuanLiKhachHang();
                return instance;
            }
        }

        public List<ViewKhachHang> SearchKhachHang(string tuKhoa)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.ToLower().Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewKhachHang> list = Model.Instance.KhachHangs.Where(kh => kh.DaXoa == false && (kh.DiaChi.ToLower().Contains(temp) || kh.SoDienThoai.ToLower().Contains(temp) || kh.TenKhachHang.ToLower().Contains(temp) || kh.MaKhachHang.ToLower().Contains(temp)))
                .Select(kh => new ViewKhachHang { DiaChi = kh.DiaChi, TenKhachHang = kh.TenKhachHang, MaKhachHang = kh.MaKhachHang, SoDienThoai = kh.SoDienThoai })
                .ToList();
            foreach (string s in cacTuKhoa)
            {
                if (s != temp)
                {
                    list = list.Where(kh => kh.DiaChi.ToLower().Contains(s) || kh.SoDienThoai.ToLower().Contains(s) || kh.TenKhachHang.ToLower().Contains(s) || kh.MaKhachHang.ToLower().Contains(s)).ToList();
                }
            }
            return list;
        }

        public List<ViewKhachHang> SortKhachHang(List<ViewKhachHang> khachHangs, string kieuSapXep)
        {
            try { return khachHangs.OrderBy(kh => kh.GetType().GetProperty(kieuSapXep).GetValue(kh, null)).ToList(); }
            catch { return khachHangs; }
        }

        public List<ViewKhachHang> GetKhachHangs(string kieuSapXep, string tuKhoa)
        {
            return SortKhachHang(SearchKhachHang(tuKhoa), kieuSapXep);
        }
    }
}
