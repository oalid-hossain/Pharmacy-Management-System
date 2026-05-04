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

        private void PopulateGridView(string sql="Select * from users;")
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
            this.ClearAll();
            
        }

        private void ClearAll()
        {
            this.txtAdManaUserUserName.Clear();
            this.txtAdManaUserUserPhone.Clear();
            this.txtAdManaUserUserEmail.Clear();
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

        private void AutoUserIdGenerate()
        {
            var sql = "select max(UserId) from Users;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            var temp = oldId.Split('-');
            var num = Convert.ToInt32(temp[1]);
            var currentId = "U-" + (++num).ToString("d3");
            this.txtAdManaUserUserId.Text = currentId;
        }

        private void AdminManageUser_Load(object sender, EventArgs e)
        {
            this.AutoUserIdGenerate();
        }
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtAdManaUserUserId.Text) || string.IsNullOrEmpty(this.txtAdManaUserUserName.Text) ||
                string.IsNullOrEmpty(this.txtAdManaUserUserPhone.Text) || string.IsNullOrEmpty(this.txtAdManaUserUserEmail.Text) ||
                string.IsNullOrEmpty(this.txtAdManaUserUserSalary.Text) || string.IsNullOrEmpty(this.txtAdManaUserUserRole.Text) ||
                string.IsNullOrEmpty(this.txtAdManaUserUserPassword.Text) || string.IsNullOrEmpty(this.dtpAdManaUserUserDOB.Text) ||
                string.IsNullOrEmpty(this.dtpAdManaUserUserJoiningDate.Text))

            { return false; }

            else
            { return true; }
        }
        private void btnAdManaUserSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from Users where UserId = '" + this.txtAdManaUserUserId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update users
                                set UserName = '" + this.txtAdManaUserUserName.Text + @"',
                                    UserPhone = '" + this.txtAdManaUserUserPhone.Text + @"',
                                    UserEmail = '" + this.txtAdManaUserUserEmail.Text + @"',
                                    Salary = '" + this.txtAdManaUserUserSalary.Text + @"',
                                    UserPassword = '" + this.txtAdManaUserUserPassword.Text + @"',
                                    UserRole = '" + this.txtAdManaUserUserRole.Text + @"',
                                    UserDOB = '" + this.dtpAdManaUserUserDOB.Value.ToString("yyyy-MM-dd") + @"',
                                    JoiningDate = '" + this.dtpAdManaUserUserJoiningDate.Value.ToString("yyyy-MM-dd") + @"'
                                    
                                    where UserId = '" + this.txtAdManaUserUserId.Text + "'; ";

                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated in the list");
                    else
                        MessageBox.Show("Data hasn't been updated in the list");
                }
                else
                {
                    //insert
                    
                     var sql = @"insert into users values('" + this.txtAdManaUserUserId.Text + "', '"
                                                            + this.txtAdManaUserUserName.Text + "', '"
                                                            + this.txtAdManaUserUserPhone.Text + "', '"
                                                            + this.txtAdManaUserUserEmail.Text + "', '"
                                                            + this.txtAdManaUserUserRole.Text + "','"
                                                            + this.txtAdManaUserUserPassword.Text + "','"
                                                            + this.dtpAdManaUserUserJoiningDate.Value.ToString("yyyy-MM-dd") + "','"
                                                            + this.dtpAdManaUserUserDOB.Value.ToString("yyyy-MM-dd") + "', '"
                                                            + this.txtAdManaUserUserSalary.Text + "');";

                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been added in the list");
                    else
                        MessageBox.Show("Data hasn't been added in the list");
                }

                this.PopulateGridView();
                this.ClearAll();
                this.AutoUserIdGenerate();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
            }

        }

        private void btnAdManaUserDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvAdManaUser.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                var id = this.dgvAdManaUser.CurrentRow.Cells["UserId"].Value.ToString();
                var name = this.dgvAdManaUser.CurrentRow.Cells["UserName"].Value.ToString();

                var result = MessageBox.Show("Are you sure to delete data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var sql = "delete from users where UserId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("Data hasn't been deleted from the list");

                this.PopulateGridView();
                this.ClearAll();
                this.AutoUserIdGenerate();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
            }
        }

        private void dgvAdManaUser_DoubleClick(object sender, EventArgs e)
        {
            this.txtAdManaUserUserId.Text = this.dgvAdManaUser.CurrentRow.Cells[0].Value.ToString();
            this.txtAdManaUserUserName.Text = this.dgvAdManaUser.CurrentRow.Cells["UserName"].Value.ToString();
            this.txtAdManaUserUserPhone.Text = this.dgvAdManaUser.CurrentRow.Cells["UserPhone"].Value.ToString();
            this.txtAdManaUserUserEmail.Text = this.dgvAdManaUser.CurrentRow.Cells["UserEmail"].Value.ToString();
            this.txtAdManaUserUserSalary.Text = this.dgvAdManaUser.CurrentRow.Cells["Salary"].Value.ToString();
            this.txtAdManaUserUserRole.Text = this.dgvAdManaUser.CurrentRow.Cells["UserRole"].Value.ToString();
            this.txtAdManaUserUserPassword.Text = this.dgvAdManaUser.CurrentRow.Cells["UserPassword"].Value.ToString();
            this.dtpAdManaUserUserDOB.Text = this.dgvAdManaUser.CurrentRow.Cells["UserDOB"].Value.ToString();
            this.dtpAdManaUserUserJoiningDate.Text = this.dgvAdManaUser.CurrentRow.Cells["JoiningDate"].Value.ToString();
        }
    }
}
