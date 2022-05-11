﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PBL3
{
    public partial class FormNhanVien : Form
    {
        FormManHinhChinh formManHinhChinh = new FormManHinhChinh();
        public FormNhanVien(string userName)
        {
            InitializeComponent();
            SetInitialData(userName);
        }

        public void SetInitialData(string userName)
        {
            //linkLabelTenNhanVien.Text = userName;
            linkLabelTenNhanVien.Text = "Trần Đức Po";
            pictureBox1_Click(null, null);
            formManHinhChinh.TopLevel = false;
            formManHinhChinh.FormBorderStyle = FormBorderStyle.None;
            formManHinhChinh.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(formManHinhChinh);
            panelDesktopPane.Tag = formManHinhChinh;
            formManHinhChinh.BringToFront();
            formManHinhChinh.Show();
        }

        private void iconButtonSanPham_Click(object sender, EventArgs e)
        {
            QuanLiChung.Instance.OpenChildForm(new FormSanPham(), sender, panelDesktopPane);
        }

        private void iconButtonBaoHanh_Click(object sender, EventArgs e)
        {
            QuanLiChung.Instance.OpenChildForm(new FormBaoHanh(), sender, panelDesktopPane);
        }

        private void iconButtonLichSuHoaDon_Click(object sender, EventArgs e)
        {
            QuanLiChung.Instance.OpenChildForm(new FormLichSuHoaDon(), sender, panelDesktopPane);
        }

        private void linkLabelTenNhanVien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Point position = new Point(166, -5);
            contextMenuStrip1.Show(linkLabelTenNhanVien, position);
        }

        private void ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.WhiteSmoke;
        }

        private void ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.Gainsboro;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
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

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            QuanLiChung.Instance.DisableButton();
            formManHinhChinh.BringToFront();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Size = new Size(pictureBox1.Size.Width - 3, pictureBox1.Size.Height - 3);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Size = new Size(pictureBox1.Size.Width + 3, pictureBox1.Size.Height + 3);
        }
    }
}
