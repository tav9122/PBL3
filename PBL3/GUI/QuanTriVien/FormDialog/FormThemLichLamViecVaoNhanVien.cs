using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormThemLichLamViecVaoNhanVien : Form
    {
        public delegate void SendLichLamViecs(List<ViewLichLamViec> lichLamViecs);
        public SendLichLamViecs sendLichLamViecs;

        public List<ViewLichLamViec> listLichLamViecTamThoi = new List<ViewLichLamViec>();

        public string maNhanVien;

        public FormThemLichLamViecVaoNhanVien(string maNhanVien)
        {
            InitializeComponent();

            listLichLamViecTamThoi = BLLNhanVienLichLamViec.Instance.GetLichLamViecsOfNhanVien(maNhanVien);

            labelMaNhanVien.Text = maNhanVien;

            this.maNhanVien = maNhanVien;

            Reload();

            dataGridView1.Columns["NhanViens"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns["NhanViens"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        #region Các hàm chức năng cơ bản, hạn chế sửa.
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

        private void Reload()
        {

            List<ViewLichLamViec> temp1 = listLichLamViecTamThoi.ToList();
            foreach (ViewLichLamViec nhanVien in temp1)
            {
                if (!nhanVien.NhanViens.Contains(maNhanVien))
                {
                    if (nhanVien.NhanViens == "")
                        nhanVien.NhanViens += maNhanVien;
                    else
                        nhanVien.NhanViens += ", " + maNhanVien;
                }
            }
            dataGridView1.DataSource = temp1;


            List<ViewLichLamViec> temp2 = BLLButtonQuanLiLichLamViec.Instance.GetLichLamViecs("", "").Where(x => !listLichLamViecTamThoi.Any(y => y.MaLichLamViec == x.MaLichLamViec)).ToList();
            foreach (ViewLichLamViec nhanVien in temp2)
            {
                nhanVien.NhanViens = nhanVien.NhanViens.Replace(", " + maNhanVien, "");
                nhanVien.NhanViens = nhanVien.NhanViens.Replace(maNhanVien + ", ", "");
                nhanVien.NhanViens = nhanVien.NhanViens.Replace(maNhanVien, "");
            }
            dataGridView2.DataSource = temp2;
        }

        private void buttonXoa_Click(object sender, System.EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                listLichLamViecTamThoi.RemoveAt(row.Index);
            }
            Reload();
        }

        private void buttonThem_Click(object sender, System.EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                listLichLamViecTamThoi.Add(new ViewLichLamViec
                {
                    MaLichLamViec = row.Cells["MaLichLamViec"].Value.ToString(),
                    ThoiGianBatDau = row.Cells["ThoiGianBatDau"].Value.ToString(),
                    ThoiGianKetThuc = row.Cells["ThoiGianKetThuc"].Value.ToString(),
                    NgayLamViec = row.Cells["NgayLamViec"].Value.ToString(),
                    NhanViens = row.Cells["NhanViens"].Value.ToString()
                });
            }
            Reload();
        }

        private void buttonHuyBo_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void buttonXacNhan_Click(object sender, System.EventArgs e)
        {
            sendLichLamViecs(listLichLamViecTamThoi);
            MessageBox.Show("Cập nhật thành công, nhấn xác nhận để lưu thay đổi!");
            this.Close();
        }

        private void dataGridView1_Enter(object sender, System.EventArgs e)
        {
            buttonXoa.Enabled = true;
            buttonThem.Enabled = false;
        }

        private void dataGridView2_Enter(object sender, System.EventArgs e)
        {
            buttonThem.Enabled = true;
            buttonXoa.Enabled = false;
        }
    }
}
