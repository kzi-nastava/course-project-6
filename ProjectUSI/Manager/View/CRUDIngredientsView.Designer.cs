using System.ComponentModel;

namespace ProjectUSI.Manager.View
{
    partial class CRUDIngredientsView
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
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnChangeIngredient = new System.Windows.Forms.Button();
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
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
            // btnAddIngredient
            // 
            this.btnAddIngredient.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddIngredient.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddIngredient.Location = new System.Drawing.Point(474, 95);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(248, 58);
            this.btnAddIngredient.TabIndex = 1;
            this.btnAddIngredient.Text = "Add new ingredient";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.AddClick);
            // 
            // btnChangeIngredient
            // 
            this.btnChangeIngredient.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnChangeIngredient.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnChangeIngredient.Location = new System.Drawing.Point(474, 186);
            this.btnChangeIngredient.Name = "btnChangeIngredient";
            this.btnChangeIngredient.Size = new System.Drawing.Size(248, 59);
            this.btnChangeIngredient.TabIndex = 2;
            this.btnChangeIngredient.Text = "Change ingredient";
            this.btnChangeIngredient.UseVisualStyleBackColor = true;
            this.btnChangeIngredient.Click += new System.EventHandler(this.UpdateClick);
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDeleteIngredient.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeleteIngredient.Location = new System.Drawing.Point(475, 282);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(247, 57);
            this.btnDeleteIngredient.TabIndex = 3;
            this.btnDeleteIngredient.Text = "Delete an ingredient";
            this.btnDeleteIngredient.UseVisualStyleBackColor = true;
            this.btnDeleteIngredient.Click += new System.EventHandler(this.DeleteClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRefresh.Location = new System.Drawing.Point(605, 383);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 39);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.RefreshClick);
            // 
            // CRUDIngredientsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteIngredient);
            this.Controls.Add(this.btnChangeIngredient);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.listBox1);
            this.Name = "CRUDIngredientsView";
            this.Text = "CRUDMedicineView";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.Button btnDeleteIngredient;

        private System.Windows.Forms.Button btnChangeIngredient;

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddIngredient;

        #endregion
    }
}