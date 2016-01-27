namespace EmployeeClient
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
            this.lbl_EmpId = new System.Windows.Forms.Label();
            this.lbl_First = new System.Windows.Forms.Label();
            this.lbl_Last = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.txtBoxForEmpId = new System.Windows.Forms.TextBox();
            this.txtBox_First = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBox_Last = new System.Windows.Forms.TextBox();
            this.txtBox_Country = new System.Windows.Forms.TextBox();
            this.txtBox_Title = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_EmpId
            // 
            this.lbl_EmpId.AutoSize = true;
            this.lbl_EmpId.Location = new System.Drawing.Point(22, 22);
            this.lbl_EmpId.Name = "lbl_EmpId";
            this.lbl_EmpId.Size = new System.Drawing.Size(67, 13);
            this.lbl_EmpId.TabIndex = 0;
            this.lbl_EmpId.Text = "EmployeeID:";
            // 
            // lbl_First
            // 
            this.lbl_First.AutoSize = true;
            this.lbl_First.Location = new System.Drawing.Point(22, 89);
            this.lbl_First.Name = "lbl_First";
            this.lbl_First.Size = new System.Drawing.Size(55, 13);
            this.lbl_First.TabIndex = 1;
            this.lbl_First.Text = "Firstname:";
            // 
            // lbl_Last
            // 
            this.lbl_Last.AutoSize = true;
            this.lbl_Last.Location = new System.Drawing.Point(21, 113);
            this.lbl_Last.Name = "lbl_Last";
            this.lbl_Last.Size = new System.Drawing.Size(56, 13);
            this.lbl_Last.TabIndex = 2;
            this.lbl_Last.Text = "Lastname:";
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Location = new System.Drawing.Point(22, 138);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(46, 13);
            this.lbl_Country.TabIndex = 3;
            this.lbl_Country.Text = "Country:";
            // 
            // txtBoxForEmpId
            // 
            this.txtBoxForEmpId.Location = new System.Drawing.Point(123, 19);
            this.txtBoxForEmpId.Name = "txtBoxForEmpId";
            this.txtBoxForEmpId.Size = new System.Drawing.Size(257, 20);
            this.txtBoxForEmpId.TabIndex = 4;
            // 
            // txtBox_First
            // 
            this.txtBox_First.Location = new System.Drawing.Point(123, 86);
            this.txtBox_First.Name = "txtBox_First";
            this.txtBox_First.Size = new System.Drawing.Size(257, 20);
            this.txtBox_First.TabIndex = 5;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(22, 164);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(30, 13);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "Title:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Get Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox_Last
            // 
            this.txtBox_Last.Location = new System.Drawing.Point(123, 110);
            this.txtBox_Last.Name = "txtBox_Last";
            this.txtBox_Last.Size = new System.Drawing.Size(257, 20);
            this.txtBox_Last.TabIndex = 8;
            // 
            // txtBox_Country
            // 
            this.txtBox_Country.Location = new System.Drawing.Point(123, 135);
            this.txtBox_Country.Name = "txtBox_Country";
            this.txtBox_Country.Size = new System.Drawing.Size(257, 20);
            this.txtBox_Country.TabIndex = 9;
            // 
            // txtBox_Title
            // 
            this.txtBox_Title.Location = new System.Drawing.Point(123, 161);
            this.txtBox_Title.Name = "txtBox_Title";
            this.txtBox_Title.Size = new System.Drawing.Size(257, 20);
            this.txtBox_Title.TabIndex = 10;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(123, 196);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(257, 23);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 261);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txtBox_Title);
            this.Controls.Add(this.txtBox_Country);
            this.Controls.Add(this.txtBox_Last);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txtBox_First);
            this.Controls.Add(this.txtBoxForEmpId);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.lbl_Last);
            this.Controls.Add(this.lbl_First);
            this.Controls.Add(this.lbl_EmpId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_EmpId;
        private System.Windows.Forms.Label lbl_First;
        private System.Windows.Forms.Label lbl_Last;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.TextBox txtBoxForEmpId;
        private System.Windows.Forms.TextBox txtBox_First;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBox_Last;
        private System.Windows.Forms.TextBox txtBox_Country;
        private System.Windows.Forms.TextBox txtBox_Title;
        private System.Windows.Forms.Button btn_Save;
    }
}

