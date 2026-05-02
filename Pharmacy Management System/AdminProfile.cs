using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminWindow aw = new AdminWindow();
            aw.Show();
            this.Close();
        }

        private void btnAdProClear_Click(object sender, EventArgs e)
        {
            this.txtAdProUserName.Clear();
            this.txtAdProUserPhone.Clear();
            this.txtAdProUserEmail.Clear();
            this.dtpAdProUserDOB.Text = string.Empty;
        }

        private void btnAdProDashBoard_Click(object sender, EventArgs e)
        {
            AdminWindow aw=new AdminWindow();
            aw.Show();
            this.Close();
        }

        private void btnAdProManageUser_Click(object sender, EventArgs e)
        {
            AdminManageUser amu = new AdminManageUser();
            amu.Show();
            this.Close();
        }

        private void btnAdProManageMedicine_Click(object sender, EventArgs e)
        {
            AdminManageMedicine amm = new AdminManageMedicine();
            amm.Show();
            this.Close();
        }

        private void btnAdProViewSalesDetails_Click(object sender, EventArgs e)
        {
            AdminViewSalesDetails avsd = new AdminViewSalesDetails();
            avsd.Show();
            this.Close();
        }

        private void btnAdProLogOut_Click(object sender, EventArgs e)
        {
            LogInWindow lw = new LogInWindow();
            lw.Show();
            this.Close();
        }

        private void btnAdProClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdProFullScreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnAdProFullScreen.Text = "Full Screen";   // back to normal
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnAdProFullScreen.Text = "Restore";       // now full screen
            }
        }

        private void btnAdProMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
