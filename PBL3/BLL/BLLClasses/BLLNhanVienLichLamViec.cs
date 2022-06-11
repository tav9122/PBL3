using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLNhanVienLichLamViec
    {
        private static BLLNhanVienLichLamViec instance;
        public static BLLNhanVienLichLamViec Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLNhanVienLichLamViec();
                return instance;
            }
        }

        public List<ViewNhanVien> GetNhanViensOfLichLamViec(string maLichLamViec)
        {
            try
            {
                List<string> list = Model.Instance.NhanVienLichLamViecs.Where(nvllv => nvllv.MaLichLamViec == maLichLamViec).Select(nvllv => nvllv.MaNhanVien).ToList();
                return Model.Instance.NhanViens.AsEnumerable().Where(llv => list.Contains(llv.MaNhanVien)).Select(nv => new ViewNhanVien { MaNhanVien = nv.MaNhanVien, HoVaTen = nv.HoVaTen, SoDienThoai = nv.SoDienThoai, DiaChi = nv.DiaChi, NgaySinh = Convert.ToDateTime(nv.NgaySinh.ToString("dd/MM/yyyy")), GioiTinh = nv.GioiTinh, TenDangNhap = Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.MaNhanVien == nv.MaNhanVien).TenDangNhap, MucLuong = nv.MucLuong, LichLamViecs = BLLNhanVienLichLamViec.Instance.GetMaLichLamViecsOfNhanVien(nv.MaNhanVien) }).ToList();
            }
            catch { return null; }
        }

        public void SetNhanViensOfLichlamViec(string maLichLamViec, List<string> maNhanViens)
        {
            Model.Instance.NhanVienLichLamViecs.RemoveRange(Model.Instance.NhanVienLichLamViecs.Where(nvllv => nvllv.MaLichLamViec == maLichLamViec));
            foreach (string i in maNhanViens)
            {
                Model.Instance.NhanVienLichLamViecs.Add(new NhanVienLichLamViec { MaLichLamViec = maLichLamViec, MaNhanVien = i });
            }
            Model.Instance.SaveChanges();
        }

        public string GetMaNhanViensOfLichLamViec(string maLichLamViecs)
        {
            string result = "";
            foreach (string i in Model.Instance.NhanVienLichLamViecs.Where(nvllv => nvllv.MaLichLamViec == maLichLamViecs).Select(nvllv => nvllv.MaNhanVien).ToList())
            {
                result += i + ", ";
            }
            try { return result.Substring(0, result.Length - 2); }
            catch { return ""; }
        }

        public List<ViewLichLamViec> GetLichLamViecsOfNhanVien(string maNhanVien)
        {
            try
            {
                List<string> list = Model.Instance.NhanVienLichLamViecs.Where(nvllv => nvllv.MaNhanVien == maNhanVien).Select(nvllv => nvllv.MaLichLamViec).ToList();
                return Model.Instance.LichLamViecs.AsEnumerable().Where(llv => list.Contains(llv.MaLichLamViec)).Select(llv => new ViewLichLamViec { MaLichLamViec = llv.MaLichLamViec, ThoiGianBatDau = llv.ThoiGianBatDau, ThoiGianKetThuc = llv.ThoiGianKetThuc, NgayLamViec = llv.NgayLamViec, NhanViens = BLLNhanVienLichLamViec.Instance.GetMaNhanViensOfLichLamViec(llv.MaLichLamViec) }).ToList();
            }
            catch { return null; }
        }

        public void SetLichLamViecsOfNhanVien(string maNhanVien, List<string> maLichLamViecs)
        {
            Model.Instance.NhanVienLichLamViecs.RemoveRange(Model.Instance.NhanVienLichLamViecs.Where(nvllv => nvllv.MaNhanVien == maNhanVien));
            foreach (string i in maLichLamViecs)
            {
                Model.Instance.NhanVienLichLamViecs.Add(new NhanVienLichLamViec { MaNhanVien = maNhanVien, MaLichLamViec = i });
            }
            Model.Instance.SaveChanges();
        }

        public string GetMaLichLamViecsOfNhanVien(string maNhanVien)
        {
            string result = "";
            foreach (string i in Model.Instance.NhanVienLichLamViecs.Where(nvllv => nvllv.MaNhanVien == maNhanVien).Select(nvllv => nvllv.MaLichLamViec).ToList())
            {
                result += i + ", ";
            }
            try { return result.Substring(0, result.Length - 2); }
            catch { return ""; }
        }
    }
}
