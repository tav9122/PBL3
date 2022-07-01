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
            List<string> list = Model.Instance.NhanVienLichLamViecs.Where(nvllv => nvllv.MaLichLamViec == maLichLamViec).Select(nvllv => nvllv.MaNhanVien).ToList();
            return Model.Instance.NhanViens.AsEnumerable().Where(llv => list.Contains(llv.MaNhanVien)).Select(nv => new ViewNhanVien { MaNhanVien = nv.MaNhanVien, HoVaTen = nv.HoVaTen, SoDienThoai = nv.SoDienThoai, Email = nv.Email, DiaChi = nv.DiaChi, GioiTinh = nv.GioiTinh, LichLamViecs = BLLNhanVienLichLamViec.Instance.GetMaLichLamViecsOfNhanVien(nv.MaNhanVien) }).ToList();
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
            foreach (string i in Model.Instance.NhanVienLichLamViecs.AsEnumerable().Where(nvllv => nvllv.MaLichLamViec == maLichLamViecs).OrderBy(nvllv => Convert.ToInt32(nvllv.MaNhanVien.Substring(2))).Select(nvllv => nvllv.MaNhanVien).ToList())
            {
                result += i + ", ";
            }
            if (result.Length >= 2)
                result = result.Substring(0, result.Length - 2);
            else result = "";
            return result;
        }

        public List<ViewLichLamViec> GetLichLamViecsOfNhanVien(string maNhanVien)
        {
            List<string> list = Model.Instance.NhanVienLichLamViecs.Where(nvllv => nvllv.MaNhanVien == maNhanVien).Select(nvllv => nvllv.MaLichLamViec).ToList();
            return Model.Instance.LichLamViecs.AsEnumerable().Where(llv => list.Contains(llv.MaLichLamViec)).Select(llv => new ViewLichLamViec { MaLichLamViec = llv.MaLichLamViec, ThoiGianBatDau = llv.ThoiGianBatDau, ThoiGianKetThuc = llv.ThoiGianKetThuc, NgayLamViec = llv.NgayLamViec, NhanViens = BLLNhanVienLichLamViec.Instance.GetMaNhanViensOfLichLamViec(llv.MaLichLamViec) }).ToList();
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
            foreach (string i in Model.Instance.NhanVienLichLamViecs.AsEnumerable().Where(nvllv => nvllv.MaNhanVien == maNhanVien).OrderBy(nvllv => Convert.ToInt32(nvllv.MaLichLamViec.Substring(3))).Select(nvllv => nvllv.MaLichLamViec).ToList())
            {
                result += i + ", ";
            }
            if (result.Length >= 2)
                result = result.Substring(0, result.Length - 2);
            else result = "";
            return result;
        }
    }
}
