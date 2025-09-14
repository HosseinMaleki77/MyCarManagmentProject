namespace MyCarManagmentProject.Controls
{
    partial class CarTextDetails
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDoors = new System.Windows.Forms.Label();
            this.lblTopSpeed = new System.Windows.Forms.Label();
            this.lblAcceleration = new System.Windows.Forms.Label();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.lblMaxTorque = new System.Windows.Forms.Label();
            this.lblMaxPower = new System.Windows.Forms.Label();
            this.lblEngine = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblEngineDetails = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblEngineDetails);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblDoors);
            this.panel2.Controls.Add(this.lblTopSpeed);
            this.panel2.Controls.Add(this.lblAcceleration);
            this.panel2.Controls.Add(this.lblTransmission);
            this.panel2.Controls.Add(this.lblMaxTorque);
            this.panel2.Controls.Add(this.lblMaxPower);
            this.panel2.Controls.Add(this.lblEngine);
            this.panel2.Controls.Add(this.lblFuel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 184);
            this.panel2.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(340, 145);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 19);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price:";
            // 
            // lblDoors
            // 
            this.lblDoors.AutoSize = true;
            this.lblDoors.Location = new System.Drawing.Point(340, 71);
            this.lblDoors.Name = "lblDoors";
            this.lblDoors.Size = new System.Drawing.Size(120, 19);
            this.lblDoors.TabIndex = 7;
            this.lblDoors.Text = "DoorsNumber:";
            // 
            // lblTopSpeed
            // 
            this.lblTopSpeed.AutoSize = true;
            this.lblTopSpeed.Location = new System.Drawing.Point(340, 43);
            this.lblTopSpeed.Name = "lblTopSpeed";
            this.lblTopSpeed.Size = new System.Drawing.Size(92, 19);
            this.lblTopSpeed.TabIndex = 6;
            this.lblTopSpeed.Text = "Top Speed:";
            // 
            // lblAcceleration
            // 
            this.lblAcceleration.AutoSize = true;
            this.lblAcceleration.Location = new System.Drawing.Point(340, 17);
            this.lblAcceleration.Name = "lblAcceleration";
            this.lblAcceleration.Size = new System.Drawing.Size(108, 19);
            this.lblAcceleration.TabIndex = 5;
            this.lblAcceleration.Text = "Acceleration:";
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Location = new System.Drawing.Point(24, 145);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(110, 19);
            this.lblTransmission.TabIndex = 4;
            this.lblTransmission.Text = "Transmission:";
            // 
            // lblMaxTorque
            // 
            this.lblMaxTorque.AutoSize = true;
            this.lblMaxTorque.Location = new System.Drawing.Point(24, 120);
            this.lblMaxTorque.Name = "lblMaxTorque";
            this.lblMaxTorque.Size = new System.Drawing.Size(145, 19);
            this.lblMaxTorque.TabIndex = 3;
            this.lblMaxTorque.Text = "Maximum Torque:";
            // 
            // lblMaxPower
            // 
            this.lblMaxPower.AutoSize = true;
            this.lblMaxPower.Location = new System.Drawing.Point(24, 96);
            this.lblMaxPower.Name = "lblMaxPower";
            this.lblMaxPower.Size = new System.Drawing.Size(139, 19);
            this.lblMaxPower.TabIndex = 2;
            this.lblMaxPower.Text = "Maximum Power:";
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Location = new System.Drawing.Point(24, 43);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(172, 19);
            this.lblEngine.TabIndex = 1;
            this.lblEngine.Text = "Engine Displacement:\t";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(24, 17);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(45, 19);
            this.lblFuel.TabIndex = 0;
            this.lblFuel.Text = "Fuel:";
            // 
            // lblEngineDetails
            // 
            this.lblEngineDetails.AutoSize = true;
            this.lblEngineDetails.Location = new System.Drawing.Point(24, 71);
            this.lblEngineDetails.Name = "lblEngineDetails";
            this.lblEngineDetails.Size = new System.Drawing.Size(121, 19);
            this.lblEngineDetails.TabIndex = 9;
            this.lblEngineDetails.Text = "Engine Details:";
            // 
            // CarTextDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "CarTextDetails";
            this.Size = new System.Drawing.Size(545, 184);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDoors;
        private System.Windows.Forms.Label lblTopSpeed;
        private System.Windows.Forms.Label lblAcceleration;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.Label lblMaxTorque;
        private System.Windows.Forms.Label lblMaxPower;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblEngineDetails;
    }
}
