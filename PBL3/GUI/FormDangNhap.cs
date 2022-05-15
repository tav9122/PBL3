using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

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
                if (textBoxTenDangNhap.Text == "qtv" && textBoxMatKhau.Text == "qtv")
                {
                    FormQuanTriVien formAdmin = new FormQuanTriVien(textBoxTenDangNhap.Text);
                    this.Hide();
                    formAdmin.ShowDialog();
                    this.Show();
                }
                else if (textBoxTenDangNhap.Text == "nv" && textBoxMatKhau.Text == "nv")
                {
                    FormNhanVien formNhanVien = new FormNhanVien(textBoxTenDangNhap.Text);
                    this.Hide();
                    formNhanVien.ShowDialog();
                    this.Show();
                }
                else textBoxCanhBao.Text = "Tên đăng nhập hoặc mật khẩu không đúng";

                textBoxTenDangNhap.Clear();
                textBoxMatKhau.Clear();
                textBoxTenDangNhap.Focus();
            }
        }

        private void linkLabelQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Quên thì chịu chứ sao h :<");
        }

        private void iconButtonAnHienMatKhau_Click(object sender, EventArgs e)
        {
            if (iconButtonAnHienMatKhau.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                iconButtonAnHienMatKhau.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                iconButtonAnHienMatKhau.IconFont = FontAwesome.Sharp.IconFont.Regular;
                iconButtonAnHienMatKhau.IconSize = 30;
                textBoxMatKhau.UseSystemPasswordChar = false;
                textBoxMatKhau.Multiline = true;
            }
            else
            {
                iconButtonAnHienMatKhau.IconChar = FontAwesome.Sharp.IconChar.Eye;
                iconButtonAnHienMatKhau.IconFont = FontAwesome.Sharp.IconFont.Regular;
                iconButtonAnHienMatKhau.IconSize = 27;
                textBoxMatKhau.UseSystemPasswordChar = true;
                textBoxMatKhau.Multiline = false;
            }
        }


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
    }
}
