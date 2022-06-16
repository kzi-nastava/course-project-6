using System.ComponentModel;

namespace ProjectUSI.Equipment.View
{
    partial class EquipmentWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbQuantity = new System.Windows.Forms.ComboBox();
            this.cbEquipmentType = new System.Windows.Forms.ComboBox();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRelocate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(60, 49);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(466, 356);
            this.listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.cbQuantity);
            this.panel1.Controls.Add(this.cbEquipmentType);
            this.panel1.Controls.Add(this.cbRoomType);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnRelocate);
            this.panel1.Location = new System.Drawing.Point(551, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 356);
            this.panel1.TabIndex = 1;
            // 
            // cbQuantity
            // 
            this.cbQuantity.BackColor = System.Drawing.SystemColors.Menu;
            this.cbQuantity.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cbQuantity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbQuantity.FormattingEnabled = true;
            this.cbQuantity.Location = new System.Drawing.Point(42, 120);
            this.cbQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Size = new System.Drawing.Size(245, 24);
            this.cbQuantity.TabIndex = 11;
            // 
            // cbEquipmentType
            // 
            this.cbEquipmentType.BackColor = System.Drawing.SystemColors.Menu;
            this.cbEquipmentType.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cbEquipmentType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbEquipmentType.FormattingEnabled = true;
            this.cbEquipmentType.Location = new System.Drawing.Point(42, 150);
            this.cbEquipmentType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbEquipmentType.Name = "cbEquipmentType";
            this.cbEquipmentType.Size = new System.Drawing.Size(245, 24);
            this.cbEquipmentType.TabIndex = 10;
            // 
            // cbRoomType
            // 
            this.cbRoomType.BackColor = System.Drawing.SystemColors.Menu;
            this.cbRoomType.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cbRoomType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Location = new System.Drawing.Point(42, 90);
            this.cbRoomType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(245, 24);
            this.cbRoomType.TabIndex = 9;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.Menu;
            this.btnFilter.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnFilter.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnFilter.Location = new System.Drawing.Point(42, 209);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(244, 39);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(42, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Input text for search";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRelocate
            // 
            this.btnRelocate.BackColor = System.Drawing.SystemColors.Menu;
            this.btnRelocate.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRelocate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRelocate.Location = new System.Drawing.Point(42, 267);
            this.btnRelocate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRelocate.Name = "btnRelocate";
            this.btnRelocate.Size = new System.Drawing.Size(244, 39);
            this.btnRelocate.TabIndex = 6;
            this.btnRelocate.Text = "Relocate";
            this.btnRelocate.UseVisualStyleBackColor = false;
            this.btnRelocate.Click += new System.EventHandler(this.btnRelocate_Click);
            // 
            // EquipmentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EquipmentWindow";
            this.Text = "EquipmentWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox cbQuantity;
        private System.Windows.Forms.ComboBox cbEquipmentType;

        private System.Windows.Forms.ComboBox cbRoomType;

        private System.Windows.Forms.Button btnFilter;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button btnRelocate;

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        

        #endregion
    }
}