using System.ComponentModel;

namespace ProjectUSI.Doctor.View
{
    partial class VerifyMedicines
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.viewMed = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(31, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(716, 276);
            this.listBox1.TabIndex = 0;
            // 
            // viewMed
            // 
            this.viewMed.BackColor = System.Drawing.SystemColors.Info;
            this.viewMed.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.viewMed.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.viewMed.Location = new System.Drawing.Point(450, 384);
            this.viewMed.Name = "viewMed";
            this.viewMed.Size = new System.Drawing.Size(297, 54);
            this.viewMed.TabIndex = 1;
            this.viewMed.Text = "Reject medicine";
            this.viewMed.UseVisualStyleBackColor = false;
            this.viewMed.Click += new System.EventHandler(this.viewMed_Click);
            // 
            // accept
            // 
            this.accept.BackColor = System.Drawing.SystemColors.Info;
            this.accept.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.accept.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.accept.Location = new System.Drawing.Point(31, 384);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(297, 54);
            this.accept.TabIndex = 2;
            this.accept.Text = "Accept medicine";
            this.accept.UseVisualStyleBackColor = false;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // VerifyMedicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.viewMed);
            this.Controls.Add(this.listBox1);
            this.Name = "VerifyMedicines";
            this.Text = "VerifyMedicines";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button viewMed;

        private System.Windows.Forms.Button accept;

        private System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}