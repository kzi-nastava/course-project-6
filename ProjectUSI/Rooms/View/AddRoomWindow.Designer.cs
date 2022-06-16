using System.ComponentModel;

namespace ProjectUSI.Rooms.View
{
    partial class AddRoomWindow
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
            this.lblNameOfRoom = new System.Windows.Forms.Label();
            this.txtBoxNameOfRoom = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtBoxIdOfRoom = new System.Windows.Forms.TextBox();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtBoxArea = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbPurpose = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNameOfRoom
            // 
            this.lblNameOfRoom.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNameOfRoom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblNameOfRoom.Location = new System.Drawing.Point(27, 31);
            this.lblNameOfRoom.Name = "lblNameOfRoom";
            this.lblNameOfRoom.Size = new System.Drawing.Size(151, 31);
            this.lblNameOfRoom.TabIndex = 0;
            this.lblNameOfRoom.Text = "NAME:";
            // 
            // txtBoxNameOfRoom
            // 
            this.txtBoxNameOfRoom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBoxNameOfRoom.Location = new System.Drawing.Point(166, 23);
            this.txtBoxNameOfRoom.Multiline = true;
            this.txtBoxNameOfRoom.Name = "txtBoxNameOfRoom";
            this.txtBoxNameOfRoom.Size = new System.Drawing.Size(186, 39);
            this.txtBoxNameOfRoom.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblId.Location = new System.Drawing.Point(27, 89);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(151, 31);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID:";
            // 
            // txtBoxIdOfRoom
            // 
            this.txtBoxIdOfRoom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBoxIdOfRoom.Location = new System.Drawing.Point(166, 81);
            this.txtBoxIdOfRoom.Multiline = true;
            this.txtBoxIdOfRoom.Name = "txtBoxIdOfRoom";
            this.txtBoxIdOfRoom.Size = new System.Drawing.Size(186, 39);
            this.txtBoxIdOfRoom.TabIndex = 3;
            // 
            // lblPurpose
            // 
            this.lblPurpose.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPurpose.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblPurpose.Location = new System.Drawing.Point(27, 147);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(151, 31);
            this.lblPurpose.TabIndex = 4;
            this.lblPurpose.Text = "PURPOSE:";
            // 
            // lblArea
            // 
            this.lblArea.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblArea.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblArea.Location = new System.Drawing.Point(27, 205);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(151, 31);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "AREA:";
            // 
            // txtBoxArea
            // 
            this.txtBoxArea.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBoxArea.Location = new System.Drawing.Point(165, 197);
            this.txtBoxArea.Multiline = true;
            this.txtBoxArea.Name = "txtBoxArea";
            this.txtBoxArea.Size = new System.Drawing.Size(186, 39);
            this.txtBoxArea.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSubmit.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSubmit.Location = new System.Drawing.Point(165, 267);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(187, 45);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbPurpose
            // 
            this.cbPurpose.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbPurpose.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cbPurpose.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbPurpose.FormattingEnabled = true;
            this.cbPurpose.Location = new System.Drawing.Point(166, 147);
            this.cbPurpose.Name = "cbPurpose";
            this.cbPurpose.Size = new System.Drawing.Size(186, 24);
            this.cbPurpose.TabIndex = 10;
            // 
            // AddRoomWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 355);
            this.Controls.Add(this.cbPurpose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.txtBoxIdOfRoom);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtBoxNameOfRoom);
            this.Controls.Add(this.lblNameOfRoom);
            this.Name = "AddRoomWindow";
            this.Text = "AddWindow";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cbPurpose;

        private System.Windows.Forms.Button btnSubmit;

        private System.Windows.Forms.TextBox txtBoxIdOfRoom;

        private System.Windows.Forms.Label lblId;

        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtBoxArea;

        private System.Windows.Forms.Label lblPurpose;
        
        private System.Windows.Forms.TextBox txtBoxNameOfRoom;

        private System.Windows.Forms.Label lblNameOfRoom;

        #endregion
    }
}