using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();

            //Bốn câu lệnh ở dưới chỉ có mục đích khởi tạo Model
            textBoxTenDangNhap.Text = "khoitao";
            textBoxMatKhau.Text = "khoitao";
            buttonDangNhap_Click(null, null);
            textBoxCanhBao.Text = "";
        }

        #region Các hàm chức năng cơ bản, hạn chế sửa

        private void textBoxMatKhau_Enter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(125, 125, 200);
        }

        private void textBoxMatKhau_Leave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void textBoxTenDangNhap_Enter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(125, 125, 200);
        }

        private void textBoxTenDangNhap_Leave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void FormDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                buttonDangNhap.PerformClick();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text != "")
            {
                textBoxCanhBao.Text = "";
            }
        }

        int count = 0;
        private void buttonAnHienMatKhau_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                textBoxMatKhau.Multiline = false;
                buttonAnHienMatKhau.Image = Properties.Resources.openedeye20;
            }
            else
            {
                textBoxMatKhau.Multiline = true;
                buttonAnHienMatKhau.Image = Properties.Resources.closedeye20;
            }
        }
        #endregion

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            if (textBoxTenDangNhap.Text == "" || textBoxMatKhau.Text == "")
            {
                if (textBoxTenDangNhap.Text == "") textBoxTenDangNhap.Focus();
                else textBoxMatKhau.Focus();
                textBoxCanhBao.Text = "Không được để trống các trường";
            }
            else
            {
                string result = BLLQuanLiChung.Instance.LoginChecker(textBoxTenDangNhap.Text, textBoxMatKhau.Text);
                if (result != null)
                {
                    if (result == "QUẢN TRỊ VIÊN")
                    {
                        FormLuaChonVaiTroDangNhap formLuaChonVaiTroDangNhap = new FormLuaChonVaiTroDangNhap();
                        this.Hide();
                        formLuaChonVaiTroDangNhap.ShowDialog();
                        this.Show();
                        count = 1;
                        buttonAnHienMatKhau.PerformClick();
                    }
                    else
                    {
                        FormNhanVien formNhanVien = new FormNhanVien(result);
                        this.Hide();
                        formNhanVien.ShowDialog();
                        this.Show();
                        count = 1;
                        buttonAnHienMatKhau.PerformClick();
                    }
                }
                else textBoxCanhBao.Text = "Tên đăng nhập hoặc mật khẩu không đúng";

                textBoxTenDangNhap.Clear();
                textBoxMatKhau.Clear();
                textBoxTenDangNhap.Focus();
            }
        }

        private void linkLabelQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Tính năng lấy lại mật khẩu tạm thời chưa khả dụng vì lí do bảo mật, hãy liên hệ với quản trị viên!");
        }
    }
}
