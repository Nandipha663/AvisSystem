namespace AvisSystem
{
    partial class UpdatePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePayment));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateRentalStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPaymentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdatePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageClaimsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClaimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateClaimsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBranchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateBranchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(152, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transactions";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 165);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Payment_ID:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(152, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "🔍 Search Payment...";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageTransactionsToolStripMenuItem,
            this.manageBookingToolStripMenuItem,
            this.manageRentalsToolStripMenuItem,
            this.manageVehiclesToolStripMenuItem,
            this.processPaymentToolStripMenuItem,
            this.manageClaimsToolStripMenuItem,
            this.manageBranchesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(141, 450);
            this.menuStrip1.TabIndex = 3;
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(128, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.loginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loginToolStripMenuItem.Image")));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // manageTransactionsToolStripMenuItem
            // 
            this.manageTransactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPaymentToolStripMenuItem,
            this.viewUpdateCustomerToolStripMenuItem});
            this.manageTransactionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageTransactionsToolStripMenuItem.Name = "manageTransactionsToolStripMenuItem";
            this.manageTransactionsToolStripMenuItem.Size = new System.Drawing.Size(128, 19);
            this.manageTransactionsToolStripMenuItem.Text = "👥  Manage Customer";
            // 
            // addPaymentToolStripMenuItem
            // 
            this.addPaymentToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addPaymentToolStripMenuItem.Name = "addPaymentToolStripMenuItem";
            this.addPaymentToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addPaymentToolStripMenuItem.Text = "Add Customer";
            this.addPaymentToolStripMenuItem.Click += new System.EventHandler(this.addPaymentToolStripMenuItem_Click);
            // 
            // viewUpdateCustomerToolStripMenuItem
            // 
            this.viewUpdateCustomerToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateCustomerToolStripMenuItem.Name = "viewUpdateCustomerToolStripMenuItem";
            this.viewUpdateCustomerToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.viewUpdateCustomerToolStripMenuItem.Text = "View/Update Customer";
            this.viewUpdateCustomerToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateCustomerToolStripMenuItem_Click);
            // 
            // manageBookingToolStripMenuItem
            // 
            this.manageBookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookingToolStripMenuItem,
            this.viewUpdateBookingToolStripMenuItem});
            this.manageBookingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageBookingToolStripMenuItem.Name = "manageBookingToolStripMenuItem";
            this.manageBookingToolStripMenuItem.Size = new System.Drawing.Size(128, 19);
            this.manageBookingToolStripMenuItem.Text = "📅 Manage Booking";
            // 
            // addBookingToolStripMenuItem
            // 
            this.addBookingToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addBookingToolStripMenuItem.Name = "addBookingToolStripMenuItem";
            this.addBookingToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addBookingToolStripMenuItem.Text = "Add Booking";
            this.addBookingToolStripMenuItem.Click += new System.EventHandler(this.addBookingToolStripMenuItem_Click);
            // 
            // viewUpdateBookingToolStripMenuItem
            // 
            this.viewUpdateBookingToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateBookingToolStripMenuItem.Name = "viewUpdateBookingToolStripMenuItem";
            this.viewUpdateBookingToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.viewUpdateBookingToolStripMenuItem.Text = "View/Update Booking";
            this.viewUpdateBookingToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateBookingToolStripMenuItem_Click);
            // 
            // manageRentalsToolStripMenuItem
            // 
            this.manageRentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRentalToolStripMenuItem,
            this.viewUpdateRentalStatusToolStripMenuItem});
            this.manageRentalsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageRentalsToolStripMenuItem.Name = "manageRentalsToolStripMenuItem";
            this.manageRentalsToolStripMenuItem.Size = new System.Drawing.Size(128, 19);
            this.manageRentalsToolStripMenuItem.Text = "🔑 Manage Rentals";
            this.manageRentalsToolStripMenuItem.Click += new System.EventHandler(this.manageRentalsToolStripMenuItem_Click);
            // 
            // addRentalToolStripMenuItem
            // 
            this.addRentalToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addRentalToolStripMenuItem.Name = "addRentalToolStripMenuItem";
            this.addRentalToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.addRentalToolStripMenuItem.Text = "Add Rental";
            this.addRentalToolStripMenuItem.Click += new System.EventHandler(this.addRentalToolStripMenuItem_Click);
            // 
            // viewUpdateRentalStatusToolStripMenuItem
            // 
            this.viewUpdateRentalStatusToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateRentalStatusToolStripMenuItem.Name = "viewUpdateRentalStatusToolStripMenuItem";
            this.viewUpdateRentalStatusToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.viewUpdateRentalStatusToolStripMenuItem.Text = "View/Update Rental Status";
            this.viewUpdateRentalStatusToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateRentalStatusToolStripMenuItem_Click);
            // 
            // manageVehiclesToolStripMenuItem
            // 
            this.manageVehiclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicleToolStripMenuItem,
            this.viewUpdateVehiclesToolStripMenuItem});
            this.manageVehiclesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageVehiclesToolStripMenuItem.Name = "manageVehiclesToolStripMenuItem";
            this.manageVehiclesToolStripMenuItem.Size = new System.Drawing.Size(128, 19);
            this.manageVehiclesToolStripMenuItem.Text = "🚗 Manage Vehicles";
            // 
            // addVehicleToolStripMenuItem
            // 
            this.addVehicleToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addVehicleToolStripMenuItem.Name = "addVehicleToolStripMenuItem";
            this.addVehicleToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.addVehicleToolStripMenuItem.Text = "Add Vehicle";
            this.addVehicleToolStripMenuItem.Click += new System.EventHandler(this.addVehicleToolStripMenuItem_Click);
            // 
            // viewUpdateVehiclesToolStripMenuItem
            // 
            this.viewUpdateVehiclesToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateVehiclesToolStripMenuItem.Name = "viewUpdateVehiclesToolStripMenuItem";
            this.viewUpdateVehiclesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewUpdateVehiclesToolStripMenuItem.Text = "View/Update Vehicles";
            this.viewUpdateVehiclesToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateVehiclesToolStripMenuItem_Click);
            // 
            // processPaymentToolStripMenuItem
            // 
            this.processPaymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPaymentToolStripMenuItem1,
            this.viewUpdatePaymentToolStripMenuItem});
            this.processPaymentToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.processPaymentToolStripMenuItem.Name = "processPaymentToolStripMenuItem";
            this.processPaymentToolStripMenuItem.Size = new System.Drawing.Size(128, 19);
            this.processPaymentToolStripMenuItem.Text = "💰 Process Payment";
            // 
            // addPaymentToolStripMenuItem1
            // 
            this.addPaymentToolStripMenuItem1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addPaymentToolStripMenuItem1.Name = "addPaymentToolStripMenuItem1";
            this.addPaymentToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.addPaymentToolStripMenuItem1.Text = "Add Payment";
            this.addPaymentToolStripMenuItem1.Click += new System.EventHandler(this.addPaymentToolStripMenuItem1_Click);
            // 
            // viewUpdatePaymentToolStripMenuItem
            // 
            this.viewUpdatePaymentToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdatePaymentToolStripMenuItem.Name = "viewUpdatePaymentToolStripMenuItem";
            this.viewUpdatePaymentToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.viewUpdatePaymentToolStripMenuItem.Text = "View/Update Payment";
            this.viewUpdatePaymentToolStripMenuItem.Click += new System.EventHandler(this.viewUpdatePaymentToolStripMenuItem_Click);
            // 
            // manageClaimsToolStripMenuItem
            // 
            this.manageClaimsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewClaimToolStripMenuItem,
            this.viewUpdateClaimsToolStripMenuItem});
            this.manageClaimsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageClaimsToolStripMenuItem.Name = "manageClaimsToolStripMenuItem";
            this.manageClaimsToolStripMenuItem.Size = new System.Drawing.Size(128, 19);
            this.manageClaimsToolStripMenuItem.Text = "📝 Manage Claims";
            // 
            // addNewClaimToolStripMenuItem
            // 
            this.addNewClaimToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewClaimToolStripMenuItem.Name = "addNewClaimToolStripMenuItem";
            this.addNewClaimToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addNewClaimToolStripMenuItem.Text = "Add New Claim";
            this.addNewClaimToolStripMenuItem.Click += new System.EventHandler(this.addNewClaimToolStripMenuItem_Click);
            // 
            // viewUpdateClaimsToolStripMenuItem
            // 
            this.viewUpdateClaimsToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateClaimsToolStripMenuItem.Name = "viewUpdateClaimsToolStripMenuItem";
            this.viewUpdateClaimsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.viewUpdateClaimsToolStripMenuItem.Text = "View/Update Claims";
            this.viewUpdateClaimsToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateClaimsToolStripMenuItem_Click);
            // 
            // manageBranchesToolStripMenuItem
            // 
            this.manageBranchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBranchToolStripMenuItem,
            this.viewUpdateBranchesToolStripMenuItem});
            this.manageBranchesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageBranchesToolStripMenuItem.Name = "manageBranchesToolStripMenuItem";
            this.manageBranchesToolStripMenuItem.Size = new System.Drawing.Size(128, 19);
            this.manageBranchesToolStripMenuItem.Text = "🏛️ Manage Branches";
            // 
            // addNewBranchToolStripMenuItem
            // 
            this.addNewBranchToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewBranchToolStripMenuItem.Name = "addNewBranchToolStripMenuItem";
            this.addNewBranchToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.addNewBranchToolStripMenuItem.Text = "Add New Branch";
            this.addNewBranchToolStripMenuItem.Click += new System.EventHandler(this.addNewBranchToolStripMenuItem_Click);
            // 
            // viewUpdateBranchesToolStripMenuItem
            // 
            this.viewUpdateBranchesToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewUpdateBranchesToolStripMenuItem.Name = "viewUpdateBranchesToolStripMenuItem";
            this.viewUpdateBranchesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.viewUpdateBranchesToolStripMenuItem.Text = "View/Update Branches";
            this.viewUpdateBranchesToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateBranchesToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(152, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Updtate Transaction";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCyan;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(167, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 54);
            this.button3.TabIndex = 4;
            this.button3.Text = " Clear";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(19, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "X  Cancel Payment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(516, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update payment Details";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selected Payment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search Transaction";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(766, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 50);
            this.button5.TabIndex = 8;
            this.button5.Text = "Filter";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(434, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Filter By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Value:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(437, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(564, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // UpdatePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UpdatePayment";
            this.Text = "UpdatePayment";
            this.Load += new System.EventHandler(this.UpdatePayment_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPaymentToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateRentalStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPaymentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewUpdatePaymentToolStripMenuItem;
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
    }
}