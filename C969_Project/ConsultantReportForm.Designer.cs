
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.selectbutton1 = new System.Windows.Forms.Button();
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
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
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
            this.ConsultantReportDataGridView.Location = new System.Drawing.Point(12, 81);
            this.ConsultantReportDataGridView.Name = "ConsultantReportDataGridView";
            this.ConsultantReportDataGridView.RowHeadersWidth = 62;
            this.ConsultantReportDataGridView.RowTemplate.Height = 28;
            this.ConsultantReportDataGridView.Size = new System.Drawing.Size(752, 447);
            this.ConsultantReportDataGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Consultant to View";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(224, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(222, 64);
            this.listBox1.TabIndex = 7;
            // 
            // selectbutton1
            // 
            this.selectbutton1.Location = new System.Drawing.Point(129, 44);
            this.selectbutton1.Name = "selectbutton1";
            this.selectbutton1.Size = new System.Drawing.Size(75, 33);
            this.selectbutton1.TabIndex = 8;
            this.selectbutton1.Text = "select";
            this.selectbutton1.UseVisualStyleBackColor = true;
            this.selectbutton1.Click += new System.EventHandler(this.selectbutton1_Click);
            // 
            // ConsultantReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 540);
            this.Controls.Add(this.selectbutton1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button selectbutton1;
    }
}