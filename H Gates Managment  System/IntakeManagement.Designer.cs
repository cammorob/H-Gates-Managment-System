namespace H_Gates_Managment__System
{
    partial class IntakeManagement
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
            this.dvIntake_Managment_list = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvIntake_Managment_list)).BeginInit();
            this.SuspendLayout();
            // 
            // dvIntake_Managment_list
            // 
            this.dvIntake_Managment_list.AllowUserToAddRows = false;
            this.dvIntake_Managment_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvIntake_Managment_list.Location = new System.Drawing.Point(12, 108);
            this.dvIntake_Managment_list.Name = "dvIntake_Managment_list";
            this.dvIntake_Managment_list.Size = new System.Drawing.Size(1351, 388);
            this.dvIntake_Managment_list.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Intake Data Management System";
            // 
            // IntakeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 668);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvIntake_Managment_list);
            this.Name = "IntakeManagement";
            this.Text = "IntakeManagement";
            this.Load += new System.EventHandler(this.IntakeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvIntake_Managment_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvIntake_Managment_list;
        private System.Windows.Forms.Label label2;
    }
}