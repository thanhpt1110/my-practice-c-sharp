using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_GUI_1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(childForm);
            panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonDanhSachSV_Click(object sender, EventArgs e)
        {
            disableButtonSidebar();
            openChildForm(new FormDanhSach());
            activateButtonSidebar(sender);
        }

        private void buttonTimSV_Click(object sender, EventArgs e)
        {
            disableButtonSidebar();
            openChildForm(new FormTimThongTin());
            activateButtonSidebar(sender);
        }

        private void buttonThemSV_Click(object sender, EventArgs e)
        {
            disableButtonSidebar();
            openChildForm(new FormThemSV());
            activateButtonSidebar(sender);
        }

        private void buttonXoaSinhVien_Click(object sender, EventArgs e)
        {
            disableButtonSidebar();
            openChildForm(new FormXoaSV());
            activateButtonSidebar(sender);
        }

        private void buttonSuaThongTin_Click(object sender, EventArgs e)
        {
            disableButtonSidebar();
            openChildForm(new FormSuaThongTin());
            activateButtonSidebar(sender);
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            disableButtonSidebar();
            activateButtonSidebar(sender);
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát ứng dụng không?", "Student Info",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                this.Close();
            else
                this.buttonThoat.BackColor = Color.FromArgb(44, 156, 163);
        }

        private void activateButtonSidebar(object btnSender)
        {
            if (btnSender != null)
            {
                Button currentButton = (Button)btnSender;
                currentButton = (Button)btnSender;
                currentButton.BackColor = Color.FromArgb(62, 224, 234);
            }
        }

        private void disableButtonSidebar()
        {
            foreach (Control prevButton in panelSidebar.Controls)
            {
                if (prevButton.GetType() == typeof(Button))
                    prevButton.BackColor = Color.FromArgb(44, 156, 163);
            }
        }

        private void labelName_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

        // Custom design for cursors
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.labelName.Cursor = Cursors.Hand;
            this.buttonDanhSachSV.Cursor = Cursors.Hand;
            this.buttonTimSV.Cursor = Cursors.Hand;
            this.buttonThemSV.Cursor = Cursors.Hand;
            this.buttonXoaSinhVien.Cursor = Cursors.Hand;
            this.buttonSuaThongTin.Cursor = Cursors.Hand;
            this.buttonThoat.Cursor = Cursors.Hand;
        }
    }
}
