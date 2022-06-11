using System;
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

        public void DeleteBaoHanh(string soSeri)
        {
            Model.Instance.BaoHanhs.Where(bh => bh.SoSeri == soSeri).FirstOrDefault().DaXoa = true;
            Model.Instance.SaveChanges();
        }

        public BaoHanh GetBaoHanh(string soSeri)
        {
            return Model.Instance.BaoHanhs.Where(bh => bh.SoSeri == soSeri).FirstOrDefault();
        }
    }
}
