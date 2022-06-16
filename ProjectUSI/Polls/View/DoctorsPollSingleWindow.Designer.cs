using System.ComponentModel;

namespace ProjectUSI.Polls.View
{
    partial class DoctorsPollSingleWindow
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
            this.lblQuality = new System.Windows.Forms.Label();
            this.lblRecomendation = new System.Windows.Forms.Label();
            this.averageQuality = new System.Windows.Forms.TextBox();
            this.averageRecomendation = new System.Windows.Forms.TextBox();
            this.cbQuality = new System.Windows.Forms.ComboBox();
            this.cbRecomendation = new System.Windows.Forms.ComboBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.comments = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuality
            // 
            this.lblQuality.Font = new System.Drawing.Font("Orbitron", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblQuality.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblQuality.Location = new System.Drawing.Point(25, 150);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(294, 31);
            this.lblQuality.TabIndex = 0;
            this.lblQuality.Text = "Quality:";
            // 
            // lblRecomendation
            // 
            this.lblRecomendation.Font = new System.Drawing.Font("Orbitron", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblRecomendation.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblRecomendation.Location = new System.Drawing.Point(25, 210);
            this.lblRecomendation.Name = "lblRecomendation";
            this.lblRecomendation.Size = new System.Drawing.Size(294, 31);
            this.lblRecomendation.TabIndex = 3;
            this.lblRecomendation.Text = "Recomendation:";
            // 
            // averageQuality
            // 
            this.averageQuality.Enabled = false;
            this.averageQuality.Location = new System.Drawing.Point(291, 143);
            this.averageQuality.Multiline = true;
            this.averageQuality.Name = "averageQuality";
            this.averageQuality.Size = new System.Drawing.Size(206, 38);
            this.averageQuality.TabIndex = 4;
            // 
            // averageRecomendation
            // 
            this.averageRecomendation.Enabled = false;
            this.averageRecomendation.Location = new System.Drawing.Point(291, 203);
            this.averageRecomendation.Multiline = true;
            this.averageRecomendation.Name = "averageRecomendation";
            this.averageRecomendation.Size = new System.Drawing.Size(206, 38);
            this.averageRecomendation.TabIndex = 7;
            // 
            // cbQuality
            // 
            this.cbQuality.FormattingEnabled = true;
            this.cbQuality.Location = new System.Drawing.Point(563, 156);
            this.cbQuality.Name = "cbQuality";
            this.cbQuality.Size = new System.Drawing.Size(193, 24);
            this.cbQuality.TabIndex = 8;
            // 
            // cbRecomendation
            // 
            this.cbRecomendation.FormattingEnabled = true;
            this.cbRecomendation.Location = new System.Drawing.Point(563, 217);
            this.cbRecomendation.Name = "cbRecomendation";
            this.cbRecomendation.Size = new System.Drawing.Size(193, 24);
            this.cbRecomendation.TabIndex = 11;
            // 
            // lblComments
            // 
            this.lblComments.Font = new System.Drawing.Font("Orbitron", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblComments.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblComments.Location = new System.Drawing.Point(25, 282);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(294, 31);
            this.lblComments.TabIndex = 12;
            this.lblComments.Text = "Comments:";
            // 
            // comments
            // 
            this.comments.FormattingEnabled = true;
            this.comments.ItemHeight = 16;
            this.comments.Location = new System.Drawing.Point(291, 286);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(465, 164);
            this.comments.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.comments);
            this.panel1.Controls.Add(this.lblComments);
            this.panel1.Controls.Add(this.cbRecomendation);
            this.panel1.Controls.Add(this.cbQuality);
            this.panel1.Controls.Add(this.averageRecomendation);
            this.panel1.Controls.Add(this.averageQuality);
            this.panel1.Controls.Add(this.lblRecomendation);
            this.panel1.Controls.Add(this.lblQuality);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 482);
            this.panel1.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(291, 72);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(275, 38);
            this.tbName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Orbitron", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblName.Location = new System.Drawing.Point(25, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(294, 31);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name:";
            // 
            // DoctorsPoolSingleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.panel1);
            this.Name = "DoctorsPoolSingleWindow";
            this.Text = "DoctorsPoolSingleWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox tbName;

        private System.Windows.Forms.Label lblName;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox comments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.ComboBox cbRecomendation;
        private System.Windows.Forms.ComboBox cbQuality;
        private System.Windows.Forms.TextBox averageRecomendation;
        private System.Windows.Forms.TextBox averageQuality;
        private System.Windows.Forms.Label lblRecomendation;
        private System.Windows.Forms.Label lblQuality;

        #endregion
    }
}