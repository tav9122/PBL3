using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLQuanLiLichLamViec
    {
        private static BLLQuanLiLichLamViec instance;
        public static BLLQuanLiLichLamViec Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLQuanLiLichLamViec();
                return instance;
            }
        }

        public List<ViewLichLamViec> SearchLichLamViec(string tuKhoa)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.ToLower().Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewLichLamViec> list = Model.Instance.LichLamViecs.AsEnumerable().Where(llv => llv.MaLichLamViec.ToLower().Contains(temp) || llv.ThoiGianBatDau.ToLower().Contains(temp) || llv.ThoiGianKetThuc.ToLower().Contains(temp) || llv.NgayLamViec.ToLower().Contains(temp))
                .Select(llv => new ViewLichLamViec { MaLichLamViec = llv.MaLichLamViec, ThoiGianKetThuc = llv.ThoiGianKetThuc, NgayLamViec = llv.NgayLamViec, ThoiGianBatDau = llv.ThoiGianBatDau, NhanViens = GetMaNhanViensOfLichLamViec(llv.MaLichLamViec) })
                .ToList();
            foreach (string s in cacTuKhoa)
            {
                if (s != temp)
                {
                    list = list.Where(llv => llv.MaLichLamViec.ToLower().Contains(s) || llv.ThoiGianBatDau.ToLower().Contains(s) || llv.ThoiGianKetThuc.ToLower().Contains(s) || llv.NgayLamViec.ToLower().Contains(s)).ToList();
                }
            }
            return list;
        }

        public List<ViewLichLamViec> SortLichLamViec(List<ViewLichLamViec> lichLamViecs, string kieuSapXep)
        {
            try { return lichLamViecs.OrderBy(llv => llv.GetType().GetProperty(kieuSapXep).GetValue(llv, null)).ToList(); }
            catch { return lichLamViecs; }
        }

        public List<ViewLichLamViec> GetLichLamViecs(string kieuSapXep, string tuKhoa)
        {
            return SortLichLamViec(SearchLichLamViec(tuKhoa), kieuSapXep);
        }

        public LichLamViec GetLichLamViec(string maLichLamViec)
        {
            return Model.Instance.LichLamViecs.Where(llv => llv.MaLichLamViec == maLichLamViec).FirstOrDefault();
        }

        public void SetNhanVienOfLichlamViec(string maLichLamViec, List<string> maNhanViens)
        {
            Model.Instance.NhanVienLichLamViecs.RemoveRange(Model.Instance.NhanVienLichLamViecs.Where(nvllv => nvllv.MaLichLamViec == maLichLamViec));
            foreach (string i in maNhanViens)
            {
                Model.Instance.NhanVienLichLamViecs.Add(new NhanVienLichLamViec { MaLichLamViec = maLichLamViec, MaNhanVien = i });
            }
            Model.Instance.SaveChanges();
        }

        public void AddLichLamViec(string maLichLamViec, string thoiGianBatDau, string thoiGianKetThuc, string ngayLamViec, List<string> maNhanViens)
        {
            Model.Instance.LichLamViecs.Add(new LichLamViec { MaLichLamViec = maLichLamViec, ThoiGianBatDau = thoiGianBatDau, ThoiGianKetThuc = thoiGianKetThuc, NgayLamViec = ngayLamViec });
            SetNhanVienOfLichlamViec(maLichLamViec, maNhanViens);
            Model.Instance.SaveChanges();
        }

        public void UpdateLichLamViec(string maLichLamViec, string thoiGianBatDau, string thoiGianKetThuc, string ngayLamViec, List<string> maNhanViens)
        {
            var lichLamViec = Model.Instance.LichLamViecs.FirstOrDefault(llv => llv.MaLichLamViec == maLichLamViec);
            lichLamViec.ThoiGianBatDau = thoiGianBatDau;
            lichLamViec.ThoiGianKetThuc = thoiGianKetThuc;
            lichLamViec.NgayLamViec = ngayLamViec;
            SetNhanVienOfLichlamViec(maLichLamViec, maNhanViens);
            Model.Instance.SaveChanges();
        }

        public void DeleteLichLamViec(string maLichLamViec)
        {
            Model.Instance.NhanVienLichLamViecs.RemoveRange(Model.Instance.NhanVienLichLamViecs.Where(nvllv => nvllv.MaLichLamViec == maLichLamViec));
            Model.Instance.LichLamViecs.Remove(GetLichLamViec(maLichLamViec));
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
            catch { return "-"; }
        }

        public List<string> GetMaLichLamViecs()
        {
            if (Model.Instance.LichLamViecs.Select(x => x.MaLichLamViec).ToList() == null)
                return new List<string> { "LLV0" };
            else
                return Model.Instance.LichLamViecs.Select(x => x.MaLichLamViec).ToList();
        }

        public List<ViewNhanVien> GetNhanViensOfLichLamViec(string maLichLamViec)
        {
            try
            {
                List<string> list = Model.Instance.NhanVienLichLamViecs.Where(nvllv => nvllv.MaLichLamViec == maLichLamViec).Select(nvllv => nvllv.MaNhanVien).ToList();
                return Model.Instance.NhanViens.AsEnumerable().Where(llv => list.Contains(llv.MaNhanVien)).Select(nv => new ViewNhanVien { MaNhanVien = nv.MaNhanVien, HoVaTen = nv.HoVaTen, SoDienThoai = nv.SoDienThoai, DiaChi = nv.DiaChi, NgaySinh = Convert.ToDateTime(nv.NgaySinh.ToString("dd/MM/yyyy")), GioiTinh = nv.GioiTinh, TenDangNhap = Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.MaNhanVien == nv.MaNhanVien).TenDangNhap, MucLuong = nv.MucLuong, LichLamViecs = BLLQuanLiNhanVien.Instance.GetMaLichLamViecsOfNhanVien(nv.MaNhanVien) }).ToList();
            }
            catch { return null; }
        }
    }
}
