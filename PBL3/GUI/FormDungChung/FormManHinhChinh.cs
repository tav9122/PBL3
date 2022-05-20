using System;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormManHinhChinh : Form
    {
        public FormManHinhChinh()
        {
            InitializeComponent();
            SetInitialData();
        }
        public void SetInitialData()
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelGioPhutGiay.Text = DateTime.Now.ToString("HH:mm:ss");
            labelNgayThangNam.Text = DateTime.Now.ToString("dddd") + ", Ngày " + DateTime.Now.ToString("dd") + " Tháng " + DateTime.Now.ToString("MM") + " Năm " + DateTime.Now.ToString("yyyy");
        }
    }
}
