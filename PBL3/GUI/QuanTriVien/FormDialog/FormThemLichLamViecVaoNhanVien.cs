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

        public FormThemLichLamViecVaoNhanVien(string maNhanVien)
        {
            InitializeComponent();
            listLichLamViecTamThoi = BLLQuanLiNhanVien.Instance.GetLichLamViecsOfNhanVien(maNhanVien);
            Reload();

            dataGridView1.Columns["NhanViens"].Visible = false;
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
            dataGridView1.DataSource = listLichLamViecTamThoi.ToList();
            dataGridView2.DataSource = BLLQuanLiLichLamViec.Instance.GetLichLamViecs("", "").Where(x => !listLichLamViecTamThoi.Any(y => y.MaLichLamViec == x.MaLichLamViec)).ToList();
        }

        private void buttonXoa_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá các lịch này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    listLichLamViecTamThoi.RemoveAt(row.Index);
                }
                Reload();
                MessageBox.Show("Đã xóa thành công!");
            }
        }

        private void buttonThem_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thêm các lịch này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
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
                MessageBox.Show("Đã thêm thành công!");
            }
        }

        private void buttonHuyBo_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void buttonXacNhan_Click(object sender, System.EventArgs e)
        {
            sendLichLamViecs(listLichLamViecTamThoi);
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
