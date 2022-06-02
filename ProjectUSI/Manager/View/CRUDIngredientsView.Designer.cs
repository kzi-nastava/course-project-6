using System.ComponentModel;

namespace ProjectUSI.Manager.View
{
    partial class CRUDMedicineView
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
            this.AddIng = new System.Windows.Forms.Button();
            this.UpdateIng = new System.Windows.Forms.Button();
            this.delIng = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(52, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(341, 292);
            this.listBox1.TabIndex = 0;
            // 
            // AddIng
            // 
            this.AddIng.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.AddIng.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddIng.Location = new System.Drawing.Point(474, 95);
            this.AddIng.Name = "AddIng";
            this.AddIng.Size = new System.Drawing.Size(248, 58);
            this.AddIng.TabIndex = 1;
            this.AddIng.Text = "Add new ingredient";
            this.AddIng.UseVisualStyleBackColor = true;
            this.AddIng.Click += new System.EventHandler(this.AddIng_Click);
            // 
            // UpdateIng
            // 
            this.UpdateIng.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.UpdateIng.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UpdateIng.Location = new System.Drawing.Point(474, 186);
            this.UpdateIng.Name = "UpdateIng";
            this.UpdateIng.Size = new System.Drawing.Size(248, 59);
            this.UpdateIng.TabIndex = 2;
            this.UpdateIng.Text = "Change ingredient";
            this.UpdateIng.UseVisualStyleBackColor = true;
            this.UpdateIng.Click += new System.EventHandler(this.UpdateIng_Click);
            // 
            // delIng
            // 
            this.delIng.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.delIng.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.delIng.Location = new System.Drawing.Point(475, 282);
            this.delIng.Name = "delIng";
            this.delIng.Size = new System.Drawing.Size(247, 57);
            this.delIng.TabIndex = 3;
            this.delIng.Text = "Delete an ingredient";
            this.delIng.UseVisualStyleBackColor = true;
            this.delIng.Click += new System.EventHandler(this.delIng_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.Location = new System.Drawing.Point(605, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CRUDMedicineView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delIng);
            this.Controls.Add(this.UpdateIng);
            this.Controls.Add(this.AddIng);
            this.Controls.Add(this.listBox1);
            this.Name = "CRUDMedicineView";
            this.Text = "CRUDMedicineView";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button delIng;

        private System.Windows.Forms.Button UpdateIng;

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddIng;

        #endregion
    }
}