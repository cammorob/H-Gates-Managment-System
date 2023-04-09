namespace H_Gates_Managment__System
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.label1 = new System.Windows.Forms.Label();
            this.C_UserLabel = new System.Windows.Forms.Label();
            this.BtAddPatients = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtMenu = new System.Windows.Forms.Label();
            this.BtViewPatients = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.btRooms = new System.Windows.Forms.Button();
            this.btEmergencyContact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "H Gates Hospital";
            // 
            // C_UserLabel
            // 
            this.C_UserLabel.AutoSize = true;
            this.C_UserLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.C_UserLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C_UserLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_UserLabel.Location = new System.Drawing.Point(394, 17);
            this.C_UserLabel.Name = "C_UserLabel";
            this.C_UserLabel.Size = new System.Drawing.Size(46, 19);
            this.C_UserLabel.TabIndex = 2;
            this.C_UserLabel.Text = "  User";
            // 
            // BtAddPatients
            // 
            this.BtAddPatients.AutoSize = true;
            this.BtAddPatients.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtAddPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtAddPatients.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAddPatients.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtAddPatients.Location = new System.Drawing.Point(494, 178);
            this.BtAddPatients.Name = "BtAddPatients";
            this.BtAddPatients.Size = new System.Drawing.Size(107, 24);
            this.BtAddPatients.TabIndex = 5;
            this.BtAddPatients.Text = "Add Patient";
            this.BtAddPatients.Click += new System.EventHandler(this.BtAddPatients_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(463, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // BtMenu
            // 
            this.BtMenu.AutoSize = true;
            this.BtMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtMenu.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtMenu.Location = new System.Drawing.Point(673, 178);
            this.BtMenu.Name = "BtMenu";
            this.BtMenu.Size = new System.Drawing.Size(59, 24);
            this.BtMenu.TabIndex = 9;
            this.BtMenu.Text = "Menu";
            // 
            // BtViewPatients
            // 
            this.BtViewPatients.AutoSize = true;
            this.BtViewPatients.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtViewPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtViewPatients.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtViewPatients.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtViewPatients.Location = new System.Drawing.Point(298, 178);
            this.BtViewPatients.Name = "BtViewPatients";
            this.BtViewPatients.Size = new System.Drawing.Size(121, 24);
            this.BtViewPatients.TabIndex = 10;
            this.BtViewPatients.Text = "View Patients";
            this.BtViewPatients.Click += new System.EventHandler(this.BtViewPatients_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(634, 60);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(145, 115);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // btLogout
            // 
            this.btLogout.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.Location = new System.Drawing.Point(516, 16);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(75, 23);
            this.btLogout.TabIndex = 13;
            this.btLogout.Text = "Log Out";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Current User:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btEmergencyContact);
            this.panel1.Controls.Add(this.btRooms);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 461);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btLogout);
            this.panel2.Controls.Add(this.C_UserLabel);
            this.panel2.Location = new System.Drawing.Point(157, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 48);
            this.panel2.TabIndex = 16;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(16, 67);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(121, 21);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.Text = "Search";
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // btRooms
            // 
            this.btRooms.Location = new System.Drawing.Point(16, 110);
            this.btRooms.Name = "btRooms";
            this.btRooms.Size = new System.Drawing.Size(121, 23);
            this.btRooms.TabIndex = 3;
            this.btRooms.Text = "Rooms";
            this.btRooms.UseVisualStyleBackColor = true;
            // 
            // btEmergencyContact
            // 
            this.btEmergencyContact.Location = new System.Drawing.Point(16, 139);
            this.btEmergencyContact.Name = "btEmergencyContact";
            this.btEmergencyContact.Size = new System.Drawing.Size(121, 23);
            this.btEmergencyContact.TabIndex = 4;
            this.btEmergencyContact.Text = "Emergency Contacts";
            this.btEmergencyContact.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtViewPatients);
            this.Controls.Add(this.BtMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtAddPatients);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BtAddPatients;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label BtMenu;
        private System.Windows.Forms.Label BtViewPatients;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Label C_UserLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btEmergencyContact;
        private System.Windows.Forms.Button btRooms;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}