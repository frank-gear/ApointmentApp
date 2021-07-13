
namespace C969_Project
{
    partial class DeleteCustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerlistBox = new System.Windows.Forms.ListBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the Customer to Delete";
            // 
            // CustomerlistBox
            // 
            this.CustomerlistBox.FormattingEnabled = true;
            this.CustomerlistBox.ItemHeight = 20;
            this.CustomerlistBox.Location = new System.Drawing.Point(22, 52);
            this.CustomerlistBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomerlistBox.Name = "CustomerlistBox";
            this.CustomerlistBox.Size = new System.Drawing.Size(194, 144);
            this.CustomerlistBox.TabIndex = 1;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(22, 208);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(196, 80);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete Selected Customer";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(22, 297);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(196, 35);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Return to Records";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // DeleteCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 378);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CustomerlistBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DeleteCustomerForm";
            this.Text = "DeleteCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CustomerlistBox;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}