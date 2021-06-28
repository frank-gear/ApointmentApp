
namespace C969_Project
{
    partial class AppointmentForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewByWeekRadioBtn = new System.Windows.Forms.RadioButton();
            this.ViewByMonthRadioBtn = new System.Windows.Forms.RadioButton();
            this.AddApointmentBtn = new System.Windows.Forms.Button();
            this.ModifyAppointmentBtn = new System.Windows.Forms.Button();
            this.DeleteAppointmentBtn = new System.Windows.Forms.Button();
            this.AppointmentTypesByMonthReportFormBtn = new System.Windows.Forms.Button();
            this.ConsultantReportBtn = new System.Windows.Forms.Button();
            this.CustomerReportBtn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(604, 834);
            this.dataGridView1.TabIndex = 0;
            // 
            // ViewByWeekRadioBtn
            // 
            this.ViewByWeekRadioBtn.AutoSize = true;
            this.ViewByWeekRadioBtn.Location = new System.Drawing.Point(624, 13);
            this.ViewByWeekRadioBtn.Name = "ViewByWeekRadioBtn";
            this.ViewByWeekRadioBtn.Size = new System.Drawing.Size(133, 24);
            this.ViewByWeekRadioBtn.TabIndex = 1;
            this.ViewByWeekRadioBtn.TabStop = true;
            this.ViewByWeekRadioBtn.Text = "View by Week";
            this.ViewByWeekRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ViewByMonthRadioBtn
            // 
            this.ViewByMonthRadioBtn.AutoSize = true;
            this.ViewByMonthRadioBtn.Location = new System.Drawing.Point(763, 13);
            this.ViewByMonthRadioBtn.Name = "ViewByMonthRadioBtn";
            this.ViewByMonthRadioBtn.Size = new System.Drawing.Size(137, 24);
            this.ViewByMonthRadioBtn.TabIndex = 2;
            this.ViewByMonthRadioBtn.TabStop = true;
            this.ViewByMonthRadioBtn.Text = "View by Month";
            this.ViewByMonthRadioBtn.UseVisualStyleBackColor = true;
            // 
            // AddApointmentBtn
            // 
            this.AddApointmentBtn.Location = new System.Drawing.Point(624, 362);
            this.AddApointmentBtn.Name = "AddApointmentBtn";
            this.AddApointmentBtn.Size = new System.Drawing.Size(276, 56);
            this.AddApointmentBtn.TabIndex = 3;
            this.AddApointmentBtn.Text = "Add Appointment";
            this.AddApointmentBtn.UseVisualStyleBackColor = true;
            // 
            // ModifyAppointmentBtn
            // 
            this.ModifyAppointmentBtn.Location = new System.Drawing.Point(624, 448);
            this.ModifyAppointmentBtn.Name = "ModifyAppointmentBtn";
            this.ModifyAppointmentBtn.Size = new System.Drawing.Size(276, 56);
            this.ModifyAppointmentBtn.TabIndex = 4;
            this.ModifyAppointmentBtn.Text = "Modify Appointment";
            this.ModifyAppointmentBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteAppointmentBtn
            // 
            this.DeleteAppointmentBtn.Location = new System.Drawing.Point(624, 537);
            this.DeleteAppointmentBtn.Name = "DeleteAppointmentBtn";
            this.DeleteAppointmentBtn.Size = new System.Drawing.Size(276, 56);
            this.DeleteAppointmentBtn.TabIndex = 5;
            this.DeleteAppointmentBtn.Text = "Delete Appointment";
            this.DeleteAppointmentBtn.UseVisualStyleBackColor = true;
            // 
            // AppointmentTypesByMonthReportFormBtn
            // 
            this.AppointmentTypesByMonthReportFormBtn.Location = new System.Drawing.Point(624, 621);
            this.AppointmentTypesByMonthReportFormBtn.Name = "AppointmentTypesByMonthReportFormBtn";
            this.AppointmentTypesByMonthReportFormBtn.Size = new System.Drawing.Size(276, 56);
            this.AppointmentTypesByMonthReportFormBtn.TabIndex = 6;
            this.AppointmentTypesByMonthReportFormBtn.Text = "Appointment Types By Month Report";
            this.AppointmentTypesByMonthReportFormBtn.UseVisualStyleBackColor = true;
            // 
            // ConsultantReportBtn
            // 
            this.ConsultantReportBtn.Location = new System.Drawing.Point(624, 708);
            this.ConsultantReportBtn.Name = "ConsultantReportBtn";
            this.ConsultantReportBtn.Size = new System.Drawing.Size(276, 56);
            this.ConsultantReportBtn.TabIndex = 7;
            this.ConsultantReportBtn.Text = "Consultant Schedule Report ";
            this.ConsultantReportBtn.UseVisualStyleBackColor = true;
            // 
            // CustomerReportBtn
            // 
            this.CustomerReportBtn.Location = new System.Drawing.Point(624, 788);
            this.CustomerReportBtn.Name = "CustomerReportBtn";
            this.CustomerReportBtn.Size = new System.Drawing.Size(276, 59);
            this.CustomerReportBtn.TabIndex = 8;
            this.CustomerReportBtn.Text = "Customer Report";
            this.CustomerReportBtn.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(624, 76);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 866);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.CustomerReportBtn);
            this.Controls.Add(this.ConsultantReportBtn);
            this.Controls.Add(this.AppointmentTypesByMonthReportFormBtn);
            this.Controls.Add(this.DeleteAppointmentBtn);
            this.Controls.Add(this.ModifyAppointmentBtn);
            this.Controls.Add(this.AddApointmentBtn);
            this.Controls.Add(this.ViewByMonthRadioBtn);
            this.Controls.Add(this.ViewByWeekRadioBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton ViewByWeekRadioBtn;
        private System.Windows.Forms.RadioButton ViewByMonthRadioBtn;
        private System.Windows.Forms.Button AddApointmentBtn;
        private System.Windows.Forms.Button ModifyAppointmentBtn;
        private System.Windows.Forms.Button DeleteAppointmentBtn;
        private System.Windows.Forms.Button AppointmentTypesByMonthReportFormBtn;
        private System.Windows.Forms.Button ConsultantReportBtn;
        private System.Windows.Forms.Button CustomerReportBtn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}