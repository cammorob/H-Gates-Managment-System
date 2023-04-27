namespace H_Gates_Managment__System
{
    partial class Users_Administration
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblHeader = new System.Windows.Forms.Label();
            this.btDeactivate = new System.Windows.Forms.Button();
            this.BtAddNewUser = new System.Windows.Forms.Button();
            this.BtEditUser = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btAddUser = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.DeAct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btResetPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(35, 75);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(384, 186);
            this.dgvUsers.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(323, -98);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(0, 22);
            this.lblHeader.TabIndex = 12;
            // 
            // btDeactivate
            // 
            this.btDeactivate.Location = new System.Drawing.Point(754, 235);
            this.btDeactivate.Name = "btDeactivate";
            this.btDeactivate.Size = new System.Drawing.Size(10, 10);
            this.btDeactivate.TabIndex = 10;
            this.btDeactivate.Text = "Deactivate User";
            this.btDeactivate.UseVisualStyleBackColor = true;
            // 
            // BtAddNewUser
            // 
            this.BtAddNewUser.Location = new System.Drawing.Point(754, 105);
            this.BtAddNewUser.Name = "BtAddNewUser";
            this.BtAddNewUser.Size = new System.Drawing.Size(10, 10);
            this.BtAddNewUser.TabIndex = 9;
            this.BtAddNewUser.Text = "Add New User";
            this.BtAddNewUser.UseVisualStyleBackColor = true;
            // 
            // BtEditUser
            // 
            this.BtEditUser.Location = new System.Drawing.Point(754, 179);
            this.BtEditUser.Name = "BtEditUser";
            this.BtEditUser.Size = new System.Drawing.Size(10, 10);
            this.BtEditUser.TabIndex = 8;
            this.BtEditUser.Text = "Edit User";
            this.BtEditUser.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btAddUser
            // 
            this.btAddUser.Location = new System.Drawing.Point(499, 86);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(93, 23);
            this.btAddUser.TabIndex = 13;
            this.btAddUser.Text = "Add New User";
            this.btAddUser.UseVisualStyleBackColor = true;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(499, 136);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(93, 23);
            this.btEdit.TabIndex = 14;
            this.btEdit.Text = "Edit User";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // DeAct
            // 
            this.DeAct.Location = new System.Drawing.Point(499, 229);
            this.DeAct.Name = "DeAct";
            this.DeAct.Size = new System.Drawing.Size(93, 23);
            this.DeAct.TabIndex = 15;
            this.DeAct.Text = "Deactivate User";
            this.DeAct.UseVisualStyleBackColor = true;
            this.DeAct.Click += new System.EventHandler(this.DeAct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Manage Users";
            // 
            // btResetPassword
            // 
            this.btResetPassword.Location = new System.Drawing.Point(499, 184);
            this.btResetPassword.Name = "btResetPassword";
            this.btResetPassword.Size = new System.Drawing.Size(93, 23);
            this.btResetPassword.TabIndex = 17;
            this.btResetPassword.Text = "Reset Password";
            this.btResetPassword.UseVisualStyleBackColor = true;
            this.btResetPassword.Click += new System.EventHandler(this.btResetPassword_Click);
            // 
            // Users_Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 333);
            this.Controls.Add(this.btResetPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeAct);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAddUser);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btDeactivate);
            this.Controls.Add(this.BtAddNewUser);
            this.Controls.Add(this.BtEditUser);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Users_Administration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Users_Administration";
            this.Load += new System.EventHandler(this.Users_Administration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btDeactivate;
        private System.Windows.Forms.Button BtAddNewUser;
        private System.Windows.Forms.Button BtEditUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btAddUser;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button DeAct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btResetPassword;
    }
}