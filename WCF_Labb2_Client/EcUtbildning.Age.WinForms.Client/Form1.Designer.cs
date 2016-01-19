namespace EcUtbildning.Age.WinForms.Client
{
    partial class Form1
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
            this.btnMessage = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.txtBoxYear = new System.Windows.Forms.TextBox();
            this.txtBoxMonth = new System.Windows.Forms.TextBox();
            this.txtBoxDay = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(145, 77);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(75, 22);
            this.btnMessage.TabIndex = 0;
            this.btnMessage.Text = "Get Age";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(13, 13);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(61, 13);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Enter  year:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(13, 61);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(70, 13);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Enter  month:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(13, 110);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(58, 13);
            this.lblDay.TabIndex = 3;
            this.lblDay.Text = "Enter  day:";
            // 
            // txtBoxYear
            // 
            this.txtBoxYear.Location = new System.Drawing.Point(16, 29);
            this.txtBoxYear.Name = "txtBoxYear";
            this.txtBoxYear.Size = new System.Drawing.Size(100, 20);
            this.txtBoxYear.TabIndex = 4;
            // 
            // txtBoxMonth
            // 
            this.txtBoxMonth.Location = new System.Drawing.Point(16, 77);
            this.txtBoxMonth.Name = "txtBoxMonth";
            this.txtBoxMonth.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMonth.TabIndex = 5;
            // 
            // txtBoxDay
            // 
            this.txtBoxDay.Location = new System.Drawing.Point(16, 126);
            this.txtBoxDay.Name = "txtBoxDay";
            this.txtBoxDay.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDay.TabIndex = 6;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(13, 160);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(37, 13);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtBoxDay);
            this.Controls.Add(this.txtBoxMonth);
            this.Controls.Add(this.txtBoxYear);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.TextBox txtBoxYear;
        private System.Windows.Forms.TextBox txtBoxMonth;
        private System.Windows.Forms.TextBox txtBoxDay;
        private System.Windows.Forms.Label lblMessage;
    }
}

