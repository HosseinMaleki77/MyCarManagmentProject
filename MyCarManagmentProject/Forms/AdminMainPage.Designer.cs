namespace MyCarManagmentProject
{
    partial class frmAdminMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMainPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCustomerAndOrders = new System.Windows.Forms.Button();
            this.BtnMyCars = new System.Windows.Forms.Button();
            this.btnAddNewCar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsWallet = new System.Windows.Forms.ToolStripSplitButton();
            this.goToWalletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(814, 50);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnCustomerAndOrders
            // 
            this.btnCustomerAndOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustomerAndOrders.BackColor = System.Drawing.Color.IndianRed;
            this.btnCustomerAndOrders.Font = new System.Drawing.Font("Segoe Print", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerAndOrders.Location = new System.Drawing.Point(246, 114);
            this.btnCustomerAndOrders.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCustomerAndOrders.Name = "btnCustomerAndOrders";
            this.btnCustomerAndOrders.Size = new System.Drawing.Size(350, 84);
            this.btnCustomerAndOrders.TabIndex = 1;
            this.btnCustomerAndOrders.Text = "Customers And Orders";
            this.btnCustomerAndOrders.UseVisualStyleBackColor = false;
            this.btnCustomerAndOrders.Click += new System.EventHandler(this.btnCustomerAndOrders_Click);
            // 
            // BtnMyCars
            // 
            this.BtnMyCars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnMyCars.BackColor = System.Drawing.Color.IndianRed;
            this.BtnMyCars.Font = new System.Drawing.Font("Segoe Print", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMyCars.Location = new System.Drawing.Point(246, 224);
            this.BtnMyCars.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnMyCars.Name = "BtnMyCars";
            this.BtnMyCars.Size = new System.Drawing.Size(350, 88);
            this.BtnMyCars.TabIndex = 2;
            this.BtnMyCars.Text = "MyCars";
            this.BtnMyCars.UseVisualStyleBackColor = false;
            this.BtnMyCars.Click += new System.EventHandler(this.BtnMyCars_Click);
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNewCar.BackColor = System.Drawing.Color.IndianRed;
            this.btnAddNewCar.Font = new System.Drawing.Font("Segoe Print", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCar.Location = new System.Drawing.Point(246, 339);
            this.btnAddNewCar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(350, 90);
            this.btnAddNewCar.TabIndex = 3;
            this.btnAddNewCar.Text = "Add New Car";
            this.btnAddNewCar.UseVisualStyleBackColor = false;
            this.btnAddNewCar.Click += new System.EventHandler(this.btnAddNewCar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsWallet});
            this.statusStrip1.Location = new System.Drawing.Point(0, 50);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(814, 36);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsWallet
            // 
            this.tsWallet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToWalletToolStripMenuItem});
            this.tsWallet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsWallet.Image = global::MyCarManagmentProject.Properties.Resources.icons8_wallet_30;
            this.tsWallet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsWallet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsWallet.Name = "tsWallet";
            this.tsWallet.Size = new System.Drawing.Size(46, 34);
            // 
            // goToWalletToolStripMenuItem
            // 
            this.goToWalletToolStripMenuItem.Name = "goToWalletToolStripMenuItem";
            this.goToWalletToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goToWalletToolStripMenuItem.Text = "Go To Wallet";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Image = global::MyCarManagmentProject.Properties.Resources.menu_icon_244496;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(52, 44);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOutToolStripMenuItem.Text = "LogOut";
            // 
            // frmAdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(814, 530);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAddNewCar);
            this.Controls.Add(this.BtnMyCars);
            this.Controls.Add(this.btnCustomerAndOrders);
            this.Font = new System.Drawing.Font("Segoe Print", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmAdminMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage(Admin)";
            this.Load += new System.EventHandler(this.frmAdminMainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button btnCustomerAndOrders;
        private System.Windows.Forms.Button BtnMyCars;
        private System.Windows.Forms.Button btnAddNewCar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton tsWallet;
        private System.Windows.Forms.ToolStripMenuItem goToWalletToolStripMenuItem;
    }
}