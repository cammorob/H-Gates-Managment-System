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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.intakeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intakeManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intakeListToolStripMenuItem,
            this.intakeManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // intakeListToolStripMenuItem
            // 
            this.intakeListToolStripMenuItem.Name = "intakeListToolStripMenuItem";
            this.intakeListToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.intakeListToolStripMenuItem.Text = "Intake List ";
            this.intakeListToolStripMenuItem.Click += new System.EventHandler(this.intakeListToolStripMenuItem_Click);
            // 
            // intakeManagementToolStripMenuItem
            // 
            this.intakeManagementToolStripMenuItem.Name = "intakeManagementToolStripMenuItem";
            this.intakeManagementToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.intakeManagementToolStripMenuItem.Text = "Intake Management ";
            this.intakeManagementToolStripMenuItem.Click += new System.EventHandler(this.intakeManagementToolStripMenuItem_Click);
            // 
            // IntakePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 565);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IntakePage";
            this.Text = "IntakePage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem intakeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intakeManagementToolStripMenuItem;
    }
}