
namespace C969_Project
{
    partial class AddCustomerForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.ZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CitySelectBox = new System.Windows.Forms.ListBox();
            this.ActiveLabel = new System.Windows.Forms.Label();
            this.ActiveCheckBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(9, 31);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(82, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Customer Name";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(11, 66);
            this.StreetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(35, 13);
            this.StreetLabel.TabIndex = 1;
            this.StreetLabel.Text = "Street";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(11, 99);
            this.CityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(24, 13);
            this.CityLabel.TabIndex = 2;
            this.CityLabel.Text = "City";
            // 
            // ZipLabel
            // 
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Location = new System.Drawing.Point(11, 251);
            this.ZipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(50, 13);
            this.ZipLabel.TabIndex = 3;
            this.ZipLabel.Text = "Zip Code";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(11, 284);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumberLabel.TabIndex = 4;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(96, 27);
            this.CustomerNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(125, 20);
            this.CustomerNameTextBox.TabIndex = 5;
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(96, 62);
            this.StreetTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(125, 20);
            this.StreetTextBox.TabIndex = 6;
            // 
            // ZipCodeTextBox
            // 
            this.ZipCodeTextBox.Location = new System.Drawing.Point(96, 249);
            this.ZipCodeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ZipCodeTextBox.Name = "ZipCodeTextBox";
            this.ZipCodeTextBox.Size = new System.Drawing.Size(125, 20);
            this.ZipCodeTextBox.TabIndex = 8;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(96, 284);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(125, 20);
            this.PhoneNumberTextBox.TabIndex = 9;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(14, 351);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(74, 42);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(145, 351);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(74, 42);
            this.CancelBtn.TabIndex = 11;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CitySelectBox
            // 
            this.CitySelectBox.FormattingEnabled = true;
            this.CitySelectBox.Location = new System.Drawing.Point(96, 99);
            this.CitySelectBox.Name = "CitySelectBox";
            this.CitySelectBox.ScrollAlwaysVisible = true;
            this.CitySelectBox.Size = new System.Drawing.Size(120, 82);
            this.CitySelectBox.TabIndex = 12;
            // 
            // ActiveLabel
            // 
            this.ActiveLabel.AutoSize = true;
            this.ActiveLabel.Location = new System.Drawing.Point(12, 203);
            this.ActiveLabel.Name = "ActiveLabel";
            this.ActiveLabel.Size = new System.Drawing.Size(43, 13);
            this.ActiveLabel.TabIndex = 13;
            this.ActiveLabel.Text = "Active?";
            // 
            // ActiveCheckBox1
            // 
            this.ActiveCheckBox1.AutoSize = true;
            this.ActiveCheckBox1.Location = new System.Drawing.Point(96, 203);
            this.ActiveCheckBox1.Name = "ActiveCheckBox1";
            this.ActiveCheckBox1.Size = new System.Drawing.Size(119, 17);
            this.ActiveCheckBox1.TabIndex = 14;
            this.ActiveCheckBox1.Text = "Check Box if Active";
            this.ActiveCheckBox1.UseVisualStyleBackColor = true;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 414);
            this.Controls.Add(this.ActiveCheckBox1);
            this.Controls.Add(this.ActiveLabel);
            this.Controls.Add(this.CitySelectBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.ZipCodeTextBox);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.ZipLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.NameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label ZipLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox ZipCodeTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ListBox CitySelectBox;
        private System.Windows.Forms.Label ActiveLabel;
        private System.Windows.Forms.CheckBox ActiveCheckBox1;
    }
}