using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    internal class QuanLiChung
    {
        private static QuanLiChung instance;
        private QuanLiChung() { }
        public static QuanLiChung Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QuanLiChung();
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

        public Form formBaoHanh { get; set; }
        public Form formLichSuHoaDon { get; set; }
        public Form formSanPham { get; set; }
        public Form formQuanLiNhanVien { get; set; }
        public Form formQuanLiSanPham { get; set; }
        public Form formQuanLiLichLamViec { get; set; }
        public Form formThongKe { get; set; }

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
    }
}
