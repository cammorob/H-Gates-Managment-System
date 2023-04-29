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
            this.doctorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorsToolStripMenuItem1,
            this.nursesToolStripMenuItem,
            this.otherUserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doctorsToolStripMenuItem1
            // 
            this.doctorsToolStripMenuItem1.Name = "doctorsToolStripMenuItem1";
            this.doctorsToolStripMenuItem1.Size = new System.Drawing.Size(106, 20);
            this.doctorsToolStripMenuItem1.Text = "Manage Doctors";
            this.doctorsToolStripMenuItem1.Click += new System.EventHandler(this.doctorsToolStripMenuItem1_Click);
            // 
            // nursesToolStripMenuItem
            // 
            this.nursesToolStripMenuItem.Name = "nursesToolStripMenuItem";
            this.nursesToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.nursesToolStripMenuItem.Text = "Manage Nurses";
            this.nursesToolStripMenuItem.Click += new System.EventHandler(this.nursesToolStripMenuItem_Click);
            // 
            // otherUserToolStripMenuItem
            // 
            this.otherUserToolStripMenuItem.Name = "otherUserToolStripMenuItem";
            this.otherUserToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.otherUserToolStripMenuItem.Text = "System Users";
            this.otherUserToolStripMenuItem.Click += new System.EventHandler(this.otherUserToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(169, 123);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(479, 172);
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
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(448, 317);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(110, 23);
            this.btUpdate.TabIndex = 8;
            this.btUpdate.Text = "Update Selected";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(267, 317);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(104, 23);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 543);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administration_FormClosing);
            this.Load += new System.EventHandler(this.doctorsToolStripMenuItem1_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherUserToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
    }
}