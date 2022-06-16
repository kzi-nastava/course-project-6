using System.ComponentModel;

namespace ProjectUSI.Doctor.View
{
    partial class FreeDaysWindow
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
            this.createReq = new System.Windows.Forms.Button();
            this.instantReq = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(51, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(707, 260);
            this.listBox1.TabIndex = 0;
            // 
            // createReq
            // 
            this.createReq.BackColor = System.Drawing.SystemColors.Info;
            this.createReq.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.createReq.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createReq.Location = new System.Drawing.Point(53, 345);
            this.createReq.Name = "createReq";
            this.createReq.Size = new System.Drawing.Size(227, 59);
            this.createReq.TabIndex = 1;
            this.createReq.Text = "Create new request";
            this.createReq.UseVisualStyleBackColor = false;
            this.createReq.Click += new System.EventHandler(this.createReq_Click);
            // 
            // instantReq
            // 
            this.instantReq.BackColor = System.Drawing.SystemColors.Info;
            this.instantReq.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.instantReq.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.instantReq.Location = new System.Drawing.Point(321, 346);
            this.instantReq.Name = "instantReq";
            this.instantReq.Size = new System.Drawing.Size(227, 58);
            this.instantReq.TabIndex = 2;
            this.instantReq.Text = "Instant request";
            this.instantReq.UseVisualStyleBackColor = false;
            this.instantReq.Click += new System.EventHandler(this.instantReq_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.SystemColors.Info;
            this.refresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.refresh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.refresh.Location = new System.Drawing.Point(588, 346);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(169, 57);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // FreeDaysWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.instantReq);
            this.Controls.Add(this.createReq);
            this.Controls.Add(this.listBox1);
            this.Name = "FreeDaysWindow";
            this.Text = "FreeDaysWindow";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button refresh;

        private System.Windows.Forms.Button createReq;
        
        private System.Windows.Forms.Button instantReq;

        private System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}