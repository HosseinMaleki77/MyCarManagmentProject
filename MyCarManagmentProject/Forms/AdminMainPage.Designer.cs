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
            this.btnCustomerAndOrders = new System.Windows.Forms.Button();
            this.BtnMyCars = new System.Windows.Forms.Button();
            this.btnWallet = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsAccount = new System.Windows.Forms.ToolStripDropDownButton();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsWallet = new System.Windows.Forms.ToolStripSplitButton();
            this.goToWalletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // btnWallet
            // 
            this.btnWallet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWallet.BackColor = System.Drawing.Color.IndianRed;
            this.btnWallet.Font = new System.Drawing.Font("Segoe Print", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWallet.Location = new System.Drawing.Point(246, 339);
            this.btnWallet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnWallet.Name = "btnWallet";
            this.btnWallet.Size = new System.Drawing.Size(350, 90);
            this.btnWallet.TabIndex = 3;
            this.btnWallet.Text = "Wallet";
            this.btnWallet.UseVisualStyleBackColor = false;
            this.btnWallet.Click += new System.EventHandler(this.btnAddNewCar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAccount,
            this.tsWallet});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(814, 54);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsAccount
            // 
            this.tsAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myAccountToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.tsAccount.Image = global::MyCarManagmentProject.Properties.Resources.icons8_test_account_48;
            this.tsAccount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAccount.Name = "tsAccount";
            this.tsAccount.Size = new System.Drawing.Size(61, 52);
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.myAccountToolStripMenuItem.Text = "My Account";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
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
            this.tsWallet.Size = new System.Drawing.Size(46, 52);
            // 
            // goToWalletToolStripMenuItem
            // 
            this.goToWalletToolStripMenuItem.Name = "goToWalletToolStripMenuItem";
            this.goToWalletToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goToWalletToolStripMenuItem.Text = "Go To Wallet";
            // 
            // frmAdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(814, 530);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnWallet);
            this.Controls.Add(this.BtnMyCars);
            this.Controls.Add(this.btnCustomerAndOrders);
            this.Font = new System.Drawing.Font("Segoe Print", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmAdminMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage(Admin)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdminMainPage_FormClosing);
            this.Load += new System.EventHandler(this.frmAdminMainPage_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCustomerAndOrders;
        private System.Windows.Forms.Button BtnMyCars;
        private System.Windows.Forms.Button btnWallet;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsAccount;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton tsWallet;
        private System.Windows.Forms.ToolStripMenuItem goToWalletToolStripMenuItem;
    }
}