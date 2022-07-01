using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLVatPham
    {
        private static BLLVatPham instance;
        public static BLLVatPham Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLVatPham();
                return instance;
            }
        }

        public void InitializeNewVatPhams(int soLuongNhapThem, string maSanPham, string maLoHang)
        {
            int count = Model.Instance.VatPhams.Count();
            var x = Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham);
            x.SoLuongHienTai += soLuongNhapThem;
            x.SoLuongNhap += soLuongNhapThem;
            for (int i = 0; i < soLuongNhapThem; i++)
            {
                Model.Instance.VatPhams.Add(new VatPham { SoSeri = DateTime.Now.ToString("yyyyMMdd") + count.ToString().PadLeft(6, '0'), MaSanPham = maSanPham, MaLoHang = maLoHang, GiaMua = Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham).GiaMua, GiaBan = Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham).GiaBan });
                count++;
            }
            Model.Instance.SaveChanges();
        }

        public VatPham GetVatPham(string soSeri)
        {
            var x = Model.Instance.VatPhams.Where(vp => vp.SoSeri == soSeri);
            if (!x.Any())
                return x.FirstOrDefault();
            else
                return null;
        }

        public List<ViewVatPham_NhanVien> GetVatPhamsByMaHoaDon(string maHoaDon)
        {
            List<ViewVatPham_NhanVien> vatPhams = new List<ViewVatPham_NhanVien>();
            foreach (ViewVatPham_NhanVien vatPham in Model.Instance.VatPhams.Where(vp => vp.MaHoaDon == maHoaDon).Select(vp => new ViewVatPham_NhanVien { SoSeri = vp.SoSeri, MaSanPham = vp.MaSanPham, TenSanPham = vp.SanPham.TenSanPham, GiaBan = vp.GiaBan }))
            {
                vatPhams.Add(vatPham);
            }
            return vatPhams.OrderBy(vp => Convert.ToDouble(vp.SoSeri)).ToList();
        }
    }
}
