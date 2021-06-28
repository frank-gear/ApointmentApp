
namespace C969_Project
{
    partial class AppointmentTypesByMonthReportForm
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
            this.AppointmentTypesByMonthReportDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentTypesByMonthReportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(818, 529);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 40);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // AppointmentTypesByMonthReportDataGridView
            // 
            this.AppointmentTypesByMonthReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentTypesByMonthReportDataGridView.Location = new System.Drawing.Point(46, 53);
            this.AppointmentTypesByMonthReportDataGridView.Name = "AppointmentTypesByMonthReportDataGridView";
            this.AppointmentTypesByMonthReportDataGridView.RowHeadersWidth = 62;
            this.AppointmentTypesByMonthReportDataGridView.RowTemplate.Height = 28;
            this.AppointmentTypesByMonthReportDataGridView.Size = new System.Drawing.Size(752, 447);
            this.AppointmentTypesByMonthReportDataGridView.TabIndex = 6;
            // 
            // AppointmentTypesByMonthReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 623);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AppointmentTypesByMonthReportDataGridView);
            this.Name = "AppointmentTypesByMonthReportForm";
            this.Text = "AppointmentTypesByMonthReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentTypesByMonthReportDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.DataGridView AppointmentTypesByMonthReportDataGridView;
    }
}