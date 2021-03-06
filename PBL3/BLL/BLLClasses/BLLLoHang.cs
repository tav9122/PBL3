using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLLoHang
    {
        private static BLLLoHang instance;
        public static BLLLoHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLLoHang();
                return instance;
            }
        }

        public void AddLoHang(string maLoHang, DateTime thoiGianNhapHang, double tongTien)
        {
            Model.Instance.LoHangs.Add(new LoHang { MaLoHang = maLoHang, ThoiGianNhapHang = thoiGianNhapHang, TongTien = tongTien });
            Model.Instance.SaveChanges();
        }

        public LoHang GetLoHang(string maLoHang)
        {
            return Model.Instance.LoHangs.Where(llv => llv.MaLoHang == maLoHang).FirstOrDefault();
        }

        public List<string> GetMaLoHangs()
        {
            var x = Model.Instance.LoHangs.Select(lh => lh.MaLoHang).ToList();
            if (!x.Any())
                return new List<string> { "LH0" };
            else
                return x;
        }
    }
}
