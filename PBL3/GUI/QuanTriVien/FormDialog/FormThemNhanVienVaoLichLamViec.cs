using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormThemNhanVienVaoLichLamViec : Form
    {
        public delegate void SendNhanViens(List<ViewNhanVien> nhanViens);
        public SendNhanViens sendNhanViens;

        public List<ViewNhanVien> listNhanVienTamThoi = new List<ViewNhanVien>();

        public string maLichLamViec;

        public FormThemNhanVienVaoLichLamViec(string maLichLamViec)
        {
            InitializeComponent();

            listNhanVienTamThoi = BLLNhanVienLichLamViec.Instance.GetNhanViensOfLichLamViec(maLichLamViec);

            labelMaLichLamViec.Text = maLichLamViec;

            this.maLichLamViec = maLichLamViec;

            Reload();

            dataGridView1.Columns["NgaySinh"].Visible = false;
            dataGridView1.Columns["TenDangNhap"].Visible = false;
            dataGridView1.Columns["MucLuong"].Visible = false;

            dataGridView2.Columns["NgaySinh"].Visible = false;
            dataGridView2.Columns["TenDangNhap"].Visible = false;
            dataGridView2.Columns["MucLuong"].Visible = false;
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
            List<ViewNhanVien> temp1 = listNhanVienTamThoi.ToList();
            foreach (ViewNhanVien nhanVien in temp1)
            {
                if (!nhanVien.LichLamViecs.Contains(maLichLamViec))
                {
                    if (nhanVien.LichLamViecs == "")
                        nhanVien.LichLamViecs += maLichLamViec;
                    else
                        nhanVien.LichLamViecs += ", " + maLichLamViec;
                }
            }
            dataGridView1.DataSource = temp1;


            List<ViewNhanVien> temp2 = BLLButtonQuanLiNhanVien.Instance.GetNhanViens("", "").Where(x => !listNhanVienTamThoi.Any(y => y.MaNhanVien == x.MaNhanVien)).ToList();
            foreach (ViewNhanVien nhanVien in temp2)
            {
                nhanVien.LichLamViecs = nhanVien.LichLamViecs.Replace(", " + maLichLamViec, "");
                nhanVien.LichLamViecs = nhanVien.LichLamViecs.Replace(maLichLamViec + ", ", "");
                nhanVien.LichLamViecs = nhanVien.LichLamViecs.Replace(maLichLamViec, "");
            }
            dataGridView2.DataSource = temp2;
        }

        private void buttonXoa_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá các nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    listNhanVienTamThoi.RemoveAt(row.Index);
                }
                Reload();
            }
        }

        private void buttonThem_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thêm các nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    listNhanVienTamThoi.Add(new ViewNhanVien
                    {
                        MaNhanVien = row.Cells["MaNhanVien"].Value.ToString(),
                        HoVaTen = row.Cells["HoVaTen"].Value.ToString(),
                        SoDienThoai = row.Cells["SoDienThoai"].Value.ToString(),
                        Email = row.Cells["Email"].Value.ToString(),
                        DiaChi = row.Cells["DiaChi"].Value.ToString(),
                        NgaySinh = Convert.ToDateTime(row.Cells["NgaySinh"].Value),
                        GioiTinh = Convert.ToBoolean(row.Cells["GioiTinh"].Value),
                        MucLuong = Convert.ToDouble(row.Cells["MucLuong"].Value),
                        TenDangNhap = row.Cells["TenDangNhap"].Value.ToString(),
                        LichLamViecs = row.Cells["LichLamViecs"].Value.ToString()
                    });
                }
                Reload();
            }
        }

        private void buttonHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonXacNhan_Click(object sender, System.EventArgs e)
        {
            sendNhanViens(listNhanVienTamThoi);
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
