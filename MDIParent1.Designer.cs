using System;

namespace PG
{
    partial class MDIParent1
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bRANDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOUPONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.product1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplier1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaction1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pGReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMaintenanceToolStripMenuItem,
            this.editMenu,
            this.toolsMenu,
            this.userAccountToolStripMenuItem1,
            this.printReceiptToolStripMenuItem,
            this.pGReportToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1291, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMaintenanceToolStripMenuItem
            // 
            this.fileMaintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.userToolStripMenuItem,
            this.supplierToolStripMenuItem1});
            this.fileMaintenanceToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMaintenanceToolStripMenuItem.Name = "fileMaintenanceToolStripMenuItem";
            this.fileMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(153, 23);
            this.fileMaintenanceToolStripMenuItem.Text = "File Maintenance";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.productToolStripMenuItem.Text = "Product Item";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.supplierToolStripMenuItem.Text = "Customer";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click_1);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem1
            // 
            this.supplierToolStripMenuItem1.Name = "supplierToolStripMenuItem1";
            this.supplierToolStripMenuItem1.Size = new System.Drawing.Size(190, 26);
            this.supplierToolStripMenuItem1.Text = "Supplier";
            this.supplierToolStripMenuItem1.Click += new System.EventHandler(this.supplierToolStripMenuItem1_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.toolStripSeparator7,
            this.hOMEToolStripMenuItem,
            this.bRANDToolStripMenuItem,
            this.sTORYToolStripMenuItem,
            this.cOUPONSToolStripMenuItem});
            this.editMenu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(48, 23);
            this.editMenu.Text = "PG";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(171, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(171, 6);
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // bRANDToolStripMenuItem
            // 
            this.bRANDToolStripMenuItem.Name = "bRANDToolStripMenuItem";
            this.bRANDToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.bRANDToolStripMenuItem.Text = "BRAND";
            this.bRANDToolStripMenuItem.Click += new System.EventHandler(this.bRANDToolStripMenuItem_Click);
            // 
            // sTORYToolStripMenuItem
            // 
            this.sTORYToolStripMenuItem.Name = "sTORYToolStripMenuItem";
            this.sTORYToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.sTORYToolStripMenuItem.Text = "STORY";
            this.sTORYToolStripMenuItem.Click += new System.EventHandler(this.sTORYToolStripMenuItem_Click);
            // 
            // cOUPONSToolStripMenuItem
            // 
            this.cOUPONSToolStripMenuItem.Name = "cOUPONSToolStripMenuItem";
            this.cOUPONSToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.cOUPONSToolStripMenuItem.Text = "COUPONS";
            this.cOUPONSToolStripMenuItem.Click += new System.EventHandler(this.cOUPONSToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem1,
            this.product1ToolStripMenuItem,
            this.supplier1ToolStripMenuItem,
            this.transaction1ToolStripMenuItem,
            this.iTEMToolStripMenuItem,
            this.graphToolStripMenuItem});
            this.toolsMenu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(117, 23);
            this.toolsMenu.Text = "Transactions";
            this.toolsMenu.Click += new System.EventHandler(this.toolsMenu_Click);
            // 
            // customerToolStripMenuItem1
            // 
            this.customerToolStripMenuItem1.Name = "customerToolStripMenuItem1";
            this.customerToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.customerToolStripMenuItem1.Text = "Customer";
            this.customerToolStripMenuItem1.Click += new System.EventHandler(this.customerToolStripMenuItem1_Click);
            // 
            // product1ToolStripMenuItem
            // 
            this.product1ToolStripMenuItem.Name = "product1ToolStripMenuItem";
            this.product1ToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.product1ToolStripMenuItem.Text = "Product";
            this.product1ToolStripMenuItem.Click += new System.EventHandler(this.product1ToolStripMenuItem_Click);
            // 
            // supplier1ToolStripMenuItem
            // 
            this.supplier1ToolStripMenuItem.Name = "supplier1ToolStripMenuItem";
            this.supplier1ToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.supplier1ToolStripMenuItem.Text = "Supplier1";
            this.supplier1ToolStripMenuItem.Click += new System.EventHandler(this.supplier1ToolStripMenuItem_Click);
            // 
            // transaction1ToolStripMenuItem
            // 
            this.transaction1ToolStripMenuItem.Name = "transaction1ToolStripMenuItem";
            this.transaction1ToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.transaction1ToolStripMenuItem.Text = "Transaction";
            this.transaction1ToolStripMenuItem.Click += new System.EventHandler(this.transaction1ToolStripMenuItem_Click);
            // 
            // iTEMToolStripMenuItem
            // 
            this.iTEMToolStripMenuItem.Name = "iTEMToolStripMenuItem";
            this.iTEMToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.iTEMToolStripMenuItem.Text = "Item";
            this.iTEMToolStripMenuItem.Click += new System.EventHandler(this.iTEMToolStripMenuItem_Click);
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.graphToolStripMenuItem.Text = "Graph";
            this.graphToolStripMenuItem.Click += new System.EventHandler(this.graphToolStripMenuItem_Click);
            // 
            // userAccountToolStripMenuItem1
            // 
            this.userAccountToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAccountToolStripMenuItem1.Name = "userAccountToolStripMenuItem1";
            this.userAccountToolStripMenuItem1.Size = new System.Drawing.Size(121, 23);
            this.userAccountToolStripMenuItem1.Text = "User Account";
            this.userAccountToolStripMenuItem1.Click += new System.EventHandler(this.userAccountToolStripMenuItem1_Click);
            // 
            // printReceiptToolStripMenuItem
            // 
            this.printReceiptToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptToolStripMenuItem.Name = "printReceiptToolStripMenuItem";
            this.printReceiptToolStripMenuItem.Size = new System.Drawing.Size(124, 23);
            this.printReceiptToolStripMenuItem.Text = "Print Receipt";
            this.printReceiptToolStripMenuItem.Click += new System.EventHandler(this.printReceiptToolStripMenuItem_Click);
            // 
            // pGReportToolStripMenuItem
            // 
            this.pGReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerReportToolStripMenuItem,
            this.productReportToolStripMenuItem,
            this.supplierReportToolStripMenuItem,
            this.itemReportToolStripMenuItem});
            this.pGReportToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pGReportToolStripMenuItem.Name = "pGReportToolStripMenuItem";
            this.pGReportToolStripMenuItem.Size = new System.Drawing.Size(104, 23);
            this.pGReportToolStripMenuItem.Text = "PG Report";
            // 
            // customerReportToolStripMenuItem
            // 
            this.customerReportToolStripMenuItem.Name = "customerReportToolStripMenuItem";
            this.customerReportToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.customerReportToolStripMenuItem.Text = "Customer Report";
            // 
            // productReportToolStripMenuItem
            // 
            this.productReportToolStripMenuItem.Name = "productReportToolStripMenuItem";
            this.productReportToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.productReportToolStripMenuItem.Text = "Product Report";
            // 
            // supplierReportToolStripMenuItem
            // 
            this.supplierReportToolStripMenuItem.Name = "supplierReportToolStripMenuItem";
            this.supplierReportToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.supplierReportToolStripMenuItem.Text = "Supplier Report";
            // 
            // itemReportToolStripMenuItem
            // 
            this.itemReportToolStripMenuItem.Name = "itemReportToolStripMenuItem";
            this.itemReportToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.itemReportToolStripMenuItem.Text = "Item Report";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.toolStrip.Location = new System.Drawing.Point(0, 27);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1291, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(0, 651);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.statusStrip.Size = new System.Drawing.Size(1291, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 673);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MDIParent1";
            this.ShowIcon = false;
            this.Text = "PG PRODUCT FILIPINO";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fileMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private EventHandler supplierToolStripMenuItem_Click;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bRANDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTORYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOUPONSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem product1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplier1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaction1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTEMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pGReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemReportToolStripMenuItem;
    }
}



