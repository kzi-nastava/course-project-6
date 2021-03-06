using System.ComponentModel;

namespace ProjectUSI.Users.View
{
    partial class ManagerMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnHospitalPools = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnDoctorsPools = new System.Windows.Forms.Button();
            this.btnRejectedMedicaments = new System.Windows.Forms.Button();
            this.btnEquipmentReviw = new System.Windows.Forms.Button();
            this.btnMedicaments = new System.Windows.Forms.Button();
            this.btnRenovation = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlButtons.Controls.Add(this.btnHospitalPools);
            this.pnlButtons.Controls.Add(this.btnSignOut);
            this.pnlButtons.Controls.Add(this.btnDoctorsPools);
            this.pnlButtons.Controls.Add(this.btnRejectedMedicaments);
            this.pnlButtons.Controls.Add(this.btnEquipmentReviw);
            this.pnlButtons.Controls.Add(this.btnMedicaments);
            this.pnlButtons.Controls.Add(this.btnRenovation);
            this.pnlButtons.Controls.Add(this.btnRooms);
            this.pnlButtons.Location = new System.Drawing.Point(32, 28);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(317, 465);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnHospitalPools
            // 
            this.btnHospitalPools.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnHospitalPools.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnHospitalPools.Location = new System.Drawing.Point(16, 339);
            this.btnHospitalPools.Name = "btnHospitalPools";
            this.btnHospitalPools.Size = new System.Drawing.Size(284, 47);
            this.btnHospitalPools.TabIndex = 7;
            this.btnHospitalPools.Text = "Hospital pools";
            this.btnHospitalPools.UseVisualStyleBackColor = true;
            this.btnHospitalPools.Click += new System.EventHandler(this.btnHospitalPools_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSignOut.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSignOut.Location = new System.Drawing.Point(16, 392);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(284, 47);
            this.btnSignOut.TabIndex = 1;
            this.btnSignOut.Text = "Sign out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnDoctorsPools
            // 
            this.btnDoctorsPools.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDoctorsPools.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDoctorsPools.Location = new System.Drawing.Point(16, 286);
            this.btnDoctorsPools.Name = "btnDoctorsPools";
            this.btnDoctorsPools.Size = new System.Drawing.Size(284, 47);
            this.btnDoctorsPools.TabIndex = 6;
            this.btnDoctorsPools.Text = "Doctors pools";
            this.btnDoctorsPools.UseVisualStyleBackColor = true;
            this.btnDoctorsPools.Click += new System.EventHandler(this.btnPolls_Click);
            // 
            // btnRejectedMedicaments
            // 
            this.btnRejectedMedicaments.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRejectedMedicaments.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRejectedMedicaments.Location = new System.Drawing.Point(16, 233);
            this.btnRejectedMedicaments.Name = "btnRejectedMedicaments";
            this.btnRejectedMedicaments.Size = new System.Drawing.Size(284, 47);
            this.btnRejectedMedicaments.TabIndex = 5;
            this.btnRejectedMedicaments.Text = "Rejected medicaments";
            this.btnRejectedMedicaments.UseVisualStyleBackColor = true;
            this.btnRejectedMedicaments.Click += new System.EventHandler(this.btnRejectedMedicaments_Click);
            // 
            // btnEquipmentReviw
            // 
            this.btnEquipmentReviw.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEquipmentReviw.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEquipmentReviw.Location = new System.Drawing.Point(16, 74);
            this.btnEquipmentReviw.Name = "btnEquipmentReviw";
            this.btnEquipmentReviw.Size = new System.Drawing.Size(284, 47);
            this.btnEquipmentReviw.TabIndex = 4;
            this.btnEquipmentReviw.Text = "Equipment";
            this.btnEquipmentReviw.UseVisualStyleBackColor = true;
            this.btnEquipmentReviw.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // btnMedicaments
            // 
            this.btnMedicaments.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnMedicaments.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMedicaments.Location = new System.Drawing.Point(16, 180);
            this.btnMedicaments.Name = "btnMedicaments";
            this.btnMedicaments.Size = new System.Drawing.Size(284, 47);
            this.btnMedicaments.TabIndex = 2;
            this.btnMedicaments.Text = "Medicaments";
            this.btnMedicaments.UseVisualStyleBackColor = true;
            this.btnMedicaments.Click += new System.EventHandler(this.btnMedicaments_Click);
            // 
            // btnRenovation
            // 
            this.btnRenovation.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRenovation.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRenovation.Location = new System.Drawing.Point(16, 127);
            this.btnRenovation.Name = "btnRenovation";
            this.btnRenovation.Size = new System.Drawing.Size(284, 47);
            this.btnRenovation.TabIndex = 1;
            this.btnRenovation.Text = "Renovations";
            this.btnRenovation.UseVisualStyleBackColor = true;
            this.btnRenovation.Click += new System.EventHandler(this.btnRenovation_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRooms.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRooms.Location = new System.Drawing.Point(16, 21);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(284, 47);
            this.btnRooms.TabIndex = 0;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlWelcome.Controls.Add(this.label1);
            this.pnlWelcome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlWelcome.Location = new System.Drawing.Point(371, 28);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(556, 465);
            this.pnlWelcome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Orbitron", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 418);
            this.label1.TabIndex = 0;
            // 
            // ManagerMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 530);
            this.Controls.Add(this.pnlWelcome);
            this.Controls.Add(this.pnlButtons);
            this.Name = "ManagerMainWindow";
            this.Text = "ManagerMainWindow";
            this.Load += new System.EventHandler(this.ManagerMainWindow_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlWelcome.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnHospitalPools;

        private System.Windows.Forms.Button btnRenovation;
        private System.Windows.Forms.Button btnMedicaments;
        private System.Windows.Forms.Button btnEquipmentReviw;
        private System.Windows.Forms.Button btnRejectedMedicaments;
        private System.Windows.Forms.Button btnDoctorsPools;
        private System.Windows.Forms.Button btnSignOut;

        private System.Windows.Forms.Button btnRooms;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel pnlWelcome;

        private System.Windows.Forms.Panel pnlButtons;

        #endregion
    }
}