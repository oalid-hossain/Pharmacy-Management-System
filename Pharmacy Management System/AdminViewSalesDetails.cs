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
            try
            {
                DateTime sysDate = DateTime.Now;
                DateTime minDate = GetMinSaleDate();

                string fromText = txtAdViSaDeSearchFrom.Text;
                string toText = txtAdViSaDeSearchTo.Text;

                // 
                if (fromText == "")
                {
                    fromText = minDate.ToString("yyyy-MM-dd");
                }

                //
                if (toText == "")
                {
                    toText = sysDate.ToString("yyyy-MM-dd");
                }

                //
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

                // 
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


            catch (Exception ex) 
            {
                    MessageBox.Show("Invalid Input.\n Details:\n" + ex);
            
            }



        }

        private void AdminViewSalesDetails_Load(object sender, EventArgs e)
        {
            this.dgvAdViewSalesDetails.ClearSelection();
            this.dgvAdViewSalesDetails.AutoGenerateColumns = false;

            this.PupulateGridView(@"SELECT s.SaleID,sd.MedicineID,sd.Quantity,s.TotalAmount,s.SaleDate,  
                                  s.UserID FROM Sales s INNER JOIN SalesDetails sd ON s.SaleID = sd.SaleID;");
            this.pnlAdViSaDeSellerAndProductDetails.Visible = false;
        }

        private void dgvAdViewSalesDetails_DoubleClick(object sender, EventArgs e)
        {
            // 
            if (this.dgvAdViewSalesDetails.CurrentRow == null)
            {
                MessageBox.Show("Please select a row first!");
                return;
            }

            // 
            var uid = this.dgvAdViewSalesDetails.CurrentRow.Cells["UserId"].Value.ToString();
            var mid = this.dgvAdViewSalesDetails.CurrentRow.Cells["MedicineId"].Value.ToString();

            //
            var userSql = @"SELECT UserId, UserName, UserPhone, JoiningDate, Salary 
                    FROM Users 
                    WHERE UserId = '" + uid + "'";

            var dtUser = this.Da.ExecuteQueryTable(userSql);

            if (dtUser.Rows.Count > 0)
            {
                this.lblAdViSaDeSellerId.Text = dtUser.Rows[0]["UserId"].ToString();
                this.lblAdViSaDeSellerName.Text = dtUser.Rows[0]["UserName"].ToString();
                this.lblAdViSaDeSellerPhone.Text = dtUser.Rows[0]["UserPhone"].ToString();
                this.lblAdViSaDeSellerJoiningDate.Text = Convert.ToDateTime(dtUser.Rows[0]["JoiningDate"]).ToString("yyyy-MM-dd");
                this.lblAdViSaDeSellerSalary.Text = dtUser.Rows[0]["Salary"].ToString();
            }
            else
            {
                MessageBox.Show("User not found!");
            }

            // 
            var medSql = @"SELECT MedicineId, MedicineName, Category, SellPrice, SupplierId 
                   FROM Medicines 
                   WHERE MedicineId = '" + mid + "'";

            var dtMed = this.Da.ExecuteQueryTable(medSql);

            if (dtMed.Rows.Count > 0)
            {
                this.lblAdViSaDeProductId.Text = dtMed.Rows[0]["MedicineId"].ToString();
                this.lblAdViSaDeProductName.Text = dtMed.Rows[0]["MedicineName"].ToString();
                this.lblAdViSaDeProductCategory.Text = dtMed.Rows[0]["Category"].ToString();
                this.lblAdViSaDeProductSellPrice.Text = dtMed.Rows[0]["SellPrice"].ToString();
                this.lblAdViSaDeProductSuppilerId.Text = dtMed.Rows[0]["SupplierId"].ToString();
            }
            else
            {
                MessageBox.Show("Medicine not found!");
            }


            this.pnlAdViSaDeSellerAndProductDetails.Visible = true;

        }
    }
}
