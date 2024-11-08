namespace WindowsFormsApp23
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
            this.StudentNo = new System.Windows.Forms.TextBox();
            this.ContactNo = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.Middle = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Course = new System.Windows.Forms.ComboBox();
            this.FIrstName = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentNo
            // 
            this.StudentNo.Location = new System.Drawing.Point(46, 46);
            this.StudentNo.Name = "StudentNo";
            this.StudentNo.Size = new System.Drawing.Size(100, 20);
            this.StudentNo.TabIndex = 0;
            // 
            // ContactNo
            // 
            this.ContactNo.Location = new System.Drawing.Point(350, 256);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(100, 20);
            this.ContactNo.TabIndex = 1;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(46, 166);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(100, 20);
            this.Age.TabIndex = 3;
            // 
            // Middle
            // 
            this.Middle.Location = new System.Drawing.Point(460, 100);
            this.Middle.Name = "Middle";
            this.Middle.Size = new System.Drawing.Size(77, 20);
            this.Middle.TabIndex = 4;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(46, 100);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 20);
            this.LastName.TabIndex = 5;
            // 
            // Course
            // 
            this.Course.FormattingEnabled = true;
            this.Course.Items.AddRange(new object[] {
            "IT",
            "CS",
            "TOURISM",
            "XD",
            "XXXD"});
            this.Course.Location = new System.Drawing.Point(287, 46);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(121, 21);
            this.Course.TabIndex = 6;
            // 
            // FIrstName
            // 
            this.FIrstName.Location = new System.Drawing.Point(287, 100);
            this.FIrstName.Name = "FIrstName";
            this.FIrstName.Size = new System.Drawing.Size(100, 20);
            this.FIrstName.TabIndex = 7;
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "His/Her",
            "Her/Him",
            "They/Are"});
            this.Gender.Location = new System.Drawing.Point(287, 165);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(121, 21);
            this.Gender.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 253);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.FIrstName);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Middle);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.ContactNo);
            this.Controls.Add(this.StudentNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentNo;
        private System.Windows.Forms.TextBox ContactNo;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox Middle;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.ComboBox Course;
        private System.Windows.Forms.TextBox FIrstName;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}

