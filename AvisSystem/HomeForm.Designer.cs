namespace AvisSystem
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCustomerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewScheduledReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVehiclesStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageClaimsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClaimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClaimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBranchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Navy;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageCustomerToolStripMenuItem1,
            this.manageReservationToolStripMenuItem,
            this.manageRentalsToolStripMenuItem,
            this.manageVehiclesToolStripMenuItem,
            this.processPaymentToolStripMenuItem,
            this.manageClaimsToolStripMenuItem,
            this.manageBranchesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(210, 499);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.fileToolStripMenuItem.Text = "User";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loginToolStripMenuItem.Image")));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click_1);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // manageCustomerToolStripMenuItem1
            // 
            this.manageCustomerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.viewUpdateCustomerToolStripMenuItem});
            this.manageCustomerToolStripMenuItem1.Enabled = false;
            this.manageCustomerToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCustomerToolStripMenuItem1.Name = "manageCustomerToolStripMenuItem1";
            this.manageCustomerToolStripMenuItem1.Size = new System.Drawing.Size(197, 34);
            this.manageCustomerToolStripMenuItem1.Text = "Manage Customer";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(314, 34);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            // 
            // viewUpdateCustomerToolStripMenuItem
            // 
            this.viewUpdateCustomerToolStripMenuItem.Name = "viewUpdateCustomerToolStripMenuItem";
            this.viewUpdateCustomerToolStripMenuItem.Size = new System.Drawing.Size(314, 34);
            this.viewUpdateCustomerToolStripMenuItem.Text = "View/Update Customer";
            // 
            // manageReservationToolStripMenuItem
            // 
            this.manageReservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReservationToolStripMenuItem,
            this.viewScheduledReservationToolStripMenuItem});
            this.manageReservationToolStripMenuItem.Enabled = false;
            this.manageReservationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageReservationToolStripMenuItem.Name = "manageReservationToolStripMenuItem";
            this.manageReservationToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.manageReservationToolStripMenuItem.Text = "Manage Booking";
            // 
            // addReservationToolStripMenuItem
            // 
            this.addReservationToolStripMenuItem.Name = "addReservationToolStripMenuItem";
            this.addReservationToolStripMenuItem.Size = new System.Drawing.Size(411, 34);
            this.addReservationToolStripMenuItem.Text = "Add Booking";
            // 
            // viewScheduledReservationToolStripMenuItem
            // 
            this.viewScheduledReservationToolStripMenuItem.Name = "viewScheduledReservationToolStripMenuItem";
            this.viewScheduledReservationToolStripMenuItem.Size = new System.Drawing.Size(411, 34);
            this.viewScheduledReservationToolStripMenuItem.Text = "View/Update Scheduled Booking";
            // 
            // manageRentalsToolStripMenuItem
            // 
            this.manageRentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRentalsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.manageRentalsToolStripMenuItem.Enabled = false;
            this.manageRentalsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageRentalsToolStripMenuItem.Name = "manageRentalsToolStripMenuItem";
            this.manageRentalsToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.manageRentalsToolStripMenuItem.Text = "Manage Rentals";
            // 
            // addRentalsToolStripMenuItem
            // 
            this.addRentalsToolStripMenuItem.Name = "addRentalsToolStripMenuItem";
            this.addRentalsToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.addRentalsToolStripMenuItem.Text = "Add Rentals";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.viewToolStripMenuItem.Text = "View/Update Rentals";
            // 
            // manageVehiclesToolStripMenuItem
            // 
            this.manageVehiclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicleToolStripMenuItem,
            this.viewVehiclesStatusToolStripMenuItem});
            this.manageVehiclesToolStripMenuItem.Enabled = false;
            this.manageVehiclesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageVehiclesToolStripMenuItem.Name = "manageVehiclesToolStripMenuItem";
            this.manageVehiclesToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.manageVehiclesToolStripMenuItem.Text = "Manage Vehicles";
            // 
            // addVehicleToolStripMenuItem
            // 
            this.addVehicleToolStripMenuItem.Name = "addVehicleToolStripMenuItem";
            this.addVehicleToolStripMenuItem.Size = new System.Drawing.Size(365, 34);
            this.addVehicleToolStripMenuItem.Text = "Add Vehicle";
            // 
            // viewVehiclesStatusToolStripMenuItem
            // 
            this.viewVehiclesStatusToolStripMenuItem.Name = "viewVehiclesStatusToolStripMenuItem";
            this.viewVehiclesStatusToolStripMenuItem.Size = new System.Drawing.Size(365, 34);
            this.viewVehiclesStatusToolStripMenuItem.Text = "View/Update Vehicles Status";
            // 
            // processPaymentToolStripMenuItem
            // 
            this.processPaymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPaymentToolStripMenuItem,
            this.viewPaymentsToolStripMenuItem});
            this.processPaymentToolStripMenuItem.Enabled = false;
            this.processPaymentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processPaymentToolStripMenuItem.Name = "processPaymentToolStripMenuItem";
            this.processPaymentToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.processPaymentToolStripMenuItem.Text = "Process Payment";
            // 
            // addPaymentToolStripMenuItem
            // 
            this.addPaymentToolStripMenuItem.Name = "addPaymentToolStripMenuItem";
            this.addPaymentToolStripMenuItem.Size = new System.Drawing.Size(314, 34);
            this.addPaymentToolStripMenuItem.Text = "Add Payment";
            // 
            // viewPaymentsToolStripMenuItem
            // 
            this.viewPaymentsToolStripMenuItem.Name = "viewPaymentsToolStripMenuItem";
            this.viewPaymentsToolStripMenuItem.Size = new System.Drawing.Size(314, 34);
            this.viewPaymentsToolStripMenuItem.Text = "View/Update Payments";
            // 
            // manageClaimsToolStripMenuItem
            // 
            this.manageClaimsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClaimToolStripMenuItem,
            this.updateClaimToolStripMenuItem});
            this.manageClaimsToolStripMenuItem.Enabled = false;
            this.manageClaimsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageClaimsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageClaimsToolStripMenuItem.Name = "manageClaimsToolStripMenuItem";
            this.manageClaimsToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.manageClaimsToolStripMenuItem.Text = "Manage Claims";
            // 
            // addClaimToolStripMenuItem
            // 
            this.addClaimToolStripMenuItem.Name = "addClaimToolStripMenuItem";
            this.addClaimToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.addClaimToolStripMenuItem.Text = "Add Claim";
            // 
            // updateClaimToolStripMenuItem
            // 
            this.updateClaimToolStripMenuItem.Name = "updateClaimToolStripMenuItem";
            this.updateClaimToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.updateClaimToolStripMenuItem.Text = "View/Update Claim";
            // 
            // manageBranchesToolStripMenuItem
            // 
            this.manageBranchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBranchToolStripMenuItem,
            this.updateBranchToolStripMenuItem});
            this.manageBranchesToolStripMenuItem.Enabled = false;
            this.manageBranchesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBranchesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageBranchesToolStripMenuItem.Name = "manageBranchesToolStripMenuItem";
            this.manageBranchesToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.manageBranchesToolStripMenuItem.Text = "Manage Branches";
            // 
            // addBranchToolStripMenuItem
            // 
            this.addBranchToolStripMenuItem.Name = "addBranchToolStripMenuItem";
            this.addBranchToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.addBranchToolStripMenuItem.Text = "Add Branch";
            // 
            // updateBranchToolStripMenuItem
            // 
            this.updateBranchToolStripMenuItem.Name = "updateBranchToolStripMenuItem";
            this.updateBranchToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.updateBranchToolStripMenuItem.Text = "View/Update Branch";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(621, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 108);
            this.label1.TabIndex = 6;
            this.label1.Text = "00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 499);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewScheduledReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVehiclesStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCustomerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageClaimsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClaimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClaimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBranchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBranchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBranchToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}