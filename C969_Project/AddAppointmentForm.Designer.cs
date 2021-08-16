
namespace C969_Project
{
    partial class AddAppointmentForm
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
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TypeOfAppointmentLabel = new System.Windows.Forms.Label();
            this.StartTimeOfAppointmentLabel = new System.Windows.Forms.Label();
            this.EndTimeofAppointmentLabel = new System.Windows.Forms.Label();
            this.EndOfAppointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartOfAppointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TitleOfAppointmentTextBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.customerlistBox1 = new System.Windows.Forms.ListBox();
            this.TypelistBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(12, 9);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(124, 20);
            this.CustomerNameLabel.TabIndex = 0;
            this.CustomerNameLabel.Text = "Customer Name";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 131);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(151, 20);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title of Appointment";
            // 
            // TypeOfAppointmentLabel
            // 
            this.TypeOfAppointmentLabel.AutoSize = true;
            this.TypeOfAppointmentLabel.Location = new System.Drawing.Point(12, 202);
            this.TypeOfAppointmentLabel.Name = "TypeOfAppointmentLabel";
            this.TypeOfAppointmentLabel.Size = new System.Drawing.Size(156, 20);
            this.TypeOfAppointmentLabel.TabIndex = 2;
            this.TypeOfAppointmentLabel.Text = "Type of Appointment";
            // 
            // StartTimeOfAppointmentLabel
            // 
            this.StartTimeOfAppointmentLabel.AutoSize = true;
            this.StartTimeOfAppointmentLabel.Location = new System.Drawing.Point(12, 346);
            this.StartTimeOfAppointmentLabel.Name = "StartTimeOfAppointmentLabel";
            this.StartTimeOfAppointmentLabel.Size = new System.Drawing.Size(195, 20);
            this.StartTimeOfAppointmentLabel.TabIndex = 3;
            this.StartTimeOfAppointmentLabel.Text = "Start Time of Appointment";
            // 
            // EndTimeofAppointmentLabel
            // 
            this.EndTimeofAppointmentLabel.AutoSize = true;
            this.EndTimeofAppointmentLabel.Location = new System.Drawing.Point(12, 419);
            this.EndTimeofAppointmentLabel.Name = "EndTimeofAppointmentLabel";
            this.EndTimeofAppointmentLabel.Size = new System.Drawing.Size(189, 20);
            this.EndTimeofAppointmentLabel.TabIndex = 4;
            this.EndTimeofAppointmentLabel.Text = "End Time of Appointment";
            // 
            // EndOfAppointmentDateTimePicker
            // 
            this.EndOfAppointmentDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.EndOfAppointmentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndOfAppointmentDateTimePicker.Location = new System.Drawing.Point(224, 419);
            this.EndOfAppointmentDateTimePicker.Name = "EndOfAppointmentDateTimePicker";
            this.EndOfAppointmentDateTimePicker.Size = new System.Drawing.Size(344, 26);
            this.EndOfAppointmentDateTimePicker.TabIndex = 6;
            this.EndOfAppointmentDateTimePicker.Value = new System.DateTime(2021, 8, 16, 0, 0, 0, 0);
            // 
            // StartOfAppointmentDateTimePicker
            // 
            this.StartOfAppointmentDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.StartOfAppointmentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartOfAppointmentDateTimePicker.Location = new System.Drawing.Point(224, 346);
            this.StartOfAppointmentDateTimePicker.Name = "StartOfAppointmentDateTimePicker";
            this.StartOfAppointmentDateTimePicker.Size = new System.Drawing.Size(344, 26);
            this.StartOfAppointmentDateTimePicker.TabIndex = 7;
            this.StartOfAppointmentDateTimePicker.Value = new System.DateTime(2021, 8, 16, 19, 25, 6, 0);
            // 
            // TitleOfAppointmentTextBox
            // 
            this.TitleOfAppointmentTextBox.Location = new System.Drawing.Point(224, 131);
            this.TitleOfAppointmentTextBox.Name = "TitleOfAppointmentTextBox";
            this.TitleOfAppointmentTextBox.Size = new System.Drawing.Size(344, 26);
            this.TitleOfAppointmentTextBox.TabIndex = 8;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(16, 508);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(174, 62);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(224, 508);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(174, 62);
            this.CancelBtn.TabIndex = 11;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // customerlistBox1
            // 
            this.customerlistBox1.FormattingEnabled = true;
            this.customerlistBox1.ItemHeight = 20;
            this.customerlistBox1.Location = new System.Drawing.Point(224, 9);
            this.customerlistBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerlistBox1.Name = "customerlistBox1";
            this.customerlistBox1.ScrollAlwaysVisible = true;
            this.customerlistBox1.Size = new System.Drawing.Size(344, 104);
            this.customerlistBox1.TabIndex = 12;
            // 
            // TypelistBox1
            // 
            this.TypelistBox1.FormattingEnabled = true;
            this.TypelistBox1.ItemHeight = 20;
            this.TypelistBox1.Location = new System.Drawing.Point(224, 202);
            this.TypelistBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TypelistBox1.Name = "TypelistBox1";
            this.TypelistBox1.ScrollAlwaysVisible = true;
            this.TypelistBox1.Size = new System.Drawing.Size(344, 104);
            this.TypelistBox1.TabIndex = 13;
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 591);
            this.Controls.Add(this.TypelistBox1);
            this.Controls.Add(this.customerlistBox1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.TitleOfAppointmentTextBox);
            this.Controls.Add(this.StartOfAppointmentDateTimePicker);
            this.Controls.Add(this.EndOfAppointmentDateTimePicker);
            this.Controls.Add(this.EndTimeofAppointmentLabel);
            this.Controls.Add(this.StartTimeOfAppointmentLabel);
            this.Controls.Add(this.TypeOfAppointmentLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Name = "AddAppointmentForm";
            this.Text = "AddAppointmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TypeOfAppointmentLabel;
        private System.Windows.Forms.Label StartTimeOfAppointmentLabel;
        private System.Windows.Forms.Label EndTimeofAppointmentLabel;
        private System.Windows.Forms.DateTimePicker EndOfAppointmentDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartOfAppointmentDateTimePicker;
        private System.Windows.Forms.TextBox TitleOfAppointmentTextBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ListBox customerlistBox1;
        private System.Windows.Forms.ListBox TypelistBox1;
    }
}