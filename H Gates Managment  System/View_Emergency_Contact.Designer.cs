namespace H_Gates_Managment__System
{
    partial class tbshowRelation
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
            this.label5 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.Emergencydgv = new System.Windows.Forms.DataGridView();
            this.btUpDateEmergency = new System.Windows.Forms.Button();
            this.tbEAddress = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbENumber = new System.Windows.Forms.TextBox();
            this.tbEName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbERelationship = new System.Windows.Forms.ComboBox();
            this.TbEDelete = new System.Windows.Forms.Button();
            this.hGatesDesktopAppDataSet = new H_Gates_Managment__System.HGatesDesktopAppDataSet();
            this.tbDisplayEname = new System.Windows.Forms.TextBox();
            this.tbContactNumber = new System.Windows.Forms.TextBox();
            this.tbERelation = new System.Windows.Forms.TextBox();
            this.tbContactAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Emergencydgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hGatesDesktopAppDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(264, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Emergency Contact";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(356, 106);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(106, 34);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Emergencydgv
            // 
            this.Emergencydgv.AllowUserToAddRows = false;
            this.Emergencydgv.AllowUserToDeleteRows = false;
            this.Emergencydgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Emergencydgv.Location = new System.Drawing.Point(594, 40);
            this.Emergencydgv.Name = "Emergencydgv";
            this.Emergencydgv.ReadOnly = true;
            this.Emergencydgv.Size = new System.Drawing.Size(131, 54);
            this.Emergencydgv.TabIndex = 12;
            // 
            // btUpDateEmergency
            // 
            this.btUpDateEmergency.Location = new System.Drawing.Point(86, 129);
            this.btUpDateEmergency.Name = "btUpDateEmergency";
            this.btUpDateEmergency.Size = new System.Drawing.Size(106, 34);
            this.btUpDateEmergency.TabIndex = 13;
            this.btUpDateEmergency.Text = "Update Record";
            this.btUpDateEmergency.UseVisualStyleBackColor = true;
            this.btUpDateEmergency.Click += new System.EventHandler(this.btUpDateEmergency_Click);
            // 
            // tbEAddress
            // 
            this.tbEAddress.FormattingEnabled = true;
            this.tbEAddress.Location = new System.Drawing.Point(409, 235);
            this.tbEAddress.Name = "tbEAddress";
            this.tbEAddress.Size = new System.Drawing.Size(159, 21);
            this.tbEAddress.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(622, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "Relationship";
            // 
            // tbENumber
            // 
            this.tbENumber.Location = new System.Drawing.Point(585, 235);
            this.tbENumber.Name = "tbENumber";
            this.tbENumber.Size = new System.Drawing.Size(159, 20);
            this.tbENumber.TabIndex = 32;
            // 
            // tbEName
            // 
            this.tbEName.Location = new System.Drawing.Point(409, 186);
            this.tbEName.Name = "tbEName";
            this.tbEName.Size = new System.Drawing.Size(159, 20);
            this.tbEName.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(457, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(622, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(457, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "First Name :";
            // 
            // tbERelationship
            // 
            this.tbERelationship.FormattingEnabled = true;
            this.tbERelationship.Location = new System.Drawing.Point(585, 186);
            this.tbERelationship.Name = "tbERelationship";
            this.tbERelationship.Size = new System.Drawing.Size(159, 21);
            this.tbERelationship.TabIndex = 35;
            // 
            // TbEDelete
            // 
            this.TbEDelete.BackColor = System.Drawing.Color.Red;
            this.TbEDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEDelete.Location = new System.Drawing.Point(648, 9);
            this.TbEDelete.Name = "TbEDelete";
            this.TbEDelete.Size = new System.Drawing.Size(106, 25);
            this.TbEDelete.TabIndex = 36;
            this.TbEDelete.Text = "Delete Record";
            this.TbEDelete.UseVisualStyleBackColor = false;
            this.TbEDelete.Click += new System.EventHandler(this.TbEDelete_Click);
            // 
            // hGatesDesktopAppDataSet
            // 
            this.hGatesDesktopAppDataSet.DataSetName = "HGatesDesktopAppDataSet";
            this.hGatesDesktopAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbDisplayEname
            // 
            this.tbDisplayEname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDisplayEname.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisplayEname.Location = new System.Drawing.Point(39, 58);
            this.tbDisplayEname.Name = "tbDisplayEname";
            this.tbDisplayEname.ReadOnly = true;
            this.tbDisplayEname.Size = new System.Drawing.Size(123, 15);
            this.tbDisplayEname.TabIndex = 37;
            // 
            // tbContactNumber
            // 
            this.tbContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContactNumber.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContactNumber.Location = new System.Drawing.Point(297, 60);
            this.tbContactNumber.Name = "tbContactNumber";
            this.tbContactNumber.ReadOnly = true;
            this.tbContactNumber.Size = new System.Drawing.Size(123, 15);
            this.tbContactNumber.TabIndex = 38;
            // 
            // tbERelation
            // 
            this.tbERelation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbERelation.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbERelation.Location = new System.Drawing.Point(426, 60);
            this.tbERelation.Name = "tbERelation";
            this.tbERelation.ReadOnly = true;
            this.tbERelation.Size = new System.Drawing.Size(123, 15);
            this.tbERelation.TabIndex = 39;
            // 
            // tbContactAddress
            // 
            this.tbContactAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContactAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContactAddress.Location = new System.Drawing.Point(168, 58);
            this.tbContactAddress.Name = "tbContactAddress";
            this.tbContactAddress.ReadOnly = true;
            this.tbContactAddress.Size = new System.Drawing.Size(123, 15);
            this.tbContactAddress.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Relationship";
            // 
            // tbshowRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(756, 286);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbContactAddress);
            this.Controls.Add(this.tbERelation);
            this.Controls.Add(this.tbContactNumber);
            this.Controls.Add(this.tbDisplayEname);
            this.Controls.Add(this.TbEDelete);
            this.Controls.Add(this.tbERelationship);
            this.Controls.Add(this.tbEAddress);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbENumber);
            this.Controls.Add(this.tbEName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btUpDateEmergency);
            this.Controls.Add(this.Emergencydgv);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label5);
            this.Name = "tbshowRelation";
            this.Text = "View_Emergency_contact";
            this.Load += new System.EventHandler(this.View_Emergency_contact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Emergencydgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hGatesDesktopAppDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridView Emergencydgv;
        private System.Windows.Forms.Button btUpDateEmergency;
        private System.Windows.Forms.ComboBox tbEAddress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbENumber;
        private System.Windows.Forms.TextBox tbEName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox tbERelationship;
        private System.Windows.Forms.Button TbEDelete;
        private HGatesDesktopAppDataSet hGatesDesktopAppDataSet;
        public System.Windows.Forms.TextBox tbDisplayEname;
        public System.Windows.Forms.TextBox tbContactNumber;
        public System.Windows.Forms.TextBox tbERelation;
        public System.Windows.Forms.TextBox tbContactAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}