namespace H_Gates_Managment__System
{
    partial class IntakePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.intakeManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.editRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvIntakelist = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTHome = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.C_UserLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btdelete = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntakelist)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intakeManagementToolStripMenuItem,
            this.viewRoomsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(131, 580);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // intakeManagementToolStripMenuItem
            // 
            this.intakeManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecord,
            this.editRecordToolStripMenuItem,
            this.deleteRecord});
            this.intakeManagementToolStripMenuItem.Name = "intakeManagementToolStripMenuItem";
            this.intakeManagementToolStripMenuItem.Size = new System.Drawing.Size(124, 19);
            this.intakeManagementToolStripMenuItem.Text = "Intake Management ";
            // 
            // addRecord
            // 
            this.addRecord.Name = "addRecord";
            this.addRecord.Size = new System.Drawing.Size(180, 22);
            this.addRecord.Text = "Add Record";
            this.addRecord.Click += new System.EventHandler(this.addRecord_Click);
            // 
            // editRecordToolStripMenuItem
            // 
            this.editRecordToolStripMenuItem.Name = "editRecordToolStripMenuItem";
            this.editRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editRecordToolStripMenuItem.Text = "Edit Record";
            this.editRecordToolStripMenuItem.Click += new System.EventHandler(this.editRecordToolStripMenuItem_Click);
            // 
            // deleteRecord
            // 
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(180, 22);
            this.deleteRecord.Text = "Delete Record";
            this.deleteRecord.Click += new System.EventHandler(this.deleteRecord_Click);
            // 
            // viewRoomsToolStripMenuItem
            // 
            this.viewRoomsToolStripMenuItem.Name = "viewRoomsToolStripMenuItem";
            this.viewRoomsToolStripMenuItem.Size = new System.Drawing.Size(124, 19);
            this.viewRoomsToolStripMenuItem.Text = "View Rooms";
            // 
            // dgvIntakelist
            // 
            this.dgvIntakelist.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvIntakelist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvIntakelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntakelist.Location = new System.Drawing.Point(476, 76);
            this.dgvIntakelist.MultiSelect = false;
            this.dgvIntakelist.Name = "dgvIntakelist";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntakelist.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIntakelist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIntakelist.Size = new System.Drawing.Size(708, 483);
            this.dgvIntakelist.TabIndex = 2;
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
            this.panel1.Location = new System.Drawing.Point(131, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 76);
            this.panel1.TabIndex = 3;
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
            // btLogout
            // 
            this.btLogout.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.Location = new System.Drawing.Point(878, 26);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(75, 23);
            this.btLogout.TabIndex = 17;
            this.btLogout.Text = "Log Out";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
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
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btdelete.Location = new System.Drawing.Point(1190, 82);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 5;
            this.btdelete.Text = "Delete Record";
            this.btdelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // IntakePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1271, 580);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvIntakelist);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IntakePage";
            this.Text = "IntakePage";
            this.Load += new System.EventHandler(this.IntakePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntakelist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem intakeManagementToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvIntakelist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTHome;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Label C_UserLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem viewRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecord;
        private System.Windows.Forms.ToolStripMenuItem editRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecord;
        private System.Windows.Forms.Button btdelete;
    }
}