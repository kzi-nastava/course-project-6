using System.ComponentModel;

namespace ProjectUSI.Doctor.View
{
    partial class ScheduleWindow
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
            this.appointments = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonUpdateAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appointments
            // 
            this.appointments.BackColor = System.Drawing.SystemColors.Info;
            this.appointments.FormattingEnabled = true;
            this.appointments.ItemHeight = 16;
            this.appointments.Location = new System.Drawing.Point(49, 28);
            this.appointments.Name = "appointments";
            this.appointments.Size = new System.Drawing.Size(802, 340);
            this.appointments.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(49, 397);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 52);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Search an appointment";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.Location = new System.Drawing.Point(671, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start an appointment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonStartApp_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button2.Location = new System.Drawing.Point(463, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete an appointment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonDeleteApp_Click);
            // 
            // buttonUpdateAppointment
            // 
            this.buttonUpdateAppointment.BackColor = System.Drawing.SystemColors.Info;
            this.buttonUpdateAppointment.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonUpdateAppointment.Location = new System.Drawing.Point(258, 397);
            this.buttonUpdateAppointment.Name = "buttonUpdateAppointment";
            this.buttonUpdateAppointment.Size = new System.Drawing.Size(179, 52);
            this.buttonUpdateAppointment.TabIndex = 4;
            this.buttonUpdateAppointment.Text = "Update an appointment";
            this.buttonUpdateAppointment.UseVisualStyleBackColor = false;
            this.buttonUpdateAppointment.Click += new System.EventHandler(this.buttonUpdateApp_Click);
            // 
            // ScheduleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.buttonUpdateAppointment);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.appointments);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "ScheduleWindow";
            this.Text = "ScheduleWindow";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonUpdateAppointment;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.ListBox appointments;

        #endregion
    }
}