using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLButtonQuanLiLichLamViec
    {
        private static BLLButtonQuanLiLichLamViec instance;
        public static BLLButtonQuanLiLichLamViec Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLButtonQuanLiLichLamViec();
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
                .Select(llv => new ViewLichLamViec { MaLichLamViec = llv.MaLichLamViec, ThoiGianKetThuc = llv.ThoiGianKetThuc, NgayLamViec = llv.NgayLamViec, ThoiGianBatDau = llv.ThoiGianBatDau, NhanViens = BLLNhanVienLichLamViec.Instance.GetMaNhanViensOfLichLamViec(llv.MaLichLamViec) })
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
            if (kieuSapXep == "MaLichLamViec")
                return lichLamViecs.OrderBy(llv => Convert.ToInt32(llv.MaLichLamViec.Substring(3))).ToList();
            return lichLamViecs.OrderBy(llv => llv.GetType().GetProperty(kieuSapXep).GetValue(llv, null)).ToList();
        }

        public List<ViewLichLamViec> GetLichLamViecs(string kieuSapXep, string tuKhoa)
        {
            return SortLichLamViec(SearchLichLamViec(tuKhoa), kieuSapXep);
        }
    }
}
