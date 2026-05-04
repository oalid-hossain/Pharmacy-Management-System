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
        public DataAccess Da { get; set; }
        public AdminProfile()
        {
            InitializeComponent();
            this.Da = new DataAccess();
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

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            string role = LoginInfoTrack.LoggedInUserRole;
            string password = LoginInfoTrack.LoggedInUserPassword;

            string query = "SELECT UserId, UserName,UserPhone,UserEmail,UserRole,UserPassword,JoiningDate,UserDOB,Salary " +
                           "FROM Users " +
                           "WHERE UserRole = '" + role + "' and UserPassword ='"+password+"';";

            var dt = Da.ExecuteQueryTable(query);

            if (dt.Rows.Count == 1)
            {
                this.txtAdProUserID.Text = dt.Rows[0]["UserId"].ToString();
                this.txtAdProUserName.Text = dt.Rows[0]["UserName"].ToString();
                this.txtAdProUserPhone.Text = dt.Rows[0]["UserPhone"].ToString();
                this.txtAdProUserEmail.Text = dt.Rows[0]["UserEmail"].ToString();
                this.txtAdProSalary.Text = dt.Rows[0]["Salary"].ToString();
                this.dtpAdProUserDOB.Value = Convert.ToDateTime(dt.Rows[0]["UserDOB"]);
                this.txtAdProJoiningDate.Text =Convert.ToDateTime(dt.Rows[0]["JoiningDate"]).ToString("yyyy-MM-dd");
                this.txtAdProUserRole.Text = dt.Rows[0]["UserRole"].ToString();
                this.txtAdProUserPassword.Text = dt.Rows[0]["UserPassword"].ToString();
                return;
                
            }


        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtAdProUserName.Text) || 
                string.IsNullOrEmpty(this.txtAdProUserPhone.Text) ||
                string.IsNullOrEmpty(this.txtAdProUserEmail.Text) ||
                string.IsNullOrEmpty(this.dtpAdProUserDOB.Text))

            { return false; }

            else
            { return true; }
        }

        private void btnAdProSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from Users where UserId = '" + this.txtAdProUserID.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update users
                                set UserName = '" + this.txtAdProUserName.Text + @"',
                                    UserPhone = '" + this.txtAdProUserPhone.Text + @"',
                                    UserEmail = '" + this.txtAdProUserEmail.Text + @"',
                                    UserDOB = '" + this.dtpAdProUserDOB.Value.ToString("yyyy-MM-dd") + @"'
                                    
                                    where UserId = '" + this.txtAdProUserID.Text + "'; ";

                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated in the list");
                    else
                        MessageBox.Show("Data hasn't been updated in the list");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
            }

        }
    }
}
