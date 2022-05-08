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
        private IconButton currentButton;
        private Form activeForm;
        private void ActivateButton(object buttonSender)
        {
            if (buttonSender != null)
            {
                if (currentButton != (IconButton)buttonSender)
                {
                    DisableButton();
                    currentButton = (IconButton)buttonSender;
                    currentButton.BackColor = Color.FromArgb(125, 125, 161);
                    currentButton.ForeColor = Color.WhiteSmoke;
                    currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentButton.ImageAlign = ContentAlignment.MiddleRight;
                    currentButton.TextAlign = ContentAlignment.MiddleCenter;
                    currentButton.IconColor = Color.WhiteSmoke;
                }
            }
        }
        
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(51, 51, 76);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
            }
        }

        public void OpenChildForm(Form childForm, object buttonSender, Panel panelDesktopPane)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(buttonSender);
            activeForm = childForm;
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
