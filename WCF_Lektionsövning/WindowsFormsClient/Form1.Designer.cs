namespace WindowsFormsClient
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(206, 116);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 13);
            this.lbl_result.TabIndex = 1;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(12, 113);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 2;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(12, 149);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 13);
            this.lbl_message.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label lbl_message;
    }
}

