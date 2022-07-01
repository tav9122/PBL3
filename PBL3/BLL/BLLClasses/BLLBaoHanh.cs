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

        public void AddBaoHanh(string maBaoHanh, string soSeri, bool trangThai, string ghiChu, DateTime thoiGianTaoPhieuBaoHanh)
        {
            Model.Instance.BaoHanhs.Add(new BaoHanh { MaBaoHanh = maBaoHanh, SoSeri = soSeri, TrangThai = trangThai, GhiChu = ghiChu, ThoiGianTaoPhieuBaoHanh = thoiGianTaoPhieuBaoHanh });
            Model.Instance.SaveChanges();
        }

        public void UpdateBaoHanh(string maBaoHanh, bool trangThai, string ghiChu)
        {
            var x = Model.Instance.BaoHanhs.FirstOrDefault(bh => bh.MaBaoHanh == maBaoHanh);
            x.TrangThai = trangThai;
            x.GhiChu = ghiChu;
            Model.Instance.SaveChanges();
        }

        public BaoHanh GetBaoHanh(string maBaoHanh)
        {
            return Model.Instance.BaoHanhs.FirstOrDefault(bh => bh.MaBaoHanh == maBaoHanh);
        }

        public List<string> GetMaBaoHanhs()
        {
            var x = Model.Instance.BaoHanhs.Select(bh => bh.MaBaoHanh).ToList();
            if (!x.Any())
                return new List<string> { "BH0" };
            else
                return x;
        }
    }
}
