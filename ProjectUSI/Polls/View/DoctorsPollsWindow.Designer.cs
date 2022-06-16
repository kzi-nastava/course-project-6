using System.ComponentModel;

namespace ProjectUSI.Polls.View
{
    partial class DoctorsPoolsWindow
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
            this.lbDoctorPools = new System.Windows.Forms.ListBox();
            this.btnMore = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnMore);
            this.panel1.Controls.Add(this.lbDoctorPools);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 482);
            this.panel1.TabIndex = 1;
            // 
            // lbDoctorPools
            // 
            this.lbDoctorPools.FormattingEnabled = true;
            this.lbDoctorPools.ItemHeight = 16;
            this.lbDoctorPools.Location = new System.Drawing.Point(29, 33);
            this.lbDoctorPools.Name = "lbDoctorPools";
            this.lbDoctorPools.Size = new System.Drawing.Size(717, 324);
            this.lbDoctorPools.TabIndex = 0;
            // 
            // btnMore
            // 
            this.btnMore.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnMore.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMore.Location = new System.Drawing.Point(462, 388);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(284, 47);
            this.btnMore.TabIndex = 3;
            this.btnMore.Text = "View more";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // DoctorsPoolsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.panel1);
            this.Name = "DoctorsPoolsWindow";
            this.Text = "DoctorsPoolsWindow";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnMore;

        private System.Windows.Forms.ListBox lbDoctorPools;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}