using System.ComponentModel;

namespace ProjectUSI.Doctor.View
{
    partial class VerifyMedicineWindow
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
            this.name = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ingredients = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.wayOfUse = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.reason = new System.Windows.Forms.TextBox();
            this.reject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(54, 86);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Name:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(215, 86);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(209, 63);
            this.name.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.Location = new System.Drawing.Point(54, 202);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 27);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Ingredients:";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ingredients
            // 
            this.ingredients.Location = new System.Drawing.Point(215, 202);
            this.ingredients.Multiline = true;
            this.ingredients.Name = "ingredients";
            this.ingredients.Size = new System.Drawing.Size(209, 63);
            this.ingredients.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox4.Location = new System.Drawing.Point(54, 316);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(133, 27);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Way of use:";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // wayOfUse
            // 
            this.wayOfUse.Location = new System.Drawing.Point(215, 313);
            this.wayOfUse.Multiline = true;
            this.wayOfUse.Name = "wayOfUse";
            this.wayOfUse.Size = new System.Drawing.Size(209, 63);
            this.wayOfUse.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox3.Location = new System.Drawing.Point(478, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 27);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Reason of rejection:";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // reason
            // 
            this.reason.Location = new System.Drawing.Point(692, 86);
            this.reason.Multiline = true;
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(253, 134);
            this.reason.TabIndex = 7;
            // 
            // reject
            // 
            this.reject.BackColor = System.Drawing.SystemColors.Info;
            this.reject.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.reject.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.reject.Location = new System.Drawing.Point(642, 322);
            this.reject.Name = "reject";
            this.reject.Size = new System.Drawing.Size(303, 54);
            this.reject.TabIndex = 8;
            this.reject.Text = "Reject medicine";
            this.reject.UseVisualStyleBackColor = false;
            this.reject.Click += new System.EventHandler(this.reject_Click);
            // 
            // VerifyMedicineWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 514);
            this.Controls.Add(this.reject);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.wayOfUse);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.ingredients);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VerifyMedicineWindow";
            this.Text = "VerifyMedicineWindow";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button reject;

        private System.Windows.Forms.TextBox reason;

        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.TextBox wayOfUse;

        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.TextBox ingredients;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TextBox name;

        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}