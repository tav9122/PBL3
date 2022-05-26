using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormLuaChonVaiTroDangNhap : Form
    {
        public FormLuaChonVaiTroDangNhap()
        {
            InitializeComponent();
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
            FormQuanTriVien f = new FormQuanTriVien();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void buttonVaiTroNhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien f = new FormNhanVien("QUẢN TRỊ VIÊN");
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
