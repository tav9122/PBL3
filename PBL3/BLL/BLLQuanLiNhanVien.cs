using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public NhanVien GetNhanVien(string maNhanVien)
        {
            return Model.Instance.NhanViens.Where(nv => nv.MaNhanVien == maNhanVien).FirstOrDefault();
        }
        
        public string GetMatKhau(string maNhanVien)
        {
            return Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.MaNhanVien == maNhanVien).MatKhau;
        }

        public string GetTenDangNhap(string maNhanVien)
        {
            return Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.MaNhanVien == maNhanVien).TenDangNhap;
        }

        public string GetTen(string maNhanVien)
        {
            return Model.Instance.NhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien).HoVaTen;
        }

        public List<ViewLichLamViec_NhanVien> GetLichLamViec(string maNhanVien)
        {
            List<string> list = Model.Instance.NhanVienLichLamViecs.Where(nvllv => nvllv.MaNhanVien == maNhanVien).Select(nvllv => nvllv.MaLichLamViec).ToList();
            return Model.Instance.LichLamViecs.Where(llv => list.Contains(llv.MaLichLamViec)).Select(llv => new ViewLichLamViec_NhanVien { MaLichLamViec = llv.MaLichLamViec, ThoiGianBatDau = llv.ThoiGianBatDau, ThoiGianKetThuc = llv.ThoiGianKetThuc, NgayLamViec = llv.NgayLamViec }).ToList();
        }

        public void Update(string maNhanVien, string matKhau, string soDienThoai, string diaChi)
        {
            var nhanVien = Model.Instance.NhanViens.FirstOrDefault(tk => tk.MaNhanVien == maNhanVien);
            nhanVien.SoDienThoai = soDienThoai;
            nhanVien.DiaChi = diaChi;
            Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.MaNhanVien == maNhanVien).MatKhau = matKhau;
            Model.Instance.SaveChanges();
        }
    }
}
