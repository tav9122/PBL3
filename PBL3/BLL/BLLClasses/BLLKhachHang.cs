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
            x.GhiChu = ghiChu;
            Model.Instance.SaveChanges();
        }

        public void DeleteKhachHang(string maKhachHang)
        {
            Model.Instance.KhachHangs.Where(kh => kh.MaKhachHang == maKhachHang).FirstOrDefault().DaXoa = true;
            Model.Instance.SaveChanges();
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

        public List<string> GetMaKhachHangs()
        {
            if (Model.Instance.KhachHangs.Select(x => x.MaKhachHang).ToList() == null)
                return new List<string> { "KH0" };
            else
                return Model.Instance.KhachHangs.Select(x => x.MaKhachHang).ToList();
        }
    }
}
