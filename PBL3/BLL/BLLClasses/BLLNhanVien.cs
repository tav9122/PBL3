using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLNhanVien
    {
        private static BLLNhanVien instance;
        public static BLLNhanVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLNhanVien();
                return instance;
            }
        }

        public void AddNhanVien(string maNhanVien, string soDienThoai, string email, string diaChi, string hoVaTen, DateTime ngaySinh, bool gioiTinh, double mucLuong, List<string> maLichLamViecs, string tenDangNhap, string matKhau)
        {
            Model.Instance.NhanViens.Add(new NhanVien { MaNhanVien = maNhanVien, SoDienThoai = soDienThoai, Email = email, DiaChi = diaChi, HoVaTen = hoVaTen, NgaySinh = ngaySinh, GioiTinh = gioiTinh, MucLuong = mucLuong });
            Model.Instance.TaiKhoans.Add(new TaiKhoan { MaTaiKhoan = BLLQuanLiChung.Instance.GetNextPrimaryKey(BLLTaiKhoan.Instance.GetMaTaiKhoans()), MaNhanVien = maNhanVien, TenDangNhap = tenDangNhap, MatKhau = matKhau });
            if (maLichLamViecs != null)
                BLLNhanVienLichLamViec.Instance.SetLichLamViecsOfNhanVien(maNhanVien, maLichLamViecs);
            Model.Instance.SaveChanges();
        }

        public void UpdateNhanVien(string maNhanVien, string soDienThoai, string email, string diaChi, string hoVaTen, DateTime ngaySinh, bool gioiTinh, double mucLuong, List<string> maLichLamViecs)
        {
            var nhanVien = Model.Instance.NhanViens.FirstOrDefault(tk => tk.MaNhanVien == maNhanVien);
            nhanVien.SoDienThoai = soDienThoai;
            nhanVien.Email = email;
            nhanVien.DiaChi = diaChi;
            nhanVien.HoVaTen = hoVaTen;
            nhanVien.NgaySinh = ngaySinh;
            nhanVien.GioiTinh = gioiTinh;
            if (mucLuong != -1)
                nhanVien.MucLuong = mucLuong;
            if (maLichLamViecs != null)
                BLLNhanVienLichLamViec.Instance.SetLichLamViecsOfNhanVien(maNhanVien, maLichLamViecs);
            Model.Instance.SaveChanges();
        }

        public void DeleteNhanVien(string maNhanVien)
        {
            Model.Instance.NhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien).DaXoa = true;
            Model.Instance.NhanVienLichLamViecs.RemoveRange(Model.Instance.NhanVienLichLamViecs.Where(nvllv => nvllv.MaNhanVien == maNhanVien));
            Model.Instance.TaiKhoans.Remove(Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.MaNhanVien == maNhanVien));
            Model.Instance.SaveChanges();
        }

        public NhanVien GetNhanVien(string text)
        {
            try
            {
                if (text.Contains("@"))
                    return Model.Instance.NhanViens.Where(nv => nv.Email == text).FirstOrDefault();
                else
                    return Model.Instance.NhanViens.Where(nv => nv.MaNhanVien == text).FirstOrDefault();
            }
            catch { return null; }
        }

        public List<string> GetMaNhanViens()
        {
            if (Model.Instance.NhanViens.Select(x => x.MaNhanVien).ToList() == null)
                return new List<string> { "NV0" };
            else
                return Model.Instance.NhanViens.Select(x => x.MaNhanVien).ToList();
        }
    }
}
