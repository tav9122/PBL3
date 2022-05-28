using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLQuanLiSanPham
    {
        private static BLLQuanLiSanPham instance;
        public static BLLQuanLiSanPham Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLQuanLiSanPham();
                return instance;
            }
        }

        public List<ViewSanPham_QuanTriVien> SearchSanPham(string tuKhoa)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewSanPham_QuanTriVien> list = Model.Instance.SanPhams.Where(sp => sp.DaXoa == false && (sp.MaSanPham.ToLower().Contains(temp) || sp.LoaiSanPham.ToLower().Contains(temp) || sp.TenSanPham.ToLower().Contains(temp) || sp.TenHang.ToLower().Contains(temp)))
                .Select(sp => new ViewSanPham_QuanTriVien { MaSanPham = sp.MaSanPham, TenSanPham = sp.TenSanPham, TenHang = sp.TenHang, LoaiSanPham = sp.LoaiSanPham, GiaMua = sp.GiaMua, GiaBan = sp.GiaBan, SoLuongNhap = sp.SoLuongNhap, SoLuongHienTai = sp.SoLuongHienTai, ThoiGianBaoHanh = sp.ThoiGianBaoHanh })
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

        public List<ViewSanPham_QuanTriVien> SortSanPham(List<ViewSanPham_QuanTriVien> sanPhams, string kieuSapXep)
        {
            try { return sanPhams.OrderBy(sp => sp.GetType().GetProperty(kieuSapXep).GetValue(sp, null)).ToList(); }
            catch { return sanPhams; }
        }

        public List<ViewSanPham_QuanTriVien> GetSanPhams(string kieuSapXep, string tuKhoa)
        {
            return SortSanPham(SearchSanPham(tuKhoa), kieuSapXep);
        }

        public SanPham GetSanPham(string maSanPham)
        {
            return Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham);
        }

        public List<string> GetLoaiSanPhams()
        {
            return Model.Instance.SanPhams.Select(sp => sp.LoaiSanPham).Distinct().ToList();
        }

        public List<string> GetMaSanPhams()
        {
            return Model.Instance.SanPhams.Select(sp => sp.MaSanPham).ToList();
        }
        public void DeleteSanPham(string maSanPham)
        {
            Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham).DaXoa = true;
            Model.Instance.SaveChanges();
        }

        public void AddSanPham(string maSanPham, string tenSanPham, string tenHang, string loaiSanPham, double giaMua, double giaBan, int soLuongNhap, int soLuongHienTai, string thoiGianBaoHanh)
        {
            Model.Instance.SanPhams.Add(new SanPham { MaSanPham = maSanPham, TenSanPham = tenSanPham, TenHang = tenHang, LoaiSanPham = loaiSanPham, GiaMua = giaMua, GiaBan = giaBan, SoLuongNhap = soLuongNhap, SoLuongHienTai = soLuongHienTai, ThoiGianBaoHanh = thoiGianBaoHanh });
            Model.Instance.SaveChanges();
        }
        public void UpdateSanPham(string maSanPham, string tenSanPham, string tenHang, string loaiSanPham, double giaMua, double giaBan, int soLuongNhap, int soLuongHienTai, string thoiGianBaoHanh)
        {
            var sanpham = Model.Instance.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham);
            sanpham.MaSanPham = maSanPham;
            sanpham.TenSanPham = tenSanPham;
            sanpham.TenHang = tenHang;
            sanpham.LoaiSanPham = loaiSanPham;
            sanpham.GiaMua = giaMua;
            sanpham.GiaBan = giaBan;
            sanpham.SoLuongNhap = soLuongNhap;
            sanpham.SoLuongHienTai = soLuongHienTai;
            sanpham.ThoiGianBaoHanh = thoiGianBaoHanh;
            Model.Instance.SaveChanges();
        }

        public void InitializeNewSeri(int soLuongNhap, string maSanPham)
        {
            for (int i = Model.Instance.VatPhams.Count() + 1; i < soLuongNhap + Model.Instance.VatPhams.Count(); i++)
            {
                Model.Instance.VatPhams.Add(new VatPham { SoSeri = maSanPham + "-" + i.ToString().PadLeft(4, '0'), MaSanPham = maSanPham });
            }
            Model.Instance.SaveChanges();
        }
        public dynamic GetAllBaoHanh(int ordertype = 0, string search = "")
        {
            var result = Model.Instance.BaoHanhs.Select(p => new { p.SoSeri, p.VatPham.SanPham.TenSanPham, p.KhachHang.TenKhachHang, p.ThoiGianTaoPhieuBaoHanh, p.TrangThai, p.GhiChu })
                        .Where(p => p.TenSanPham.Contains(search) || p.TenKhachHang.Contains(search));
            switch (ordertype)
            {
                case 1:
                    return result.OrderBy(p => p.TenSanPham).ToList();
                case 2:
                    return result.OrderBy(p => p.TenKhachHang).ToList();
                case 3:
                    return result.OrderBy(p => p.ThoiGianTaoPhieuBaoHanh).ToList();
                case 4:
                    return result.OrderBy(p => p.TrangThai).ToList();
                default:
                    return result.OrderBy(p => p.SoSeri).ToList();
            }
        }
        public BaoHanh GetBaoHanhviaSerial(string serial)
        {
            return Model.Instance.BaoHanhs.FirstOrDefault(p => p.SoSeri == serial);
        }
        public VatPham GetVatPhamviSerial(string serial)
        {
            return Model.Instance.VatPhams.FirstOrDefault(p => p.SoSeri == serial);
        }
        public void AddBaoHanh(BaoHanh obj)
        {
            Model.Instance.BaoHanhs.Add(obj);
            Model.Instance.SaveChanges();
        }
        public void UpdateBaoHanh(BaoHanh obj)
        {
            BaoHanh target = Model.Instance.BaoHanhs.FirstOrDefault(p => p.SoSeri == obj.SoSeri);
            target.GhiChu = obj.GhiChu;
            target.TrangThai = obj.TrangThai;
            Model.Instance.SaveChanges();
        }
    }
}
