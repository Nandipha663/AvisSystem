namespace AvisSystem
{
    partial class ManageInspection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageInspection));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdatePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageClaimsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateClaimsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBranchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBranchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signUpNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageInspectionRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addInspectionRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInspectionDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehicleInspectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avisDS = new AvisSystem.AvisDS();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.vehicle_InspectionTableAdapter = new AvisSystem.AvisDSTableAdapters.Vehicle_InspectionTableAdapter();
            this.inspectionCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleMakeModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odometerReadingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectionDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damageFoundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damageDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectionNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleInspectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avisDS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.manageCustomerToolStripMenuItem,
            this.manageBookingToolStripMenuItem,
            this.manageRentalsToolStripMenuItem,
            this.manageVehiclesToolStripMenuItem,
            this.processPaymentToolStripMenuItem,
            this.manageClaimsToolStripMenuItem,
            this.manageBranchesToolStripMenuItem,
            this.manageEmployeesToolStripMenuItem,
            this.manageInspectionRecordsToolStripMenuItem,
            this.manageRentalsToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(338, 693);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(325, 34);
            this.userToolStripMenuItem.Text = "User";
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
            // manageCustomerToolStripMenuItem
            // 
            this.manageCustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.viewUpdateCustomersToolStripMenuItem});
            this.manageCustomerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCustomerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageCustomerToolStripMenuItem.Name = "manageCustomerToolStripMenuItem";
            this.manageCustomerToolStripMenuItem.Size = new System.Drawing.Size(325, 34);
            this.manageCustomerToolStripMenuItem.Text = "👥  Manage Customer";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.addNewCustomerToolStripMenuItem.Text = "Add New Customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
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
            this.manageBookingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBookingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageBookingToolStripMenuItem.Name = "manageBookingToolStripMenuItem";
            this.manageBookingToolStripMenuItem.Size = new System.Drawing.Size(325, 34);
            this.manageBookingToolStripMenuItem.Text = "📅 Manage Booking";
            // 
            // addNewBookingToolStripMenuItem
            // 
            this.addNewBookingToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
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
            this.manageRentalsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageRentalsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageRentalsToolStripMenuItem.Name = "manageRentalsToolStripMenuItem";
            this.manageRentalsToolStripMenuItem.Size = new System.Drawing.Size(325, 34);
            this.manageRentalsToolStripMenuItem.Text = "🔑 Manage Returned Vehicles";
            // 
            // addNewRentalToolStripMenuItem
            // 
            this.addNewRentalToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewRentalToolStripMenuItem.Name = "addNewRentalToolStripMenuItem";
            this.addNewRentalToolStripMenuItem.Size = new System.Drawing.Size(395, 34);
            this.addNewRentalToolStripMenuItem.Text = "Add New Returned Vehicle";
            this.addNewRentalToolStripMenuItem.Click += new System.EventHandler(this.addNewRentalToolStripMenuItem_Click);
            // 
            // viewUpdateRentalsToolStripMenuItem
            // 
            this.viewUpdateRentalsToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateRentalsToolStripMenuItem.Name = "viewUpdateRentalsToolStripMenuItem";
            this.viewUpdateRentalsToolStripMenuItem.Size = new System.Drawing.Size(395, 34);
            this.viewUpdateRentalsToolStripMenuItem.Text = "View/Update Returned Vehicles";
            this.viewUpdateRentalsToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateRentalsToolStripMenuItem_Click);
            // 
            // manageVehiclesToolStripMenuItem
            // 
            this.manageVehiclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewVehicleToolStripMenuItem,
            this.viToolStripMenuItem});
            this.manageVehiclesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageVehiclesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageVehiclesToolStripMenuItem.Name = "manageVehiclesToolStripMenuItem";
            this.manageVehiclesToolStripMenuItem.Size = new System.Drawing.Size(325, 34);
            this.manageVehiclesToolStripMenuItem.Text = "🚗 Manage Vehicles";
            // 
            // addNewVehicleToolStripMenuItem
            // 
            this.addNewVehicleToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewVehicleToolStripMenuItem.Name = "addNewVehicleToolStripMenuItem";
            this.addNewVehicleToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.addNewVehicleToolStripMenuItem.Text = "Add New Vehicle";
            this.addNewVehicleToolStripMenuItem.Click += new System.EventHandler(this.addNewVehicleToolStripMenuItem_Click);
            // 
            // viToolStripMenuItem
            // 
            this.viToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viToolStripMenuItem.Name = "viToolStripMenuItem";
            this.viToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.viToolStripMenuItem.Text = "View/Update Vehicles";
            this.viToolStripMenuItem.Click += new System.EventHandler(this.viToolStripMenuItem_Click);
            // 
            // processPaymentToolStripMenuItem
            // 
            this.processPaymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPaymentToolStripMenuItem,
            this.viewUpdatePaymentToolStripMenuItem});
            this.processPaymentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processPaymentToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.processPaymentToolStripMenuItem.Name = "processPaymentToolStripMenuItem";
            this.processPaymentToolStripMenuItem.Size = new System.Drawing.Size(325, 34);
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
            // manageClaimsToolStripMenuItem
            // 
            this.manageClaimsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adNewToolStripMenuItem,
            this.viewUpdateClaimsToolStripMenuItem});
            this.manageClaimsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageClaimsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageClaimsToolStripMenuItem.Name = "manageClaimsToolStripMenuItem";
            this.manageClaimsToolStripMenuItem.Size = new System.Drawing.Size(325, 34);
            this.manageClaimsToolStripMenuItem.Text = "📝 Manage Claims";
            // 
            // adNewToolStripMenuItem
            // 
            this.adNewToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.adNewToolStripMenuItem.Name = "adNewToolStripMenuItem";
            this.adNewToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.adNewToolStripMenuItem.Text = "Add New Claim";
            this.adNewToolStripMenuItem.Click += new System.EventHandler(this.adNewToolStripMenuItem_Click);
            // 
            // viewUpdateClaimsToolStripMenuItem
            // 
            this.viewUpdateClaimsToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateClaimsToolStripMenuItem.Name = "viewUpdateClaimsToolStripMenuItem";
            this.viewUpdateClaimsToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.viewUpdateClaimsToolStripMenuItem.Text = "View/Update Claims";
            this.viewUpdateClaimsToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateClaimsToolStripMenuItem_Click);
            // 
            // manageBranchesToolStripMenuItem
            // 
            this.manageBranchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBranchesToolStripMenuItem});
            this.manageBranchesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBranchesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageBranchesToolStripMenuItem.Name = "manageBranchesToolStripMenuItem";
            this.manageBranchesToolStripMenuItem.Size = new System.Drawing.Size(325, 34);
            this.manageBranchesToolStripMenuItem.Text = "🏛️ Branches";
            // 
            // viewBranchesToolStripMenuItem
            // 
            this.viewBranchesToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewBranchesToolStripMenuItem.Name = "viewBranchesToolStripMenuItem";
            this.viewBranchesToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.viewBranchesToolStripMenuItem.Text = "View Active Branches";
            this.viewBranchesToolStripMenuItem.Click += new System.EventHandler(this.viewBranchesToolStripMenuItem_Click);
            // 
            // manageEmployeesToolStripMenuItem
            // 
            this.manageEmployeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signUpNewEmployeeToolStripMenuItem,
            this.viewUpdateEmployeeToolStripMenuItem});
            this.manageEmployeesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageEmployeesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageEmployeesToolStripMenuItem.Name = "manageEmployeesToolStripMenuItem";
            this.manageEmployeesToolStripMenuItem.Size = new System.Drawing.Size(325, 34);
            this.manageEmployeesToolStripMenuItem.Text = "👥 Manage Employees";
            // 
            // signUpNewEmployeeToolStripMenuItem
            // 
            this.signUpNewEmployeeToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.signUpNewEmployeeToolStripMenuItem.Name = "signUpNewEmployeeToolStripMenuItem";
            this.signUpNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(324, 34);
            this.signUpNewEmployeeToolStripMenuItem.Text = "Sign Up New Employee";
            this.signUpNewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.signUpNewEmployeeToolStripMenuItem_Click);
            // 
            // viewUpdateEmployeeToolStripMenuItem
            // 
            this.viewUpdateEmployeeToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateEmployeeToolStripMenuItem.Name = "viewUpdateEmployeeToolStripMenuItem";
            this.viewUpdateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(324, 34);
            this.viewUpdateEmployeeToolStripMenuItem.Text = "View/Update Employees";
            this.viewUpdateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateEmployeeToolStripMenuItem_Click);
            // 
            // manageInspectionRecordsToolStripMenuItem
            // 
            this.manageInspectionRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addInspectionRecordToolStripMenuItem,
            this.viewInspectionDetailsToolStripMenuItem});
            this.manageInspectionRecordsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageInspectionRecordsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageInspectionRecordsToolStripMenuItem.Name = "manageInspectionRecordsToolStripMenuItem";
            this.manageInspectionRecordsToolStripMenuItem.Size = new System.Drawing.Size(325, 34);
            this.manageInspectionRecordsToolStripMenuItem.Text = "📜 Manage Inspection Records";
            // 
            // addInspectionRecordToolStripMenuItem
            // 
            this.addInspectionRecordToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addInspectionRecordToolStripMenuItem.Name = "addInspectionRecordToolStripMenuItem";
            this.addInspectionRecordToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.addInspectionRecordToolStripMenuItem.Text = "Add Inspection Record";
            this.addInspectionRecordToolStripMenuItem.Click += new System.EventHandler(this.addInspectionRecordToolStripMenuItem_Click);
            // 
            // viewInspectionDetailsToolStripMenuItem
            // 
            this.viewInspectionDetailsToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewInspectionDetailsToolStripMenuItem.Name = "viewInspectionDetailsToolStripMenuItem";
            this.viewInspectionDetailsToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.viewInspectionDetailsToolStripMenuItem.Text = "View Inspection Details";
            // 
            // manageRentalsToolStripMenuItem1
            // 
            this.manageRentalsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRentalToolStripMenuItem,
            this.viewUpdateRentalToolStripMenuItem});
            this.manageRentalsToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageRentalsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.manageRentalsToolStripMenuItem1.Name = "manageRentalsToolStripMenuItem1";
            this.manageRentalsToolStripMenuItem1.Size = new System.Drawing.Size(325, 34);
            this.manageRentalsToolStripMenuItem1.Text = "Manage Rentals";
            // 
            // addRentalToolStripMenuItem
            // 
            this.addRentalToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addRentalToolStripMenuItem.Name = "addRentalToolStripMenuItem";
            this.addRentalToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.addRentalToolStripMenuItem.Text = "Add Rental";
            this.addRentalToolStripMenuItem.Click += new System.EventHandler(this.addRentalToolStripMenuItem_Click);
            // 
            // viewUpdateRentalToolStripMenuItem
            // 
            this.viewUpdateRentalToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateRentalToolStripMenuItem.Name = "viewUpdateRentalToolStripMenuItem";
            this.viewUpdateRentalToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.viewUpdateRentalToolStripMenuItem.Text = "View/Update Rental";
            this.viewUpdateRentalToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateRentalToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(338, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1032, 693);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Inspection Details";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(426, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(399, 31);
            this.dateTimePicker1.TabIndex = 68;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(259, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 59);
            this.button1.TabIndex = 67;
            this.button1.Text = " Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.LightCyan;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(31, 425);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(181, 59);
            this.button6.TabIndex = 50;
            this.button6.Text = "🗑️   Delete";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.LightCyan;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(859, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 37);
            this.button4.TabIndex = 59;
            this.button4.Text = "Reset Filter";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(859, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 51);
            this.button5.TabIndex = 66;
            this.button5.Text = "Filter";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Status",
            "Position",
            "BranchID"});
            this.comboBox2.Location = new System.Drawing.Point(588, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(152, 28);
            this.comboBox2.TabIndex = 65;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Status",
            "Position",
            "BranchID"});
            this.comboBox1.Location = new System.Drawing.Point(426, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 28);
            this.comboBox1.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Value:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(435, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 62;
            this.label13.Text = "Filter By:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(11, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 31);
            this.textBox1.TabIndex = 61;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Enter Employee\'s Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(11, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1009, 258);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inspection Details";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inspectionCodeDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.rentalIDDataGridViewTextBoxColumn,
            this.branchNameDataGridViewTextBoxColumn,
            this.vehicleMakeModelDataGridViewTextBoxColumn,
            this.odometerReadingDataGridViewTextBoxColumn,
            this.fuelLevelDataGridViewTextBoxColumn,
            this.inspectionTypeDataGridViewTextBoxColumn,
            this.inspectionDateTimeDataGridViewTextBoxColumn,
            this.damageFoundDataGridViewTextBoxColumn,
            this.damageDescriptionDataGridViewTextBoxColumn,
            this.inspectionNotesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehicleInspectionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(981, 178);
            this.dataGridView1.TabIndex = 49;
            // 
            // vehicleInspectionBindingSource
            // 
            this.vehicleInspectionBindingSource.DataMember = "Vehicle Inspection";
            this.vehicleInspectionBindingSource.DataSource = this.avisDS;
            // 
            // avisDS
            // 
            this.avisDS.DataSetName = "AvisDS";
            this.avisDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 570);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 117);
            this.panel1.TabIndex = 35;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 33);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ask me anything!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(66, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "AI Assistant";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // vehicle_InspectionTableAdapter
            // 
            this.vehicle_InspectionTableAdapter.ClearBeforeFill = true;
            // 
            // inspectionCodeDataGridViewTextBoxColumn
            // 
            this.inspectionCodeDataGridViewTextBoxColumn.DataPropertyName = "InspectionCode";
            this.inspectionCodeDataGridViewTextBoxColumn.HeaderText = "InspectionCode";
            this.inspectionCodeDataGridViewTextBoxColumn.Name = "inspectionCodeDataGridViewTextBoxColumn";
            this.inspectionCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.inspectionCodeDataGridViewTextBoxColumn.Width = 200;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            this.employeeNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Width = 180;
            // 
            // rentalIDDataGridViewTextBoxColumn
            // 
            this.rentalIDDataGridViewTextBoxColumn.DataPropertyName = "RentalID";
            this.rentalIDDataGridViewTextBoxColumn.HeaderText = "RentalID";
            this.rentalIDDataGridViewTextBoxColumn.Name = "rentalIDDataGridViewTextBoxColumn";
            this.rentalIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // branchNameDataGridViewTextBoxColumn
            // 
            this.branchNameDataGridViewTextBoxColumn.DataPropertyName = "BranchName";
            this.branchNameDataGridViewTextBoxColumn.HeaderText = "BranchName";
            this.branchNameDataGridViewTextBoxColumn.Name = "branchNameDataGridViewTextBoxColumn";
            this.branchNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // vehicleMakeModelDataGridViewTextBoxColumn
            // 
            this.vehicleMakeModelDataGridViewTextBoxColumn.DataPropertyName = "VehicleMakeModel";
            this.vehicleMakeModelDataGridViewTextBoxColumn.HeaderText = "VehicleMakeModel";
            this.vehicleMakeModelDataGridViewTextBoxColumn.Name = "vehicleMakeModelDataGridViewTextBoxColumn";
            this.vehicleMakeModelDataGridViewTextBoxColumn.Width = 250;
            // 
            // odometerReadingDataGridViewTextBoxColumn
            // 
            this.odometerReadingDataGridViewTextBoxColumn.DataPropertyName = "OdometerReading";
            this.odometerReadingDataGridViewTextBoxColumn.HeaderText = "OdometerReading";
            this.odometerReadingDataGridViewTextBoxColumn.Name = "odometerReadingDataGridViewTextBoxColumn";
            this.odometerReadingDataGridViewTextBoxColumn.Width = 250;
            // 
            // fuelLevelDataGridViewTextBoxColumn
            // 
            this.fuelLevelDataGridViewTextBoxColumn.DataPropertyName = "FuelLevel";
            this.fuelLevelDataGridViewTextBoxColumn.HeaderText = "FuelLevel";
            this.fuelLevelDataGridViewTextBoxColumn.Name = "fuelLevelDataGridViewTextBoxColumn";
            this.fuelLevelDataGridViewTextBoxColumn.Width = 150;
            // 
            // inspectionTypeDataGridViewTextBoxColumn
            // 
            this.inspectionTypeDataGridViewTextBoxColumn.DataPropertyName = "InspectionType";
            this.inspectionTypeDataGridViewTextBoxColumn.HeaderText = "InspectionType";
            this.inspectionTypeDataGridViewTextBoxColumn.Name = "inspectionTypeDataGridViewTextBoxColumn";
            this.inspectionTypeDataGridViewTextBoxColumn.Width = 200;
            // 
            // inspectionDateTimeDataGridViewTextBoxColumn
            // 
            this.inspectionDateTimeDataGridViewTextBoxColumn.DataPropertyName = "InspectionDateTime";
            this.inspectionDateTimeDataGridViewTextBoxColumn.HeaderText = "InspectionDateTime";
            this.inspectionDateTimeDataGridViewTextBoxColumn.Name = "inspectionDateTimeDataGridViewTextBoxColumn";
            this.inspectionDateTimeDataGridViewTextBoxColumn.Width = 250;
            // 
            // damageFoundDataGridViewTextBoxColumn
            // 
            this.damageFoundDataGridViewTextBoxColumn.DataPropertyName = "DamageFound";
            this.damageFoundDataGridViewTextBoxColumn.HeaderText = "DamageFound";
            this.damageFoundDataGridViewTextBoxColumn.Name = "damageFoundDataGridViewTextBoxColumn";
            this.damageFoundDataGridViewTextBoxColumn.Width = 180;
            // 
            // damageDescriptionDataGridViewTextBoxColumn
            // 
            this.damageDescriptionDataGridViewTextBoxColumn.DataPropertyName = "DamageDescription";
            this.damageDescriptionDataGridViewTextBoxColumn.HeaderText = "DamageDescription";
            this.damageDescriptionDataGridViewTextBoxColumn.Name = "damageDescriptionDataGridViewTextBoxColumn";
            this.damageDescriptionDataGridViewTextBoxColumn.Width = 250;
            // 
            // inspectionNotesDataGridViewTextBoxColumn
            // 
            this.inspectionNotesDataGridViewTextBoxColumn.DataPropertyName = "InspectionNotes";
            this.inspectionNotesDataGridViewTextBoxColumn.HeaderText = "InspectionNotes";
            this.inspectionNotesDataGridViewTextBoxColumn.Name = "inspectionNotesDataGridViewTextBoxColumn";
            this.inspectionNotesDataGridViewTextBoxColumn.Width = 180;
            // 
            // ManageInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 693);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ManageInspection";
            this.Text = "ManageInspection";
            this.Load += new System.EventHandler(this.ManageInspection_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleInspectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avisDS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdatePaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageClaimsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateClaimsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBranchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBranchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signUpNewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageInspectionRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addInspectionRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInspectionDetailsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem manageRentalsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateRentalToolStripMenuItem;
        private AvisDS avisDS;
        private System.Windows.Forms.BindingSource vehicleInspectionBindingSource;
        private AvisDSTableAdapters.Vehicle_InspectionTableAdapter vehicle_InspectionTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectionCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleMakeModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odometerReadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectionDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damageFoundDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damageDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectionNotesDataGridViewTextBoxColumn;
    }
}