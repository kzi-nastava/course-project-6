using System.ComponentModel;

namespace ProjectUSI.Doctor.View
{
    partial class NewFreeDayWindow
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.nameAndLastName = new System.Windows.Forms.TextBox();
            this.reason = new System.Windows.Forms.TextBox();
            this.startDate = new System.Windows.Forms.TextBox();
            this.endDate = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(53, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Name and Last Name:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.Location = new System.Drawing.Point(404, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 24);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Reason for free days:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox3.Location = new System.Drawing.Point(53, 255);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 24);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "From Date: (dd/mm/yyyy)";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox4.Location = new System.Drawing.Point(405, 255);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 24);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "To Date: (dd/mm/yyyy)";
            // 
            // nameAndLastName
            // 
            this.nameAndLastName.Location = new System.Drawing.Point(53, 144);
            this.nameAndLastName.Multiline = true;
            this.nameAndLastName.Name = "nameAndLastName";
            this.nameAndLastName.Size = new System.Drawing.Size(181, 50);
            this.nameAndLastName.TabIndex = 4;
            // 
            // reason
            // 
            this.reason.Location = new System.Drawing.Point(405, 144);
            this.reason.Multiline = true;
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(179, 50);
            this.reason.TabIndex = 5;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(53, 318);
            this.startDate.Multiline = true;
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(181, 50);
            this.startDate.TabIndex = 6;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(404, 318);
            this.endDate.Multiline = true;
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(180, 50);
            this.endDate.TabIndex = 7;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.SystemColors.Info;
            this.sendButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.sendButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sendButton.Location = new System.Drawing.Point(223, 418);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(193, 47);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // NewFreeDayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 490);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.nameAndLastName);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "NewFreeDayWindow";
            this.Text = "NewFreeDayWindow";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button sendButton;

        private System.Windows.Forms.TextBox endDate;

        private System.Windows.Forms.TextBox startDate;

        private System.Windows.Forms.TextBox reason;

        private System.Windows.Forms.TextBox nameAndLastName;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;

        #endregion
    }
}