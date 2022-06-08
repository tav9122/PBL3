using System;
using System.ComponentModel;

namespace PBL3
{
    internal class ViewLoHang
    {
        [DisplayName("Mã lô hàng")]
        public string MaLoHang { get; set; }

        [DisplayName("Thời gian nhập hàng")]
        public DateTime ThoiGianNhapHang { get; set; }

        [DisplayName("Tổng tiền")]
        public double TongTien { get; set; }
    }
}
