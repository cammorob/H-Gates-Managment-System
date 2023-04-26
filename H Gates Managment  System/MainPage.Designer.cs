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
            this.BtViewPatients = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Intake_Pagebt = new System.Windows.Forms.Button();
            this.btRooms = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.LabelAddPatients = new System.Windows.Forms.Label();
            this.bAddPatients = new System.Windows.Forms.Button();
            this.btAdminstration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.C_UserLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_UserLabel.Location = new System.Drawing.Point(612, 24);
            this.C_UserLabel.Name = "C_UserLabel";
            this.C_UserLabel.Size = new System.Drawing.Size(38, 15);
            this.C_UserLabel.TabIndex = 2;
            this.C_UserLabel.Text = "  User";
            // 
            // BtViewPatients
            // 
            this.BtViewPatients.AutoSize = true;
            this.BtViewPatients.BackColor = System.Drawing.Color.White;
            this.BtViewPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtViewPatients.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtViewPatients.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtViewPatients.Location = new System.Drawing.Point(641, 101);
            this.BtViewPatients.Name = "BtViewPatients";
            this.BtViewPatients.Size = new System.Drawing.Size(103, 21);
            this.BtViewPatients.TabIndex = 10;
            this.BtViewPatients.Text = "View Patients";
            this.BtViewPatients.Click += new System.EventHandler(this.BtViewPatients_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 258);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(145, 115);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // btLogout
            // 
            this.btLogout.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.Location = new System.Drawing.Point(929, 20);
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
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Current User:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btAdminstration);
            this.panel1.Controls.Add(this.Intake_Pagebt);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.btRooms);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 763);
            this.panel1.TabIndex = 15;
            // 
            // Intake_Pagebt
            // 
            this.Intake_Pagebt.Location = new System.Drawing.Point(16, 163);
            this.Intake_Pagebt.Name = "Intake_Pagebt";
            this.Intake_Pagebt.Size = new System.Drawing.Size(121, 23);
            this.Intake_Pagebt.TabIndex = 13;
            this.Intake_Pagebt.Text = "Intakes";
            this.Intake_Pagebt.UseVisualStyleBackColor = true;
            this.Intake_Pagebt.Click += new System.EventHandler(this.Intake_Pagebt_Click);
            // 
            // btRooms
            // 
            this.btRooms.Location = new System.Drawing.Point(16, 115);
            this.btRooms.Name = "btRooms";
            this.btRooms.Size = new System.Drawing.Size(121, 23);
            this.btRooms.TabIndex = 3;
            this.btRooms.Text = "Rooms";
            this.btRooms.UseVisualStyleBackColor = true;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btLogout);
            this.panel2.Controls.Add(this.C_UserLabel);
            this.panel2.Location = new System.Drawing.Point(157, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 48);
            this.panel2.TabIndex = 16;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.LabelAddPatients);
            this.panel3.Controls.Add(this.BtViewPatients);
            this.panel3.Controls.Add(this.bAddPatients);
            this.panel3.Location = new System.Drawing.Point(159, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1019, 130);
            this.panel3.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(634, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 85);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LabelAddPatients
            // 
            this.LabelAddPatients.AutoSize = true;
            this.LabelAddPatients.BackColor = System.Drawing.Color.White;
            this.LabelAddPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelAddPatients.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddPatients.Location = new System.Drawing.Point(289, 103);
            this.LabelAddPatients.Name = "LabelAddPatients";
            this.LabelAddPatients.Size = new System.Drawing.Size(87, 19);
            this.LabelAddPatients.TabIndex = 13;
            this.LabelAddPatients.Text = "Add Patient";
            this.LabelAddPatients.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LabelAddPatients.Click += new System.EventHandler(this.LabelAddPatients_Click);
            // 
            // bAddPatients
            // 
            this.bAddPatients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAddPatients.BackgroundImage")));
            this.bAddPatients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAddPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddPatients.Location = new System.Drawing.Point(269, 16);
            this.bAddPatients.Name = "bAddPatients";
            this.bAddPatients.Size = new System.Drawing.Size(126, 85);
            this.bAddPatients.TabIndex = 12;
            this.bAddPatients.UseVisualStyleBackColor = true;
            this.bAddPatients.Click += new System.EventHandler(this.bAddPatients_Click);
            // 
            // btAdminstration
            // 
            this.btAdminstration.Location = new System.Drawing.Point(16, 208);
            this.btAdminstration.Name = "btAdminstration";
            this.btAdminstration.Size = new System.Drawing.Size(121, 23);
            this.btAdminstration.TabIndex = 15;
            this.btAdminstration.Text = "Administation";
            this.btAdminstration.UseVisualStyleBackColor = true;
            this.btAdminstration.Click += new System.EventHandler(this.btAdminstration_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1173, 752);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.IsMdiContainer = true;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BtViewPatients;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Label C_UserLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btRooms;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelAddPatients;
        private System.Windows.Forms.Button bAddPatients;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Intake_Pagebt;
        public System.Windows.Forms.Button btAdminstration;
    }
}