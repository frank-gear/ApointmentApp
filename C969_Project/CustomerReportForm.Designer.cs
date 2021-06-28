
namespace C969_Project
{
    partial class CustomerReportForm
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
            this.CustomerReportDataGridView = new System.Windows.Forms.DataGridView();
            this.CustomerReportlabel = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerReportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerReportDataGridView
            // 
            this.CustomerReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerReportDataGridView.Location = new System.Drawing.Point(19, 63);
            this.CustomerReportDataGridView.Name = "CustomerReportDataGridView";
            this.CustomerReportDataGridView.RowHeadersWidth = 62;
            this.CustomerReportDataGridView.RowTemplate.Height = 28;
            this.CustomerReportDataGridView.Size = new System.Drawing.Size(752, 447);
            this.CustomerReportDataGridView.TabIndex = 0;
            // 
            // CustomerReportlabel
            // 
            this.CustomerReportlabel.AutoSize = true;
            this.CustomerReportlabel.Location = new System.Drawing.Point(24, 40);
            this.CustomerReportlabel.Name = "CustomerReportlabel";
            this.CustomerReportlabel.Size = new System.Drawing.Size(131, 20);
            this.CustomerReportlabel.TabIndex = 1;
            this.CustomerReportlabel.Text = "Customer Report";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(696, 528);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 40);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // CustomerReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CustomerReportlabel);
            this.Controls.Add(this.CustomerReportDataGridView);
            this.Name = "CustomerReportForm";
            this.Text = "CustomerReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerReportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerReportDataGridView;
        private System.Windows.Forms.Label CustomerReportlabel;
        private System.Windows.Forms.Button ExitBtn;
    }
}