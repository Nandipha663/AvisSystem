namespace AvisSystem
{
    partial class UpdateRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRental));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdatePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageClaimsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClaimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateClaimsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBranchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateBranchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signUpEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.returnIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectionReportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleVinNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vEHICLERETURNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avisDS = new AvisSystem.AvisDS();
            this.vEHICLE_RETURNTableAdapter = new AvisSystem.AvisDSTableAdapters.VEHICLE_RETURNTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLERETURNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avisDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.returnIDDataGridViewTextBoxColumn,
            this.bookingIDDataGridViewTextBoxColumn,
            this.branchIDDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.inspectionReportDataGridViewTextBoxColumn,
            this.chargesDataGridViewTextBoxColumn,
            this.vehicleVinNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vEHICLERETURNBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(828, 155);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Rental";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(262, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 31);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "🔍 Search Rental...";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageCustomerToolStripMenuItem,
            this.manageBookingToolStripMenuItem,
            this.manageRentalToolStripMenuItem,
            this.manageVehicleToolStripMenuItem,
            this.processPaymentsToolStripMenuItem,
            this.manageClaimsToolStripMenuItem,
            this.manageBranchesToolStripMenuItem,
            this.manageEmployeesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(256, 450);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
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
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // manageCustomerToolStripMenuItem
            // 
            this.manageCustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.viewUpdateCustomerToolStripMenuItem});
            this.manageCustomerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCustomerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageCustomerToolStripMenuItem.Name = "manageCustomerToolStripMenuItem";
            this.manageCustomerToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.manageCustomerToolStripMenuItem.Text = "👥 Manage Customer ";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(314, 34);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // viewUpdateCustomerToolStripMenuItem
            // 
            this.viewUpdateCustomerToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateCustomerToolStripMenuItem.Name = "viewUpdateCustomerToolStripMenuItem";
            this.viewUpdateCustomerToolStripMenuItem.Size = new System.Drawing.Size(314, 34);
            this.viewUpdateCustomerToolStripMenuItem.Text = "View/Update Customer";
            this.viewUpdateCustomerToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateCustomerToolStripMenuItem_Click);
            // 
            // manageBookingToolStripMenuItem
            // 
            this.manageBookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookingToolStripMenuItem,
            this.viewUpdateBookingToolStripMenuItem});
            this.manageBookingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBookingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageBookingToolStripMenuItem.Name = "manageBookingToolStripMenuItem";
            this.manageBookingToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.manageBookingToolStripMenuItem.Text = "📅 Manage Booking";
            // 
            // addBookingToolStripMenuItem
            // 
            this.addBookingToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addBookingToolStripMenuItem.Name = "addBookingToolStripMenuItem";
            this.addBookingToolStripMenuItem.Size = new System.Drawing.Size(303, 34);
            this.addBookingToolStripMenuItem.Text = "Add Booking";
            this.addBookingToolStripMenuItem.Click += new System.EventHandler(this.addBookingToolStripMenuItem_Click);
            // 
            // viewUpdateBookingToolStripMenuItem
            // 
            this.viewUpdateBookingToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateBookingToolStripMenuItem.Name = "viewUpdateBookingToolStripMenuItem";
            this.viewUpdateBookingToolStripMenuItem.Size = new System.Drawing.Size(303, 34);
            this.viewUpdateBookingToolStripMenuItem.Text = "View/Update Booking";
            this.viewUpdateBookingToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateBookingToolStripMenuItem_Click);
            // 
            // manageRentalToolStripMenuItem
            // 
            this.manageRentalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRentalToolStripMenuItem,
            this.viewUpdateRentalToolStripMenuItem});
            this.manageRentalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageRentalToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageRentalToolStripMenuItem.Name = "manageRentalToolStripMenuItem";
            this.manageRentalToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.manageRentalToolStripMenuItem.Text = "🔑 Manage Rental";
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
            // manageVehicleToolStripMenuItem
            // 
            this.manageVehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicleToolStripMenuItem,
            this.viewUpdateVehicleToolStripMenuItem});
            this.manageVehicleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageVehicleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageVehicleToolStripMenuItem.Name = "manageVehicleToolStripMenuItem";
            this.manageVehicleToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.manageVehicleToolStripMenuItem.Text = "🚗 Manage Vehicle";
            // 
            // addVehicleToolStripMenuItem
            // 
            this.addVehicleToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addVehicleToolStripMenuItem.Name = "addVehicleToolStripMenuItem";
            this.addVehicleToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this.addVehicleToolStripMenuItem.Text = "Add Vehicle";
            this.addVehicleToolStripMenuItem.Click += new System.EventHandler(this.addVehicleToolStripMenuItem_Click);
            // 
            // viewUpdateVehicleToolStripMenuItem
            // 
            this.viewUpdateVehicleToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateVehicleToolStripMenuItem.Name = "viewUpdateVehicleToolStripMenuItem";
            this.viewUpdateVehicleToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this.viewUpdateVehicleToolStripMenuItem.Text = "View/Update Vehicle";
            this.viewUpdateVehicleToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateVehicleToolStripMenuItem_Click);
            // 
            // processPaymentsToolStripMenuItem
            // 
            this.processPaymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPToolStripMenuItem,
            this.viewUpdatePaymentToolStripMenuItem});
            this.processPaymentsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processPaymentsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.processPaymentsToolStripMenuItem.Name = "processPaymentsToolStripMenuItem";
            this.processPaymentsToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.processPaymentsToolStripMenuItem.Text = "💰 Process Payment";
            // 
            // addPToolStripMenuItem
            // 
            this.addPToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addPToolStripMenuItem.Name = "addPToolStripMenuItem";
            this.addPToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.addPToolStripMenuItem.Text = "Add Payment";
            this.addPToolStripMenuItem.Click += new System.EventHandler(this.addPToolStripMenuItem_Click);
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
            this.addNewClaimToolStripMenuItem,
            this.viewUpdateClaimsToolStripMenuItem});
            this.manageClaimsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageClaimsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageClaimsToolStripMenuItem.Name = "manageClaimsToolStripMenuItem";
            this.manageClaimsToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.manageClaimsToolStripMenuItem.Text = "📝 Manage Claims";
            // 
            // addNewClaimToolStripMenuItem
            // 
            this.addNewClaimToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewClaimToolStripMenuItem.Name = "addNewClaimToolStripMenuItem";
            this.addNewClaimToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.addNewClaimToolStripMenuItem.Text = "Add New Claim";
            this.addNewClaimToolStripMenuItem.Click += new System.EventHandler(this.addNewClaimToolStripMenuItem_Click);
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
            this.addNewBranchToolStripMenuItem,
            this.viewUpdateBranchesToolStripMenuItem});
            this.manageBranchesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBranchesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageBranchesToolStripMenuItem.Name = "manageBranchesToolStripMenuItem";
            this.manageBranchesToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.manageBranchesToolStripMenuItem.Text = "🏛️ Manage Branches";
            // 
            // addNewBranchToolStripMenuItem
            // 
            this.addNewBranchToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewBranchToolStripMenuItem.Name = "addNewBranchToolStripMenuItem";
            this.addNewBranchToolStripMenuItem.Size = new System.Drawing.Size(308, 34);
            this.addNewBranchToolStripMenuItem.Text = "Add New Branch";
            this.addNewBranchToolStripMenuItem.Click += new System.EventHandler(this.addNewBranchToolStripMenuItem_Click);
            // 
            // viewUpdateBranchesToolStripMenuItem
            // 
            this.viewUpdateBranchesToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateBranchesToolStripMenuItem.Name = "viewUpdateBranchesToolStripMenuItem";
            this.viewUpdateBranchesToolStripMenuItem.Size = new System.Drawing.Size(308, 34);
            this.viewUpdateBranchesToolStripMenuItem.Text = "View/Update Branches";
            this.viewUpdateBranchesToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateBranchesToolStripMenuItem_Click);
            // 
            // manageEmployeesToolStripMenuItem
            // 
            this.manageEmployeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signUpEmployeeToolStripMenuItem,
            this.viewUpdateEmployeeToolStripMenuItem});
            this.manageEmployeesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageEmployeesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageEmployeesToolStripMenuItem.Name = "manageEmployeesToolStripMenuItem";
            this.manageEmployeesToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.manageEmployeesToolStripMenuItem.Text = "👥 Manage Employees";
            // 
            // signUpEmployeeToolStripMenuItem
            // 
            this.signUpEmployeeToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.signUpEmployeeToolStripMenuItem.Name = "signUpEmployeeToolStripMenuItem";
            this.signUpEmployeeToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.signUpEmployeeToolStripMenuItem.Text = "Sign Up Employee";
            this.signUpEmployeeToolStripMenuItem.Click += new System.EventHandler(this.signUpEmployeeToolStripMenuItem_Click);
            // 
            // viewUpdateEmployeeToolStripMenuItem
            // 
            this.viewUpdateEmployeeToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateEmployeeToolStripMenuItem.Name = "viewUpdateEmployeeToolStripMenuItem";
            this.viewUpdateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.viewUpdateEmployeeToolStripMenuItem.Text = "View/Update Employee";
            this.viewUpdateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateEmployeeToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Booking_ID:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(198, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(385, 31);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(11, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "🗑️Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(619, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 51);
            this.button2.TabIndex = 11;
            this.button2.Text = "Save Changes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Selected Rental:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(264, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(828, 129);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Rental";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.LightCyan;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(147, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 44);
            this.button4.TabIndex = 14;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(258, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 180);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rentals";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(936, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(167, 43);
            this.button5.TabIndex = 7;
            this.button5.Text = "Filter";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(579, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 25);
            this.label13.TabIndex = 8;
            this.label13.Text = "Filter By:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(725, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Value:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Charges",
            "Date"});
            this.comboBox1.Location = new System.Drawing.Point(584, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 28);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(730, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 28);
            this.comboBox2.TabIndex = 11;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.LightCyan;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(936, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(167, 37);
            this.button6.TabIndex = 21;
            this.button6.Text = "Reset Filter";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(730, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // returnIDDataGridViewTextBoxColumn
            // 
            this.returnIDDataGridViewTextBoxColumn.DataPropertyName = "ReturnID";
            this.returnIDDataGridViewTextBoxColumn.HeaderText = "ReturnID";
            this.returnIDDataGridViewTextBoxColumn.Name = "returnIDDataGridViewTextBoxColumn";
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "BranchID";
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "BranchID";
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            this.returnDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // inspectionReportDataGridViewTextBoxColumn
            // 
            this.inspectionReportDataGridViewTextBoxColumn.DataPropertyName = "Inspection Report";
            this.inspectionReportDataGridViewTextBoxColumn.HeaderText = "Inspection Report";
            this.inspectionReportDataGridViewTextBoxColumn.Name = "inspectionReportDataGridViewTextBoxColumn";
            this.inspectionReportDataGridViewTextBoxColumn.Width = 250;
            // 
            // chargesDataGridViewTextBoxColumn
            // 
            this.chargesDataGridViewTextBoxColumn.DataPropertyName = "Charges";
            this.chargesDataGridViewTextBoxColumn.HeaderText = "Charges";
            this.chargesDataGridViewTextBoxColumn.Name = "chargesDataGridViewTextBoxColumn";
            // 
            // vehicleVinNoDataGridViewTextBoxColumn
            // 
            this.vehicleVinNoDataGridViewTextBoxColumn.DataPropertyName = "VehicleVinNo";
            this.vehicleVinNoDataGridViewTextBoxColumn.HeaderText = "VehicleVinNo";
            this.vehicleVinNoDataGridViewTextBoxColumn.Name = "vehicleVinNoDataGridViewTextBoxColumn";
            this.vehicleVinNoDataGridViewTextBoxColumn.Width = 250;
            // 
            // vEHICLERETURNBindingSource
            // 
            this.vEHICLERETURNBindingSource.DataMember = "VEHICLE RETURN";
            this.vEHICLERETURNBindingSource.DataSource = this.avisDS;
            // 
            // avisDS
            // 
            this.avisDS.DataSetName = "AvisDS";
            this.avisDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEHICLE_RETURNTableAdapter
            // 
            this.vEHICLE_RETURNTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1104, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UpdateRental";
            this.Text = "UpdateVehicleReturn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UpdateRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLERETURNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avisDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateRentalToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processPaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdatePaymentToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolStripMenuItem manageClaimsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewClaimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateClaimsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBranchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBranchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateBranchesToolStripMenuItem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signUpEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateEmployeeToolStripMenuItem;
        private AvisDS avisDS;
        private System.Windows.Forms.BindingSource vEHICLERETURNBindingSource;
        private AvisDSTableAdapters.VEHICLE_RETURNTableAdapter vEHICLE_RETURNTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectionReportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleVinNoDataGridViewTextBoxColumn;
    }
}