namespace Pharmacy_Management_System
{
    partial class AdminWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdWinWelcomeName = new System.Windows.Forms.Label();
            this.btnAdWinLogOut = new System.Windows.Forms.Button();
            this.btnAdWinViewSalesDetails = new System.Windows.Forms.Button();
            this.btnAdWinManageMedicine = new System.Windows.Forms.Button();
            this.btnAdWinViewProfile = new System.Windows.Forms.Button();
            this.btnAdWinManageUser = new System.Windows.Forms.Button();
            this.btnAdminDashBoard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdWinSeePurchaseHistory = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAdWinMinimize = new System.Windows.Forms.Button();
            this.btnAdWinFullScreen = new System.Windows.Forms.Button();
            this.btnAdWinClose = new System.Windows.Forms.Button();
            this.dgvAdminWindow = new System.Windows.Forms.DataGridView();
            this.MedicineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdWinStockOutMedicine = new System.Windows.Forms.Button();
            this.btnAdWinExpiredMedicine = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAdWinTotalUserCount = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAdWinTotalCost = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminWindow)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAdWinWelcomeName);
            this.panel1.Controls.Add(this.btnAdWinLogOut);
            this.panel1.Controls.Add(this.btnAdWinViewSalesDetails);
            this.panel1.Controls.Add(this.btnAdWinManageMedicine);
            this.panel1.Controls.Add(this.btnAdWinViewProfile);
            this.panel1.Controls.Add(this.btnAdWinManageUser);
            this.panel1.Controls.Add(this.btnAdminDashBoard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 746);
            this.panel1.TabIndex = 0;
            // 
            // lblAdWinWelcomeName
            // 
            this.lblAdWinWelcomeName.AutoSize = true;
            this.lblAdWinWelcomeName.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdWinWelcomeName.Location = new System.Drawing.Point(189, 74);
            this.lblAdWinWelcomeName.Name = "lblAdWinWelcomeName";
            this.lblAdWinWelcomeName.Size = new System.Drawing.Size(121, 20);
            this.lblAdWinWelcomeName.TabIndex = 8;
            this.lblAdWinWelcomeName.Text = "admin name";
            // 
            // btnAdWinLogOut
            // 
            this.btnAdWinLogOut.Location = new System.Drawing.Point(66, 625);
            this.btnAdWinLogOut.Name = "btnAdWinLogOut";
            this.btnAdWinLogOut.Size = new System.Drawing.Size(113, 36);
            this.btnAdWinLogOut.TabIndex = 7;
            this.btnAdWinLogOut.Text = "Log out";
            this.btnAdWinLogOut.UseVisualStyleBackColor = true;
            this.btnAdWinLogOut.Click += new System.EventHandler(this.btnAdWinLogOut_Click);
            // 
            // btnAdWinViewSalesDetails
            // 
            this.btnAdWinViewSalesDetails.Location = new System.Drawing.Point(126, 483);
            this.btnAdWinViewSalesDetails.Name = "btnAdWinViewSalesDetails";
            this.btnAdWinViewSalesDetails.Size = new System.Drawing.Size(168, 62);
            this.btnAdWinViewSalesDetails.TabIndex = 6;
            this.btnAdWinViewSalesDetails.TabStop = false;
            this.btnAdWinViewSalesDetails.Text = "View Sales Details";
            this.btnAdWinViewSalesDetails.UseVisualStyleBackColor = true;
            this.btnAdWinViewSalesDetails.Click += new System.EventHandler(this.btnAdWinViewSalesDetails_Click);
            // 
            // btnAdWinManageMedicine
            // 
            this.btnAdWinManageMedicine.Location = new System.Drawing.Point(126, 412);
            this.btnAdWinManageMedicine.Name = "btnAdWinManageMedicine";
            this.btnAdWinManageMedicine.Size = new System.Drawing.Size(168, 62);
            this.btnAdWinManageMedicine.TabIndex = 5;
            this.btnAdWinManageMedicine.TabStop = false;
            this.btnAdWinManageMedicine.Text = "Manage Medicine";
            this.btnAdWinManageMedicine.UseVisualStyleBackColor = true;
            this.btnAdWinManageMedicine.Click += new System.EventHandler(this.btnAdWinManageMedicine_Click);
            // 
            // btnAdWinViewProfile
            // 
            this.btnAdWinViewProfile.Location = new System.Drawing.Point(126, 270);
            this.btnAdWinViewProfile.Name = "btnAdWinViewProfile";
            this.btnAdWinViewProfile.Size = new System.Drawing.Size(168, 62);
            this.btnAdWinViewProfile.TabIndex = 4;
            this.btnAdWinViewProfile.TabStop = false;
            this.btnAdWinViewProfile.Text = "View Profile";
            this.btnAdWinViewProfile.UseVisualStyleBackColor = true;
            this.btnAdWinViewProfile.Click += new System.EventHandler(this.btnAdWinViewProfile_Click);
            // 
            // btnAdWinManageUser
            // 
            this.btnAdWinManageUser.Location = new System.Drawing.Point(126, 341);
            this.btnAdWinManageUser.Name = "btnAdWinManageUser";
            this.btnAdWinManageUser.Size = new System.Drawing.Size(168, 62);
            this.btnAdWinManageUser.TabIndex = 3;
            this.btnAdWinManageUser.TabStop = false;
            this.btnAdWinManageUser.Text = "Manage User";
            this.btnAdWinManageUser.UseVisualStyleBackColor = true;
            this.btnAdWinManageUser.Click += new System.EventHandler(this.btnAdWinManageUser_Click);
            // 
            // btnAdminDashBoard
            // 
            this.btnAdminDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDashBoard.Location = new System.Drawing.Point(126, 199);
            this.btnAdminDashBoard.Name = "btnAdminDashBoard";
            this.btnAdminDashBoard.Size = new System.Drawing.Size(168, 62);
            this.btnAdminDashBoard.TabIndex = 2;
            this.btnAdminDashBoard.Text = "Dash Board";
            this.btnAdminDashBoard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdWinSeePurchaseHistory);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.dgvAdminWindow);
            this.panel2.Controls.Add(this.btnAdWinStockOutMedicine);
            this.panel2.Controls.Add(this.btnAdWinExpiredMedicine);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(440, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 746);
            this.panel2.TabIndex = 1;
            // 
            // btnAdWinSeePurchaseHistory
            // 
            this.btnAdWinSeePurchaseHistory.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdWinSeePurchaseHistory.Location = new System.Drawing.Point(379, 267);
            this.btnAdWinSeePurchaseHistory.Name = "btnAdWinSeePurchaseHistory";
            this.btnAdWinSeePurchaseHistory.Size = new System.Drawing.Size(194, 56);
            this.btnAdWinSeePurchaseHistory.TabIndex = 15;
            this.btnAdWinSeePurchaseHistory.Text = "See Purchase History";
            this.btnAdWinSeePurchaseHistory.UseVisualStyleBackColor = true;
            this.btnAdWinSeePurchaseHistory.Click += new System.EventHandler(this.btnAdWinSeePurchaseHistory_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnAdWinMinimize);
            this.panel6.Controls.Add(this.btnAdWinFullScreen);
            this.panel6.Controls.Add(this.btnAdWinClose);
            this.panel6.Location = new System.Drawing.Point(671, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(274, 26);
            this.panel6.TabIndex = 14;
            // 
            // btnAdWinMinimize
            // 
            this.btnAdWinMinimize.Location = new System.Drawing.Point(0, 3);
            this.btnAdWinMinimize.Name = "btnAdWinMinimize";
            this.btnAdWinMinimize.Size = new System.Drawing.Size(75, 23);
            this.btnAdWinMinimize.TabIndex = 2;
            this.btnAdWinMinimize.Text = "Minimize";
            this.btnAdWinMinimize.UseVisualStyleBackColor = true;
            this.btnAdWinMinimize.Click += new System.EventHandler(this.btnAdWinMinimize_Click);
            // 
            // btnAdWinFullScreen
            // 
            this.btnAdWinFullScreen.Location = new System.Drawing.Point(81, 3);
            this.btnAdWinFullScreen.Name = "btnAdWinFullScreen";
            this.btnAdWinFullScreen.Size = new System.Drawing.Size(105, 23);
            this.btnAdWinFullScreen.TabIndex = 1;
            this.btnAdWinFullScreen.Text = "Full Screen";
            this.btnAdWinFullScreen.UseVisualStyleBackColor = true;
            this.btnAdWinFullScreen.Click += new System.EventHandler(this.btnAdWinFullScreen_Click);
            // 
            // btnAdWinClose
            // 
            this.btnAdWinClose.Location = new System.Drawing.Point(192, 3);
            this.btnAdWinClose.Name = "btnAdWinClose";
            this.btnAdWinClose.Size = new System.Drawing.Size(75, 23);
            this.btnAdWinClose.TabIndex = 0;
            this.btnAdWinClose.Text = "Close";
            this.btnAdWinClose.UseVisualStyleBackColor = true;
            this.btnAdWinClose.Click += new System.EventHandler(this.btnAdWinClose_Click);
            // 
            // dgvAdminWindow
            // 
            this.dgvAdminWindow.AllowUserToAddRows = false;
            this.dgvAdminWindow.AllowUserToDeleteRows = false;
            this.dgvAdminWindow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminWindow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineId,
            this.MedicineName,
            this.Category,
            this.PurchaseId,
            this.PurchaseDate,
            this.PurchasePrice,
            this.SellPrice,
            this.Quantity,
            this.ExpiryDate,
            this.SupplierId});
            this.dgvAdminWindow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAdminWindow.Location = new System.Drawing.Point(0, 329);
            this.dgvAdminWindow.Name = "dgvAdminWindow";
            this.dgvAdminWindow.ReadOnly = true;
            this.dgvAdminWindow.RowHeadersWidth = 51;
            this.dgvAdminWindow.RowTemplate.Height = 24;
            this.dgvAdminWindow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminWindow.Size = new System.Drawing.Size(948, 417);
            this.dgvAdminWindow.TabIndex = 13;
            // 
            // MedicineId
            // 
            this.MedicineId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineId.DataPropertyName = "MedicineId";
            this.MedicineId.HeaderText = "Medicine Id";
            this.MedicineId.MinimumWidth = 6;
            this.MedicineId.Name = "MedicineId";
            this.MedicineId.ReadOnly = true;
            // 
            // MedicineName
            // 
            this.MedicineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineName.DataPropertyName = "MedicineName";
            this.MedicineName.HeaderText = "Medicine Name";
            this.MedicineName.MinimumWidth = 6;
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // PurchaseId
            // 
            this.PurchaseId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PurchaseId.DataPropertyName = "PurchaseId";
            this.PurchaseId.HeaderText = "Purchase Id";
            this.PurchaseId.MinimumWidth = 6;
            this.PurchaseId.Name = "PurchaseId";
            this.PurchaseId.ReadOnly = true;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PurchaseDate.DataPropertyName = "PurchaseDate";
            this.PurchaseDate.HeaderText = "Purchase Date";
            this.PurchaseDate.MinimumWidth = 6;
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            this.PurchasePrice.HeaderText = "Purchase Price";
            this.PurchasePrice.MinimumWidth = 6;
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            // 
            // SellPrice
            // 
            this.SellPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SellPrice.DataPropertyName = "SellPrice";
            this.SellPrice.HeaderText = "Sell Price";
            this.SellPrice.MinimumWidth = 6;
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExpiryDate.DataPropertyName = "ExpiryDate";
            this.ExpiryDate.HeaderText = "Expiry Date";
            this.ExpiryDate.MinimumWidth = 6;
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.ReadOnly = true;
            // 
            // SupplierId
            // 
            this.SupplierId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierId.DataPropertyName = "SupplierId";
            this.SupplierId.HeaderText = "Supplier Id";
            this.SupplierId.MinimumWidth = 6;
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.ReadOnly = true;
            // 
            // btnAdWinStockOutMedicine
            // 
            this.btnAdWinStockOutMedicine.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdWinStockOutMedicine.Location = new System.Drawing.Point(744, 267);
            this.btnAdWinStockOutMedicine.Name = "btnAdWinStockOutMedicine";
            this.btnAdWinStockOutMedicine.Size = new System.Drawing.Size(194, 56);
            this.btnAdWinStockOutMedicine.TabIndex = 12;
            this.btnAdWinStockOutMedicine.Text = "Stock Out Medicine";
            this.btnAdWinStockOutMedicine.UseVisualStyleBackColor = true;
            this.btnAdWinStockOutMedicine.Click += new System.EventHandler(this.btnAdWinStockOutMedicine_Click);
            // 
            // btnAdWinExpiredMedicine
            // 
            this.btnAdWinExpiredMedicine.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdWinExpiredMedicine.Location = new System.Drawing.Point(14, 267);
            this.btnAdWinExpiredMedicine.Name = "btnAdWinExpiredMedicine";
            this.btnAdWinExpiredMedicine.Size = new System.Drawing.Size(194, 56);
            this.btnAdWinExpiredMedicine.TabIndex = 11;
            this.btnAdWinExpiredMedicine.Text = "Expired Medicine";
            this.btnAdWinExpiredMedicine.UseVisualStyleBackColor = true;
            this.btnAdWinExpiredMedicine.Click += new System.EventHandler(this.btnAdWinExpiredMedicine_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.lblAdWinTotalUserCount);
            this.panel5.Location = new System.Drawing.Point(14, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 66);
            this.panel5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total User";
            // 
            // lblAdWinTotalUserCount
            // 
            this.lblAdWinTotalUserCount.AutoSize = true;
            this.lblAdWinTotalUserCount.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdWinTotalUserCount.Location = new System.Drawing.Point(64, 30);
            this.lblAdWinTotalUserCount.Name = "lblAdWinTotalUserCount";
            this.lblAdWinTotalUserCount.Size = new System.Drawing.Size(93, 31);
            this.lblAdWinTotalUserCount.TabIndex = 9;
            this.lblAdWinTotalUserCount.Text = "count";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lblAdWinTotalCost);
            this.panel4.Location = new System.Drawing.Point(14, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 66);
            this.panel4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Cost";
            // 
            // lblAdWinTotalCost
            // 
            this.lblAdWinTotalCost.AutoSize = true;
            this.lblAdWinTotalCost.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdWinTotalCost.Location = new System.Drawing.Point(61, 40);
            this.lblAdWinTotalCost.Name = "lblAdWinTotalCost";
            this.lblAdWinTotalCost.Size = new System.Drawing.Size(49, 19);
            this.lblAdWinTotalCost.TabIndex = 9;
            this.lblAdWinTotalCost.Text = "Cost";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(379, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 66);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Profit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Profit";
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 770);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminWindow)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdWinLogOut;
        private System.Windows.Forms.Button btnAdWinViewSalesDetails;
        private System.Windows.Forms.Button btnAdWinManageMedicine;
        private System.Windows.Forms.Button btnAdWinViewProfile;
        private System.Windows.Forms.Button btnAdWinManageUser;
        private System.Windows.Forms.Button btnAdminDashBoard;
        private System.Windows.Forms.Button btnAdWinExpiredMedicine;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAdWinTotalUserCount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAdWinTotalCost;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAdminWindow;
        private System.Windows.Forms.Button btnAdWinStockOutMedicine;
        private System.Windows.Forms.Label lblAdWinWelcomeName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnAdWinMinimize;
        private System.Windows.Forms.Button btnAdWinFullScreen;
        private System.Windows.Forms.Button btnAdWinClose;
        private System.Windows.Forms.Button btnAdWinSeePurchaseHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
    }
}