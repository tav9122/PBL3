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
            labelGioPhut.Text = DateTime.Now.ToString("HH:m");
            labelGiay.Text = DateTime.Now.ToString("ss");
            labelNgayThangNam.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelThu.Text = DateTime.Now.ToString("dddd");
        }
    }
}
