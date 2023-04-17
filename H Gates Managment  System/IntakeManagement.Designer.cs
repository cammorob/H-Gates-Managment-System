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
            this.Editbt = new System.Windows.Forms.Button();
            this.Deletebt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvIntake_Managment_list)).BeginInit();
            this.SuspendLayout();
            // 
            // dvIntake_Managment_list
            // 
            this.dvIntake_Managment_list.AllowUserToAddRows = false;
            this.dvIntake_Managment_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvIntake_Managment_list.Location = new System.Drawing.Point(12, 136);
            this.dvIntake_Managment_list.Name = "dvIntake_Managment_list";
            this.dvIntake_Managment_list.Size = new System.Drawing.Size(579, 345);
            this.dvIntake_Managment_list.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Intake Data Management System";
            // 
            // Editbt
            // 
            this.Editbt.Location = new System.Drawing.Point(641, 136);
            this.Editbt.Name = "Editbt";
            this.Editbt.Size = new System.Drawing.Size(166, 72);
            this.Editbt.TabIndex = 6;
            this.Editbt.Text = "Edit Intake List";
            this.Editbt.UseVisualStyleBackColor = true;
            this.Editbt.Click += new System.EventHandler(this.Editbt_Click);
            // 
            // Deletebt
            // 
            this.Deletebt.Location = new System.Drawing.Point(641, 239);
            this.Deletebt.Name = "Deletebt";
            this.Deletebt.Size = new System.Drawing.Size(166, 79);
            this.Deletebt.TabIndex = 7;
            this.Deletebt.Text = "Delete Intake List";
            this.Deletebt.UseVisualStyleBackColor = true;
            this.Deletebt.Click += new System.EventHandler(this.Deletebt_Click);
            // 
            // IntakeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 541);
            this.Controls.Add(this.Deletebt);
            this.Controls.Add(this.Editbt);
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
        private System.Windows.Forms.Button Editbt;
        private System.Windows.Forms.Button Deletebt;
    }
}