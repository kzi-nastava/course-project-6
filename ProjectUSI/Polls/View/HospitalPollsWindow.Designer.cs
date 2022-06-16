using System.ComponentModel;

namespace ProjectUSI.Polls.View
{
    partial class HospitalPoolsWindow
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
            this.comments = new System.Windows.Forms.ListBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.cbRecomendation = new System.Windows.Forms.ComboBox();
            this.cbSatisfaction = new System.Windows.Forms.ComboBox();
            this.cbHygiene = new System.Windows.Forms.ComboBox();
            this.cbQuality = new System.Windows.Forms.ComboBox();
            this.averageRecomendation = new System.Windows.Forms.TextBox();
            this.averageSatisfaction = new System.Windows.Forms.TextBox();
            this.averageHygiene = new System.Windows.Forms.TextBox();
            this.averageQuality = new System.Windows.Forms.TextBox();
            this.lblRecomendation = new System.Windows.Forms.Label();
            this.lblSatisfaction = new System.Windows.Forms.Label();
            this.lblHygiene = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.comments);
            this.panel1.Controls.Add(this.lblComments);
            this.panel1.Controls.Add(this.cbRecomendation);
            this.panel1.Controls.Add(this.cbSatisfaction);
            this.panel1.Controls.Add(this.cbHygiene);
            this.panel1.Controls.Add(this.cbQuality);
            this.panel1.Controls.Add(this.averageRecomendation);
            this.panel1.Controls.Add(this.averageSatisfaction);
            this.panel1.Controls.Add(this.averageHygiene);
            this.panel1.Controls.Add(this.averageQuality);
            this.panel1.Controls.Add(this.lblRecomendation);
            this.panel1.Controls.Add(this.lblSatisfaction);
            this.panel1.Controls.Add(this.lblHygiene);
            this.panel1.Controls.Add(this.lblQuality);
            this.panel1.Location = new System.Drawing.Point(16, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 482);
            this.panel1.TabIndex = 0;
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
            // cbRecomendation
            // 
            this.cbRecomendation.FormattingEnabled = true;
            this.cbRecomendation.Location = new System.Drawing.Point(563, 217);
            this.cbRecomendation.Name = "cbRecomendation";
            this.cbRecomendation.Size = new System.Drawing.Size(193, 24);
            this.cbRecomendation.TabIndex = 11;
            // 
            // cbSatisfaction
            // 
            this.cbSatisfaction.FormattingEnabled = true;
            this.cbSatisfaction.Location = new System.Drawing.Point(563, 149);
            this.cbSatisfaction.Name = "cbSatisfaction";
            this.cbSatisfaction.Size = new System.Drawing.Size(193, 24);
            this.cbSatisfaction.TabIndex = 10;
            // 
            // cbHygiene
            // 
            this.cbHygiene.FormattingEnabled = true;
            this.cbHygiene.Location = new System.Drawing.Point(563, 93);
            this.cbHygiene.Name = "cbHygiene";
            this.cbHygiene.Size = new System.Drawing.Size(193, 24);
            this.cbHygiene.TabIndex = 9;
            // 
            // cbQuality
            // 
            this.cbQuality.FormattingEnabled = true;
            this.cbQuality.Location = new System.Drawing.Point(563, 35);
            this.cbQuality.Name = "cbQuality";
            this.cbQuality.Size = new System.Drawing.Size(193, 24);
            this.cbQuality.TabIndex = 8;
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
            // averageSatisfaction
            // 
            this.averageSatisfaction.Enabled = false;
            this.averageSatisfaction.Location = new System.Drawing.Point(291, 142);
            this.averageSatisfaction.Multiline = true;
            this.averageSatisfaction.Name = "averageSatisfaction";
            this.averageSatisfaction.Size = new System.Drawing.Size(206, 38);
            this.averageSatisfaction.TabIndex = 6;
            // 
            // averageHygiene
            // 
            this.averageHygiene.Enabled = false;
            this.averageHygiene.Location = new System.Drawing.Point(291, 79);
            this.averageHygiene.Multiline = true;
            this.averageHygiene.Name = "averageHygiene";
            this.averageHygiene.Size = new System.Drawing.Size(206, 38);
            this.averageHygiene.TabIndex = 5;
            // 
            // averageQuality
            // 
            this.averageQuality.Enabled = false;
            this.averageQuality.Location = new System.Drawing.Point(291, 21);
            this.averageQuality.Multiline = true;
            this.averageQuality.Name = "averageQuality";
            this.averageQuality.Size = new System.Drawing.Size(206, 38);
            this.averageQuality.TabIndex = 4;
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
            // lblSatisfaction
            // 
            this.lblSatisfaction.Font = new System.Drawing.Font("Orbitron", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSatisfaction.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblSatisfaction.Location = new System.Drawing.Point(25, 149);
            this.lblSatisfaction.Name = "lblSatisfaction";
            this.lblSatisfaction.Size = new System.Drawing.Size(294, 31);
            this.lblSatisfaction.TabIndex = 2;
            this.lblSatisfaction.Text = "Satisfaction:";
            // 
            // lblHygiene
            // 
            this.lblHygiene.Font = new System.Drawing.Font("Orbitron", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblHygiene.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblHygiene.Location = new System.Drawing.Point(25, 86);
            this.lblHygiene.Name = "lblHygiene";
            this.lblHygiene.Size = new System.Drawing.Size(294, 31);
            this.lblHygiene.TabIndex = 1;
            this.lblHygiene.Text = "Hygiene:";
            // 
            // lblQuality
            // 
            this.lblQuality.Font = new System.Drawing.Font("Orbitron", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblQuality.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblQuality.Location = new System.Drawing.Point(25, 21);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(294, 31);
            this.lblQuality.TabIndex = 0;
            this.lblQuality.Text = "Quality:";
            // 
            // HospitalPoolsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.panel1);
            this.Name = "HospitalPoolsWindow";
            this.Text = "HospitalPoolsWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.ListBox comments;

        private System.Windows.Forms.ComboBox cbQuality;
        private System.Windows.Forms.ComboBox cbHygiene;
        private System.Windows.Forms.ComboBox cbSatisfaction;
        private System.Windows.Forms.ComboBox cbRecomendation;

        private System.Windows.Forms.TextBox averageHygiene;
        private System.Windows.Forms.TextBox averageSatisfaction;
        private System.Windows.Forms.TextBox averageRecomendation;

        private System.Windows.Forms.TextBox averageQuality;

        private System.Windows.Forms.Label lblHygiene;
        private System.Windows.Forms.Label lblSatisfaction;
        private System.Windows.Forms.Label lblRecomendation;

        private System.Windows.Forms.Label lblQuality;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}