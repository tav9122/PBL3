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

        public List<ViewSanPham_NhanVien> SearchSanPham(string tuKhoa)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.ToLower().Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewSanPham_NhanVien> list = Model.Instance.SanPhams.Where(sp => sp.DaXoa == false && (sp.MaSanPham.ToLower().Contains(temp) || sp.LoaiSanPham.ToLower().Contains(temp) || sp.TenSanPham.ToLower().Contains(temp) || sp.TenHang.ToLower().Contains(temp)))
                .Select(sp => new ViewSanPham_NhanVien { MaSanPham = sp.MaSanPham, TenSanPham = sp.TenSanPham, TenHang = sp.TenHang, LoaiSanPham = sp.LoaiSanPham, GiaBan = sp.GiaBan, SoLuongHienTai = sp.SoLuongHienTai, ThoiGianBaoHanh = sp.ThoiGianBaoHanh, SoLuongTrongTuiHang = sp.SoLuongTrongTuiHang })
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
            try { return sanPhams.OrderBy(sp => sp.GetType().GetProperty(kieuSapXep).GetValue(sp, null)).ToList(); }
            catch { return sanPhams; }
        }

        public List<ViewSanPham_NhanVien> GetSanPhams(string kieuSapXep, string tuKhoa)
        {
            return SortSanPham(SearchSanPham(tuKhoa), kieuSapXep);
        }

        public void SetSoLuongTrongTuiHang(string maSanPham, int soLuong)
        {
            Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham).SoLuongTrongTuiHang = soLuong;
            Model.Instance.SaveChanges();
        }
        public void ResetSoLuongTrongTuiHang()
        {
            foreach (SanPham sanPham in Model.Instance.SanPhams.Where(sp => sp.SoLuongTrongTuiHang > 0))
            {
                sanPham.SoLuongTrongTuiHang = 0;
            }
            Model.Instance.SaveChanges();
        }

        public List<ViewSanPham_NhanVien> GetTuiHang()
        {
            return Model.Instance.SanPhams.Where(sp => sp.SoLuongTrongTuiHang > 0).Select(sp => new ViewSanPham_NhanVien { MaSanPham = sp.MaSanPham, TenSanPham = sp.TenSanPham, TenHang = sp.TenHang, LoaiSanPham = sp.LoaiSanPham, GiaBan = sp.GiaBan, SoLuongHienTai = sp.SoLuongHienTai, ThoiGianBaoHanh = sp.ThoiGianBaoHanh, SoLuongTrongTuiHang = sp.SoLuongTrongTuiHang }).ToList();
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

        public string GetTenSanPhamBySoSeri(string soSeri)
        {
            try { return Model.Instance.VatPhams.FirstOrDefault(vp => vp.SoSeri == soSeri).SanPham.TenSanPham; }
            catch { return null; }
        }

        public string GetSoDienThoaiKhachHangBySoSeri(string soSeri)
        {
            try { return Model.Instance.VatPhams.FirstOrDefault(vp => vp.SoSeri == soSeri).HoaDon.KhachHang.SoDienThoai; }
            catch { return null; }
        }
    }
}
