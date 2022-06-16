using System.ComponentModel;

namespace ProjectUSI.Equipment.View
{
    partial class RelocateWindow
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.dateOfRelocation = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbRelocateTo = new System.Windows.Forms.ComboBox();
            this.lblRelocateTo = new System.Windows.Forms.Label();
            this.btnRelocate = new System.Windows.Forms.Button();
            this.lblRelocateFrom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblFrom.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblFrom.Location = new System.Drawing.Point(33, 94);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(233, 24);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Room";
            // 
            // dateOfRelocation
            // 
            this.dateOfRelocation.CalendarFont = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateOfRelocation.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateOfRelocation.CalendarTitleBackColor = System.Drawing.SystemColors.Window;
            this.dateOfRelocation.Location = new System.Drawing.Point(33, 170);
            this.dateOfRelocation.Name = "dateOfRelocation";
            this.dateOfRelocation.Size = new System.Drawing.Size(233, 22);
            this.dateOfRelocation.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblDate.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblDate.Location = new System.Drawing.Point(33, 141);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(233, 26);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date of relocation";
            // 
            // cbRelocateTo
            // 
            this.cbRelocateTo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbRelocateTo.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cbRelocateTo.FormattingEnabled = true;
            this.cbRelocateTo.Location = new System.Drawing.Point(34, 246);
            this.cbRelocateTo.Name = "cbRelocateTo";
            this.cbRelocateTo.Size = new System.Drawing.Size(232, 24);
            this.cbRelocateTo.TabIndex = 3;
            // 
            // lblRelocateTo
            // 
            this.lblRelocateTo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblRelocateTo.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblRelocateTo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblRelocateTo.Location = new System.Drawing.Point(33, 217);
            this.lblRelocateTo.Name = "lblRelocateTo";
            this.lblRelocateTo.Size = new System.Drawing.Size(233, 26);
            this.lblRelocateTo.TabIndex = 4;
            this.lblRelocateTo.Text = "Relocate to";
            // 
            // btnRelocate
            // 
            this.btnRelocate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRelocate.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRelocate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRelocate.Location = new System.Drawing.Point(33, 293);
            this.btnRelocate.Name = "btnRelocate";
            this.btnRelocate.Size = new System.Drawing.Size(233, 51);
            this.btnRelocate.TabIndex = 5;
            this.btnRelocate.Text = "Relocate";
            this.btnRelocate.UseVisualStyleBackColor = false;
            this.btnRelocate.Click += new System.EventHandler(this.btnRelocate_Click);
            // 
            // lblRelocateFrom
            // 
            this.lblRelocateFrom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblRelocateFrom.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblRelocateFrom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblRelocateFrom.Location = new System.Drawing.Point(33, 70);
            this.lblRelocateFrom.Name = "lblRelocateFrom";
            this.lblRelocateFrom.Size = new System.Drawing.Size(233, 24);
            this.lblRelocateFrom.TabIndex = 6;
            this.lblRelocateFrom.Text = "Relocate from:";
            // 
            // DeployWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 400);
            this.Controls.Add(this.lblRelocateFrom);
            this.Controls.Add(this.btnRelocate);
            this.Controls.Add(this.lblRelocateTo);
            this.Controls.Add(this.cbRelocateTo);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateOfRelocation);
            this.Controls.Add(this.lblFrom);
            this.Name = "DeployWindow";
            this.Text = "DeployWindow";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblRelocateFrom;

        private System.Windows.Forms.Button btnRelocate;

        private System.Windows.Forms.Label lblRelocateTo;

        private System.Windows.Forms.ComboBox cbRelocateTo;

        private System.Windows.Forms.DateTimePicker dateOfRelocation;
        private System.Windows.Forms.Label lblDate;

        private System.Windows.Forms.Label lblFrom;

        #endregion
    }
}