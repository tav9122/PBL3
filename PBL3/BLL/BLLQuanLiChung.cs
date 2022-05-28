using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PBL3
{
    internal class BLLQuanLiChung
    {
        private static BLLQuanLiChung instance;
        public static BLLQuanLiChung Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLLQuanLiChung();
                }
                return instance;
            }
        }
        private Button currentButton { get; set; }

        public bool alreadyOpenFormBaoHanh { get; set; }
        public bool alreadyOpenFormLichSuHoaDon { get; set; }
        public bool alreadyOpenFormSanPham { get; set; }
        public bool alreadyOpenFormQuanLiNhanVien { get; set; }
        public bool alreadyOpenFormQuanLiSanPham { get; set; }
        public bool alreadyOpenFormQuanLiLichLamViec { get; set; }
        public bool alreadyOpenFormThongKe { get; set; }
        public bool alreadyOpenFormQuanLiKhachHang { get; set; }

        public Form formBaoHanh { get; set; }
        public Form formLichSuHoaDon { get; set; }
        public Form formSanPham { get; set; }
        public Form formQuanLiNhanVien { get; set; }
        public Form formQuanLiSanPham { get; set; }
        public Form formQuanLiLichLamViec { get; set; }
        public Form formThongKe { get; set; }
        public Form formQuanLiKhachHang { get; set; }

        public void ResetProperties()
        {
            alreadyOpenFormBaoHanh = false;
            alreadyOpenFormLichSuHoaDon = false;
            alreadyOpenFormSanPham = false;
            alreadyOpenFormQuanLiNhanVien = false;
            alreadyOpenFormQuanLiSanPham = false;
            alreadyOpenFormQuanLiLichLamViec = false;
            alreadyOpenFormThongKe = false;
            alreadyOpenFormQuanLiKhachHang = false;
            formBaoHanh = null;
            formLichSuHoaDon = null;
            formSanPham = null;
            formQuanLiNhanVien = null;
            formQuanLiSanPham = null;
            formQuanLiLichLamViec = null;
            formThongKe = null;
            formQuanLiKhachHang = null;
        }

        private string tempText { get; set; }

        private void ActivateButton(object buttonSender)
        {
            if (buttonSender != null)
            {
                DisableButton();
                currentButton = (Button)buttonSender;
                Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
                string temp = currentButton.Text.Normalize(NormalizationForm.FormD);
                temp = regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D').ToLower().Replace(" ", "") + "32";
                currentButton.Image = (Image)Properties.Resources.ResourceManager.GetObject(temp);
                currentButton.BackColor = Color.FromArgb(125, 125, 161);
                tempText = currentButton.Text;
                currentButton.Text = "";
                currentButton.ImageAlign = ContentAlignment.MiddleCenter;
            }
        }

        public void DisableButton()
        {
            if (currentButton != null)
            {
                Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
                string temp = tempText.Normalize(NormalizationForm.FormD);
                temp = regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D').ToLower().Replace(" ", "") + "26";
                currentButton.Image = (Image)Properties.Resources.ResourceManager.GetObject(temp);
                currentButton.BackColor = Color.FromArgb(39, 39, 58);
                currentButton.Text = tempText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void OpenChildForm(Form childForm, object buttonSender, Panel panelDesktopPane)
        {
            string boolCheck = "alreadyOpen" + childForm.Name;
            string formName = char.ToLower(childForm.Name[0]) + childForm.Name.Substring(1);
            if ((bool)this.GetType().GetProperty(boolCheck).GetValue(this) == true)
            {
                ActivateButton(buttonSender);
                ((Form)this.GetType().GetProperty(formName).GetValue(this)).BringToFront();
            }
            else
            {
                this.GetType().GetProperty(boolCheck).SetValue(this, true);
                ActivateButton(buttonSender);
                this.GetType().GetProperty(formName).SetValue(this, childForm);
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelDesktopPane.Controls.Add(childForm);
                panelDesktopPane.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }

        public string GetNextPrimaryKey(List<string> currentPrimaryKeys)
        {
            return currentPrimaryKeys[0].Substring(0, 2) + (Convert.ToInt32(currentPrimaryKeys.Count) + 1).ToString();
        }

        public string GetNextPrimaryKey(List<string> currentPrimaryKeys, string s)
        {
            string twoFirstCharacter = "";
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            temp = regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D').ToUpper();
            foreach (string i in temp.Split(' '))
            {
                twoFirstCharacter += i[0];
            }
            return twoFirstCharacter + (Model.Instance.SanPhams.Where(sp => sp.MaSanPham.Substring(0, 2) == twoFirstCharacter).Count() + 1).ToString();
        }

        public string LoginChecker(string tenDangNhap, string matKhau)
        {
            if (Model.Instance.TaiKhoans.Where(tk => tk.TenDangNhap == tenDangNhap && tk.MatKhau == matKhau).Count() > 0)
            {
                if (tenDangNhap == "qtv")
                {
                    return "QUẢN TRỊ VIÊN";
                }
                else
                    return Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.TenDangNhap == tenDangNhap).MaNhanVien;
            }
            return null;
        }

        public string GetMatKhauQuanTriVien()
        {
            return Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.TenDangNhap == "qtv").MatKhau;
        }

        public void UpdateMatKhauQuanTriVien(string matKhau)
        {
            Model.Instance.TaiKhoans.FirstOrDefault(tk => tk.TenDangNhap == "qtv").MatKhau = matKhau;
            Model.Instance.SaveChanges();
        }
        public KhachHang GetKhachHangviaID(string ID)
        {
            return Model.Instance.KhachHangs.FirstOrDefault(p => p.MaKhachHang == ID);
        }
    }
}
