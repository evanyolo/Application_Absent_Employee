namespace Project_Group
{
    partial class homepage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attandanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notLateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printFileEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takingLoansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentLoansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.loansToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attandanceToolStripMenuItem,
            this.salaryToolStripMenuItem,
            this.addEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.employeeToolStripMenuItem.Text = "Employee/Manager";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // attandanceToolStripMenuItem
            // 
            this.attandanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lateToolStripMenuItem,
            this.allToolStripMenuItem,
            this.permissionToolStripMenuItem});
            this.attandanceToolStripMenuItem.Name = "attandanceToolStripMenuItem";
            this.attandanceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.attandanceToolStripMenuItem.Text = "Attandance";
            // 
            // lateToolStripMenuItem
            // 
            this.lateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lateToolStripMenuItem1,
            this.notLateToolStripMenuItem});
            this.lateToolStripMenuItem.Name = "lateToolStripMenuItem";
            this.lateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lateToolStripMenuItem.Text = "Presence";
            this.lateToolStripMenuItem.Click += new System.EventHandler(this.lateToolStripMenuItem_Click);
            // 
            // lateToolStripMenuItem1
            // 
            this.lateToolStripMenuItem1.Name = "lateToolStripMenuItem1";
            this.lateToolStripMenuItem1.Size = new System.Drawing.Size(203, 26);
            this.lateToolStripMenuItem1.Text = "Late/Not Present";
            this.lateToolStripMenuItem1.Click += new System.EventHandler(this.lateToolStripMenuItem1_Click);
            // 
            // notLateToolStripMenuItem
            // 
            this.notLateToolStripMenuItem.Name = "notLateToolStripMenuItem";
            this.notLateToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.notLateToolStripMenuItem.Text = "Not late";
            this.notLateToolStripMenuItem.Click += new System.EventHandler(this.notLateToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // permissionToolStripMenuItem
            // 
            this.permissionToolStripMenuItem.Name = "permissionToolStripMenuItem";
            this.permissionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.permissionToolStripMenuItem.Text = "Permission";
            this.permissionToolStripMenuItem.Click += new System.EventHandler(this.permissionToolStripMenuItem_Click);
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToFileToolStripMenuItem});
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salaryToolStripMenuItem.Text = "Salary";
            this.salaryToolStripMenuItem.Click += new System.EventHandler(this.salaryToolStripMenuItem_Click);
            // 
            // printToFileToolStripMenuItem
            // 
            this.printToFileToolStripMenuItem.Name = "printToFileToolStripMenuItem";
            this.printToFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printToFileToolStripMenuItem.Text = "Print to File";
            this.printToFileToolStripMenuItem.Click += new System.EventHandler(this.printToFileToolStripMenuItem_Click);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.printFileEmployeeToolStripMenuItem});
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addEmployeeToolStripMenuItem.Text = "Employee ";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem.Text = "Add/Update/Del";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // printFileEmployeeToolStripMenuItem
            // 
            this.printFileEmployeeToolStripMenuItem.Name = "printFileEmployeeToolStripMenuItem";
            this.printFileEmployeeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printFileEmployeeToolStripMenuItem.Text = "Print File Employee";
            this.printFileEmployeeToolStripMenuItem.Click += new System.EventHandler(this.printFileEmployeeToolStripMenuItem_Click);
            // 
            // loansToolStripMenuItem
            // 
            this.loansToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takingLoansToolStripMenuItem,
            this.paidToolStripMenuItem,
            this.paymentLoansToolStripMenuItem});
            this.loansToolStripMenuItem.Name = "loansToolStripMenuItem";
            this.loansToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.loansToolStripMenuItem.Text = "Loans";
            // 
            // takingLoansToolStripMenuItem
            // 
            this.takingLoansToolStripMenuItem.Name = "takingLoansToolStripMenuItem";
            this.takingLoansToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.takingLoansToolStripMenuItem.Text = "Making loans";
            this.takingLoansToolStripMenuItem.Click += new System.EventHandler(this.takingLoansToolStripMenuItem_Click);
            // 
            // paidToolStripMenuItem
            // 
            this.paidToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printFileToolStripMenuItem1});
            this.paidToolStripMenuItem.Name = "paidToolStripMenuItem";
            this.paidToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.paidToolStripMenuItem.Text = "Prints loans";
            this.paidToolStripMenuItem.Click += new System.EventHandler(this.paidToolStripMenuItem_Click);
            // 
            // paymentLoansToolStripMenuItem
            // 
            this.paymentLoansToolStripMenuItem.Name = "paymentLoansToolStripMenuItem";
            this.paymentLoansToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.paymentLoansToolStripMenuItem.Text = "Payment Loans";
            this.paymentLoansToolStripMenuItem.Click += new System.EventHandler(this.paymentLoansToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click_1);
            // 
            // printFileToolStripMenuItem1
            // 
            this.printFileToolStripMenuItem1.Name = "printFileToolStripMenuItem1";
            this.printFileToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.printFileToolStripMenuItem1.Text = "Print file";
            this.printFileToolStripMenuItem1.Click += new System.EventHandler(this.printFileToolStripMenuItem1_Click);
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1119, 486);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "homepage";
            this.Text = "homepage";
            this.Load += new System.EventHandler(this.homepage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attandanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takingLoansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notLateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentLoansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printFileEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printFileToolStripMenuItem1;
    }
}