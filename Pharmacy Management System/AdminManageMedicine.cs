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

        private void PopulateGridView(string sql="Select * from Medicines;")
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

        private void ClearAll()
        {
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
        private void AutoIdGenerate()
        {
            var sql = "select max(MedicineID) from Medicines;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            var temp = oldId.Split('-');
            var num = Convert.ToInt32(temp[1]);
            var currentId = "M-" + (++num).ToString("d4");
            this.txtAdManaMediMedicineId.Text = currentId;

            var query = "select max(SupplierID) from Suppliers;";
            DataTable dts = this.Da.ExecuteQueryTable(query);
            var osId = dts.Rows[0][0].ToString();
            var stemp = osId.Split('-');
            var snum = Convert.ToInt32(stemp[1]);
            var scurrentId = "S-" + (++snum).ToString("d3");
            this.txtAdManaMediSupplierId.Text = scurrentId;


            var pquery = "select max(PurchaseID) from Purchases;";
            DataTable dtsp = this.Da.ExecuteQueryTable(pquery);
            var ospId = dtsp.Rows[0][0].ToString();
            var sptemp = ospId.Split('-');
            var spnum = Convert.ToInt32(sptemp[1]);
            var spcurrentId = "P-" + (++spnum).ToString("d4");
            this.txtAdManaMediPurchaseId.Text = spcurrentId;


        }
        private void btnAdManaMediClear_Click(object sender, EventArgs e)
        {
           this.ClearAll();

        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtAdManaMediMedicineName.Text) || string.IsNullOrEmpty(this.txtAdManaMediPurchasePrice.Text) ||
                string.IsNullOrEmpty(this.txtAdManaMediSellPrice.Text) || string.IsNullOrEmpty(this.txtAdManaMediQuantity.Text) ||
                string.IsNullOrEmpty(this.txtAdManaMediCatagory.Text) || string.IsNullOrEmpty(this.txtAdManaMediSupplierId.Text) ||
                string.IsNullOrEmpty(this.txtAdManaMediSupplierName.Text) || string.IsNullOrEmpty(this.txtAdManaMediSupplierPhone.Text) ||
                string.IsNullOrEmpty(this.txtAdManaMediSupplierAddress.Text)|| string.IsNullOrEmpty(this.dtpAdManaMediPurchaseDate.Text) ||
                string.IsNullOrEmpty(this.dtpAdManaMediExpiredDate.Text) )

            { return false; }

            else
            { return true; }
        }

        private void btnAdManaMediSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = @"SELECT m.*, s.*
                              FROM Medicines m
                              LEFT JOIN Suppliers s 
                              ON m.SupplierId = s.SupplierId
                              WHERE m.MedicineId = '" + this.txtAdManaMediMedicineId.Text + @"';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    // update suppliers
                    var ssql = @"update suppliers
                        set SupplierName = '" + this.txtAdManaMediSupplierName.Text + @"',
                        SupplierPhone = '" + this.txtAdManaMediSupplierPhone.Text + @"',
                        Address = '" + this.txtAdManaMediSupplierAddress.Text + @"'

                        where SupplierId = '" + this.txtAdManaMediSupplierId.Text + "'; ";

                    var scount = this.Da.ExecuteDMLQuery(ssql);
                    //update Medicines
                    var sql = @"update Medicines
                                set MedicineName = '" + this.txtAdManaMediMedicineName.Text + @"',
                                    Category = '" + this.txtAdManaMediCatagory.Text + @"',
                                    PurchasePrice = '" + this.txtAdManaMediPurchasePrice.Text + @"',
                                    SellPrice = '" + this.txtAdManaMediSellPrice.Text + @"',
                                    Quantity = '" + this.txtAdManaMediQuantity.Text + @"',
                                    SupplierID = '" + this.txtAdManaMediSupplierId.Text + @"',
                                    ExpiryDate = '" + this.dtpAdManaMediExpiredDate.Value.ToString("yyyy-MM-dd") + @"'
                                    
                                    where MedicineId = '" + this.txtAdManaMediMedicineId.Text + "'; ";

                    var mcount = this.Da.ExecuteDMLQuery(sql);

                    

                    if (mcount == 1&& scount == 1)
                        MessageBox.Show("Data has been updated in the list");
                    else
                        MessageBox.Show("Data hasn't been updated in the list");
                }
                else
                {
                    //insert suppliers
                    var ssql = @"insert into Suppliers values('" + this.txtAdManaMediSupplierId.Text + "', '"
                                                           + this.txtAdManaMediSupplierName.Text + "', '"
                                                           + this.txtAdManaMediSupplierPhone.Text + "', '"
                                                           + this.txtAdManaMediSupplierAddress.Text + "');";

                    var scount = this.Da.ExecuteDMLQuery(ssql);
                    //insert medicines

                    var msql = @"insert into Medicines values('" + this.txtAdManaMediMedicineId.Text + "', '"
                                                           + this.txtAdManaMediMedicineName.Text + "', '"
                                                           + this.txtAdManaMediCatagory.Text + "', '"
                                                           + this.txtAdManaMediPurchasePrice.Text + "', '"
                                                           + this.txtAdManaMediSellPrice.Text + "','"
                                                           + this.txtAdManaMediQuantity.Text + "','"
                                                           + this.dtpAdManaMediExpiredDate.Value.ToString("yyyy-MM-dd") + "', '"
                                                           + this.txtAdManaMediSupplierId.Text + "');";

                    var mcount = this.Da.ExecuteDMLQuery(msql);

                    //insert Purchases

                    var psql = @"insert into Purchases values('" + this.txtAdManaMediPurchaseId.Text + "', '"
                                                           + this.txtAdManaMediMedicineId.Text + "', '"
                                                           + this.txtAdManaMediSupplierId.Text + "', '"
                                                           + this.txtAdManaMediPurchasePrice.Text + "', '"
                                                           + this.txtAdManaMediQuantity.Text + "','"
                                                           + this.dtpAdManaMediPurchaseDate.Value.ToString("yyyy-MM-dd") + "');";

                    var pcount = this.Da.ExecuteDMLQuery(psql);



                    if (mcount == 1&&scount==1&&pcount==1)
                        MessageBox.Show("Data has been added in the list");
                    else
                        MessageBox.Show("Data hasn't been added in the list");
                }

                this.PopulateGridView();
                this.AutoIdGenerate();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
            }
            this.AutoIdGenerate();
        }

        private void AdminManageMedicine_Load(object sender, EventArgs e)
        {
            this.AutoIdGenerate();
        }

        private void btnAdManaMediDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvAdManaMedi.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

               // var sid = this.dgvAdManaMedi.CurrentRow.Cells["SupplierId"].Value.ToString();
                var mid = this.dgvAdManaMedi.CurrentRow.Cells["MedicineId"].Value.ToString();
                var mname = this.dgvAdManaMedi.CurrentRow.Cells["MedicineName"].Value.ToString();

                var result = MessageBox.Show("Are you sure to delete data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var msql = "delete from Medicines where MedicineId = '" + mid + "';";
                var mcount = this.Da.ExecuteDMLQuery(msql);

                //var ssql = "delete from Suppliers where SupplierId = '" + sid + "';";
                //var scount = this.Da.ExecuteDMLQuery(ssql);

                

                if (mcount ==1)
                    MessageBox.Show(mname.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("Data hasn't been deleted from the list");

                this.PopulateGridView();
                this.ClearAll();
                this.AutoIdGenerate();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
            }
        }
    }
}
