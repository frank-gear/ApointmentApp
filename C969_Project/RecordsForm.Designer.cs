
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
            this.RecordsDataGridView = new System.Windows.Forms.DataGridView();
            this.AddCustomerBtn = new System.Windows.Forms.Button();
            this.ModifyCustomerBtn = new System.Windows.Forms.Button();
            this.DeleteCustomerBtn = new System.Windows.Forms.Button();
            this.AppointmentsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RecordsDataGridView
            // 
            this.RecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.RecordsDataGridView.Name = "RecordsDataGridView";
            this.RecordsDataGridView.RowHeadersWidth = 62;
            this.RecordsDataGridView.RowTemplate.Height = 28;
            this.RecordsDataGridView.Size = new System.Drawing.Size(1004, 410);
            this.RecordsDataGridView.TabIndex = 0;
            // 
            // AddCustomerBtn
            // 
            this.AddCustomerBtn.Location = new System.Drawing.Point(1022, 26);
            this.AddCustomerBtn.Name = "AddCustomerBtn";
            this.AddCustomerBtn.Size = new System.Drawing.Size(185, 38);
            this.AddCustomerBtn.TabIndex = 1;
            this.AddCustomerBtn.Text = "Add New Customer";
            this.AddCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // ModifyCustomerBtn
            // 
            this.ModifyCustomerBtn.Location = new System.Drawing.Point(1022, 80);
            this.ModifyCustomerBtn.Name = "ModifyCustomerBtn";
            this.ModifyCustomerBtn.Size = new System.Drawing.Size(185, 38);
            this.ModifyCustomerBtn.TabIndex = 2;
            this.ModifyCustomerBtn.Text = "Modify Customer";
            this.ModifyCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteCustomerBtn
            // 
            this.DeleteCustomerBtn.Location = new System.Drawing.Point(1022, 133);
            this.DeleteCustomerBtn.Name = "DeleteCustomerBtn";
            this.DeleteCustomerBtn.Size = new System.Drawing.Size(185, 39);
            this.DeleteCustomerBtn.TabIndex = 3;
            this.DeleteCustomerBtn.Text = "Delete Customer";
            this.DeleteCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // AppointmentsBtn
            // 
            this.AppointmentsBtn.Location = new System.Drawing.Point(1022, 356);
            this.AppointmentsBtn.Name = "AppointmentsBtn";
            this.AppointmentsBtn.Size = new System.Drawing.Size(185, 65);
            this.AppointmentsBtn.TabIndex = 4;
            this.AppointmentsBtn.Text = "Appointments";
            this.AppointmentsBtn.UseVisualStyleBackColor = true;
            // 
            // RecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 450);
            this.Controls.Add(this.AppointmentsBtn);
            this.Controls.Add(this.DeleteCustomerBtn);
            this.Controls.Add(this.ModifyCustomerBtn);
            this.Controls.Add(this.AddCustomerBtn);
            this.Controls.Add(this.RecordsDataGridView);
            this.Name = "RecordsForm";
            this.Text = "Records of Customers";
            ((System.ComponentModel.ISupportInitialize)(this.RecordsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RecordsDataGridView;
        private System.Windows.Forms.Button AddCustomerBtn;
        private System.Windows.Forms.Button ModifyCustomerBtn;
        private System.Windows.Forms.Button DeleteCustomerBtn;
        private System.Windows.Forms.Button AppointmentsBtn;
    }
}