using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormChiTietHoacThemBaoHanh : Form
    {
        public string serial;
        public FormChiTietHoacThemBaoHanh(string serial)
        {
            InitializeComponent();
            this.serial = serial;
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
                textBoxTenSanPham.Text = "Tồn tại sản phẩm...";

            }
        }
        private void textBoxMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            KhachHang obj = BLLQuanLiChung.Instance.GetKhachHangviaID(
                textBoxMaKhachHang.Text);
            if (obj == null) 
            {
                textBoxTenKhachHang.Text = "Không tồn tại khách hàng";
                textBoxTenKhachHang.ForeColor = Color.FromArgb(200, 200, 200);
                textBoxSoDienThoai.Text = "";
                textBoxDiaChi.Text = "";
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
