using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLQuanLiKhachHang
    {
        private static BLLQuanLiKhachHang instance;
        public static BLLQuanLiKhachHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLQuanLiKhachHang();
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

        public KhachHang GetKhachHang(string maKhachHangHoacSoDienThoai)
        {
            if (Model.Instance.KhachHangs.Where(kh => kh.MaKhachHang == maKhachHangHoacSoDienThoai).FirstOrDefault() != null)
            {
                return Model.Instance.KhachHangs.Where(kh => kh.MaKhachHang == maKhachHangHoacSoDienThoai).FirstOrDefault();
            }
            else if ((Model.Instance.KhachHangs.Where(kh => kh.SoDienThoai == maKhachHangHoacSoDienThoai).FirstOrDefault() != null))
            {
                return Model.Instance.KhachHangs.Where(kh => kh.SoDienThoai == maKhachHangHoacSoDienThoai).FirstOrDefault();
            }
            else return null;
        }

        public void AddKhachHang(string maKhachHang, string tenKhachHang, string DiaChi, string soDienThoai, string ghiChu)
        {
            Model.Instance.KhachHangs.Add(new KhachHang { MaKhachHang = maKhachHang, TenKhachHang = tenKhachHang, DiaChi = DiaChi, SoDienThoai = soDienThoai, GhiChu = ghiChu });
            Model.Instance.SaveChanges();
        }

        public List<KhachHang> GetKhachHangs()
        {
            return Model.Instance.KhachHangs.ToList();
        }

        public List<string> GetMaKhachHangs()
        {
            if (Model.Instance.KhachHangs.Select(x => x.MaKhachHang).ToList() == null)
                return new List<string> { "KH0" };
            else
                return Model.Instance.KhachHangs.Select(x => x.MaKhachHang).ToList();
        }

        public void DeleteKhachHang(string maKhachHang)
        {
            Model.Instance.KhachHangs.Where(kh => kh.MaKhachHang == maKhachHang).FirstOrDefault().DaXoa = true;
            Model.Instance.SaveChanges();
        }

        public void UpdateKhachHang(string maKhachHang, string tenKhachHang, string diaChi, string soDienThoai, string ghiChu)
        {
            var x = Model.Instance.KhachHangs.Where(kh => kh.MaKhachHang == maKhachHang).FirstOrDefault();
            x.TenKhachHang = tenKhachHang;
            x.MaKhachHang = maKhachHang;
            x.DiaChi = diaChi;
            x.SoDienThoai = soDienThoai;
            x.GhiChu = ghiChu;
            Model.Instance.SaveChanges();
        }
    }
}
