using System.ComponentModel;

namespace ProjectUSI.Doctor.View
{
    partial class PrescriptionWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.instructions = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.medications = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.patientEmail = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.instructions);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.medications);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 426);
            this.panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.Location = new System.Drawing.Point(14, 216);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 27);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Instructions:";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // instructions
            // 
            this.instructions.Location = new System.Drawing.Point(145, 211);
            this.instructions.Multiline = true;
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(220, 122);
            this.instructions.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(14, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Medications:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // medications
            // 
            this.medications.Location = new System.Drawing.Point(145, 32);
            this.medications.Multiline = true;
            this.medications.Name = "medications";
            this.medications.Size = new System.Drawing.Size(221, 99);
            this.medications.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.time);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.patientEmail);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(426, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 425);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(30, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Give a prescription";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // patientEmail
            // 
            this.patientEmail.Location = new System.Drawing.Point(151, 32);
            this.patientEmail.Multiline = true;
            this.patientEmail.Name = "patientEmail";
            this.patientEmail.Size = new System.Drawing.Size(195, 43);
            this.patientEmail.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox4.Location = new System.Drawing.Point(13, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 27);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "Patient\'s email:";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(151, 163);
            this.time.Multiline = true;
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(195, 37);
            this.time.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox5.Location = new System.Drawing.Point(13, 168);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 27);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "At what time:";
            // 
            // PrescriptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PrescriptionWindow";
            this.Text = "PrescriptionWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox textBox5;

        private System.Windows.Forms.TextBox time;

        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.TextBox patientEmail;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TextBox instructions;

        private System.Windows.Forms.TextBox medications;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}