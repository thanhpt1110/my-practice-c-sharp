using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BaiTap_LT_Application
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int counter = 0;
        private Timer clockTimer;

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            --counter;
            this.labelCountDown.Text = counter.ToString();
            if (counter == 0)
            {
                clockTimer.Stop();
                clicked = false;
                string filename = "shutdown.exe";
                string arguments = string.Empty;

                if (radioShutDown.Checked == true)
                    arguments = "-s -t 0";
                else if (radioRestart.Checked == true)
                    arguments = "-r -t 0";
                else if (radioLogOut.Checked == true)
                    arguments = "-l";

                ProcessStartInfo startinfo = new ProcessStartInfo(filename, arguments);
                Process.Start(startinfo);
                this.Close();
            }
        }

        private void countDown()
        {
            clockTimer = new Timer();
            clockTimer.Tick += new EventHandler(clockTimer_Tick);
            clockTimer.Interval = 1000;
            clockTimer.Start();
            this.labelCountDown.Text = counter.ToString();
        }

        bool clicked = false;
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                if (radioTroll.Checked == true)
                {
                    MessageBox.Show("Tính năng này không có tác dụng :D!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clicked = false;
                    return;
                }

                clicked = true;
                try
                {
                    counter = int.Parse(this.textBoxDuration.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Chỉ dược nhập số nguyên dương! Vui lòng kiểm tra lại.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.panelCountDown.Visible = true;
                countDown();
            } 
            else
            {
                MessageBox.Show("Hãy đợi chương trình chạy xong 1 tính năng! Vui lòng thử lại sau.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
