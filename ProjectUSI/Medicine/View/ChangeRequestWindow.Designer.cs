using System.ComponentModel;

namespace ProjectUSI.Manager.View
{
    partial class ChangeRequestWindow
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.usage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox1.Location = new System.Drawing.Point(12, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Enter name of medicine:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(237, 74);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(204, 46);
            this.name.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox2.Location = new System.Drawing.Point(12, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Enter ingredients:";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ingredients
            // 
            this.ingredients.Location = new System.Drawing.Point(240, 177);
            this.ingredients.Multiline = true;
            this.ingredients.Name = "ingredients";
            this.ingredients.Size = new System.Drawing.Size(200, 44);
            this.ingredients.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox3.Location = new System.Drawing.Point(12, 282);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 23);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Enter way of use:";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usage
            // 
            this.usage.Location = new System.Drawing.Point(240, 282);
            this.usage.Multiline = true;
            this.usage.Name = "usage";
            this.usage.Size = new System.Drawing.Size(201, 40);
            this.usage.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.Location = new System.Drawing.Point(95, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeRequestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usage);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ingredients);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBox1);
            this.Name = "ChangeRequestWindow";
            this.Text = "ChangeRequestWindow";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox usage;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox ingredients;

        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}