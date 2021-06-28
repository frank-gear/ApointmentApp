
namespace C969_Project
{
    partial class ConsultantReportForm
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CustomerReportlabel = new System.Windows.Forms.Label();
            this.ConsultantReportDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultantReportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(784, 488);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 40);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // CustomerReportlabel
            // 
            this.CustomerReportlabel.AutoSize = true;
            this.CustomerReportlabel.Location = new System.Drawing.Point(29, -39);
            this.CustomerReportlabel.Name = "CustomerReportlabel";
            this.CustomerReportlabel.Size = new System.Drawing.Size(131, 20);
            this.CustomerReportlabel.TabIndex = 4;
            this.CustomerReportlabel.Text = "Customer Report";
            // 
            // ConsultantReportDataGridView
            // 
            this.ConsultantReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultantReportDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ConsultantReportDataGridView.Name = "ConsultantReportDataGridView";
            this.ConsultantReportDataGridView.RowHeadersWidth = 62;
            this.ConsultantReportDataGridView.RowTemplate.Height = 28;
            this.ConsultantReportDataGridView.Size = new System.Drawing.Size(752, 447);
            this.ConsultantReportDataGridView.TabIndex = 3;
            // 
            // ConsultantReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 540);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CustomerReportlabel);
            this.Controls.Add(this.ConsultantReportDataGridView);
            this.Name = "ConsultantReportForm";
            this.Text = "ConsultantReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultantReportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label CustomerReportlabel;
        private System.Windows.Forms.DataGridView ConsultantReportDataGridView;
    }
}