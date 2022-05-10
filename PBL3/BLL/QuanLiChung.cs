using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

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
        private IconButton currentButton { get; set; }

        public bool alreadyOpenFormBaoHanh { get; set; }
        public bool alreadyOpenFormLichSuHoaDon { get; set; }
        public bool alreadyOpenFormSanPham { get; set; }
        public bool alreadyOpenFormQuanLiNhanVien { get; set; }
        public bool alreadyOpenFormQuanLiSanPham { get; set; }
        public bool alreadyOpenFormThongKe { get; set; }

        public Form formBaoHanh { get; set; }
        public Form formLichSuHoaDon { get; set; }
        public Form formSanPham { get; set; }
        public Form formQuanLiNhanVien { get; set; }
        public Form formQuanLiSanPham { get; set; }
        public Form formThongKe { get; set; }
        
        private string tempText { get; set; }
        
        private void ActivateButton(object buttonSender)
        {
            if (buttonSender != null)
            {
                if (currentButton != (IconButton)buttonSender)
                {
                    DisableButton();
                    currentButton = (IconButton)buttonSender;
                    currentButton.BackColor = Color.FromArgb(125, 125, 161);
                    tempText = currentButton.Text;
                    currentButton.Text = "";
                    currentButton.ImageAlign = ContentAlignment.MiddleCenter;
                    currentButton.IconSize = 32;
                    currentButton.IconColor = Color.WhiteSmoke;
                }
            }
        }

        public void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(39, 39, 58);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.Text = tempText;
                currentButton.IconSize = 30;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
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
