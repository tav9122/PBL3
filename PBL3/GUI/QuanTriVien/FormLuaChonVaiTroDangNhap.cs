using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormLuaChonVaiTroDangNhap : Form
    {
        string maQuanTriVien;
        public FormLuaChonVaiTroDangNhap(string maQuanTriVien)
        {
            InitializeComponent();
            this.maQuanTriVien = maQuanTriVien;
        }

        #region Các hàm chức năng cơ bản, hạn chế sửa
        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            ((Button)sender).Size = new Size(((Button)sender).Size.Width - 3, ((Button)sender).Size.Height - 3);
        }

        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).Size = new Size(((Button)sender).Size.Width + 3, ((Button)sender).Size.Height + 3);
        }
        #endregion

        private void buttonVaiTroQuanTriVien_Click(object sender, EventArgs e)
        {
            FormQuanTriVien f = new FormQuanTriVien(maQuanTriVien);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void buttonVaiTroNhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien f = new FormNhanVien(maQuanTriVien);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
