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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.viewAllPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "H Gates Hospital";
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllPatientsToolStripMenuItem,
            this.searchPatientsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(-7, 54);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(600, 62);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // viewAllPatientsToolStripMenuItem
            // 
            this.viewAllPatientsToolStripMenuItem.Name = "viewAllPatientsToolStripMenuItem";
            this.viewAllPatientsToolStripMenuItem.Size = new System.Drawing.Size(106, 58);
            this.viewAllPatientsToolStripMenuItem.Text = "View All Patients";
            this.viewAllPatientsToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // searchPatientsToolStripMenuItem
            // 
            this.searchPatientsToolStripMenuItem.Name = "searchPatientsToolStripMenuItem";
            this.searchPatientsToolStripMenuItem.Size = new System.Drawing.Size(99, 58);
            this.searchPatientsToolStripMenuItem.Text = "Search Patients";
            this.searchPatientsToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // dgvPatients
            // 
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Location = new System.Drawing.Point(3, 119);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.Size = new System.Drawing.Size(590, 237);
            this.dgvPatients.TabIndex = 7;
            // 
            // PatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PatientList";
            this.Text = "PatientList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatientList_FormClosing);
            this.Load += new System.EventHandler(this.PatientList_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem viewAllPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPatientsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvPatients;
    }
}