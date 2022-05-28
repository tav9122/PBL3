using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3
{
    internal class ViewKhachHang
    {
        [DisplayName("Mã khách hàng")]
        public string MaKhachHang { get; set; }

        [DisplayName("Tên khách hàng")]
        public string TenKhachHang { get; set; }

        [DisplayName("Địa chỉ")]
        public string DiaChi { get; set; }

        [DisplayName("Số điện thoại")]
        public string SoDienThoai { get; set; }
    }
}
