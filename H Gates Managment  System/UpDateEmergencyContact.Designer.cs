namespace H_Gates_Managment__System
{
    partial class UpDateEmergencyContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.tbERelationship = new System.Windows.Forms.ComboBox();
            this.tbEAddress = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbENumber = new System.Windows.Forms.TextBox();
            this.tbEName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btUpDateEmergency = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbERelationship
            // 
            this.tbERelationship.FormattingEnabled = true;
            this.tbERelationship.Location = new System.Drawing.Point(130, 83);
            this.tbERelationship.Name = "tbERelationship";
            this.tbERelationship.Size = new System.Drawing.Size(159, 21);
            this.tbERelationship.TabIndex = 43;
            // 
            // tbEAddress
            // 
            this.tbEAddress.FormattingEnabled = true;
            this.tbEAddress.Location = new System.Drawing.Point(130, 124);
            this.tbEAddress.Name = "tbEAddress";
            this.tbEAddress.Size = new System.Drawing.Size(159, 21);
            this.tbEAddress.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(32, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 17);
            this.label16.TabIndex = 41;
            this.label16.Text = "Relationship";
            // 
            // tbENumber
            // 
            this.tbENumber.Location = new System.Drawing.Point(130, 158);
            this.tbENumber.Name = "tbENumber";
            this.tbENumber.Size = new System.Drawing.Size(159, 20);
            this.tbENumber.TabIndex = 40;
            // 
            // tbEName
            // 
            this.tbEName.Location = new System.Drawing.Point(130, 34);
            this.tbEName.Name = "tbEName";
            this.tbEName.Size = new System.Drawing.Size(159, 20);
            this.tbEName.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(32, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "First Name :";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(316, 12);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(69, 21);
            this.btExit.TabIndex = 44;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btUpDateEmergency
            // 
            this.btUpDateEmergency.Location = new System.Drawing.Point(316, 158);
            this.btUpDateEmergency.Name = "btUpDateEmergency";
            this.btUpDateEmergency.Size = new System.Drawing.Size(78, 26);
            this.btUpDateEmergency.TabIndex = 45;
            this.btUpDateEmergency.Text = "Update Record";
            this.btUpDateEmergency.UseVisualStyleBackColor = true;
            this.btUpDateEmergency.Click += new System.EventHandler(this.btUpDateEmergency_Click_1);
            // 
            // UpDateEmergencyContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 201);
            this.Controls.Add(this.btUpDateEmergency);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.tbERelationship);
            this.Controls.Add(this.tbEAddress);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbENumber);
            this.Controls.Add(this.tbEName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Name = "UpDateEmergencyContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpDateEmergencyContact";
            this.Load += new System.EventHandler(this.UpDateEmergencyContact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tbERelationship;
        private System.Windows.Forms.ComboBox tbEAddress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbENumber;
        private System.Windows.Forms.TextBox tbEName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btUpDateEmergency;
    }
}