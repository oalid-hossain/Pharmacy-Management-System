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
    public partial class AdminManageUser : Form
    {
        public DataAccess Da {  get; set; }
        public AdminManageUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            
        }

        private void PopulateGridView(string sql)
        {
            DataTable dt = Da.ExecuteQueryTable(sql);
            this.dgvAdManaUser.AutoGenerateColumns = false;
            this.dgvAdManaUser.DataSource = dt;
            this.dgvAdManaUser.ClearSelection();
        }

        private void btnAdManaUserShowAllDetails_Click(object sender, EventArgs e)
        {
            this.txtAdManaUserSearchByName.Text =string.Empty;
            this.txtAdManaUserSearchByRole.Text = string.Empty;
            this.PopulateGridView("select * from users;");
        }

        private void btnAdManaUserDashBoard_Click(object sender, EventArgs e)
        {
            AdminWindow aw = new AdminWindow();
            aw.Show();
            this.Close();
        }

        private void btnAdManaUserViewProfile_Click(object sender, EventArgs e)
        {
            AdminProfile ap=new AdminProfile();
            ap.Show();
            this.Close();
        }

        private void btnAdManaUserManageMedicine_Click(object sender, EventArgs e)
        {
            AdminManageMedicine amm= new AdminManageMedicine();
            amm.Show();
            this.Close();
        }

        private void btnAdManaUserViewSalesDetails_Click(object sender, EventArgs e)
        {
            AdminViewSalesDetails avsd = new AdminViewSalesDetails();
            avsd.Show();
            this.Close();
        }

        private void btnAdManaUserLogOut_Click(object sender, EventArgs e)
        {
            LogInWindow lw= new LogInWindow();
            lw.Show();
            this.Close();
        }

        private void btnAdManaUserClear_Click(object sender, EventArgs e)
        {
            this.txtAdManaUserUserId.Clear();
            this.txtAdManaUserUserName.Clear();
            this.txtAdManaUserUserPhone.Clear();
            this.txtAdManUserUserEmail.Clear();
            this.txtAdManaUserUserSalary.Clear();
            this.txtAdManaUserUserRole.Clear();
            this.txtAdManaUserUserPassword.Clear();

            this.dtpAdManaUserUserDOB.Text = string.Empty;
            this.dtpAdManaUserUserJoiningDate.Text = string.Empty;

            this.txtAdManaUserSearchByName.Clear();
            this.txtAdManaUserSearchByRole.Clear();

            this.dgvAdManaUser.ClearSelection();


        }

        private void btnAdManaUserFullScreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnAdManaUserFullScreen.Text = "Full Screen";   // back to normal
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnAdManaUserFullScreen.Text = "Restore";       // now full screen
            }
        }

        private void btnAdManaUserMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdManaUserClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Dynamic Query Part
        private void SearchUser()
        {
            string name = txtAdManaUserSearchByName.Text.Trim();
            string role = txtAdManaUserSearchByRole.Text.Trim();

            // Both empty hole gridview te kiso dekhabe na
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(role))
            {
                this.dgvAdManaUser.DataSource = null;
                this.dgvAdManaUser.ClearSelection();
                return;
            }

            string query = "SELECT * FROM Users WHERE 1=1";

            if (!string.IsNullOrEmpty(name))
            {
                query += " AND UserName LIKE '" + name + "%'";
            }

            if (!string.IsNullOrEmpty(role))
            {
                query += " AND UserRole LIKE '" + role + "%'";
            }

            this.PopulateGridView(query);
        }

        private void txtAdManaUserSearchByName_TextChanged(object sender, EventArgs e)
        {
            this.SearchUser();
        }

        private void txtAdManaUserSearchByRole_TextChanged(object sender, EventArgs e)
        {
            this.SearchUser();
        }
    }
}
