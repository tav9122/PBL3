using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLBaoHanh
    {
        private static BLLBaoHanh instance;
        public static BLLBaoHanh Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLBaoHanh();
                return instance;
            }
        }

        public List<ViewBaoHanh> SearchBaoHanh(string tuKhoa)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewBaoHanh> list = Model.Instance.BaoHanhs.AsEnumerable().Where(bh => bh.DaXoa == false && (bh.SoSeri.ToLower().Contains(temp) || bh.VatPham.HoaDon.KhachHang.TenKhachHang.ToLower().Contains(temp) || bh.VatPham.SanPham.TenSanPham.ToLower().Contains(temp) || bh.VatPham.HoaDon.KhachHang.SoDienThoai.Contains(temp) || bh.TrangThai.ToString().Contains(temp) || bh.GhiChu.ToLower().Contains(temp) || bh.ThoiGianTaoPhieuBaoHanh.ToString("dd/MM/yyyy h:m tt").Contains(temp)))
                .Select(bh => new ViewBaoHanh { SoSeri = bh.SoSeri, TenKhachHang = bh.VatPham.HoaDon.KhachHang.TenKhachHang, TenSanPham = bh.VatPham.SanPham.TenSanPham, SoDienThoai = bh.VatPham.HoaDon.KhachHang.SoDienThoai, TrangThai = bh.TrangThai, GhiChu = bh.GhiChu, ThoiGianTaoPhieuBaoHanh = bh.ThoiGianTaoPhieuBaoHanh })
                .ToList();
            foreach (string s in cacTuKhoa)
            {
                if (s != temp)
                {
                    list = list.Where(bh => bh.SoSeri.ToLower().Contains(s) || bh.SoDienThoai.ToLower().Contains(s) || bh.TenSanPham.ToLower().Contains(s) || bh.TenKhachHang.Contains(s) || bh.TrangThai.ToString().Contains(s) || bh.GhiChu.ToLower().Contains(s) || bh.ThoiGianTaoPhieuBaoHanh.ToString("dd/MM/yyyy h:m tt").Contains(s)).ToList();
                }
            }
            return list;
        }

        public List<ViewBaoHanh> SortBaoHanh(List<ViewBaoHanh> baoHanhs, string kieuSapXep)
        {
            try { return baoHanhs.OrderBy(bh => bh.GetType().GetProperty(kieuSapXep).GetValue(bh, null)).ToList(); }
            catch { return baoHanhs; }
        }

        public List<ViewBaoHanh> GetBaoHanhs(string kieuSapXep, string tuKhoa)
        {
            return SortBaoHanh(SearchBaoHanh(tuKhoa), kieuSapXep);
        }

        public BaoHanh GetBaoHanh(string soSeri)
        {
            return Model.Instance.BaoHanhs.Where(bh => bh.SoSeri == soSeri).FirstOrDefault();
        }
        public void DeleteBaoHanh(string soSeri)
        {
            Model.Instance.BaoHanhs.Where(bh => bh.SoSeri == soSeri).FirstOrDefault().DaXoa = true;
            Model.Instance.SaveChanges();
        }

        public void AddBaoHanh(string soSeri, bool trangThai, string ghiChu, DateTime thoiGianTaoPhieuBaoHanh)
        {
            Model.Instance.BaoHanhs.Add(new BaoHanh { SoSeri = soSeri, TrangThai = trangThai, GhiChu = ghiChu, ThoiGianTaoPhieuBaoHanh = thoiGianTaoPhieuBaoHanh });
            Model.Instance.SaveChanges();
        }

        public void UpdateBaoHanh(string soSeri, bool trangThai, string ghiChu)
        {
            Model.Instance.BaoHanhs.Where(bh => bh.SoSeri == soSeri).First().TrangThai = trangThai;
            Model.Instance.BaoHanhs.Where(bh => bh.SoSeri == soSeri).First().GhiChu = ghiChu;
            Model.Instance.SaveChanges();
        }

    }

}
