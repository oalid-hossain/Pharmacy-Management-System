using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacy_Management_System
{
    public partial class AdminViewSalesDetails : Form
    {
        public DataAccess Da { get; set; }
        public AdminViewSalesDetails()
        {
            
            InitializeComponent();
            this.Da = new DataAccess();
            this.dgvAdViewSalesDetails.AutoGenerateColumns = false;
            
            this.PupulateGridView(@"SELECT s.SaleID,sd.MedicineID,sd.Quantity,s.TotalAmount,s.SaleDate,  
                                  s.UserID FROM Sales s INNER JOIN SalesDetails sd ON s.SaleID = sd.SaleID;");
            this.pnlAdViSaDeSellerAndProductDetails.Visible = false;
            
        }

        private void PupulateGridView(string sql)
        { 
            DataTable dt = Da.ExecuteQueryTable(sql);

            this.dgvAdViewSalesDetails.DataSource = dt;
            this.dgvAdViewSalesDetails.ClearSelection();
            

        }

        private void btnAdViewSalDetaDashBoard_Click(object sender, EventArgs e)
        {
            AdminWindow aw=new AdminWindow();
            aw.Show();
            this.Close();
        }

        private void btnAdViSaDeViewProfile_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile();
            ap.Show();
            this.Close();
        }

        private void btnAdViSaDeManageUser_Click(object sender, EventArgs e)
        {
            AdminManageUser amu = new AdminManageUser();
            amu.Show();
            this.Close();
        }

        private void btnAdViSaDeManageMedicine_Click(object sender, EventArgs e)
        {
            AdminManageMedicine amm = new AdminManageMedicine();
            amm.Show();
            this.Close();
        }

        private void btnAdViSaDeLogOUt_Click(object sender, EventArgs e)
        {
            LogInWindow lw = new LogInWindow();
            lw.Show();
            this.Close();
        }

        private void btnAdProClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdViSaDeClearAll_Click(object sender, EventArgs e)
        {
            this.txtAdViSaDeSearchFrom.Clear();
            this.txtAdViSaDeSearchTo.Clear();

            this.dgvAdViewSalesDetails.ClearSelection();
            this.pnlAdViSaDeSellerAndProductDetails.Visible = false;

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


        private DateTime GetMinSaleDate()
        {
            DataTable dt = Da.ExecuteQueryTable("SELECT MIN(SaleDate) FROM Sales");

            if (dt.Rows[0][0] == DBNull.Value)
                return DateTime.Now;

            return Convert.ToDateTime(dt.Rows[0][0]);
        }

        private void btnAdViSaDeSearch_Click(object sender, EventArgs e)
        {

            DateTime sysDate = DateTime.Now;
            DateTime minDate = GetMinSaleDate();

            string fromText = txtAdViSaDeSearchFrom.Text;
            string toText = txtAdViSaDeSearchTo.Text;

            // ---------------- FROM ----------------
            if (fromText == "")
            {
                fromText = minDate.ToString("yyyy-MM-dd");
            }

            // ---------------- TO ----------------
            if (toText == "")
            {
                toText = sysDate.ToString("yyyy-MM-dd");
            }

            // ---------------- VALIDATION ----------------
            if (Convert.ToDateTime(fromText) > sysDate) 
            {
                this.lblAdViSaDeFromDateError.Text = "Invalid Input";
                return;
            }
            if (Convert.ToDateTime(toText) > sysDate)
            {
                this.lblAdViSaDeToDateError.Text = "Invalid Input";
                return;
            }

            if (Convert.ToDateTime(fromText) > Convert.ToDateTime(toText))
            {
                MessageBox.Show("Invalid Input");
                return;
            }

            // ---------------- QUERY (PURE CONCAT) ----------------
            string sql = @"SELECT s.SaleID, sd.MedicineID, sd.Quantity,s.TotalAmount, s.SaleDate, s.UserID
                           FROM Sales s
                            INNER JOIN SalesDetails sd ON s.SaleID = sd.SaleID
                             WHERE CONVERT(date, s.SaleDate)
                              BETWEEN '" + fromText + "' AND '" + toText + "'";


            

            DataTable dt = Da.ExecuteQueryTable(sql);

            dgvAdViewSalesDetails.DataSource = dt;

            dgvAdViewSalesDetails.ClearSelection();
            dgvAdViewSalesDetails.CurrentCell = null;



        }
    }
}
