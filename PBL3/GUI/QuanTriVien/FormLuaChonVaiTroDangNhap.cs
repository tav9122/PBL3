using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormLuaChonVaiTroDangNhap : Form
    {
        string userName;
        public FormLuaChonVaiTroDangNhap(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            ((Button)sender).Size = new Size(((Button)sender).Size.Width - 3, ((Button)sender).Size.Height - 3);
        }

        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).Size = new Size(((Button)sender).Size.Width + 3, ((Button)sender).Size.Height + 3);
        }

        private void buttonVaiTroQuanTriVien_Click(object sender, EventArgs e)
        {
            FormQuanTriVien f = new FormQuanTriVien(userName);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void buttonVaiTroNhanVien_Click(object sender, EventArgs e)
        {
            FormQuanTriVien f = new FormQuanTriVien(userName);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
