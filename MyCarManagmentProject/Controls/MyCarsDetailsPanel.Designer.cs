namespace MyCarManagmentProject.Controls
{
    partial class UC_MyCarsDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cartCarDetail3 = new MyCarManagmentProject.Controls.CartCarDetail();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cartCarDetail2 = new MyCarManagmentProject.Controls.CartCarDetail();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cartCarDetail1 = new MyCarManagmentProject.Controls.CartCarDetail();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 613);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cartCarDetail3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 409);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(875, 204);
            this.panel4.TabIndex = 3;
            // 
            // cartCarDetail3
            // 
            this.cartCarDetail3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartCarDetail3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartCarDetail3.Location = new System.Drawing.Point(0, 0);
            this.cartCarDetail3.Margin = new System.Windows.Forms.Padding(2);
            this.cartCarDetail3.Name = "cartCarDetail3";
            this.cartCarDetail3.SelectedCar = null;
            this.cartCarDetail3.Size = new System.Drawing.Size(875, 204);
            this.cartCarDetail3.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cartCarDetail2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 409);
            this.panel3.TabIndex = 2;
            // 
            // cartCarDetail2
            // 
            this.cartCarDetail2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartCarDetail2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartCarDetail2.Location = new System.Drawing.Point(0, 0);
            this.cartCarDetail2.Margin = new System.Windows.Forms.Padding(2);
            this.cartCarDetail2.Name = "cartCarDetail2";
            this.cartCarDetail2.SelectedCar = null;
            this.cartCarDetail2.Size = new System.Drawing.Size(875, 409);
            this.cartCarDetail2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cartCarDetail1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 204);
            this.panel2.TabIndex = 1;
            // 
            // cartCarDetail1
            // 
            this.cartCarDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartCarDetail1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartCarDetail1.Location = new System.Drawing.Point(0, 0);
            this.cartCarDetail1.Margin = new System.Windows.Forms.Padding(2);
            this.cartCarDetail1.Name = "cartCarDetail1";
            this.cartCarDetail1.SelectedCar = null;
            this.cartCarDetail1.Size = new System.Drawing.Size(875, 204);
            this.cartCarDetail1.TabIndex = 0;
            // 
            // UC_MyCarsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_MyCarsDetails";
            this.Size = new System.Drawing.Size(875, 613);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private CartCarDetail cartCarDetail3;
        private CartCarDetail cartCarDetail2;
        private CartCarDetail cartCarDetail1;
        private CartCarDetail cartCarDetail4;
    }
}
