namespace MyCarManagmentProject.Forms
{
    partial class MyCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCars));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlCar = new System.Windows.Forms.Panel();
            this.btnMercedesBenz = new System.Windows.Forms.Button();
            this.btnBMW = new System.Windows.Forms.Button();
            this.btnFERRARI = new System.Windows.Forms.Button();
            this.btnLEXUS = new System.Windows.Forms.Button();
            this.btnTOYOTA = new System.Windows.Forms.Button();
            this.btnAUDI = new System.Windows.Forms.Button();
            this.btnFORD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ee8efcd4bdbbbe5f4d183ba296010965.png");
            this.imageList1.Images.SetKeyName(1, "ee263731ea49a28656d6a8cf6dc85e85.png");
            this.imageList1.Images.SetKeyName(2, "03k77ee90c7c28233abf67ec40d3b4731b2.png");
            this.imageList1.Images.SetKeyName(3, "ixj9408884a2624f4574e3dc32119381601.png");
            this.imageList1.Images.SetKeyName(4, "16db7859313a90701b487cb5fdb09bb62a8.png");
            this.imageList1.Images.SetKeyName(5, "mzp140d438246dd4b8979b00dc4ac78ca97.png");
            this.imageList1.Images.SetKeyName(6, "34v1becdc35af257c3ad834485af096c2ba.png");
            // 
            // pnlCar
            // 
            this.pnlCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCar.Location = new System.Drawing.Point(0, 0);
            this.pnlCar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCar.Name = "pnlCar";
            this.pnlCar.Size = new System.Drawing.Size(945, 613);
            this.pnlCar.TabIndex = 1;
            // 
            // btnMercedesBenz
            // 
            this.btnMercedesBenz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMercedesBenz.ImageIndex = 0;
            this.btnMercedesBenz.ImageList = this.imageList1;
            this.btnMercedesBenz.Location = new System.Drawing.Point(0, 0);
            this.btnMercedesBenz.Margin = new System.Windows.Forms.Padding(4);
            this.btnMercedesBenz.Name = "btnMercedesBenz";
            this.btnMercedesBenz.Size = new System.Drawing.Size(255, 85);
            this.btnMercedesBenz.TabIndex = 0;
            this.btnMercedesBenz.Text = "Mercedes Benz";
            this.btnMercedesBenz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMercedesBenz.UseVisualStyleBackColor = true;
            this.btnMercedesBenz.Click += new System.EventHandler(this.btnBENZ_Click);
            // 
            // btnBMW
            // 
            this.btnBMW.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBMW.ImageIndex = 1;
            this.btnBMW.ImageList = this.imageList1;
            this.btnBMW.Location = new System.Drawing.Point(0, 85);
            this.btnBMW.Margin = new System.Windows.Forms.Padding(4);
            this.btnBMW.Name = "btnBMW";
            this.btnBMW.Size = new System.Drawing.Size(255, 90);
            this.btnBMW.TabIndex = 1;
            this.btnBMW.Text = "BMW";
            this.btnBMW.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBMW.UseVisualStyleBackColor = true;
            this.btnBMW.Click += new System.EventHandler(this.btnBMW_Click);
            // 
            // btnFERRARI
            // 
            this.btnFERRARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFERRARI.ImageIndex = 2;
            this.btnFERRARI.ImageList = this.imageList1;
            this.btnFERRARI.Location = new System.Drawing.Point(0, 175);
            this.btnFERRARI.Margin = new System.Windows.Forms.Padding(4);
            this.btnFERRARI.Name = "btnFERRARI";
            this.btnFERRARI.Size = new System.Drawing.Size(255, 90);
            this.btnFERRARI.TabIndex = 2;
            this.btnFERRARI.Text = "Ferrari";
            this.btnFERRARI.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFERRARI.UseVisualStyleBackColor = true;
            this.btnFERRARI.Click += new System.EventHandler(this.btnFERRARI_Click);
            // 
            // btnLEXUS
            // 
            this.btnLEXUS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLEXUS.ImageIndex = 3;
            this.btnLEXUS.ImageList = this.imageList1;
            this.btnLEXUS.Location = new System.Drawing.Point(0, 265);
            this.btnLEXUS.Margin = new System.Windows.Forms.Padding(4);
            this.btnLEXUS.Name = "btnLEXUS";
            this.btnLEXUS.Size = new System.Drawing.Size(255, 92);
            this.btnLEXUS.TabIndex = 3;
            this.btnLEXUS.Text = "Lexus";
            this.btnLEXUS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLEXUS.UseVisualStyleBackColor = true;
            this.btnLEXUS.Click += new System.EventHandler(this.btnLEXUS_Click);
            // 
            // btnTOYOTA
            // 
            this.btnTOYOTA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTOYOTA.ImageIndex = 4;
            this.btnTOYOTA.ImageList = this.imageList1;
            this.btnTOYOTA.Location = new System.Drawing.Point(0, 357);
            this.btnTOYOTA.Margin = new System.Windows.Forms.Padding(4);
            this.btnTOYOTA.Name = "btnTOYOTA";
            this.btnTOYOTA.Size = new System.Drawing.Size(255, 87);
            this.btnTOYOTA.TabIndex = 4;
            this.btnTOYOTA.Text = "Toyota";
            this.btnTOYOTA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTOYOTA.UseVisualStyleBackColor = true;
            this.btnTOYOTA.Click += new System.EventHandler(this.btnTOYOTA_Click);
            // 
            // btnAUDI
            // 
            this.btnAUDI.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAUDI.ImageIndex = 5;
            this.btnAUDI.ImageList = this.imageList1;
            this.btnAUDI.Location = new System.Drawing.Point(0, 444);
            this.btnAUDI.Margin = new System.Windows.Forms.Padding(4);
            this.btnAUDI.Name = "btnAUDI";
            this.btnAUDI.Size = new System.Drawing.Size(255, 80);
            this.btnAUDI.TabIndex = 5;
            this.btnAUDI.Text = "Audi";
            this.btnAUDI.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAUDI.UseVisualStyleBackColor = true;
            this.btnAUDI.Click += new System.EventHandler(this.btnAUDI_Click);
            // 
            // btnFORD
            // 
            this.btnFORD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFORD.ImageIndex = 6;
            this.btnFORD.ImageList = this.imageList1;
            this.btnFORD.Location = new System.Drawing.Point(0, 524);
            this.btnFORD.Margin = new System.Windows.Forms.Padding(4);
            this.btnFORD.Name = "btnFORD";
            this.btnFORD.Size = new System.Drawing.Size(255, 76);
            this.btnFORD.TabIndex = 6;
            this.btnFORD.Text = "Ford";
            this.btnFORD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFORD.UseVisualStyleBackColor = true;
            this.btnFORD.Click += new System.EventHandler(this.btnFORD_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFORD);
            this.panel1.Controls.Add(this.btnAUDI);
            this.panel1.Controls.Add(this.btnTOYOTA);
            this.panel1.Controls.Add(this.btnLEXUS);
            this.panel1.Controls.Add(this.btnFERRARI);
            this.panel1.Controls.Add(this.btnBMW);
            this.panel1.Controls.Add(this.btnMercedesBenz);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(945, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 613);
            this.panel1.TabIndex = 0;
            // 
            // MyCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 613);
            this.Controls.Add(this.pnlCar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCars";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlCar;
        private System.Windows.Forms.Button btnMercedesBenz;
        private System.Windows.Forms.Button btnBMW;
        private System.Windows.Forms.Button btnFERRARI;
        private System.Windows.Forms.Button btnLEXUS;
        private System.Windows.Forms.Button btnTOYOTA;
        private System.Windows.Forms.Button btnAUDI;
        private System.Windows.Forms.Button btnFORD;
        private System.Windows.Forms.Panel panel1;
    }
}