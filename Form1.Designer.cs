namespace Test_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxSurname = new System.Windows.Forms.TextBox();
            this.txtbxIDnumber = new System.Windows.Forms.TextBox();
            this.DateOfBirthTimepicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of Birth";
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(304, 340);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(85, 36);
            this.btnPost.TabIndex = 4;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(484, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(383, 104);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(233, 22);
            this.txtbxName.TabIndex = 6;
            // 
            // txtbxSurname
            // 
            this.txtbxSurname.Location = new System.Drawing.Point(383, 148);
            this.txtbxSurname.Name = "txtbxSurname";
            this.txtbxSurname.Size = new System.Drawing.Size(233, 22);
            this.txtbxSurname.TabIndex = 7;
            // 
            // txtbxIDnumber
            // 
            this.txtbxIDnumber.Location = new System.Drawing.Point(383, 189);
            this.txtbxIDnumber.MaxLength = 13;
            this.txtbxIDnumber.Name = "txtbxIDnumber";
            this.txtbxIDnumber.Size = new System.Drawing.Size(233, 22);
            this.txtbxIDnumber.TabIndex = 8;
            this.txtbxIDnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DateOfBirthTimepicker
            // 
            this.DateOfBirthTimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBirthTimepicker.Location = new System.Drawing.Point(383, 243);
            this.DateOfBirthTimepicker.Name = "DateOfBirthTimepicker";
            this.DateOfBirthTimepicker.Size = new System.Drawing.Size(233, 22);
            this.DateOfBirthTimepicker.TabIndex = 9;
            this.DateOfBirthTimepicker.Value = new System.DateTime(2022, 3, 7, 8, 1, 1, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 492);
            this.Controls.Add(this.DateOfBirthTimepicker);
            this.Controls.Add(this.txtbxIDnumber);
            this.Controls.Add(this.txtbxSurname);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "InputFields";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxSurname;
        private System.Windows.Forms.TextBox txtbxIDnumber;
        private System.Windows.Forms.DateTimePicker DateOfBirthTimepicker;
    }
}

