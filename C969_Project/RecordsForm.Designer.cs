
namespace C969_Project
{
    partial class RecordsForm
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
            this.AddCustomerBtn = new System.Windows.Forms.Button();
            this.ModifyCustomerBtn = new System.Windows.Forms.Button();
            this.DeleteCustomerBtn = new System.Windows.Forms.Button();
            this.AppointmentsBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCustomerBtn
            // 
            this.AddCustomerBtn.Location = new System.Drawing.Point(1022, 26);
            this.AddCustomerBtn.Name = "AddCustomerBtn";
            this.AddCustomerBtn.Size = new System.Drawing.Size(184, 38);
            this.AddCustomerBtn.TabIndex = 1;
            this.AddCustomerBtn.Text = "Add New Customer";
            this.AddCustomerBtn.UseVisualStyleBackColor = true;
            this.AddCustomerBtn.Click += new System.EventHandler(this.AddCustomerBtn_Click);
            // 
            // ModifyCustomerBtn
            // 
            this.ModifyCustomerBtn.Location = new System.Drawing.Point(1022, 80);
            this.ModifyCustomerBtn.Name = "ModifyCustomerBtn";
            this.ModifyCustomerBtn.Size = new System.Drawing.Size(184, 38);
            this.ModifyCustomerBtn.TabIndex = 2;
            this.ModifyCustomerBtn.Text = "Modify Customer";
            this.ModifyCustomerBtn.UseVisualStyleBackColor = true;
            this.ModifyCustomerBtn.Click += new System.EventHandler(this.ModifyCustomerBtn_Click);
            // 
            // DeleteCustomerBtn
            // 
            this.DeleteCustomerBtn.Location = new System.Drawing.Point(1022, 132);
            this.DeleteCustomerBtn.Name = "DeleteCustomerBtn";
            this.DeleteCustomerBtn.Size = new System.Drawing.Size(184, 38);
            this.DeleteCustomerBtn.TabIndex = 3;
            this.DeleteCustomerBtn.Text = "Delete Customer";
            this.DeleteCustomerBtn.UseVisualStyleBackColor = true;
            this.DeleteCustomerBtn.Click += new System.EventHandler(this.DeleteCustomerBtn_Click);
            // 
            // AppointmentsBtn
            // 
            this.AppointmentsBtn.Location = new System.Drawing.Point(1021, 190);
            this.AppointmentsBtn.Name = "AppointmentsBtn";
            this.AppointmentsBtn.Size = new System.Drawing.Size(184, 65);
            this.AppointmentsBtn.TabIndex = 4;
            this.AppointmentsBtn.Text = "Appointments";
            this.AppointmentsBtn.UseVisualStyleBackColor = true;
            this.AppointmentsBtn.Click += new System.EventHandler(this.AppointmentsBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 428);
            this.dataGridView1.TabIndex = 5;
            // 
            // RecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 449);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AppointmentsBtn);
            this.Controls.Add(this.DeleteCustomerBtn);
            this.Controls.Add(this.ModifyCustomerBtn);
            this.Controls.Add(this.AddCustomerBtn);
            this.Name = "RecordsForm";
            this.Text = "Records of Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddCustomerBtn;
        private System.Windows.Forms.Button ModifyCustomerBtn;
        private System.Windows.Forms.Button DeleteCustomerBtn;
        private System.Windows.Forms.Button AppointmentsBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}