using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormChiTietHoacThemHoaDon : Form
    {
        public FormChiTietHoacThemHoaDon(string ma)
        {
            InitializeComponent();

            if (BLLNhanVien.Instance.GetNhanVien(ma) != null)
            {
                labelTieuDe.Text = "Thêm hóa đơn";
                textBoxMaHoaDon.Text = BLLQuanLiChung.Instance.GetNextPrimaryKey(BLLHoaDon.Instance.GetMaHoaDons());
                textBoxMaNhanVien.Text = ma;
                textBoxTenNhanVien.Text = BLLNhanVien.Instance.GetNhanVien(ma).HoVaTen;
                dateTimePickerThoiGianGiaoDich.Value = DateTime.Now;
                textBoxThanhTien.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C0}", BLLButtonSanPham.Instance.GetTongTien());
                textBoxMaKhachHang.Text = BLLQuanLiChung.Instance.GetNextPrimaryKey(BLLKhachHang.Instance.GetMaKhachHangs());

                dataGridView1.DataSource = BLLButtonSanPham.Instance.GetSanPhamWithTempValueGreaterThanZero();
            }
            else
            {
                labelTieuDe.Text = "Chi tiết hoá đơn:";

                var hoaDon = BLLHoaDon.Instance.GetHoaDon(ma);
                textBoxMaHoaDon.Text = hoaDon.MaHoaDon;
                textBoxMaKhachHang.Text = hoaDon.MaKhachHang;
                textBoxMaNhanVien.Text = hoaDon.MaNhanVien;
                textBoxTenNhanVien.Text = hoaDon.NhanVien.HoVaTen;
                dateTimePickerThoiGianGiaoDich.Value = hoaDon.ThoiGianGiaoDich;
                textBoxThanhTien.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C0}", hoaDon.ThanhTien);
                textBoxSoDienThoai.Text = hoaDon.KhachHang.SoDienThoai;
                textBoxDiaChi.Text = hoaDon.KhachHang.DiaChi;
                textBoxTenKhachHang.Text = hoaDon.KhachHang.TenKhachHang;

                textBoxTenKhachHang.Enabled = false;
                textBoxDiaChi.Enabled = false;
                textBoxSoDienThoai.Enabled = false;
                buttonXacNhan.Visible = false;

                dataGridView1.DataSource = BLLVatPham.Instance.GetVatPhamsByMaHoaDon(hoaDon.MaHoaDon);
                dataGridView1.Columns["SoSeri"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
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

        #endregion

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
                if (BLLKhachHang.Instance.GetKhachHang(textBoxSoDienThoai.Text) == null)
                {
                    BLLKhachHang.Instance.AddKhachHang(textBoxMaKhachHang.Text, textBoxTenKhachHang.Text, textBoxDiaChi.Text, textBoxSoDienThoai.Text, "");
                    BLLQuanLiChung.Instance.alreadyOpenFormQuanLiKhachHang = false;
                    BLLQuanLiChung.Instance.formQuanLiKhachHang = null;
                }
                BLLHoaDon.Instance.AddHoaDon(textBoxMaHoaDon.Text, textBoxMaNhanVien.Text, textBoxMaKhachHang.Text, dateTimePickerThoiGianGiaoDich.Value, BLLButtonSanPham.Instance.GetTongTien());
                foreach (SanPham i in BLLSanPham.Instance.GetSanPhamWithTempValueGreaterThanZero())
                {
                    BLLButtonSanPham.Instance.AssignMaHoaDonToVatPhams(textBoxMaHoaDon.Text, i.MaSanPham, i.Temp);
                }
                BLLSanPham.Instance.ResetTemp();
                BLLQuanLiChung.Instance.alreadyOpenFormLichSuHoaDon = false;
                BLLQuanLiChung.Instance.formLichSuHoaDon = null;
                MessageBox.Show("Tạo hoá đơn thành công!");
                this.Close();
            }
        }

        private void textBoxSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (BLLKhachHang.Instance.GetKhachHang(textBoxSoDienThoai.Text) != null)
            {
                textBoxTenKhachHang.Enabled = false;
                textBoxDiaChi.Enabled = false;
                textBoxTenKhachHang.Text = BLLKhachHang.Instance.GetKhachHang(textBoxSoDienThoai.Text).TenKhachHang;
                textBoxDiaChi.Text = BLLKhachHang.Instance.GetKhachHang(textBoxSoDienThoai.Text).DiaChi;
                textBoxMaKhachHang.Text = BLLKhachHang.Instance.GetKhachHang(textBoxSoDienThoai.Text).MaKhachHang;
            }
            else
            {
                textBoxTenKhachHang.Enabled = true;
                textBoxDiaChi.Enabled = true;
                textBoxTenKhachHang.Text = "";
                textBoxDiaChi.Text = "";
                textBoxMaKhachHang.Text = BLLQuanLiChung.Instance.GetNextPrimaryKey(BLLKhachHang.Instance.GetMaKhachHangs());
            }
        }
    }
}
