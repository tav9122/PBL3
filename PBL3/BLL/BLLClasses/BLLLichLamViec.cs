using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLLichLamViec
    {
        private static BLLLichLamViec instance;
        public static BLLLichLamViec Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLLichLamViec();
                return instance;
            }
        }

        public void AddLichLamViec(string maLichLamViec, string thoiGianBatDau, string thoiGianKetThuc, string ngayLamViec, List<string> maNhanViens)
        {
            Model.Instance.LichLamViecs.Add(new LichLamViec { MaLichLamViec = maLichLamViec, ThoiGianBatDau = thoiGianBatDau, ThoiGianKetThuc = thoiGianKetThuc, NgayLamViec = ngayLamViec });
            BLLNhanVienLichLamViec.Instance.SetNhanViensOfLichlamViec(maLichLamViec, maNhanViens);
            Model.Instance.SaveChanges();
        }

        public void UpdateLichLamViec(string maLichLamViec, string thoiGianBatDau, string thoiGianKetThuc, string ngayLamViec, List<string> maNhanViens)
        {
            var lichLamViec = Model.Instance.LichLamViecs.FirstOrDefault(llv => llv.MaLichLamViec == maLichLamViec);
            lichLamViec.ThoiGianBatDau = thoiGianBatDau;
            lichLamViec.ThoiGianKetThuc = thoiGianKetThuc;
            lichLamViec.NgayLamViec = ngayLamViec;
            BLLNhanVienLichLamViec.Instance.SetNhanViensOfLichlamViec(maLichLamViec, maNhanViens);
            Model.Instance.SaveChanges();
        }

        public void DeleteLichLamViec(string maLichLamViec)
        {
            Model.Instance.NhanVienLichLamViecs.RemoveRange(Model.Instance.NhanVienLichLamViecs.Where(nvllv => nvllv.MaLichLamViec == maLichLamViec));
            Model.Instance.LichLamViecs.Remove(GetLichLamViec(maLichLamViec));
            Model.Instance.SaveChanges();
        }

        public LichLamViec GetLichLamViec(string maLichLamViec)
        {
            return Model.Instance.LichLamViecs.Where(llv => llv.MaLichLamViec == maLichLamViec).FirstOrDefault();
        }

        public List<string> GetMaLichLamViecs()
        {
            var x = Model.Instance.LichLamViecs.Select(llv => llv.MaLichLamViec).ToList();
            if (!x.Any())
                return new List<string> { "LLV0" };
            else
                return x;
        }
    }
}
