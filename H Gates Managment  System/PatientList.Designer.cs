namespace H_Gates_Managment__System
{
    partial class PatientList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientList));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.C_UserLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btPrevious = new System.Windows.Forms.Button();
            this.BtNext = new System.Windows.Forms.Button();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.PbSearch = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btAddPatient = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btDeletePatient = new System.Windows.Forms.Button();
            this.tbParish = new System.Windows.Forms.TextBox();
            this.tbStreetAddress = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbDateOFBirth = new System.Windows.Forms.TextBox();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.btUpDateDetails = new System.Windows.Forms.Button();
            this.btViewEContact = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbIDNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btLogout = new System.Windows.Forms.Button();
            this.BTHome = new System.Windows.Forms.Button();
            this.patientListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSearch)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "H Gates Hospital";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.BTHome);
            this.panel1.Controls.Add(this.btLogout);
            this.panel1.Controls.Add(this.C_UserLabel);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 76);
            this.panel1.TabIndex = 0;
            // 
            // C_UserLabel
            // 
            this.C_UserLabel.AutoSize = true;
            this.C_UserLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.C_UserLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C_UserLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_UserLabel.Location = new System.Drawing.Point(711, 30);
            this.C_UserLabel.Name = "C_UserLabel";
            this.C_UserLabel.Size = new System.Drawing.Size(38, 15);
            this.C_UserLabel.TabIndex = 16;
            this.C_UserLabel.Text = "  User";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(630, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Current User:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btPrevious);
            this.panel2.Controls.Add(this.BtNext);
            this.panel2.Controls.Add(this.dgvPatients);
            this.panel2.Controls.Add(this.PbSearch);
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Controls.Add(this.btAddPatient);
            this.panel2.Location = new System.Drawing.Point(401, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 376);
            this.panel2.TabIndex = 0;
            // 
            // btPrevious
            // 
            this.btPrevious.Location = new System.Drawing.Point(205, 342);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(75, 23);
            this.btPrevious.TabIndex = 5;
            this.btPrevious.Text = "Previous";
            this.btPrevious.UseVisualStyleBackColor = true;
            // 
            // BtNext
            // 
            this.BtNext.Location = new System.Drawing.Point(311, 342);
            this.BtNext.Name = "BtNext";
            this.BtNext.Size = new System.Drawing.Size(75, 23);
            this.BtNext.TabIndex = 4;
            this.BtNext.Text = "Next";
            this.BtNext.UseVisualStyleBackColor = true;
            this.BtNext.Click += new System.EventHandler(this.BtNext_Click);
            // 
            // dgvPatients
            // 
            this.dgvPatients.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Location = new System.Drawing.Point(24, 51);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(528, 285);
            this.dgvPatients.TabIndex = 3;
            this.dgvPatients.SelectionChanged += new System.EventHandler(this.dgvPatients_SelectionChanged);
            // 
            // PbSearch
            // 
            this.PbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbSearch.BackColor = System.Drawing.SystemColors.Control;
            this.PbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbSearch.Image = ((System.Drawing.Image)(resources.GetObject("PbSearch.Image")));
            this.PbSearch.Location = new System.Drawing.Point(522, 27);
            this.PbSearch.Name = "PbSearch";
            this.PbSearch.Size = new System.Drawing.Size(30, 18);
            this.PbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbSearch.TabIndex = 2;
            this.PbSearch.TabStop = false;
            this.PbSearch.Click += new System.EventHandler(this.PbSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(378, 27);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(152, 18);
            this.tbSearch.TabIndex = 2;
            // 
            // btAddPatient
            // 
            this.btAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btAddPatient.FlatAppearance.BorderSize = 0;
            this.btAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddPatient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddPatient.Location = new System.Drawing.Point(24, 18);
            this.btAddPatient.Name = "btAddPatient";
            this.btAddPatient.Size = new System.Drawing.Size(97, 27);
            this.btAddPatient.TabIndex = 1;
            this.btAddPatient.Text = "Add Patient";
            this.btAddPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btAddPatient.UseVisualStyleBackColor = false;
            this.btAddPatient.Click += new System.EventHandler(this.btAddPatient_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btDeletePatient);
            this.panel3.Controls.Add(this.tbParish);
            this.panel3.Controls.Add(this.tbStreetAddress);
            this.panel3.Controls.Add(this.tbAge);
            this.panel3.Controls.Add(this.tbDateOFBirth);
            this.panel3.Controls.Add(this.tbGender);
            this.panel3.Controls.Add(this.tbLastName);
            this.panel3.Controls.Add(this.tbFirstName);
            this.panel3.Controls.Add(this.btUpDateDetails);
            this.panel3.Controls.Add(this.btViewEContact);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 376);
            this.panel3.TabIndex = 1;
            // 
            // btDeletePatient
            // 
            this.btDeletePatient.BackColor = System.Drawing.Color.Red;
            this.btDeletePatient.Location = new System.Drawing.Point(259, 342);
            this.btDeletePatient.Name = "btDeletePatient";
            this.btDeletePatient.Size = new System.Drawing.Size(115, 23);
            this.btDeletePatient.TabIndex = 18;
            this.btDeletePatient.Text = "Delete Selected Record";
            this.btDeletePatient.UseVisualStyleBackColor = false;
            this.btDeletePatient.Click += new System.EventHandler(this.btDeletePatient_Click);
            // 
            // tbParish
            // 
            this.tbParish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbParish.Location = new System.Drawing.Point(117, 178);
            this.tbParish.Multiline = true;
            this.tbParish.Name = "tbParish";
            this.tbParish.Size = new System.Drawing.Size(147, 20);
            this.tbParish.TabIndex = 17;
            // 
            // tbStreetAddress
            // 
            this.tbStreetAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStreetAddress.Location = new System.Drawing.Point(128, 153);
            this.tbStreetAddress.Multiline = true;
            this.tbStreetAddress.Name = "tbStreetAddress";
            this.tbStreetAddress.Size = new System.Drawing.Size(136, 20);
            this.tbStreetAddress.TabIndex = 16;
            // 
            // tbAge
            // 
            this.tbAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAge.Location = new System.Drawing.Point(307, 127);
            this.tbAge.Multiline = true;
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(76, 20);
            this.tbAge.TabIndex = 15;
            // 
            // tbDateOFBirth
            // 
            this.tbDateOFBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDateOFBirth.Location = new System.Drawing.Point(111, 127);
            this.tbDateOFBirth.Multiline = true;
            this.tbDateOFBirth.Name = "tbDateOFBirth";
            this.tbDateOFBirth.Size = new System.Drawing.Size(121, 20);
            this.tbDateOFBirth.TabIndex = 14;
            // 
            // tbGender
            // 
            this.tbGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGender.Location = new System.Drawing.Point(111, 99);
            this.tbGender.Multiline = true;
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(79, 20);
            this.tbGender.TabIndex = 13;
            // 
            // tbLastName
            // 
            this.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLastName.Location = new System.Drawing.Point(111, 68);
            this.tbLastName.Multiline = true;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(171, 20);
            this.tbLastName.TabIndex = 12;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFirstName.Location = new System.Drawing.Point(111, 42);
            this.tbFirstName.Multiline = true;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(171, 20);
            this.tbFirstName.TabIndex = 11;
            // 
            // btUpDateDetails
            // 
            this.btUpDateDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btUpDateDetails.Location = new System.Drawing.Point(207, 237);
            this.btUpDateDetails.Name = "btUpDateDetails";
            this.btUpDateDetails.Size = new System.Drawing.Size(167, 23);
            this.btUpDateDetails.TabIndex = 10;
            this.btUpDateDetails.Text = "Up Date Detials";
            this.btUpDateDetails.UseVisualStyleBackColor = false;
            this.btUpDateDetails.Click += new System.EventHandler(this.btUpDateDetails_Click);
            // 
            // btViewEContact
            // 
            this.btViewEContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btViewEContact.Location = new System.Drawing.Point(35, 237);
            this.btViewEContact.Name = "btViewEContact";
            this.btViewEContact.Size = new System.Drawing.Size(155, 23);
            this.btViewEContact.TabIndex = 9;
            this.btViewEContact.Text = "View Emergency Contact";
            this.btViewEContact.UseVisualStyleBackColor = false;
            this.btViewEContact.Click += new System.EventHandler(this.btViewEContact_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Parish:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "D.O.B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Street Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.tbIDNo);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(0, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(405, 33);
            this.panel4.TabIndex = 0;
            // 
            // tbIDNo
            // 
            this.tbIDNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbIDNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIDNo.Location = new System.Drawing.Point(326, 9);
            this.tbIDNo.Multiline = true;
            this.tbIDNo.Name = "tbIDNo";
            this.tbIDNo.Size = new System.Drawing.Size(45, 20);
            this.tbIDNo.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(277, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "ID No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "PATIENT DETIALS ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btLogout
            // 
            this.btLogout.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.Location = new System.Drawing.Point(878, 26);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(75, 23);
            this.btLogout.TabIndex = 17;
            this.btLogout.Text = "Log Out";
            this.btLogout.UseVisualStyleBackColor = true;
            // 
            // BTHome
            // 
            this.BTHome.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTHome.Location = new System.Drawing.Point(797, 26);
            this.BTHome.Name = "BTHome";
            this.BTHome.Size = new System.Drawing.Size(75, 23);
            this.BTHome.TabIndex = 18;
            this.BTHome.Text = "Home";
            this.BTHome.UseVisualStyleBackColor = true;
            this.BTHome.Click += new System.EventHandler(this.BTHome_Click);
            // 
            // patientListBindingSource
            // 
            this.patientListBindingSource.DataSource = typeof(H_Gates_Managment__System.PatientList);
            // 
            // PatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PatientList";
            this.Text = "MainPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatientList_FormClosing);
            this.Load += new System.EventHandler(this.PatientList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSearch)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btAddPatient;
        private System.Windows.Forms.BindingSource patientListBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbParish;
        private System.Windows.Forms.TextBox tbStreetAddress;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbDateOFBirth;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Button btUpDateDetails;
        private System.Windows.Forms.Button btViewEContact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbIDNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Button btPrevious;
        private System.Windows.Forms.Button BtNext;
        private System.Windows.Forms.Button btDeletePatient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label C_UserLabel;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button BTHome;
    }
}