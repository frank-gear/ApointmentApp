
namespace C969_Project
{
    partial class ModifyAppointmentForm
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.TitleOfAppointmentTextBox = new System.Windows.Forms.TextBox();
            this.StartOfAppointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndOfAppointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimeofAppointmentLabel = new System.Windows.Forms.Label();
            this.StartTimeOfAppointmentLabel = new System.Windows.Forms.Label();
            this.TypeOfAppointmentLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.typelistBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(224, 380);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(174, 62);
            this.CancelBtn.TabIndex = 23;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(16, 380);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(174, 62);
            this.SaveBtn.TabIndex = 22;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // TitleOfAppointmentTextBox
            // 
            this.TitleOfAppointmentTextBox.Location = new System.Drawing.Point(224, 74);
            this.TitleOfAppointmentTextBox.Name = "TitleOfAppointmentTextBox";
            this.TitleOfAppointmentTextBox.Size = new System.Drawing.Size(344, 26);
            this.TitleOfAppointmentTextBox.TabIndex = 20;
            // 
            // StartOfAppointmentDateTimePicker
            // 
            this.StartOfAppointmentDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.StartOfAppointmentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartOfAppointmentDateTimePicker.Location = new System.Drawing.Point(224, 252);
            this.StartOfAppointmentDateTimePicker.Name = "StartOfAppointmentDateTimePicker";
            this.StartOfAppointmentDateTimePicker.Size = new System.Drawing.Size(344, 26);
            this.StartOfAppointmentDateTimePicker.TabIndex = 19;
            // 
            // EndOfAppointmentDateTimePicker
            // 
            this.EndOfAppointmentDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.EndOfAppointmentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndOfAppointmentDateTimePicker.Location = new System.Drawing.Point(224, 323);
            this.EndOfAppointmentDateTimePicker.Name = "EndOfAppointmentDateTimePicker";
            this.EndOfAppointmentDateTimePicker.Size = new System.Drawing.Size(344, 26);
            this.EndOfAppointmentDateTimePicker.TabIndex = 18;
            this.EndOfAppointmentDateTimePicker.Value = new System.DateTime(2021, 6, 11, 0, 0, 0, 0);
            // 
            // EndTimeofAppointmentLabel
            // 
            this.EndTimeofAppointmentLabel.AutoSize = true;
            this.EndTimeofAppointmentLabel.Location = new System.Drawing.Point(12, 323);
            this.EndTimeofAppointmentLabel.Name = "EndTimeofAppointmentLabel";
            this.EndTimeofAppointmentLabel.Size = new System.Drawing.Size(189, 20);
            this.EndTimeofAppointmentLabel.TabIndex = 16;
            this.EndTimeofAppointmentLabel.Text = "End Time of Appointment";
            // 
            // StartTimeOfAppointmentLabel
            // 
            this.StartTimeOfAppointmentLabel.AutoSize = true;
            this.StartTimeOfAppointmentLabel.Location = new System.Drawing.Point(12, 252);
            this.StartTimeOfAppointmentLabel.Name = "StartTimeOfAppointmentLabel";
            this.StartTimeOfAppointmentLabel.Size = new System.Drawing.Size(195, 20);
            this.StartTimeOfAppointmentLabel.TabIndex = 15;
            this.StartTimeOfAppointmentLabel.Text = "Start Time of Appointment";
            // 
            // TypeOfAppointmentLabel
            // 
            this.TypeOfAppointmentLabel.AutoSize = true;
            this.TypeOfAppointmentLabel.Location = new System.Drawing.Point(12, 145);
            this.TypeOfAppointmentLabel.Name = "TypeOfAppointmentLabel";
            this.TypeOfAppointmentLabel.Size = new System.Drawing.Size(156, 20);
            this.TypeOfAppointmentLabel.TabIndex = 14;
            this.TypeOfAppointmentLabel.Text = "Type of Appointment";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 74);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(151, 20);
            this.TitleLabel.TabIndex = 13;
            this.TitleLabel.Text = "Title of Appointment";
            // 
            // typelistBox1
            // 
            this.typelistBox1.FormattingEnabled = true;
            this.typelistBox1.ItemHeight = 20;
            this.typelistBox1.Location = new System.Drawing.Point(224, 145);
            this.typelistBox1.Name = "typelistBox1";
            this.typelistBox1.ScrollAlwaysVisible = true;
            this.typelistBox1.Size = new System.Drawing.Size(344, 84);
            this.typelistBox1.TabIndex = 24;
            // 
            // ModifyAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 449);
            this.Controls.Add(this.typelistBox1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.TitleOfAppointmentTextBox);
            this.Controls.Add(this.StartOfAppointmentDateTimePicker);
            this.Controls.Add(this.EndOfAppointmentDateTimePicker);
            this.Controls.Add(this.EndTimeofAppointmentLabel);
            this.Controls.Add(this.StartTimeOfAppointmentLabel);
            this.Controls.Add(this.TypeOfAppointmentLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ModifyAppointmentForm";
            this.Text = "ModifyAppointmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox TitleOfAppointmentTextBox;
        private System.Windows.Forms.DateTimePicker StartOfAppointmentDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndOfAppointmentDateTimePicker;
        private System.Windows.Forms.Label EndTimeofAppointmentLabel;
        private System.Windows.Forms.Label StartTimeOfAppointmentLabel;
        private System.Windows.Forms.Label TypeOfAppointmentLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox typelistBox1;
    }
}