namespace H_Gates_Managment__System
{
    partial class View_Emergency_contact
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
            this.label5 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.Emergencydgv = new System.Windows.Forms.DataGridView();
            this.viewEmergencycontactBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
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
            this.viewEmergencycontactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewEmergencycontactBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hGatesDesktopAppDataSet = new H_Gates_Managment__System.HGatesDesktopAppDataSet();
            this.viewEmergencyContactBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.viewEmergencyContactTableAdapter = new H_Gates_Managment__System.HGatesDesktopAppDataSetTableAdapters.ViewEmergencyContactTableAdapter();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eContactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationshipTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parishNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Emergencydgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmergencycontactBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmergencycontactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmergencycontactBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hGatesDesktopAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmergencyContactBindingSource3)).BeginInit();
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
            this.Emergencydgv.AutoGenerateColumns = false;
            this.Emergencydgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Emergencydgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactNameDataGridViewTextBoxColumn,
            this.eContactNoDataGridViewTextBoxColumn,
            this.relationshipTypeDataGridViewTextBoxColumn,
            this.parishNameDataGridViewTextBoxColumn});
            this.Emergencydgv.DataSource = this.viewEmergencyContactBindingSource3;
            this.Emergencydgv.Location = new System.Drawing.Point(84, 34);
            this.Emergencydgv.Name = "Emergencydgv";
            this.Emergencydgv.ReadOnly = true;
            this.Emergencydgv.Size = new System.Drawing.Size(443, 54);
            this.Emergencydgv.TabIndex = 12;
            // 
            // viewEmergencycontactBindingSource2
            // 
            this.viewEmergencycontactBindingSource2.DataSource = typeof(H_Gates_Managment__System.View_Emergency_contact);
            // 
            // btUpDateEmergency
            // 
            this.btUpDateEmergency.Location = new System.Drawing.Point(233, 106);
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
            this.tbEAddress.Location = new System.Drawing.Point(368, 176);
            this.tbEAddress.Name = "tbEAddress";
            this.tbEAddress.Size = new System.Drawing.Size(159, 21);
            this.tbEAddress.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(246, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 18);
            this.label16.TabIndex = 33;
            this.label16.Text = "Relationship";
            // 
            // tbENumber
            // 
            this.tbENumber.Location = new System.Drawing.Point(560, 177);
            this.tbENumber.Name = "tbENumber";
            this.tbENumber.Size = new System.Drawing.Size(159, 20);
            this.tbENumber.TabIndex = 32;
            // 
            // tbEName
            // 
            this.tbEName.Location = new System.Drawing.Point(12, 176);
            this.tbEName.Name = "tbEName";
            this.tbEName.Size = new System.Drawing.Size(159, 20);
            this.tbEName.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(411, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 22);
            this.label12.TabIndex = 27;
            this.label12.Text = "Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(612, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 22);
            this.label13.TabIndex = 28;
            this.label13.Text = "Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(67, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 18);
            this.label14.TabIndex = 29;
            this.label14.Text = "First Name :";
            // 
            // tbERelationship
            // 
            this.tbERelationship.FormattingEnabled = true;
            this.tbERelationship.Location = new System.Drawing.Point(198, 175);
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
            // viewEmergencycontactBindingSource
            // 
            this.viewEmergencycontactBindingSource.DataSource = typeof(H_Gates_Managment__System.View_Emergency_contact);
            // 
            // viewEmergencycontactBindingSource1
            // 
            this.viewEmergencycontactBindingSource1.DataSource = typeof(H_Gates_Managment__System.View_Emergency_contact);
            // 
            // hGatesDesktopAppDataSet
            // 
            this.hGatesDesktopAppDataSet.DataSetName = "HGatesDesktopAppDataSet";
            this.hGatesDesktopAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewEmergencyContactBindingSource3
            // 
            this.viewEmergencyContactBindingSource3.DataMember = "ViewEmergencyContact";
            this.viewEmergencyContactBindingSource3.DataSource = this.hGatesDesktopAppDataSet;
            // 
            // viewEmergencyContactTableAdapter
            // 
            this.viewEmergencyContactTableAdapter.ClearBeforeFill = true;
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            this.contactNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eContactNoDataGridViewTextBoxColumn
            // 
            this.eContactNoDataGridViewTextBoxColumn.DataPropertyName = "EContactNo";
            this.eContactNoDataGridViewTextBoxColumn.HeaderText = "EContactNo";
            this.eContactNoDataGridViewTextBoxColumn.Name = "eContactNoDataGridViewTextBoxColumn";
            this.eContactNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // relationshipTypeDataGridViewTextBoxColumn
            // 
            this.relationshipTypeDataGridViewTextBoxColumn.DataPropertyName = "RelationshipType";
            this.relationshipTypeDataGridViewTextBoxColumn.HeaderText = "RelationshipType";
            this.relationshipTypeDataGridViewTextBoxColumn.Name = "relationshipTypeDataGridViewTextBoxColumn";
            this.relationshipTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parishNameDataGridViewTextBoxColumn
            // 
            this.parishNameDataGridViewTextBoxColumn.DataPropertyName = "ParishName";
            this.parishNameDataGridViewTextBoxColumn.HeaderText = "ParishName";
            this.parishNameDataGridViewTextBoxColumn.Name = "parishNameDataGridViewTextBoxColumn";
            this.parishNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // View_Emergency_contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(756, 209);
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
            this.Name = "View_Emergency_contact";
            this.Text = "View_Emergency_contact";
            this.Load += new System.EventHandler(this.View_Emergency_contact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Emergencydgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmergencycontactBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmergencycontactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmergencycontactBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hGatesDesktopAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmergencyContactBindingSource3)).EndInit();
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
        private System.Windows.Forms.BindingSource viewEmergencycontactBindingSource1;
        private System.Windows.Forms.BindingSource viewEmergencycontactBindingSource;
        private System.Windows.Forms.BindingSource viewEmergencycontactBindingSource2;
        private HGatesDesktopAppDataSet hGatesDesktopAppDataSet;
        private System.Windows.Forms.BindingSource viewEmergencyContactBindingSource3;
        private HGatesDesktopAppDataSetTableAdapters.ViewEmergencyContactTableAdapter viewEmergencyContactTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eContactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationshipTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parishNameDataGridViewTextBoxColumn;
    }
}