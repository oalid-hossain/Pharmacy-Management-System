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
    
    public partial class LogInWindow : Form
    {
        public DataAccess Da { get; set; }
        public LogInWindow()
        {
            InitializeComponent();
            this.Da = new DataAccess();

        }


        private void chkLwShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLwShowPassword.Checked == true) 
            {
                this.txtLwPassword.UseSystemPasswordChar = false;
                return;
            }
            if (chkLwShowPassword.Checked == false) 
            {
                this.txtLwPassword.UseSystemPasswordChar= true;
                return;
            }
        }

        private void btnLogWinClear_Click(object sender, EventArgs e)
        {
            this.txtLwUserName.Clear();
            this.txtLwPassword.Clear();
            this.chkLwShowPassword.Checked = false;
            this.lblLwErrorUserName.Text = string.Empty;
            this.lblLwErrorPassword.Text = string.Empty;


        }

        private void btnLogWinSignIn_Click(object sender, EventArgs e)
        {
            

            string username = txtLwUserName.Text.Trim();
            string password = txtLwPassword.Text.Trim();

            // 🔴 1. Empty validation first
            if (string.IsNullOrEmpty(username))
            {
                this.lblLwErrorUserName.Text = "Username is required";
                this.lblLwErrorPassword.Text= string.Empty;
            }
            else if (string.IsNullOrEmpty(password))
            {
                this.lblLwErrorPassword.Text = "Password is required";
                this.lblLwErrorUserName.Text= string.Empty;
            }
            else
            {
                
                // 🔵 STEP 1: Check username exists or not
                DataTable dtUser = Da.ExecuteQueryTable("SELECT * FROM users WHERE UserRole = '" + username + "';");

                if(dtUser.Rows.Count>0)
                {
                    // 🔵 STEP 2: Check username + password together
                    DataTable dtLogin =Da.ExecuteQueryTable("SELECT * FROM users WHERE UserRole = '" + username + "' AND UserPassword = '" + password + "';");

                    if (dtLogin.Rows.Count > 0)
                    {
                       // string adminName = dtLogin.Rows[0]["UserName"].ToString();
                        string role = dtLogin.Rows[0]["UserRole"].ToString();
                        if(role=="Admin")
                        {
                            AdminWindow ad = new AdminWindow();
                            ad.Show();
                            this.Hide();
                            return;
                        }

                        

                       
                    }
                    else
                    {
                        this.lblLwErrorPassword.Text="Invalid Password";
                        this.lblLwErrorUserName.Text=string.Empty;
                    }
                }
                else 
                {
                    this.lblLwErrorUserName.Text="Invalid Username";
                    this.lblLwErrorPassword.Text=string.Empty;
                }
            }

        }

        private void btnLogWinClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogWinMinimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogWinFullScreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnLogWinFullScreen.Text = "Full Screen";   // back to normal
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnLogWinFullScreen.Text = "Restore";       // now full screen
            }
        }
    }
}
