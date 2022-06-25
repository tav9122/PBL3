using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLButtonQuanLiLoHang
    {
        private static BLLButtonQuanLiLoHang instance;
        public static BLLButtonQuanLiLoHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLButtonQuanLiLoHang();
                return instance;
            }
        }

        public List<ViewLoHang> SearchLoHang(string tuKhoa)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.ToLower().Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewLoHang> list = Model.Instance.LoHangs.AsEnumerable().Where(lh => lh.MaLoHang.ToLower().Contains(temp) || lh.TongTien.ToString().Contains(temp) || lh.ThoiGianNhapHang.ToString("dd/MM/yyyy h:m tt").Contains(temp))
                .Select(lh => new ViewLoHang { MaLoHang = lh.MaLoHang, ThoiGianNhapHang = lh.ThoiGianNhapHang, TongTien = lh.TongTien })
                .ToList();
            foreach (string s in cacTuKhoa)
            {
                if (s != temp)
                {
                    list = list.Where(lh => lh.MaLoHang.ToLower().Contains(s) || lh.TongTien.ToString().Contains(s) || lh.ThoiGianNhapHang.ToString("dd/MM/yyyy h:m tt").Contains(s)).ToList();
                }
            }
            return list;
        }

        public List<ViewLoHang> SortLoHang(List<ViewLoHang> loHangs, string kieuSapXep)
        {
            if (kieuSapXep == "MaLoHang")
                return loHangs.OrderBy(lh => Convert.ToInt32(lh.MaLoHang.Substring(2))).ToList();
            return loHangs.OrderBy(lh => lh.GetType().GetProperty(kieuSapXep).GetValue(lh, null)).ToList();
        }

        public List<ViewLoHang> GetLoHangs(string kieuSapXep, string tuKhoa)
        {
            return SortLoHang(SearchLoHang(tuKhoa), kieuSapXep);
        }

        public double GetTongTien()
        {
            if (Model.Instance.SanPhams.Where(sp => sp.Temp > 0).Count() > 0)
                return Model.Instance.SanPhams.Where(sp => sp.Temp > 0).Sum(sp => sp.GiaMua * sp.Temp);
            else return 0;
        }

        public void UpdateSoLuongSanPham(string maSanPham, int soLuong)
        {
            Model.Instance.SanPhams.Where(sp => sp.MaSanPham == maSanPham).FirstOrDefault().SoLuongNhap += soLuong;
            Model.Instance.SanPhams.Where(sp => sp.MaSanPham == maSanPham).FirstOrDefault().SoLuongHienTai += soLuong;
            Model.Instance.SaveChanges();
        }


        //Đây là các hàm hiển thị sản phẩm riêng cho lô hàng.
        public List<ViewSanPham_QuanTriVien_LoHang> SearchSanPham(string tuKhoa)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.ToLower().Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewSanPham_QuanTriVien_LoHang> list = Model.Instance.SanPhams.Where(sp => sp.DaXoa == false && (sp.MaSanPham.ToLower().Contains(temp) || sp.LoaiSanPham.ToLower().Contains(temp) || sp.TenSanPham.ToLower().Contains(temp) || sp.TenHang.ToLower().Contains(temp)))
                .Select(sp => new ViewSanPham_QuanTriVien_LoHang { MaSanPham = sp.MaSanPham, TenSanPham = sp.TenSanPham, TenHang = sp.TenHang, LoaiSanPham = sp.LoaiSanPham, GiaMua = sp.GiaMua, GiaBan = sp.GiaBan, SoLuongNhap = sp.SoLuongNhap, SoLuongHienTai = sp.SoLuongHienTai, ThoiGianBaoHanh = sp.ThoiGianBaoHanh, SoLuongNhapThem = sp.Temp })
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

        public List<ViewSanPham_QuanTriVien_LoHang> SortSanPham(List<ViewSanPham_QuanTriVien_LoHang> sanPhams, string kieuSapXep)
        {
            return sanPhams.OrderBy(sp => sp.GetType().GetProperty(kieuSapXep).GetValue(sp, null)).ToList();
        }

        public List<ViewSanPham_QuanTriVien_LoHang> GetSanPhams(string kieuSapXep, string tuKhoa)
        {
            return SortSanPham(SearchSanPham(tuKhoa), kieuSapXep);
        }


        //Đây là các hàm hiển thị vật phẩm riêng cho lô hàng.
        public List<ViewVatPham_QuanTriVien> SearchVatPham(string tuKhoa, string maLoHang)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.ToLower().Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewVatPham_QuanTriVien> list = Model.Instance.VatPhams.AsEnumerable().Where(vp => vp.MaLoHang.Equals(maLoHang) && (vp.SoSeri.ToLower().Contains(temp) || vp.MaSanPham.ToLower().Contains(temp) || vp.SanPham.TenSanPham.Contains(temp) || vp.SanPham.TenHang.ToLower().Contains(temp) || vp.SanPham.LoaiSanPham.ToLower().Contains(temp)))
                .Select(vp => new ViewVatPham_QuanTriVien { SoSeri = vp.SoSeri, MaSanPham = vp.MaSanPham, TenSanPham = vp.SanPham.TenSanPham, TenHang = vp.SanPham.TenHang, LoaiSanPham = vp.SanPham.LoaiSanPham, GiaMua = vp.GiaMua })
                .ToList();
            foreach (string s in cacTuKhoa)
            {
                if (s != temp)
                {
                    list = list.Where(vp => (vp.SoSeri.ToLower().Contains(temp) || vp.MaSanPham.ToLower().Contains(temp) || vp.TenSanPham.Contains(temp) || vp.TenHang.ToLower().Contains(temp) || vp.LoaiSanPham.ToLower().Contains(temp))).ToList();
                }
            }
            return list;
        }

        public List<ViewVatPham_QuanTriVien> SortVatPham(List<ViewVatPham_QuanTriVien> vatPhams, string kieuSapXep)
        {
            if (kieuSapXep == "SoSeri")
                return vatPhams.OrderBy(vp => Convert.ToDouble(vp.SoSeri)).ToList();
            return vatPhams.OrderBy(vp => vp.GetType().GetProperty(kieuSapXep).GetValue(vp, null)).ToList();
        }

        public List<ViewVatPham_QuanTriVien> GetVatPhams(string kieuSapXep, string tuKhoa, string maLoHang)
        {
            return SortVatPham(SearchVatPham(tuKhoa, maLoHang), kieuSapXep);
        }
    }
}
