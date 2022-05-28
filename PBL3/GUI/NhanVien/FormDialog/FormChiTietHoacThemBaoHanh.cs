using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormChiTietHoacThemBaoHanh : Form
    {
        public delegate void BaoHanhDel(int ordertype, string search);
        public BaoHanhDel Del { get; set; }
        public string serial;
        public int ordertype;
        public FormChiTietHoacThemBaoHanh(string serial, int ordertype)
        {
            InitializeComponent();
            this.serial = serial;
            this.ordertype = ordertype;
            GUI();
        }

        public void GUI()
        {
            textBoxTenKhachHang.Enabled = false;
            textBoxSoDienThoai.Enabled = false;
            textBoxDiaChi.Enabled = false;
            textBoxTenSanPham.Enabled = false;
            if (serial != "")
            {
                BaoHanh obj = BLLQuanLiSanPham.Instance.GetBaoHanhviaSerial(serial);
                textBoxSoSeriVatPham.Text = obj.SoSeri.ToString();
                textBoxTenSanPham.Text = obj.VatPham.SanPham.TenSanPham;
                textBoxSoSeriVatPham.Enabled = false;
                dateTimePickerThoiGianGiaoTaoPhieuBaoHanh.Value = obj.ThoiGianTaoPhieuBaoHanh;
                textBoxThongTinBaoHanh.Text = obj.GhiChu;
                if (obj.TrangThai) radioButtonHoanThanh.Checked = true;
                else radioButtonChuaHoanThanh.Checked = true;
                textBoxMaKhachHang.Text = obj.MaKhachHang;
                textBoxMaKhachHang.Enabled = false;
                textBoxTenKhachHang.Text = obj.KhachHang.TenKhachHang;
                textBoxSoDienThoai.Text = obj.KhachHang.SoDienThoai;
                textBoxDiaChi.Text = obj.KhachHang.DiaChi;
                
            }
        }
        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            BaoHanh obj = new BaoHanh
            {
                SoSeri = textBoxSoSeriVatPham.Text,
                ThoiGianTaoPhieuBaoHanh = dateTimePickerThoiGianGiaoTaoPhieuBaoHanh.Value,
                GhiChu = textBoxThongTinBaoHanh.Text,
                TrangThai = radioButtonHoanThanh.Checked,
                MaKhachHang = textBoxMaKhachHang.Text
            };
            if (serial == "") BLLQuanLiSanPham.Instance.AddBaoHanh(obj);
            else BLLQuanLiSanPham.Instance.UpdateBaoHanh(obj);
            Del(ordertype, "");
            this.Close();

        }
        private void buttonHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBoxSoSeriVatPham_TextChanged(object sender, EventArgs e)
        {
            VatPham obj = BLLQuanLiSanPham.Instance.GetVatPhamviSerial(textBoxSoSeriVatPham.Text);
            if(obj==null)
            {
                textBoxTenSanPham.Text = "Không tồn tại sản phẩm...";                
            }
            else
            {
                textBoxTenSanPham.Text = obj.SanPham.TenSanPham;
            }
        }
        private void textBoxMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            KhachHang obj = BLLQuanLiChung.Instance.GetKhachHangviaID(
                textBoxMaKhachHang.Text);
            if (obj == null) 
            {
                textBoxTenKhachHang.Text = "Không tồn tại khách hàng";
                textBoxSoDienThoai.Text = "";
                textBoxDiaChi.Text = "";
            }
            else
            {
                textBoxTenKhachHang.Text = obj.TenKhachHang;
                textBoxSoDienThoai.Text = obj.SoDienThoai;
                textBoxDiaChi.Text = obj.DiaChi;
            }
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
