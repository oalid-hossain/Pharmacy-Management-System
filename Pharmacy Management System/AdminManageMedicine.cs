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
    public partial class AdminManageMedicine : Form
    {
        public DataAccess Da {  get; set; }
        public AdminManageMedicine()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnAdManaMediDashBoard_Click(object sender, EventArgs e)
        {
            AdminWindow aw=new AdminWindow();
            aw.Show();
            this.Close();
        }

        private void btnAdManaMediViewProfile_Click(object sender, EventArgs e)
        {
            AdminProfile ap=new AdminProfile();
            ap.Show();
            this.Close();
        }

        private void btnAdManaMediManageUser_Click(object sender, EventArgs e)
        {
            AdminManageUser amu =new AdminManageUser();
            amu.Show();
            this.Close();
        }

        private void btnAdManaMediViewSalesDetails_Click(object sender, EventArgs e)
        {
            AdminViewSalesDetails avsd = new AdminViewSalesDetails();
            avsd.Show();
            this.Close();
        }

        private void btnAdManaMediLogOut_Click(object sender, EventArgs e)
        {
            LogInWindow lw= new LogInWindow();
            lw.Show();
            this.Close();
        }

        private void btnAdManaMediShowAllMedicine_Click(object sender, EventArgs e)
        {
            this.txtAdManaMediSearchByName.Text = string.Empty;
            this.txtAdManaMediSearchByCategory.Text = string.Empty;
            this.PopulateGridView("Select * from Medicines;");
        }

        private void btnAdManaMediClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Dynamic Query Part

        private void SearchMedicine()
        {
            string name = txtAdManaMediSearchByName.Text.Trim();
            string category = txtAdManaMediSearchByCategory.Text.Trim();

            // 
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(category))
            {
                this.dgvAdManaMedi.DataSource = null;
                this.dgvAdManaMedi.ClearSelection();
                return;
            }

            string sql = "SELECT * FROM Medicines WHERE 1=1";

            if (!string.IsNullOrEmpty(name))
            {
                sql += " AND MedicineName LIKE '" + name + "%'";
            }

            if (!string.IsNullOrEmpty(category))
            {
                sql += " AND Category LIKE '" + category + "%'";
            }

            PopulateGridView(sql);
        }


        private void txtAdManaMediSearchByName_TextChanged(object sender, EventArgs e)
        {
            this.SearchMedicine();
        }

        private void PopulateGridView(string sql)
        {
            DataTable dt = Da.ExecuteQueryTable(sql);
            dgvAdManaMedi.AutoGenerateColumns = false;
            this.dgvAdManaMedi.DataSource= dt;
            this.dgvAdManaMedi.ClearSelection();
        }

        private void txtAdManaMediSearchByCategory_TextChanged(object sender, EventArgs e)
        {
            this.SearchMedicine();

        }

        private void btnAdManaMediFullScreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnAdManaMediFullScreen.Text = "Full Screen";   // back to normal
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnAdManaMediFullScreen.Text = "Restore";       // now full screen
            }
        }

        private void btnAdManaMediMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdManaMediClear_Click(object sender, EventArgs e)
        {
           // this.txtAdManaMediMedicineId.Clear();
            this.txtAdManaMediMedicineName.Clear();
            this.txtAdManaMediPurchasePrice.Clear();
            this.txtAdManaMediSellPrice.Clear();
            this.txtAdManaMediQuantity.Clear();
            this.txtAdManaMediCatagory.Clear();
            this.txtAdManaMediSearchByCategory.Clear();
            this.txtAdManaMediSearchByName.Clear();

           // this.txtAdManaMediSupplierId.Clear();
            this.txtAdManaMediSupplierName.Clear();
            this.txtAdManaMediSupplierPhone.Clear();
            this.txtAdManaMediSupplierAddress.Clear();
            this.dgvAdManaMedi.ClearSelection();

            this.dtpAdManaMediPurchaseDate.Text = string.Empty;
            this.dtpAdManaMediExpiredDate.Text = string.Empty;

        }
    }
}
