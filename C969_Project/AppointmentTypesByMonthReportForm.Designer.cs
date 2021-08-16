
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
            this.namelabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AugPrestextBox1 = new System.Windows.Forms.TextBox();
            this.AugInttextBox2 = new System.Windows.Forms.TextBox();
            this.AugScrumtextBox3 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(129, 272);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 40);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // namelabel1
            // 
            this.namelabel1.AutoSize = true;
            this.namelabel1.Location = new System.Drawing.Point(12, 9);
            this.namelabel1.Name = "namelabel1";
            this.namelabel1.Size = new System.Drawing.Size(217, 20);
            this.namelabel1.TabIndex = 8;
            this.namelabel1.Text = "Appointment Types By Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Change Slected Month to View Type Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Presentation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Interview";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Scrum";
            // 
            // AugPrestextBox1
            // 
            this.AugPrestextBox1.Enabled = false;
            this.AugPrestextBox1.Location = new System.Drawing.Point(132, 103);
            this.AugPrestextBox1.Name = "AugPrestextBox1";
            this.AugPrestextBox1.Size = new System.Drawing.Size(100, 26);
            this.AugPrestextBox1.TabIndex = 13;
            // 
            // AugInttextBox2
            // 
            this.AugInttextBox2.Enabled = false;
            this.AugInttextBox2.Location = new System.Drawing.Point(132, 143);
            this.AugInttextBox2.Name = "AugInttextBox2";
            this.AugInttextBox2.Size = new System.Drawing.Size(100, 26);
            this.AugInttextBox2.TabIndex = 14;
            // 
            // AugScrumtextBox3
            // 
            this.AugScrumtextBox3.Enabled = false;
            this.AugScrumtextBox3.Location = new System.Drawing.Point(129, 178);
            this.AugScrumtextBox3.Name = "AugScrumtextBox3";
            this.AugScrumtextBox3.Size = new System.Drawing.Size(100, 26);
            this.AugScrumtextBox3.TabIndex = 15;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(366, 59);
            this.monthCalendar1.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
            // 
            // AppointmentTypesByMonthReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 385);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.AugScrumtextBox3);
            this.Controls.Add(this.AugInttextBox2);
            this.Controls.Add(this.AugPrestextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namelabel1);
            this.Controls.Add(this.ExitBtn);
            this.Name = "AppointmentTypesByMonthReportForm";
            this.Text = "AppointmentTypesByMonthReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label namelabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AugPrestextBox1;
        private System.Windows.Forms.TextBox AugInttextBox2;
        private System.Windows.Forms.TextBox AugScrumtextBox3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}