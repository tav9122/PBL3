using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace WindowsFormsApp1
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
        private IconButton currentButton;
        private bool alreadyOpenQuanLiNhanVien = false;
        private bool alreadyOpenQuanLiSanPham = false;
        private Form formQuanLiNhanVien;
        private Form formQuanLiSanPham;
        private string tempText;
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
            MessageBox.Show(formName);
            MessageBox.Show(boolCheck);
            if (childForm is FormQuanLiNhanVien)
            {
                if (alreadyOpenQuanLiNhanVien)
                {
                    ActivateButton(buttonSender);
                    formQuanLiNhanVien.BringToFront();
                }
                else
                {
                    alreadyOpenQuanLiNhanVien = true;
                    ActivateButton(buttonSender);
                    formQuanLiNhanVien = childForm;
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;
                    panelDesktopPane.Controls.Add(childForm);
                    panelDesktopPane.Tag = childForm;
                    childForm.BringToFront();
                    childForm.Show();
                }
            }
            if (childForm is FormQuanLiSanPham)
            {
                if (alreadyOpenQuanLiSanPham)
                {
                    ActivateButton(buttonSender);
                    formQuanLiSanPham.BringToFront();
                }
                else
                {
                    alreadyOpenQuanLiSanPham = true;
                    ActivateButton(buttonSender);
                    formQuanLiSanPham = childForm;
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
}    
    
