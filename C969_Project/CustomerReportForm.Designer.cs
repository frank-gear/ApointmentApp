
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
            this.CustomerReportlabel = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CustomertextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CustomerReportlabel
            // 
            this.CustomerReportlabel.AutoSize = true;
            this.CustomerReportlabel.Location = new System.Drawing.Point(24, 40);
            this.CustomerReportlabel.Name = "CustomerReportlabel";
            this.CustomerReportlabel.Size = new System.Drawing.Size(168, 20);
            this.CustomerReportlabel.TabIndex = 1;
            this.CustomerReportlabel.Text = "Number of  Customers";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(117, 132);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 40);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CustomertextBox1
            // 
            this.CustomertextBox1.Location = new System.Drawing.Point(28, 78);
            this.CustomertextBox1.Name = "CustomertextBox1";
            this.CustomertextBox1.ReadOnly = true;
            this.CustomertextBox1.Size = new System.Drawing.Size(164, 26);
            this.CustomertextBox1.TabIndex = 3;
            // 
            // CustomerReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 580);
            this.Controls.Add(this.CustomertextBox1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CustomerReportlabel);
            this.Name = "CustomerReportForm";
            this.Text = "CustomerReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CustomerReportlabel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox CustomertextBox1;
    }
}