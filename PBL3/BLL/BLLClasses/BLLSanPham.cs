using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLSanPham
    {
        private static BLLSanPham instance;
        public static BLLSanPham Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLSanPham();
                return instance;
            }
        }

        public SanPham GetSanPham(string maSanPham)
        {
            return Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham);
        }

        public List<string> GetMaSanPhams()
        {
            if (Model.Instance.SanPhams.Select(sp => sp.MaSanPham).ToList() == null)
                return new List<string> { "SP0" };
            else
                return Model.Instance.SanPhams.Select(sp => sp.MaSanPham).ToList();
        }

        public void AddSanPham(string maSanPham, string tenSanPham, string tenHang, string loaiSanPham, double giaMua, double giaBan, int soLuongNhap, int soLuongHienTai, string thoiGianBaoHanh)
        {
            Model.Instance.SanPhams.Add(new SanPham { MaSanPham = maSanPham, TenSanPham = tenSanPham, TenHang = tenHang, LoaiSanPham = loaiSanPham, GiaMua = giaMua, GiaBan = giaBan, SoLuongNhap = soLuongNhap, SoLuongHienTai = soLuongHienTai, ThoiGianBaoHanh = thoiGianBaoHanh });
            Model.Instance.SaveChanges();
        }
        public void UpdateSanPham(string maSanPham, string tenSanPham, string tenHang, string loaiSanPham, double giaMua, double giaBan, int soLuongNhap, int soLuongHienTai, string thoiGianBaoHanh)
        {
            var sanpham = Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham);
            sanpham.TenSanPham = tenSanPham;
            sanpham.TenHang = tenHang;
            sanpham.LoaiSanPham = loaiSanPham;
            sanpham.GiaMua = giaMua;
            sanpham.GiaBan = giaBan;
            sanpham.SoLuongNhap = soLuongNhap;
            sanpham.SoLuongHienTai = soLuongHienTai;
            sanpham.ThoiGianBaoHanh = thoiGianBaoHanh;

            foreach (VatPham vatPhams in Model.Instance.VatPhams.Where(vp => vp.MaSanPham == maSanPham))
            {
                if (vatPhams.MaHoaDon == null)
                {
                    vatPhams.GiaBan = giaBan;
                }
            }
            Model.Instance.SaveChanges();
        }

        public void DeleteSanPham(string maSanPham)
        {
            Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham).DaXoa = true;
            Model.Instance.SaveChanges();
        }

        public List<string> GetLoaiSanPhams()
        {
            return Model.Instance.SanPhams.Select(sp => sp.LoaiSanPham).Distinct().ToList();
        }

        public void SetTempValue(string maSanPham, int soLuong)
        {
            Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham).Temp = soLuong;
            Model.Instance.SaveChanges();
        }

        public void ResetTemp()
        {
            foreach (SanPham sanPham in Model.Instance.SanPhams.Where(sp => sp.Temp > 0))
            {
                sanPham.Temp = 0;
            }
            Model.Instance.SaveChanges();
        }

        public List<SanPham> GetSanPhamWithTempValueGreaterThanZero()
        {
            return Model.Instance.SanPhams.Where(sp => sp.Temp > 0).ToList();
        }
    }
}
