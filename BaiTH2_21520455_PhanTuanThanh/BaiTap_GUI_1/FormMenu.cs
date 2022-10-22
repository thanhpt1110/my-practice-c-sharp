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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSave formSave = new FormSave(); 
            formSave.ShowDialog();
            this.Close();
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFind formFind = new FormFind();
            formFind.ShowDialog();
            this.Close();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdate formUpdate = new FormUpdate();
            formUpdate.ShowDialog();
            this.Close();
        }
    }
}
