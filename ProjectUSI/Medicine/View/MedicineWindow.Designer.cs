using System.ComponentModel;

namespace ProjectUSI.Manager.View
{
    partial class MedicineWindow
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
            this.pnlMedicine = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ViewMed = new System.Windows.Forms.Button();
            this.newMed = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMedicine.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMedicine
            // 
            this.pnlMedicine.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlMedicine.Controls.Add(this.button1);
            this.pnlMedicine.Controls.Add(this.ViewMed);
            this.pnlMedicine.Controls.Add(this.newMed);
            this.pnlMedicine.Controls.Add(this.listBox1);
            this.pnlMedicine.Controls.Add(this.label1);
            this.pnlMedicine.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.pnlMedicine.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlMedicine.Location = new System.Drawing.Point(23, 28);
            this.pnlMedicine.Name = "pnlMedicine";
            this.pnlMedicine.Size = new System.Drawing.Size(754, 480);
            this.pnlMedicine.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.Location = new System.Drawing.Point(588, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ViewMed
            // 
            this.ViewMed.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ViewMed.Location = new System.Drawing.Point(319, 396);
            this.ViewMed.Name = "ViewMed";
            this.ViewMed.Size = new System.Drawing.Size(251, 65);
            this.ViewMed.TabIndex = 6;
            this.ViewMed.Text = "View ingredients";
            this.ViewMed.UseVisualStyleBackColor = true;
            this.ViewMed.Click += new System.EventHandler(this.button1_Click);
            // 
            // newMed
            // 
            this.newMed.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.newMed.Location = new System.Drawing.Point(46, 396);
            this.newMed.Name = "newMed";
            this.newMed.Size = new System.Drawing.Size(251, 65);
            this.newMed.TabIndex = 5;
            this.newMed.Text = "Create new medicine";
            this.newMed.UseVisualStyleBackColor = true;
            this.newMed.Click += new System.EventHandler(this.newMed_Click);
            // 
            // listBox1
            // 
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(46, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(651, 276);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Orbitron", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(178, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicines";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MedicineWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.pnlMedicine);
            this.Name = "MedicineWindow";
            this.Text = "MedicineWindow";
            this.pnlMedicine.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button ViewMed;

        private System.Windows.Forms.Button newMed;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel pnlMedicine;

        #endregion
    }
}