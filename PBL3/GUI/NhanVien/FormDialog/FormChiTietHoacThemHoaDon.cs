using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormChiTietHoacThemHoaDon : Form
    {
        public FormChiTietHoacThemHoaDon(string ma)
        {
            InitializeComponent();

            if (BLLQuanLiNhanVien.Instance.GetNhanVien(ma) != null)
            {
                InitializeNewHoaDonInformation(ma);
            }
            else InitializeHoaDonInformation(ma);
            dataGridView1.Columns["GiaBan"].DefaultCellStyle.Format = "C0";
            dataGridView1.Columns["TenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        #region Các hàm chức năng cơ bản, hạn chế sửa

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
        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        #endregion

        private void textBoxSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (BLLQuanLiKhachHang.Instance.GetKhachHang(textBoxSoDienThoai.Text) != null)
            {
                textBoxTenKhachHang.Enabled = false;
                textBoxDiaChi.Enabled = false;
                textBoxTenKhachHang.Text = BLLQuanLiKhachHang.Instance.GetKhachHang(textBoxSoDienThoai.Text).TenKhachHang;
                textBoxDiaChi.Text = BLLQuanLiKhachHang.Instance.GetKhachHang(textBoxSoDienThoai.Text).DiaChi;
                textBoxMaKhachHang.Text = BLLQuanLiKhachHang.Instance.GetKhachHang(textBoxSoDienThoai.Text).MaKhachHang;
            }
            else
            {
                textBoxTenKhachHang.Enabled = true;
                textBoxDiaChi.Enabled = true;
                textBoxTenKhachHang.Text = "";
                textBoxDiaChi.Text = "";
                textBoxMaKhachHang.Text = BLLQuanLiChung.Instance.GetNextPrimaryKey(BLLQuanLiKhachHang.Instance.GetMaKhachHangs());
            }
        }

        public void InitializeNewHoaDonInformation(string maNhanVien)
        {
            labelTieuDe.Text = "Thêm hóa đơn";
            textBoxMaHoaDon.Text = BLLQuanLiChung.Instance.GetNextPrimaryKey(BLLLichSuHoaDon.Instance.GetMaHoaDons());
            textBoxMaNhanVien.Text = maNhanVien;
            dateTimePickerThoiGianGiaoDich.Value = DateTime.Now;
            textBoxThanhTien.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C0}", BLLLichSuHoaDon.Instance.GetTongSoTien());
            textBoxMaKhachHang.Text = BLLQuanLiChung.Instance.GetNextPrimaryKey(BLLQuanLiKhachHang.Instance.GetMaKhachHangs());
            dataGridView1.DataSource = BLLSanPham.Instance.GetTuiHang();
        }

        public void InitializeHoaDonInformation(string maHoaDon)
        {
            labelTieuDe.Text = "Chi tiết hoá đơn:";
            var hoaDon = BLLLichSuHoaDon.Instance.GetHoaDon(maHoaDon);
            textBoxMaHoaDon.Text = hoaDon.MaHoaDon;
            textBoxMaKhachHang.Text = hoaDon.MaKhachHang;
            textBoxMaNhanVien.Text = hoaDon.MaNhanVien;
            dateTimePickerThoiGianGiaoDich.Value = hoaDon.ThoiGianGiaoDich;
            textBoxThanhTien.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C0}", hoaDon.ThanhTien);
            textBoxSoDienThoai.Text = hoaDon.KhachHang.SoDienThoai;
            textBoxDiaChi.Text = hoaDon.KhachHang.DiaChi;
            textBoxTenKhachHang.Text = hoaDon.KhachHang.TenKhachHang;
            dataGridView1.DataSource = BLLLichSuHoaDon.Instance.GetVatPhamsByMaHoaDon(hoaDon.MaHoaDon);
            textBoxTenKhachHang.Enabled = false;
            textBoxDiaChi.Enabled = false;
            textBoxSoDienThoai.Enabled = false;
            buttonXacNhan.Visible = false;
        }

        private void buttonHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            if (textBoxDiaChi.Text == "" || textBoxMaKhachHang.Text == "" || textBoxSoDienThoai.Text == "" || textBoxTenKhachHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng");
                return;
            }
            else
            {
                if (BLLQuanLiKhachHang.Instance.GetKhachHang(textBoxSoDienThoai.Text) == null)
                {
                    BLLQuanLiKhachHang.Instance.AddKhachHang(textBoxMaKhachHang.Text, textBoxTenKhachHang.Text, textBoxDiaChi.Text, textBoxSoDienThoai.Text, "");
                }
                BLLLichSuHoaDon.Instance.AddHoaDon(textBoxMaHoaDon.Text, textBoxMaNhanVien.Text, textBoxMaKhachHang.Text, dateTimePickerThoiGianGiaoDich.Value, BLLLichSuHoaDon.Instance.GetTongSoTien());
                foreach (ViewSanPham_NhanVien i in BLLSanPham.Instance.GetTuiHang().Distinct())
                {
                    BLLSanPham.Instance.AssignMaHoaDonToVatPhams(textBoxMaHoaDon.Text, i.MaSanPham, i.SoLuongTrongTuiHang);
                }
                BLLSanPham.Instance.ResetSoLuongTrongTuiHang();
                BLLQuanLiChung.Instance.alreadyOpenFormLichSuHoaDon = false;
                BLLQuanLiChung.Instance.formLichSuHoaDon = null;
                MessageBox.Show("Tạo hoá đơn thành công!");
                this.Close();
            }
        }
    }
}
