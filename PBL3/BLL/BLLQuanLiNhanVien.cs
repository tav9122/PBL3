using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLQuanLiNhanVien
    {
        private static BLLQuanLiNhanVien instance;
        public static BLLQuanLiNhanVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLQuanLiNhanVien();
                return instance;
            }
        }

        public List<ViewNhanVien> SearchNhanVien(string tuKhoa)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.ToLower().Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewNhanVien> list = Model.Instance.NhanViens.AsEnumerable().Where(nv => nv.DaXoa == false && nv.MaNhanVien != "QTV" && (nv.MaNhanVien.ToLower().Contains(temp) || nv.HoVaTen.ToLower().Contains(temp) || nv.SoDienThoai.ToLower().Contains(temp) || nv.DiaChi.ToLower().Contains(temp) || nv.NgaySinh.ToString("dd/MM/yyyy h:m tt").Contains(temp) || Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.MaNhanVien == nv.MaNhanVien).TenDangNhap.ToLower().Contains(temp)))
                .Select(nv => new ViewNhanVien { MaNhanVien = nv.MaNhanVien, HoVaTen = nv.HoVaTen, SoDienThoai = nv.SoDienThoai, DiaChi = nv.DiaChi, NgaySinh = Convert.ToDateTime(nv.NgaySinh.ToString("dd/MM/yyyy")), GioiTinh = nv.GioiTinh, TenDangNhap = Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.MaNhanVien == nv.MaNhanVien).TenDangNhap, MucLuong = nv.MucLuong, LichLamViecs = GetMaLichLamViecsOfNhanVien(nv.MaNhanVien) })
                .ToList();
            foreach (string s in cacTuKhoa)
            {
                if (s != temp)
                {
                    list = list.Where(nv => nv.MaNhanVien.ToLower().Contains(s) || nv.HoVaTen.ToLower().Contains(s) || nv.SoDienThoai.ToLower().Contains(s) || nv.DiaChi.ToLower().Contains(s) || nv.NgaySinh.ToString("dd/MM/yyyy h:m tt").Contains(s) || nv.TenDangNhap.Contains(s)).ToList();
                }
            }
            return list;
        }

        public List<ViewNhanVien> SortNhanVien(List<ViewNhanVien> nhanViens, string kieuSapXep)
        {
            try { return nhanViens.OrderBy(nv => nv.GetType().GetProperty(kieuSapXep).GetValue(nv, null)).ToList(); }
            catch { return nhanViens; }
        }

        public List<ViewNhanVien> GetNhanViens(string kieuSapXep, string tuKhoa)
        {
            return SortNhanVien(SearchNhanVien(tuKhoa), kieuSapXep);
        }

        public NhanVien GetNhanVien(string maNhanVien)
        {
            try { return Model.Instance.NhanViens.Where(nv => nv.MaNhanVien == maNhanVien).FirstOrDefault(); }
            catch { return null; }
        }

        public string GetMatKhauNhanVien(string maNhanVien)
        {
            return Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.MaNhanVien == maNhanVien).MatKhau;
        }

        public string GetTenDangNhapNhanVien(string maNhanVien)
        {
            return Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.MaNhanVien == maNhanVien).TenDangNhap;
        }

        public string GetTenNhanVien(string maNhanVien)
        {
            return Model.Instance.NhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien).HoVaTen;
        }

        public List<ViewLichLamViec> GetLichLamViecsOfNhanVien(string maNhanVien)
        {
            try
            {
                List<string> list = Model.Instance.NhanVienLichLamViecs.Where(nvllv => nvllv.MaNhanVien == maNhanVien).Select(nvllv => nvllv.MaLichLamViec).ToList();
                return Model.Instance.LichLamViecs.AsEnumerable().Where(llv => list.Contains(llv.MaLichLamViec)).Select(llv => new ViewLichLamViec { MaLichLamViec = llv.MaLichLamViec, ThoiGianBatDau = llv.ThoiGianBatDau, ThoiGianKetThuc = llv.ThoiGianKetThuc, NgayLamViec = llv.NgayLamViec, NhanViens = BLLQuanLiLichLamViec.Instance.GetMaNhanViensOfLichLamViec(llv.MaLichLamViec) }).ToList();
            }
            catch { return null; }
        }

        public string GetMaLichLamViecsOfNhanVien(string maNhanVien)
        {
            string result = "";
            foreach (string i in Model.Instance.NhanVienLichLamViecs.Where(nvllv => nvllv.MaNhanVien == maNhanVien).Select(nvllv => nvllv.MaLichLamViec).ToList())
            {
                result += i + ", ";
            }
            try { return result.Substring(0, result.Length - 2); }
            catch { return "-"; }
        }

        public void UpdateNhanVien(string maNhanVien, string soDienThoai, string diaChi, string hoVaTen, DateTime ngaySinh, bool gioiTinh, double mucLuong, List<string> maLichLamViecs)
        {
            var nhanVien = Model.Instance.NhanViens.FirstOrDefault(tk => tk.MaNhanVien == maNhanVien);
            nhanVien.SoDienThoai = soDienThoai;
            nhanVien.DiaChi = diaChi;
            nhanVien.HoVaTen = hoVaTen;
            nhanVien.NgaySinh = ngaySinh;
            nhanVien.GioiTinh = gioiTinh;
            if (mucLuong != -1)
                nhanVien.MucLuong = mucLuong;
            if (maLichLamViecs != null)
                SetLichLamViecOfNhanVien(maNhanVien, maLichLamViecs);
            Model.Instance.SaveChanges();
        }

        public void AddNhanVien(string maNhanVien, string soDienThoai, string diaChi, string hoVaTen, DateTime ngaySinh, bool gioiTinh, double mucLuong, List<string> maLichLamViecs, string tenTaiKhoan, string matKhau)
        {
            Model.Instance.NhanViens.Add(new NhanVien { MaNhanVien = maNhanVien, SoDienThoai = soDienThoai, DiaChi = diaChi, HoVaTen = hoVaTen, NgaySinh = ngaySinh, GioiTinh = gioiTinh, MucLuong = mucLuong });
            Model.Instance.TaiKhoans.Add(new TaiKhoan { MaNhanVien = maNhanVien, TenDangNhap = tenTaiKhoan, MatKhau = matKhau });
            if (maLichLamViecs != null)
                SetLichLamViecOfNhanVien(maNhanVien, maLichLamViecs);
            Model.Instance.SaveChanges();
        }
        public void UpdateMatKhauNhanVien(string tenDangNhap, string matKhau)
        {
            Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.TenDangNhap == tenDangNhap).MatKhau = matKhau;
            Model.Instance.SaveChanges();
        }

        public void DeleteNhanVien(string maNhanVien)
        {
            Model.Instance.NhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien).DaXoa = true;
            Model.Instance.NhanVienLichLamViecs.RemoveRange(Model.Instance.NhanVienLichLamViecs.Where(nvllv => nvllv.MaNhanVien == maNhanVien));
            Model.Instance.TaiKhoans.Remove(Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.MaNhanVien == maNhanVien));
            Model.Instance.SaveChanges();
        }

        public List<string> GetMaNhanViens()
        {
            if (Model.Instance.NhanViens.Select(x => x.MaNhanVien).ToList() == null)
                return new List<string> { "NV0" };
            else
                return Model.Instance.NhanViens.Select(x => x.MaNhanVien).ToList();
        }

        public void SetLichLamViecOfNhanVien(string maNhanVien, List<string> maLichLamViecs)
        {
            Model.Instance.NhanVienLichLamViecs.RemoveRange(Model.Instance.NhanVienLichLamViecs.Where(nvllv => nvllv.MaNhanVien == maNhanVien));
            foreach (string i in maLichLamViecs)
            {
                Model.Instance.NhanVienLichLamViecs.Add(new NhanVienLichLamViec { MaNhanVien = maNhanVien, MaLichLamViec = i });
            }
            Model.Instance.SaveChanges();
        }
    }
}
