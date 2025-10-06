namespace MyCarManagmentProject.Controls
{
    partial class UC_MyCars
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MyCars));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUserDetail = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblIsRented = new System.Windows.Forms.Label();
            this.btnReject = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nmSellCount = new System.Windows.Forms.NumericUpDown();
            this.btnSell = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDoors = new System.Windows.Forms.Label();
            this.lblTopSpeed = new System.Windows.Forms.Label();
            this.lblAcceleration = new System.Windows.Forms.Label();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.lblMaxTorque = new System.Windows.Forms.Label();
            this.lblMaxPower = new System.Windows.Forms.Label();
            this.lblEngineDetails = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblED = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSellCount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.btnUserDetail);
            this.panel1.Controls.Add(this.lblIsRented);
            this.panel1.Controls.Add(this.btnReject);
            this.panel1.Controls.Add(this.lblCustomer);
            this.panel1.Controls.Add(this.btnAccept);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.nmSellCount);
            this.panel1.Controls.Add(this.btnSell);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblDoors);
            this.panel1.Controls.Add(this.lblTopSpeed);
            this.panel1.Controls.Add(this.lblAcceleration);
            this.panel1.Controls.Add(this.lblTransmission);
            this.panel1.Controls.Add(this.lblMaxTorque);
            this.panel1.Controls.Add(this.lblMaxPower);
            this.panel1.Controls.Add(this.lblEngineDetails);
            this.panel1.Controls.Add(this.lblFuel);
            this.panel1.Controls.Add(this.lblED);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.lblA);
            this.panel1.Controls.Add(this.lblT);
            this.panel1.Controls.Add(this.lblMa);
            this.panel1.Controls.Add(this.lblM);
            this.panel1.Controls.Add(this.lblF);
            this.panel1.Controls.Add(this.lblP);
            this.panel1.Controls.Add(this.lblD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(294, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 188);
            this.panel1.TabIndex = 0;
            // 
            // btnUserDetail
            // 
            this.btnUserDetail.BackColor = System.Drawing.Color.White;
            this.btnUserDetail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUserDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserDetail.ImageIndex = 2;
            this.btnUserDetail.ImageList = this.imageList1;
            this.btnUserDetail.Location = new System.Drawing.Point(422, 70);
            this.btnUserDetail.Name = "btnUserDetail";
            this.btnUserDetail.Size = new System.Drawing.Size(107, 34);
            this.btnUserDetail.TabIndex = 57;
            this.btnUserDetail.Text = "UserDetail";
            this.btnUserDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserDetail.UseVisualStyleBackColor = false;
            this.btnUserDetail.Click += new System.EventHandler(this.btnUserDetail_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-car-sale-48.png");
            this.imageList1.Images.SetKeyName(1, "icons8-cancel-60.png");
            this.imageList1.Images.SetKeyName(2, "icons8-contact-details-64.png");
            this.imageList1.Images.SetKeyName(3, "icons8-like-100.png");
            this.imageList1.Images.SetKeyName(4, "icons8-thumbs-down-100.png");
            // 
            // lblIsRented
            // 
            this.lblIsRented.AutoSize = true;
            this.lblIsRented.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblIsRented.Location = new System.Drawing.Point(151, 143);
            this.lblIsRented.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIsRented.Name = "lblIsRented";
            this.lblIsRented.Size = new System.Drawing.Size(67, 14);
            this.lblIsRented.TabIndex = 56;
            this.lblIsRented.Text = "IsRented:";
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.White;
            this.btnReject.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReject.ImageIndex = 4;
            this.btnReject.ImageList = this.imageList1;
            this.btnReject.Location = new System.Drawing.Point(359, 110);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(82, 34);
            this.btnReject.TabIndex = 55;
            this.btnReject.Text = "Reject";
            this.btnReject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomer.Location = new System.Drawing.Point(190, 167);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(83, 14);
            this.lblCustomer.TabIndex = 54;
            this.lblCustomer.Text = "CustomerId:";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.White;
            this.btnAccept.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.ImageIndex = 3;
            this.btnAccept.ImageList = this.imageList1;
            this.btnAccept.Location = new System.Drawing.Point(447, 109);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(82, 34);
            this.btnAccept.TabIndex = 52;
            this.btnAccept.Text = "Accept";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageIndex = 1;
            this.btnCancel.ImageList = this.imageList1;
            this.btnCancel.Location = new System.Drawing.Point(447, 149);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 34);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nmSellCount
            // 
            this.nmSellCount.Location = new System.Drawing.Point(377, 157);
            this.nmSellCount.Name = "nmSellCount";
            this.nmSellCount.Size = new System.Drawing.Size(36, 22);
            this.nmSellCount.TabIndex = 50;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.White;
            this.btnSell.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSell.ImageIndex = 0;
            this.btnSell.ImageList = this.imageList1;
            this.btnSell.Location = new System.Drawing.Point(289, 152);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(82, 34);
            this.btnSell.TabIndex = 47;
            this.btnSell.Text = "Sell";
            this.btnSell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(50, 18);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 42;
            this.label2.Text = "Name:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(293, 126);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 13);
            this.lblPrice.TabIndex = 41;
            this.lblPrice.Text = "label10";
            // 
            // lblDoors
            // 
            this.lblDoors.AutoSize = true;
            this.lblDoors.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoors.Location = new System.Drawing.Point(314, 66);
            this.lblDoors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoors.Name = "lblDoors";
            this.lblDoors.Size = new System.Drawing.Size(35, 13);
            this.lblDoors.TabIndex = 40;
            this.lblDoors.Text = "label9";
            // 
            // lblTopSpeed
            // 
            this.lblTopSpeed.AutoSize = true;
            this.lblTopSpeed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopSpeed.Location = new System.Drawing.Point(345, 41);
            this.lblTopSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTopSpeed.Name = "lblTopSpeed";
            this.lblTopSpeed.Size = new System.Drawing.Size(35, 13);
            this.lblTopSpeed.TabIndex = 39;
            this.lblTopSpeed.Text = "label8";
            // 
            // lblAcceleration
            // 
            this.lblAcceleration.AutoSize = true;
            this.lblAcceleration.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceleration.Location = new System.Drawing.Point(352, 18);
            this.lblAcceleration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcceleration.Name = "lblAcceleration";
            this.lblAcceleration.Size = new System.Drawing.Size(35, 13);
            this.lblAcceleration.TabIndex = 38;
            this.lblAcceleration.Text = "label7";
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransmission.Location = new System.Drawing.Point(94, 115);
            this.lblTransmission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(35, 13);
            this.lblTransmission.TabIndex = 37;
            this.lblTransmission.Text = "label6";
            // 
            // lblMaxTorque
            // 
            this.lblMaxTorque.AutoSize = true;
            this.lblMaxTorque.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTorque.Location = new System.Drawing.Point(122, 91);
            this.lblMaxTorque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxTorque.Name = "lblMaxTorque";
            this.lblMaxTorque.Size = new System.Drawing.Size(35, 13);
            this.lblMaxTorque.TabIndex = 36;
            this.lblMaxTorque.Text = "label5";
            // 
            // lblMaxPower
            // 
            this.lblMaxPower.AutoSize = true;
            this.lblMaxPower.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPower.Location = new System.Drawing.Point(118, 66);
            this.lblMaxPower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxPower.Name = "lblMaxPower";
            this.lblMaxPower.Size = new System.Drawing.Size(35, 13);
            this.lblMaxPower.TabIndex = 35;
            this.lblMaxPower.Text = "label4";
            // 
            // lblEngineDetails
            // 
            this.lblEngineDetails.AutoSize = true;
            this.lblEngineDetails.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngineDetails.Location = new System.Drawing.Point(103, 43);
            this.lblEngineDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEngineDetails.Name = "lblEngineDetails";
            this.lblEngineDetails.Size = new System.Drawing.Size(35, 13);
            this.lblEngineDetails.TabIndex = 34;
            this.lblEngineDetails.Text = "label3";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuel.Location = new System.Drawing.Point(306, 89);
            this.lblFuel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(35, 13);
            this.lblFuel.TabIndex = 32;
            this.lblFuel.Text = "label1";
            // 
            // lblED
            // 
            this.lblED.AutoSize = true;
            this.lblED.BackColor = System.Drawing.SystemColors.Control;
            this.lblED.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblED.Location = new System.Drawing.Point(10, 42);
            this.lblED.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblED.Name = "lblED";
            this.lblED.Size = new System.Drawing.Size(97, 14);
            this.lblED.TabIndex = 31;
            this.lblED.Text = "Engine Details:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.SystemColors.Control;
            this.lblTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(271, 40);
            this.lblTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(76, 14);
            this.lblTo.TabIndex = 28;
            this.lblTo.Text = "Top Speed:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.SystemColors.Control;
            this.lblA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(271, 16);
            this.lblA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(86, 14);
            this.lblA.TabIndex = 27;
            this.lblA.Text = "Acceleration:";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.BackColor = System.Drawing.SystemColors.Control;
            this.lblT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.Location = new System.Drawing.Point(10, 114);
            this.lblT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(89, 14);
            this.lblT.TabIndex = 26;
            this.lblT.Text = "Transmission:";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.BackColor = System.Drawing.SystemColors.Control;
            this.lblMa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(10, 90);
            this.lblMa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(116, 14);
            this.lblMa.TabIndex = 25;
            this.lblMa.Text = "Maximum Torque:";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.BackColor = System.Drawing.SystemColors.Control;
            this.lblM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(10, 65);
            this.lblM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(112, 14);
            this.lblM.TabIndex = 24;
            this.lblM.Text = "Maximum Power:";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.BackColor = System.Drawing.SystemColors.Control;
            this.lblF.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.Location = new System.Drawing.Point(273, 88);
            this.lblF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(35, 14);
            this.lblF.TabIndex = 22;
            this.lblF.Text = "Fuel:";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.BackColor = System.Drawing.SystemColors.Control;
            this.lblP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(258, 125);
            this.lblP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(40, 14);
            this.lblP.TabIndex = 30;
            this.lblP.Text = "Price:";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.BackColor = System.Drawing.SystemColors.Control;
            this.lblD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(271, 64);
            this.lblD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(47, 14);
            this.lblD.TabIndex = 29;
            this.lblD.Text = "Doors:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 188);
            this.panel4.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyCarManagmentProject.Properties.Resources.FirstCar;
            this.pictureBox1.Location = new System.Drawing.Point(13, -19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(10, 170);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 58;
            this.lblTime.Text = "label6";
            // 
            // UC_MyCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_MyCars";
            this.Size = new System.Drawing.Size(832, 188);
            this.Load += new System.EventHandler(this.UC_MyCars_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSellCount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDoors;
        private System.Windows.Forms.Label lblTopSpeed;
        private System.Windows.Forms.Label lblAcceleration;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.Label lblMaxTorque;
        private System.Windows.Forms.Label lblMaxPower;
        private System.Windows.Forms.Label lblEngineDetails;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblED;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.NumericUpDown nmSellCount;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Label lblIsRented;
        private System.Windows.Forms.Button btnUserDetail;
        private System.Windows.Forms.Label lblTime;
    }
}
