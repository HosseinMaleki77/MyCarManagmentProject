namespace MyCarManagmentProject.Forms
{
    partial class AddNewCar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.gpPictureAdd = new System.Windows.Forms.GroupBox();
            this.picBoxNewCar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.h = new System.Windows.Forms.Label();
            this.nmCarCountAdd = new System.Windows.Forms.NumericUpDown();
            this.cbFactory = new System.Windows.Forms.ComboBox();
            this.g = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.f = new System.Windows.Forms.Label();
            this.txtFuel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoorsNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTopSpeed = new System.Windows.Forms.TextBox();
            this.e = new System.Windows.Forms.Label();
            this.txtAcceler = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.txtTransmission = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.Label();
            this.txtMaxTorq = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.Label();
            this.txtMaxPower = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.Label();
            this.txtEngineDet = new System.Windows.Forms.TextBox();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gpPictureAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNewCar)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCarCountAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 645);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnAddCar);
            this.panel3.Controls.Add(this.gpPictureAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 645);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 545);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 69);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(307, 545);
            this.btnAddCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(137, 69);
            this.btnAddCar.TabIndex = 2;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // gpPictureAdd
            // 
            this.gpPictureAdd.Controls.Add(this.picBoxNewCar);
            this.gpPictureAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpPictureAdd.Location = new System.Drawing.Point(0, 0);
            this.gpPictureAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpPictureAdd.Name = "gpPictureAdd";
            this.gpPictureAdd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpPictureAdd.Size = new System.Drawing.Size(461, 274);
            this.gpPictureAdd.TabIndex = 0;
            this.gpPictureAdd.TabStop = false;
            this.gpPictureAdd.Text = "groupBox2";
            // 
            // picBoxNewCar
            // 
            this.picBoxNewCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxNewCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBoxNewCar.Location = new System.Drawing.Point(3, 17);
            this.picBoxNewCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxNewCar.Name = "picBoxNewCar";
            this.picBoxNewCar.Size = new System.Drawing.Size(455, 256);
            this.picBoxNewCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxNewCar.TabIndex = 0;
            this.picBoxNewCar.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(466, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 645);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.h);
            this.groupBox1.Controls.Add(this.nmCarCountAdd);
            this.groupBox1.Controls.Add(this.cbFactory);
            this.groupBox1.Controls.Add(this.g);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.f);
            this.groupBox1.Controls.Add(this.txtFuel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDoorsNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTopSpeed);
            this.groupBox1.Controls.Add(this.e);
            this.groupBox1.Controls.Add(this.txtAcceler);
            this.groupBox1.Controls.Add(this.a);
            this.groupBox1.Controls.Add(this.txtTransmission);
            this.groupBox1.Controls.Add(this.b);
            this.groupBox1.Controls.Add(this.txtMaxTorq);
            this.groupBox1.Controls.Add(this.d);
            this.groupBox1.Controls.Add(this.txtMaxPower);
            this.groupBox1.Controls.Add(this.c);
            this.groupBox1.Controls.Add(this.txtEngineDet);
            this.groupBox1.Controls.Add(this.txtCarName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(451, 645);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Specifications";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Location = new System.Drawing.Point(75, 591);
            this.h.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(51, 22);
            this.h.TabIndex = 24;
            this.h.Text = "Count:";
            // 
            // nmCarCountAdd
            // 
            this.nmCarCountAdd.Location = new System.Drawing.Point(135, 586);
            this.nmCarCountAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmCarCountAdd.Name = "nmCarCountAdd";
            this.nmCarCountAdd.Size = new System.Drawing.Size(160, 27);
            this.nmCarCountAdd.TabIndex = 23;
            // 
            // cbFactory
            // 
            this.cbFactory.FormattingEnabled = true;
            this.cbFactory.Location = new System.Drawing.Point(135, 542);
            this.cbFactory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFactory.Name = "cbFactory";
            this.cbFactory.Size = new System.Drawing.Size(299, 30);
            this.cbFactory.TabIndex = 22;
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Location = new System.Drawing.Point(64, 546);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(61, 22);
            this.g.TabIndex = 21;
            this.g.Text = "Factory:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Engine Details:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(135, 494);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(299, 27);
            this.txtPrice.TabIndex = 18;
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(75, 497);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(46, 22);
            this.f.TabIndex = 19;
            this.f.Text = "Price:";
            // 
            // txtFuel
            // 
            this.txtFuel.Location = new System.Drawing.Point(135, 449);
            this.txtFuel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFuel.Name = "txtFuel";
            this.txtFuel.Size = new System.Drawing.Size(299, 27);
            this.txtFuel.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "MaximumPower:";
            // 
            // txtDoorsNum
            // 
            this.txtDoorsNum.Location = new System.Drawing.Point(135, 396);
            this.txtDoorsNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoorsNum.Name = "txtDoorsNum";
            this.txtDoorsNum.Size = new System.Drawing.Size(299, 27);
            this.txtDoorsNum.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "MaximumTorque:";
            // 
            // txtTopSpeed
            // 
            this.txtTopSpeed.Location = new System.Drawing.Point(135, 346);
            this.txtTopSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTopSpeed.Name = "txtTopSpeed";
            this.txtTopSpeed.Size = new System.Drawing.Size(299, 27);
            this.txtTopSpeed.TabIndex = 12;
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Location = new System.Drawing.Point(45, 452);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(78, 22);
            this.e.TabIndex = 17;
            this.e.Text = "Fuel Type:";
            // 
            // txtAcceler
            // 
            this.txtAcceler.Location = new System.Drawing.Point(135, 294);
            this.txtAcceler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAcceler.Name = "txtAcceler";
            this.txtAcceler.Size = new System.Drawing.Size(299, 27);
            this.txtAcceler.TabIndex = 10;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(25, 251);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 22);
            this.a.TabIndex = 9;
            this.a.Text = "Transmission:";
            // 
            // txtTransmission
            // 
            this.txtTransmission.Location = new System.Drawing.Point(135, 249);
            this.txtTransmission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTransmission.Name = "txtTransmission";
            this.txtTransmission.Size = new System.Drawing.Size(299, 27);
            this.txtTransmission.TabIndex = 8;
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(35, 299);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(91, 22);
            this.b.TabIndex = 11;
            this.b.Text = "Acceleration:";
            // 
            // txtMaxTorq
            // 
            this.txtMaxTorq.Location = new System.Drawing.Point(135, 202);
            this.txtMaxTorq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaxTorq.Name = "txtMaxTorq";
            this.txtMaxTorq.Size = new System.Drawing.Size(299, 27);
            this.txtMaxTorq.TabIndex = 6;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(21, 399);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(104, 22);
            this.d.TabIndex = 15;
            this.d.Text = "DoorsNumber:";
            // 
            // txtMaxPower
            // 
            this.txtMaxPower.Location = new System.Drawing.Point(135, 155);
            this.txtMaxPower.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaxPower.Name = "txtMaxPower";
            this.txtMaxPower.Size = new System.Drawing.Size(299, 27);
            this.txtMaxPower.TabIndex = 4;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(45, 350);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(80, 22);
            this.c.TabIndex = 13;
            this.c.Text = "TopSpeed:";
            // 
            // txtEngineDet
            // 
            this.txtEngineDet.Location = new System.Drawing.Point(135, 107);
            this.txtEngineDet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEngineDet.Name = "txtEngineDet";
            this.txtEngineDet.Size = new System.Drawing.Size(299, 27);
            this.txtEngineDet.TabIndex = 2;
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(135, 60);
            this.txtCarName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(299, 27);
            this.txtCarName.TabIndex = 0;
            // 
            // AddNewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 645);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddNewCar";
            this.Text = "AddNewCarForm";
            this.Load += new System.EventHandler(this.AddNewCar_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gpPictureAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNewCar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCarCountAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label g;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.TextBox txtFuel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoorsNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTopSpeed;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.TextBox txtAcceler;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox txtTransmission;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.TextBox txtMaxTorq;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.TextBox txtMaxPower;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.TextBox txtEngineDet;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.GroupBox gpPictureAdd;
        private System.Windows.Forms.PictureBox picBoxNewCar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.ComboBox cbFactory;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.NumericUpDown nmCarCountAdd;
    }
}