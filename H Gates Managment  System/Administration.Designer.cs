namespace H_Gates_Managment__System
{
    partial class Administration
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtEditUser = new System.Windows.Forms.Button();
            this.BtAddNewUser = new System.Windows.Forms.Button();
            this.btDeactivate = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.doctorsToolStripMenuItem1,
            this.nursesToolStripMenuItem,
            this.otherUserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.manageUsersToolStripMenuItem.Text = "Administrators";
            // 
            // doctorsToolStripMenuItem1
            // 
            this.doctorsToolStripMenuItem1.Name = "doctorsToolStripMenuItem1";
            this.doctorsToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.doctorsToolStripMenuItem1.Text = "Doctors";
            this.doctorsToolStripMenuItem1.Click += new System.EventHandler(this.doctorsToolStripMenuItem1_Click);
            // 
            // nursesToolStripMenuItem
            // 
            this.nursesToolStripMenuItem.Name = "nursesToolStripMenuItem";
            this.nursesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.nursesToolStripMenuItem.Text = "Nurses";
            this.nursesToolStripMenuItem.Click += new System.EventHandler(this.nursesToolStripMenuItem_Click);
            // 
            // otherUserToolStripMenuItem
            // 
            this.otherUserToolStripMenuItem.Name = "otherUserToolStripMenuItem";
            this.otherUserToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.otherUserToolStripMenuItem.Text = "Other User";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BtEditUser
            // 
            this.BtEditUser.Location = new System.Drawing.Point(802, 181);
            this.BtEditUser.Name = "BtEditUser";
            this.BtEditUser.Size = new System.Drawing.Size(93, 23);
            this.BtEditUser.TabIndex = 2;
            this.BtEditUser.Text = "Edit User";
            this.BtEditUser.UseVisualStyleBackColor = true;
            this.BtEditUser.Click += new System.EventHandler(this.BtEditUser_Click);
            // 
            // BtAddNewUser
            // 
            this.BtAddNewUser.Location = new System.Drawing.Point(802, 123);
            this.BtAddNewUser.Name = "BtAddNewUser";
            this.BtAddNewUser.Size = new System.Drawing.Size(93, 23);
            this.BtAddNewUser.TabIndex = 3;
            this.BtAddNewUser.Text = "Add New User";
            this.BtAddNewUser.UseVisualStyleBackColor = true;
            this.BtAddNewUser.Click += new System.EventHandler(this.BtAddNewUser_Click);
            // 
            // btDeactivate
            // 
            this.btDeactivate.Location = new System.Drawing.Point(802, 290);
            this.btDeactivate.Name = "btDeactivate";
            this.btDeactivate.Size = new System.Drawing.Size(93, 23);
            this.btDeactivate.TabIndex = 4;
            this.btDeactivate.Text = "Deactivate User";
            this.btDeactivate.UseVisualStyleBackColor = true;
            this.btDeactivate.Click += new System.EventHandler(this.btDeactivate_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(76, 123);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(491, 300);
            this.dgvUsers.TabIndex = 5;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(371, 55);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(0, 22);
            this.lblHeader.TabIndex = 6;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 588);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btDeactivate);
            this.Controls.Add(this.BtAddNewUser);
            this.Controls.Add(this.BtEditUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administration";
            this.Text = "Manage Users";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherUserToolStripMenuItem;
        private System.Windows.Forms.Button BtEditUser;
        private System.Windows.Forms.Button BtAddNewUser;
        private System.Windows.Forms.Button btDeactivate;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblHeader;
    }
}