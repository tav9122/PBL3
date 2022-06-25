using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLButtonSanPham
    {
        private static BLLButtonSanPham instance;
        public static BLLButtonSanPham Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLButtonSanPham();
                return instance;
            }
        }

        public List<ViewSanPham_NhanVien> SearchSanPham(string tuKhoa)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.ToLower().Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewSanPham_NhanVien> list = Model.Instance.SanPhams.Where(sp => sp.DaXoa == false && (sp.MaSanPham.ToLower().Contains(temp) || sp.LoaiSanPham.ToLower().Contains(temp) || sp.TenSanPham.ToLower().Contains(temp) || sp.TenHang.ToLower().Contains(temp)))
                .Select(sp => new ViewSanPham_NhanVien { MaSanPham = sp.MaSanPham, TenSanPham = sp.TenSanPham, TenHang = sp.TenHang, LoaiSanPham = sp.LoaiSanPham, GiaBan = sp.GiaBan, SoLuongHienTai = sp.SoLuongHienTai, ThoiGianBaoHanh = sp.ThoiGianBaoHanh, SoLuongTrongTuiHang = sp.Temp })
                .ToList();
            foreach (string s in cacTuKhoa)
            {
                if (s != temp)
                {
                    list = list.Where(sp => sp.MaSanPham.ToLower().Contains(s) || sp.LoaiSanPham.ToLower().Contains(s) || sp.TenSanPham.ToLower().Contains(s) || sp.TenHang.ToLower().Contains(s)).ToList();
                }
            }
            return list;
        }

        public List<ViewSanPham_NhanVien> SortSanPham(List<ViewSanPham_NhanVien> sanPhams, string kieuSapXep)
        {
            return sanPhams.OrderBy(sp => sp.GetType().GetProperty(kieuSapXep).GetValue(sp, null)).ToList();
        }

        public List<ViewSanPham_NhanVien> GetSanPhams(string kieuSapXep, string tuKhoa)
        {
            return SortSanPham(SearchSanPham(tuKhoa), kieuSapXep);
        }

        public void AssignMaHoaDonToVatPhams(string maHoaDon, string maSanPham, int soLuong)
        {
            int i = 0;
            foreach (VatPham vatPham in Model.Instance.VatPhams.Where(vp => vp.MaSanPham == maSanPham).ToList())
            {
                if (vatPham.MaHoaDon == null)
                {
                    vatPham.MaHoaDon = maHoaDon;
                    i++;
                    if (i == soLuong) break;
                }
            }
            Model.Instance.SanPhams.Where(sp => sp.MaSanPham == maSanPham).FirstOrDefault().SoLuongHienTai -= soLuong;
            Model.Instance.SaveChanges();
        }

        public List<ViewSanPham_NhanVien> GetSanPhamWithTempValueGreaterThanZero()
        {
            return Model.Instance.SanPhams.Where(sp => sp.Temp > 0).Select(sp => new ViewSanPham_NhanVien { MaSanPham = sp.MaSanPham, TenSanPham = sp.TenSanPham, TenHang = sp.TenHang, LoaiSanPham = sp.LoaiSanPham, GiaBan = sp.GiaBan, SoLuongHienTai = sp.SoLuongHienTai, ThoiGianBaoHanh = sp.ThoiGianBaoHanh, SoLuongTrongTuiHang = sp.Temp }).ToList();
        }

        public double GetTongTien()
        {
            return Model.Instance.SanPhams.Where(hd => hd.Temp > 0).Sum(hd => hd.GiaBan * hd.Temp);
        }
    }
}
