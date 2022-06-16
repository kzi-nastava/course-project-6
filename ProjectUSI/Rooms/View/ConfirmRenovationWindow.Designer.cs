using System.ComponentModel;

namespace ProjectUSI.Rooms.View
{
    partial class ConfirmRenovationWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.enabledRooms = new System.Windows.Forms.ComboBox();
            this.rbMerge = new System.Windows.Forms.RadioButton();
            this.rbSplit = new System.Windows.Forms.RadioButton();
            this.rbRenovation = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.endDatePicker);
            this.panel1.Controls.Add(this.startDatePicker);
            this.panel1.Controls.Add(this.enabledRooms);
            this.panel1.Controls.Add(this.rbMerge);
            this.panel1.Controls.Add(this.rbSplit);
            this.panel1.Controls.Add(this.rbRenovation);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Location = new System.Drawing.Point(49, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 283);
            this.panel1.TabIndex = 0;
            // 
            // lblEndDate
            // 
            this.lblEndDate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblEndDate.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblEndDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblEndDate.Location = new System.Drawing.Point(324, 102);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(233, 24);
            this.lblEndDate.TabIndex = 14;
            this.lblEndDate.Text = "End date: ";
            // 
            // lblStartDate
            // 
            this.lblStartDate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblStartDate.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblStartDate.Location = new System.Drawing.Point(324, 44);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(233, 24);
            this.lblStartDate.TabIndex = 13;
            this.lblStartDate.Text = "Start date: ";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(324, 129);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(245, 22);
            this.endDatePicker.TabIndex = 12;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(324, 71);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(245, 22);
            this.startDatePicker.TabIndex = 11;
            // 
            // enabledRooms
            // 
            this.enabledRooms.FormattingEnabled = true;
            this.enabledRooms.Location = new System.Drawing.Point(47, 196);
            this.enabledRooms.Name = "enabledRooms";
            this.enabledRooms.Size = new System.Drawing.Size(244, 24);
            this.enabledRooms.TabIndex = 10;
            // 
            // rbMerge
            // 
            this.rbMerge.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rbMerge.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rbMerge.Location = new System.Drawing.Point(47, 132);
            this.rbMerge.Name = "rbMerge";
            this.rbMerge.Size = new System.Drawing.Size(242, 43);
            this.rbMerge.TabIndex = 9;
            this.rbMerge.TabStop = true;
            this.rbMerge.Text = "Merge ";
            this.rbMerge.UseVisualStyleBackColor = true;
            // 
            // rbSplit
            // 
            this.rbSplit.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rbSplit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rbSplit.Location = new System.Drawing.Point(47, 83);
            this.rbSplit.Name = "rbSplit";
            this.rbSplit.Size = new System.Drawing.Size(242, 43);
            this.rbSplit.TabIndex = 8;
            this.rbSplit.TabStop = true;
            this.rbSplit.Text = "Split into two rooms";
            this.rbSplit.UseVisualStyleBackColor = true;
            // 
            // rbRenovation
            // 
            this.rbRenovation.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rbRenovation.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rbRenovation.Location = new System.Drawing.Point(49, 34);
            this.rbRenovation.Name = "rbRenovation";
            this.rbRenovation.Size = new System.Drawing.Size(242, 43);
            this.rbRenovation.TabIndex = 7;
            this.rbRenovation.TabStop = true;
            this.rbRenovation.Text = "Only renovation";
            this.rbRenovation.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSubmit.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSubmit.Location = new System.Drawing.Point(324, 187);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(245, 39);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ConfirmRenovationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 395);
            this.Controls.Add(this.panel1);
            this.Name = "ConfirmRenovationWindow";
            this.Text = "ConfirmRenovationWindow";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblEndDate;

        private System.Windows.Forms.Label lblStartDate;

        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rbRenovation;
        private System.Windows.Forms.RadioButton rbSplit;
        private System.Windows.Forms.RadioButton rbMerge;
        private System.Windows.Forms.ComboBox enabledRooms;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}