using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    public class BLLButtonThongKeTheoBieuDo
    {
        private static BLLButtonThongKeTheoBieuDo instance;
        public static BLLButtonThongKeTheoBieuDo Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLButtonThongKeTheoBieuDo();
                return instance;
            }
        }

        public List<string> SplitToMonths(DateTime date1, DateTime date2)
        {
            List<string> list = new List<string>();
            for (DateTime i = date1; i <= date2; i = i.AddMonths(1))
            {
                list.Add(i.ToString("MM/yyyy"));
            }
            return list;
        }

        public double GetDoanhThuOfMonth(string month)
        {
            return Model.Instance.VatPhams.AsEnumerable().Where(vp => vp.HoaDon != null && vp.HoaDon.ThoiGianGiaoDich.ToString("MM/yyyy") == month).Sum(vp => vp.GiaBan);
        }

        public List<string> SplitToYears(DateTime date1, DateTime date2)
        {
            List<string> list = new List<string>();
            for (DateTime i = date1; i <= date2; i = i.AddYears(1))
            {
                list.Add(i.ToString("yyyy"));
            }
            return list;
        }

        public double GetDoanhThuOfYear(string year)
        {
            return Model.Instance.VatPhams.AsEnumerable().Where(vp => vp.HoaDon != null && vp.HoaDon.ThoiGianGiaoDich.ToString("yyyy") == year).Sum(vp => vp.GiaBan);
        }

        public Dictionary<string, int> GetSanPhamBanChayNhat(DateTime date1, DateTime date2)
        {
            Dictionary<string, int> list = new Dictionary<string, int>();
            foreach (var vp in Model.Instance.VatPhams.AsEnumerable().Where(vp => vp.HoaDon != null && vp.HoaDon.ThoiGianGiaoDich >= date1 && vp.HoaDon.ThoiGianGiaoDich <= date2))
            {
                if (list.ContainsKey(vp.SanPham.TenSanPham))
                {
                    list[vp.SanPham.TenSanPham]++;
                }
                else
                {
                    list.Add(vp.SanPham.TenSanPham, 1);
                }
            }
            return list.OrderByDescending(x => x.Value).Take(10).ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
