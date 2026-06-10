namespace AvisSystem
{
    partial class AddClaim
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClaim));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdatePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBranchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageClaimsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClaimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateClaimsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signUpEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cLAIMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avisDS1 = new AvisSystem.AvisDS();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bOOKINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dsBook = new AvisSystem.AvisDSTableAdapters.BOOKINGTableAdapter();
            this.cLAIMTableAdapter = new AvisSystem.AvisDSTableAdapters.CLAIMTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLAIMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avisDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKINGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageCustomersToolStripMenuItem,
            this.manageBookingToolStripMenuItem,
            this.manageRentalsToolStripMenuItem,
            this.manageVehicleToolStripMenuItem,
            this.processPaymentToolStripMenuItem,
            this.manageBranchesToolStripMenuItem,
            this.manageClaimsToolStripMenuItem,
            this.manageEmployeesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(256, 503);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.loginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loginToolStripMenuItem.Image")));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // manageCustomersToolStripMenuItem
            // 
            this.manageCustomersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.viewUpdateCustomersToolStripMenuItem});
            this.manageCustomersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageCustomersToolStripMenuItem.Name = "manageCustomersToolStripMenuItem";
            this.manageCustomersToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.manageCustomersToolStripMenuItem.Text = "👥 Manage Customers";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // viewUpdateCustomersToolStripMenuItem
            // 
            this.viewUpdateCustomersToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateCustomersToolStripMenuItem.Name = "viewUpdateCustomersToolStripMenuItem";
            this.viewUpdateCustomersToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.viewUpdateCustomersToolStripMenuItem.Text = "View/Update Customers";
            this.viewUpdateCustomersToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateCustomersToolStripMenuItem_Click);
            // 
            // manageBookingToolStripMenuItem
            // 
            this.manageBookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookingToolStripMenuItem,
            this.viewUpdateBookingsToolStripMenuItem});
            this.manageBookingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageBookingToolStripMenuItem.Name = "manageBookingToolStripMenuItem";
            this.manageBookingToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.manageBookingToolStripMenuItem.Text = "📅 Manage Booking";
            this.manageBookingToolStripMenuItem.Click += new System.EventHandler(this.manageBookingToolStripMenuItem_Click);
            // 
            // addNewBookingToolStripMenuItem
            // 
            this.addNewBookingToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewBookingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addNewBookingToolStripMenuItem.Name = "addNewBookingToolStripMenuItem";
            this.addNewBookingToolStripMenuItem.Size = new System.Drawing.Size(312, 34);
            this.addNewBookingToolStripMenuItem.Text = "Add New Booking";
            this.addNewBookingToolStripMenuItem.Click += new System.EventHandler(this.addNewBookingToolStripMenuItem_Click);
            // 
            // viewUpdateBookingsToolStripMenuItem
            // 
            this.viewUpdateBookingsToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateBookingsToolStripMenuItem.Name = "viewUpdateBookingsToolStripMenuItem";
            this.viewUpdateBookingsToolStripMenuItem.Size = new System.Drawing.Size(312, 34);
            this.viewUpdateBookingsToolStripMenuItem.Text = "View/Update Bookings";
            this.viewUpdateBookingsToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateBookingsToolStripMenuItem_Click);
            // 
            // manageRentalsToolStripMenuItem
            // 
            this.manageRentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRentalToolStripMenuItem,
            this.viewUpdateRentalsToolStripMenuItem});
            this.manageRentalsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageRentalsToolStripMenuItem.Name = "manageRentalsToolStripMenuItem";
            this.manageRentalsToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.manageRentalsToolStripMenuItem.Text = "🔑 Manage Rentals";
            // 
            // addNewRentalToolStripMenuItem
            // 
            this.addNewRentalToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewRentalToolStripMenuItem.Name = "addNewRentalToolStripMenuItem";
            this.addNewRentalToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.addNewRentalToolStripMenuItem.Text = "Add New Rental";
            this.addNewRentalToolStripMenuItem.Click += new System.EventHandler(this.addNewRentalToolStripMenuItem_Click);
            // 
            // viewUpdateRentalsToolStripMenuItem
            // 
            this.viewUpdateRentalsToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateRentalsToolStripMenuItem.Name = "viewUpdateRentalsToolStripMenuItem";
            this.viewUpdateRentalsToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.viewUpdateRentalsToolStripMenuItem.Text = "View/Update Rentals";
            this.viewUpdateRentalsToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateRentalsToolStripMenuItem_Click);
            // 
            // manageVehicleToolStripMenuItem
            // 
            this.manageVehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewVehicleToolStripMenuItem,
            this.viewUpdateVehiclesToolStripMenuItem});
            this.manageVehicleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageVehicleToolStripMenuItem.Name = "manageVehicleToolStripMenuItem";
            this.manageVehicleToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.manageVehicleToolStripMenuItem.Text = "🚗 Manage Vehicle";
            // 
            // addNewVehicleToolStripMenuItem
            // 
            this.addNewVehicleToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewVehicleToolStripMenuItem.Name = "addNewVehicleToolStripMenuItem";
            this.addNewVehicleToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.addNewVehicleToolStripMenuItem.Text = "Add New Vehicle";
            this.addNewVehicleToolStripMenuItem.Click += new System.EventHandler(this.addNewVehicleToolStripMenuItem_Click);
            // 
            // viewUpdateVehiclesToolStripMenuItem
            // 
            this.viewUpdateVehiclesToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateVehiclesToolStripMenuItem.Name = "viewUpdateVehiclesToolStripMenuItem";
            this.viewUpdateVehiclesToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.viewUpdateVehiclesToolStripMenuItem.Text = "View/Update Vehicles";
            this.viewUpdateVehiclesToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateVehiclesToolStripMenuItem_Click);
            // 
            // processPaymentToolStripMenuItem
            // 
            this.processPaymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPaymentToolStripMenuItem,
            this.viewUpdatePaymentToolStripMenuItem});
            this.processPaymentToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.processPaymentToolStripMenuItem.Name = "processPaymentToolStripMenuItem";
            this.processPaymentToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.processPaymentToolStripMenuItem.Text = "💰 Process Payment";
            // 
            // addNewPaymentToolStripMenuItem
            // 
            this.addNewPaymentToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewPaymentToolStripMenuItem.Name = "addNewPaymentToolStripMenuItem";
            this.addNewPaymentToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.addNewPaymentToolStripMenuItem.Text = "Add New Payment";
            this.addNewPaymentToolStripMenuItem.Click += new System.EventHandler(this.addNewPaymentToolStripMenuItem_Click);
            // 
            // viewUpdatePaymentToolStripMenuItem
            // 
            this.viewUpdatePaymentToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdatePaymentToolStripMenuItem.Name = "viewUpdatePaymentToolStripMenuItem";
            this.viewUpdatePaymentToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.viewUpdatePaymentToolStripMenuItem.Text = "View/Update Payment";
            this.viewUpdatePaymentToolStripMenuItem.Click += new System.EventHandler(this.viewUpdatePaymentToolStripMenuItem_Click);
            // 
            // manageBranchesToolStripMenuItem
            // 
            this.manageBranchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBranchToolStripMenuItem,
            this.viewUpdateBranchToolStripMenuItem});
            this.manageBranchesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageBranchesToolStripMenuItem.Name = "manageBranchesToolStripMenuItem";
            this.manageBranchesToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.manageBranchesToolStripMenuItem.Text = "🏢 Manage Branches";
            // 
            // addNewBranchToolStripMenuItem
            // 
            this.addNewBranchToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewBranchToolStripMenuItem.Name = "addNewBranchToolStripMenuItem";
            this.addNewBranchToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.addNewBranchToolStripMenuItem.Text = "Add New Branch";
            this.addNewBranchToolStripMenuItem.Click += new System.EventHandler(this.addNewBranchToolStripMenuItem_Click);
            // 
            // viewUpdateBranchToolStripMenuItem
            // 
            this.viewUpdateBranchToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateBranchToolStripMenuItem.Name = "viewUpdateBranchToolStripMenuItem";
            this.viewUpdateBranchToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.viewUpdateBranchToolStripMenuItem.Text = "View/Update Branch";
            this.viewUpdateBranchToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateBranchToolStripMenuItem_Click);
            // 
            // manageClaimsToolStripMenuItem
            // 
            this.manageClaimsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewClaimToolStripMenuItem,
            this.viewUpdateClaimsToolStripMenuItem});
            this.manageClaimsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageClaimsToolStripMenuItem.Name = "manageClaimsToolStripMenuItem";
            this.manageClaimsToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.manageClaimsToolStripMenuItem.Text = "📋 Manage Claims";
            // 
            // addNewClaimToolStripMenuItem
            // 
            this.addNewClaimToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewClaimToolStripMenuItem.Name = "addNewClaimToolStripMenuItem";
            this.addNewClaimToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.addNewClaimToolStripMenuItem.Text = "Add New Claim";
            // 
            // viewUpdateClaimsToolStripMenuItem
            // 
            this.viewUpdateClaimsToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateClaimsToolStripMenuItem.Name = "viewUpdateClaimsToolStripMenuItem";
            this.viewUpdateClaimsToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.viewUpdateClaimsToolStripMenuItem.Text = "View/Update Claims";
            this.viewUpdateClaimsToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateClaimsToolStripMenuItem_Click);
            // 
            // manageEmployeesToolStripMenuItem
            // 
            this.manageEmployeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signUpEmployeeToolStripMenuItem,
            this.manageEmployeeToolStripMenuItem});
            this.manageEmployeesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageEmployeesToolStripMenuItem.Name = "manageEmployeesToolStripMenuItem";
            this.manageEmployeesToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.manageEmployeesToolStripMenuItem.Text = "👥 Manage Employees";
            // 
            // signUpEmployeeToolStripMenuItem
            // 
            this.signUpEmployeeToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.signUpEmployeeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signUpEmployeeToolStripMenuItem.Name = "signUpEmployeeToolStripMenuItem";
            this.signUpEmployeeToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.signUpEmployeeToolStripMenuItem.Text = "Sign Up Employee";
            this.signUpEmployeeToolStripMenuItem.Click += new System.EventHandler(this.signUpEmployeeToolStripMenuItem_Click);
            // 
            // manageEmployeeToolStripMenuItem
            // 
            this.manageEmployeeToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            this.manageEmployeeToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.manageEmployeeToolStripMenuItem.Text = "Manage Employee";
            this.manageEmployeeToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeeToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(256, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 503);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Claim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(232, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(349, 73);
            this.label7.TabIndex = 45;
            this.label7.Text = "New Claim";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 310);
            this.dateTimePicker1.MinDate = new System.DateTime(2026, 6, 9, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 31);
            this.dateTimePicker1.TabIndex = 44;
            this.dateTimePicker1.Value = new System.DateTime(2026, 6, 9, 21, 59, 39, 0);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(22, 236);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 30);
            this.textBox1.TabIndex = 43;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(403, 310);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(303, 31);
            this.textBox3.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(398, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Responsible Party:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(601, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 83);
            this.button1.TabIndex = 40;
            this.button1.Text = "+ Add Claim";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(298, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 83);
            this.button2.TabIndex = 39;
            this.button2.Text = " Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.LightCyan;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(22, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 83);
            this.button3.TabIndex = 38;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(403, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(303, 31);
            this.textBox2.TabIndex = 37;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.cLAIMBindingSource;
            this.comboBox2.DisplayMember = "ClaimStatus";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(403, 233);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(303, 33);
            this.comboBox2.TabIndex = 34;
            this.comboBox2.ValueMember = "ClaimStatus";
            // 
            // cLAIMBindingSource
            // 
            this.cLAIMBindingSource.DataMember = "CLAIM";
            this.cLAIMBindingSource.DataSource = this.avisDS1;
            // 
            // avisDS1
            // 
            this.avisDS1.DataSetName = "AvisDS";
            this.avisDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(398, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Claim Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Claim Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Claim Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Claim Description:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bOOKINGBindingSource;
            this.comboBox1.DisplayMember = "BookingID";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 33);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.ValueMember = "BookingID";
            // 
            // bOOKINGBindingSource
            // 
            this.bOOKINGBindingSource.DataMember = "BOOKING";
            this.bOOKINGBindingSource.DataSource = this.avisDS1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Booking_ID:";
            // 
            // dsBook
            // 
            this.dsBook.ClearBeforeFill = true;
            // 
            // cLAIMTableAdapter
            // 
            this.cLAIMTableAdapter.ClearBeforeFill = true;
            // 
            // AddClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1039, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddClaim";
            this.Text = "AddClaim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddClaim_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLAIMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avisDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKINGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdatePaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBranchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBranchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateBranchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageClaimsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewClaimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateClaimsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource bOOKINGBindingSource;
        private AvisDS avisDS1;
        private AvisDSTableAdapters.BOOKINGTableAdapter dsBook;
        private System.Windows.Forms.BindingSource cLAIMBindingSource;
        private AvisDSTableAdapters.CLAIMTableAdapter cLAIMTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signUpEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}