
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
            this.AppointmentdataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewByWeekRadioBtn = new System.Windows.Forms.RadioButton();
            this.ViewByMonthRadioBtn = new System.Windows.Forms.RadioButton();
            this.AddApointmentBtn = new System.Windows.Forms.Button();
            this.ModifyAppointmentBtn = new System.Windows.Forms.Button();
            this.DeleteAppointmentBtn = new System.Windows.Forms.Button();
            this.AppointmentTypesByMonthReportFormBtn = new System.Windows.Forms.Button();
            this.ConsultantReportBtn = new System.Windows.Forms.Button();
            this.CustomerReportBtn = new System.Windows.Forms.Button();
            this.AppointmentMonthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.returntorecordsbtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.dayradioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentdataGridView1
            // 
            this.AppointmentdataGridView1.AllowUserToAddRows = false;
            this.AppointmentdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentdataGridView1.Location = new System.Drawing.Point(14, 60);
            this.AppointmentdataGridView1.Name = "AppointmentdataGridView1";
            this.AppointmentdataGridView1.RowHeadersWidth = 62;
            this.AppointmentdataGridView1.RowTemplate.Height = 28;
            this.AppointmentdataGridView1.Size = new System.Drawing.Size(1172, 252);
            this.AppointmentdataGridView1.TabIndex = 0;
            // 
            // ViewByWeekRadioBtn
            // 
            this.ViewByWeekRadioBtn.AutoSize = true;
            this.ViewByWeekRadioBtn.Location = new System.Drawing.Point(152, 12);
            this.ViewByWeekRadioBtn.Name = "ViewByWeekRadioBtn";
            this.ViewByWeekRadioBtn.Size = new System.Drawing.Size(133, 24);
            this.ViewByWeekRadioBtn.TabIndex = 1;
            this.ViewByWeekRadioBtn.Text = "View by Week";
            this.ViewByWeekRadioBtn.UseVisualStyleBackColor = true;
            this.ViewByWeekRadioBtn.CheckedChanged += new System.EventHandler(this.ViewByWeekRadioBtn_CheckedChanged);
            // 
            // ViewByMonthRadioBtn
            // 
            this.ViewByMonthRadioBtn.AutoSize = true;
            this.ViewByMonthRadioBtn.Location = new System.Drawing.Point(291, 12);
            this.ViewByMonthRadioBtn.Name = "ViewByMonthRadioBtn";
            this.ViewByMonthRadioBtn.Size = new System.Drawing.Size(137, 24);
            this.ViewByMonthRadioBtn.TabIndex = 2;
            this.ViewByMonthRadioBtn.Text = "View by Month";
            this.ViewByMonthRadioBtn.UseVisualStyleBackColor = true;
            this.ViewByMonthRadioBtn.CheckedChanged += new System.EventHandler(this.ViewByMonthRadioBtn_CheckedChanged);
            // 
            // AddApointmentBtn
            // 
            this.AddApointmentBtn.Location = new System.Drawing.Point(310, 388);
            this.AddApointmentBtn.Name = "AddApointmentBtn";
            this.AddApointmentBtn.Size = new System.Drawing.Size(276, 55);
            this.AddApointmentBtn.TabIndex = 3;
            this.AddApointmentBtn.Text = "Add Appointment";
            this.AddApointmentBtn.UseVisualStyleBackColor = true;
            this.AddApointmentBtn.Click += new System.EventHandler(this.AddApointmentBtn_Click);
            // 
            // ModifyAppointmentBtn
            // 
            this.ModifyAppointmentBtn.Location = new System.Drawing.Point(310, 325);
            this.ModifyAppointmentBtn.Name = "ModifyAppointmentBtn";
            this.ModifyAppointmentBtn.Size = new System.Drawing.Size(276, 55);
            this.ModifyAppointmentBtn.TabIndex = 4;
            this.ModifyAppointmentBtn.Text = "Modify Appointment";
            this.ModifyAppointmentBtn.UseVisualStyleBackColor = true;
            this.ModifyAppointmentBtn.Click += new System.EventHandler(this.ModifyAppointmentBtn_Click);
            // 
            // DeleteAppointmentBtn
            // 
            this.DeleteAppointmentBtn.Location = new System.Drawing.Point(15, 325);
            this.DeleteAppointmentBtn.Name = "DeleteAppointmentBtn";
            this.DeleteAppointmentBtn.Size = new System.Drawing.Size(276, 55);
            this.DeleteAppointmentBtn.TabIndex = 5;
            this.DeleteAppointmentBtn.Text = "Delete Appointment";
            this.DeleteAppointmentBtn.UseVisualStyleBackColor = true;
            this.DeleteAppointmentBtn.Click += new System.EventHandler(this.DeleteAppointmentBtn_Click);
            // 
            // AppointmentTypesByMonthReportFormBtn
            // 
            this.AppointmentTypesByMonthReportFormBtn.Location = new System.Drawing.Point(592, 325);
            this.AppointmentTypesByMonthReportFormBtn.Name = "AppointmentTypesByMonthReportFormBtn";
            this.AppointmentTypesByMonthReportFormBtn.Size = new System.Drawing.Size(276, 55);
            this.AppointmentTypesByMonthReportFormBtn.TabIndex = 6;
            this.AppointmentTypesByMonthReportFormBtn.Text = "Appointment Types By Month Report";
            this.AppointmentTypesByMonthReportFormBtn.UseVisualStyleBackColor = true;
            this.AppointmentTypesByMonthReportFormBtn.Click += new System.EventHandler(this.AppointmentTypesByMonthReportFormBtn_Click);
            // 
            // ConsultantReportBtn
            // 
            this.ConsultantReportBtn.Location = new System.Drawing.Point(592, 388);
            this.ConsultantReportBtn.Name = "ConsultantReportBtn";
            this.ConsultantReportBtn.Size = new System.Drawing.Size(276, 55);
            this.ConsultantReportBtn.TabIndex = 7;
            this.ConsultantReportBtn.Text = "Consultant Schedule Report ";
            this.ConsultantReportBtn.UseVisualStyleBackColor = true;
            this.ConsultantReportBtn.Click += new System.EventHandler(this.ConsultantReportBtn_Click);
            // 
            // CustomerReportBtn
            // 
            this.CustomerReportBtn.Location = new System.Drawing.Point(592, 449);
            this.CustomerReportBtn.Name = "CustomerReportBtn";
            this.CustomerReportBtn.Size = new System.Drawing.Size(276, 58);
            this.CustomerReportBtn.TabIndex = 8;
            this.CustomerReportBtn.Text = "Cities with Customers Report";
            this.CustomerReportBtn.UseVisualStyleBackColor = true;
            this.CustomerReportBtn.Click += new System.EventHandler(this.CustomerReportBtn_Click);
            // 
            // AppointmentMonthCalendar1
            // 
            this.AppointmentMonthCalendar1.Location = new System.Drawing.Point(873, 325);
            this.AppointmentMonthCalendar1.Name = "AppointmentMonthCalendar1";
            this.AppointmentMonthCalendar1.TabIndex = 9;
            this.AppointmentMonthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.AppointmentMonthCalendar1_DateChanged);
            this.AppointmentMonthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.AppointmentMonthCalendar1_DateSelected);
            // 
            // returntorecordsbtn
            // 
            this.returntorecordsbtn.Location = new System.Drawing.Point(12, 468);
            this.returntorecordsbtn.Name = "returntorecordsbtn";
            this.returntorecordsbtn.Size = new System.Drawing.Size(276, 49);
            this.returntorecordsbtn.TabIndex = 10;
            this.returntorecordsbtn.Text = "Return to Records";
            this.returntorecordsbtn.UseVisualStyleBackColor = true;
            this.returntorecordsbtn.Click += new System.EventHandler(this.returntorecordsbtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(15, 528);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(276, 49);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "Exit Applicaiton";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // dayradioButton1
            // 
            this.dayradioButton1.AutoSize = true;
            this.dayradioButton1.Checked = true;
            this.dayradioButton1.Location = new System.Drawing.Point(15, 12);
            this.dayradioButton1.Name = "dayradioButton1";
            this.dayradioButton1.Size = new System.Drawing.Size(120, 24);
            this.dayradioButton1.TabIndex = 12;
            this.dayradioButton1.TabStop = true;
            this.dayradioButton1.Text = "View by Day";
            this.dayradioButton1.UseVisualStyleBackColor = true;
            this.dayradioButton1.CheckedChanged += new System.EventHandler(this.dayradioButton1_CheckedChanged);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 585);
            this.Controls.Add(this.dayradioButton1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.returntorecordsbtn);
            this.Controls.Add(this.AppointmentMonthCalendar1);
            this.Controls.Add(this.CustomerReportBtn);
            this.Controls.Add(this.ConsultantReportBtn);
            this.Controls.Add(this.AppointmentTypesByMonthReportFormBtn);
            this.Controls.Add(this.DeleteAppointmentBtn);
            this.Controls.Add(this.ModifyAppointmentBtn);
            this.Controls.Add(this.AddApointmentBtn);
            this.Controls.Add(this.ViewByMonthRadioBtn);
            this.Controls.Add(this.ViewByWeekRadioBtn);
            this.Controls.Add(this.AppointmentdataGridView1);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AppointmentdataGridView1;
        private System.Windows.Forms.RadioButton ViewByWeekRadioBtn;
        private System.Windows.Forms.RadioButton ViewByMonthRadioBtn;
        private System.Windows.Forms.Button AddApointmentBtn;
        private System.Windows.Forms.Button ModifyAppointmentBtn;
        private System.Windows.Forms.Button DeleteAppointmentBtn;
        private System.Windows.Forms.Button AppointmentTypesByMonthReportFormBtn;
        private System.Windows.Forms.Button ConsultantReportBtn;
        private System.Windows.Forms.Button CustomerReportBtn;
        private System.Windows.Forms.MonthCalendar AppointmentMonthCalendar1;
        private System.Windows.Forms.Button returntorecordsbtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.RadioButton dayradioButton1;
    }
}