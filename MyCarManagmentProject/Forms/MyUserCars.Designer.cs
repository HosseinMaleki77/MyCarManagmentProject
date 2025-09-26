namespace MyCarManagmentProject.Forms
{
    partial class MyUserCars
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
            this.pnlCar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_MyCars1 = new MyCarManagmentProject.Controls.UC_MyCars();
            this.uC_MyCars2 = new MyCarManagmentProject.Controls.UC_MyCars();
            this.uC_MyCars3 = new MyCarManagmentProject.Controls.UC_MyCars();
            this.pnlCar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCar
            // 
            this.pnlCar.AutoScroll = true;
            this.pnlCar.Controls.Add(this.panel3);
            this.pnlCar.Controls.Add(this.panel2);
            this.pnlCar.Controls.Add(this.panel1);
            this.pnlCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCar.Location = new System.Drawing.Point(0, 0);
            this.pnlCar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCar.Name = "pnlCar";
            this.pnlCar.Size = new System.Drawing.Size(927, 613);
            this.pnlCar.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uC_MyCars2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(927, 205);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_MyCars3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 204);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_MyCars1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 204);
            this.panel1.TabIndex = 0;
            // 
            // uC_MyCars1
            // 
            this.uC_MyCars1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_MyCars1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_MyCars1.Location = new System.Drawing.Point(0, 0);
            this.uC_MyCars1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_MyCars1.Name = "uC_MyCars1";
            this.uC_MyCars1.SelectedCar = null;
            this.uC_MyCars1.Size = new System.Drawing.Size(927, 204);
            this.uC_MyCars1.TabIndex = 0;
            // 
            // uC_MyCars2
            // 
            this.uC_MyCars2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_MyCars2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_MyCars2.Location = new System.Drawing.Point(0, 0);
            this.uC_MyCars2.Margin = new System.Windows.Forms.Padding(2);
            this.uC_MyCars2.Name = "uC_MyCars2";
            this.uC_MyCars2.SelectedCar = null;
            this.uC_MyCars2.Size = new System.Drawing.Size(927, 205);
            this.uC_MyCars2.TabIndex = 1;
            // 
            // uC_MyCars3
            // 
            this.uC_MyCars3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_MyCars3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_MyCars3.Location = new System.Drawing.Point(0, 0);
            this.uC_MyCars3.Margin = new System.Windows.Forms.Padding(2);
            this.uC_MyCars3.Name = "uC_MyCars3";
            this.uC_MyCars3.SelectedCar = null;
            this.uC_MyCars3.Size = new System.Drawing.Size(927, 204);
            this.uC_MyCars3.TabIndex = 1;
            // 
            // MyUserCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 613);
            this.Controls.Add(this.pnlCar);
            this.Name = "MyUserCars";
            this.Text = "MyUserCars";
            this.pnlCar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Controls.UC_MyCars uC_MyCars2;
        private Controls.UC_MyCars uC_MyCars3;
        private Controls.UC_MyCars uC_MyCars1;
    }
}