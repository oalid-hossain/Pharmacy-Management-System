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
    public partial class AdminWindow : Form
    {
        
        public DataAccess Da {  get; set; }
        public AdminWindow(string LoggedInUserRole,string LoggedInUserPassword)
        {
            InitializeComponent();

            LoginInfoTrack.LoggedInUserRole = LoggedInUserRole;
            LoginInfoTrack.LoggedInUserPassword = LoggedInUserPassword;
            
            this.Da = new DataAccess();
            DataTable dt = Da.ExecuteQueryTable("SELECT COUNT(*) AS TotalUsers FROM Users;");
            this.lblAdWinTotalUserCount.Text = dt.Rows[0]["TotalUsers"].ToString();
            this.dgvAdminWindow.AutoGenerateColumns = false;

        }

        public AdminWindow()
        {
            InitializeComponent();

            this.Da = new DataAccess();
            DataTable dt = Da.ExecuteQueryTable("SELECT COUNT(*) AS TotalUsers FROM Users;");
            this.lblAdWinTotalUserCount.Text = dt.Rows[0]["TotalUsers"].ToString();
            this.dgvAdminWindow.AutoGenerateColumns = false;

        }


        private void btnAdWinLogOut_Click(object sender, EventArgs e)
        {
            LogInWindow lw = new LogInWindow();
            lw.Show();
            this.Close();
        }

        private void btnAdWinViewProfile_Click(object sender, EventArgs e)
        {
            AdminProfile adp = new AdminProfile();
            adp.Show();
            this.Close();
        }

        private void btnAdWinManageUser_Click(object sender, EventArgs e)
        {
            AdminManageUser admu = new AdminManageUser();
            admu.Show();
            this.Close();
        }

        private void btnAdWinManageMedicine_Click(object sender, EventArgs e)
        {
            AdminManageMedicine admm = new AdminManageMedicine();
            admm.Show();
            this.Close();
        }

        private void btnAdWinViewSalesDetails_Click(object sender, EventArgs e)
        {
            AdminViewSalesDetails advsd = new AdminViewSalesDetails();
            advsd.Show();
            this.Close();
        }

        private void btnAdWinExpiredMedicine_Click(object sender, EventArgs e)
        {
           
            DataTable dt= Da.ExecuteQueryTable("select * from Medicines where ExpiryDate<GETDATE();");
            this.dgvAdminWindow.DataSource = dt;
            this.dgvAdminWindow.ClearSelection();
            this.dgvAdminWindow.CurrentCell = null;
           
            this.dgvAdminWindow.Columns["PurchaseId"].Visible = false;
            this.dgvAdminWindow.Columns["PurchaseDate"].Visible = false;
            this.dgvAdminWindow.Columns["PurchasePrice"].Visible = false;

            this.dgvAdminWindow.Columns["ExpiryDate"].Visible = true;
            this.dgvAdminWindow.Columns["SupplierId"].Visible = true;
            this.dgvAdminWindow.Columns["MedicineId"].Visible = true;
            this.dgvAdminWindow.Columns["MedicineName"].Visible = true;
            this.dgvAdminWindow.Columns["Quantity"].Visible = true;
            this.dgvAdminWindow.Columns["SellPrice"].Visible = true;
            this.dgvAdminWindow.Columns["Category"].Visible = true;
        }

        private void btnAdWinStockOutMedicine_Click(object sender, EventArgs e)
        {
            
            DataTable dt = Da.ExecuteQueryTable("select * from Medicines where quantity=0;");
            this.dgvAdminWindow.DataSource = dt;
            this.dgvAdminWindow.ClearSelection();
            this.dgvAdminWindow.Columns["PurchaseId"].Visible = false;
            this.dgvAdminWindow.Columns["PurchaseDate"].Visible = false;
            this.dgvAdminWindow.Columns["PurchasePrice"].Visible = false;
            this.dgvAdminWindow.Columns["ExpiryDate"].Visible = false;
            this.dgvAdminWindow.Columns["SupplierId"].Visible = false;

            this.dgvAdminWindow.Columns["MedicineId"].Visible = true;
            this.dgvAdminWindow.Columns["MedicineName"].Visible = true;
            this.dgvAdminWindow.Columns["Quantity"].Visible = true;
            this.dgvAdminWindow.Columns["SellPrice"].Visible = true;
            this.dgvAdminWindow.Columns["Category"].Visible = true;

        }

        private void btnAdWinSeePurchaseHistory_Click(object sender, EventArgs e)
        {
           
            DataTable dt = Da.ExecuteQueryTable(@"SELECT p.*,m.MedicineID, m.MedicineName,m.ExpiryDate,m.category
                                                FROM Purchases p
                                                JOIN Medicines m 
                                                ON p.MedicineID = m.MedicineID;");
            this.dgvAdminWindow.DataSource= dt;
            this.dgvAdminWindow.ClearSelection();
            this.dgvAdminWindow.CurrentCell = null;
            this.dgvAdminWindow.Columns["PurchaseId"].Visible = true;
            this.dgvAdminWindow.Columns["PurchaseDate"].Visible = true;
            this.dgvAdminWindow.Columns["PurchasePrice"].Visible = true;
            this.dgvAdminWindow.Columns["ExpiryDate"].Visible = true;
            this.dgvAdminWindow.Columns["SupplierId"].Visible = true;
            this.dgvAdminWindow.Columns["MedicineId"].Visible = true;
            this.dgvAdminWindow.Columns["MedicineName"].Visible = true;
            this.dgvAdminWindow.Columns["Quantity"].Visible = true;
            this.dgvAdminWindow.Columns["Category"].Visible = true;

            this.dgvAdminWindow.Columns["SellPrice"].Visible = false;
        }

        private void btnAdWinClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdWinMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdWinFullScreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnAdWinFullScreen.Text = "Full Screen";   // back to normal
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnAdWinFullScreen.Text = "Restore";       // now full screen
            }
        }
    }
}
