namespace EcUtbildning.Hobby.WinForms.Client
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
            this.lblMessage = new System.Windows.Forms.Button();
            this.lblHobby = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(156, 86);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(75, 23);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Go!";
            this.lblMessage.UseVisualStyleBackColor = true;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // lblHobby
            // 
            this.lblHobby.AutoSize = true;
            this.lblHobby.Location = new System.Drawing.Point(34, 59);
            this.lblHobby.Name = "lblHobby";
            this.lblHobby.Size = new System.Drawing.Size(71, 13);
            this.lblHobby.TabIndex = 1;
            this.lblHobby.Text = "FIFA or PES?";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(37, 86);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(34, 129);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(50, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lblHobby);
            this.Controls.Add(this.lblMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblMessage;
        private System.Windows.Forms.Label lblHobby;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label lblResult;
    }
}

