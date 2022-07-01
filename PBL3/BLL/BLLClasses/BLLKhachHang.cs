using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLKhachHang
    {
        private static BLLKhachHang instance;
        public static BLLKhachHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLKhachHang();
                return instance;
            }
        }

        public void AddKhachHang(string maKhachHang, string tenKhachHang, string DiaChi, string soDienThoai, string ghiChu)
        {
            Model.Instance.KhachHangs.Add(new KhachHang { MaKhachHang = maKhachHang, TenKhachHang = tenKhachHang, DiaChi = DiaChi, SoDienThoai = soDienThoai, GhiChu = ghiChu });
            Model.Instance.SaveChanges();
        }

        public void UpdateKhachHang(string maKhachHang, string tenKhachHang, string diaChi, string soDienThoai, string ghiChu)
        {
            var x = Model.Instance.KhachHangs.Where(kh => kh.MaKhachHang == maKhachHang).FirstOrDefault();
            x.TenKhachHang = tenKhachHang;
            x.MaKhachHang = maKhachHang;
            x.DiaChi = diaChi;
            x.SoDienThoai = soDienThoai;
            if (ghiChu != null)
                x.GhiChu = ghiChu;
            Model.Instance.SaveChanges();
        }

        public KhachHang GetKhachHang(string maKhachHangHoacSoDienThoai)
        {
            var x = Model.Instance.KhachHangs.Where(kh => kh.MaKhachHang == maKhachHangHoacSoDienThoai).FirstOrDefault();
            if (x != null)
            {
                return x;
            }
            else
            {
                var y = Model.Instance.KhachHangs.Where(kh => kh.SoDienThoai == maKhachHangHoacSoDienThoai).FirstOrDefault();
                if (y != null)
                    return y;
                else return null;
            }
        }

        public List<string> GetMaKhachHangs()
        {
            var x = Model.Instance.KhachHangs.Select(kh => kh.MaKhachHang).ToList();
            if (!x.Any())
                return new List<string> { "KH0" };
            else
                return x;
        }
    }
}
