namespace CMPT_391_Project_1
{
    partial class HomePage
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
            this.TextSearch = new System.Windows.Forms.TextBox();
            this.ClassSearch = new System.Windows.Forms.Button();
            this.SemesterSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddToCart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Instructor = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Capacity = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Semester = new System.Windows.Forms.Label();
            this.ClassName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Section = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SelectedCourse = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Enroll = new System.Windows.Forms.Button();
            this.RemoveClass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.Label();
            this.CartBox = new System.Windows.Forms.ListBox();
            this.ClassListBox = new System.Windows.Forms.ListBox();
            this.ViewScheduleBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(847, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cart";
            // 
            // TextSearch
            // 
            this.TextSearch.Location = new System.Drawing.Point(8, 26);
            this.TextSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.Size = new System.Drawing.Size(409, 22);
            this.TextSearch.TabIndex = 4;
            this.TextSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ClassSearch
            // 
            this.ClassSearch.Location = new System.Drawing.Point(308, 58);
            this.ClassSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ClassSearch.Name = "ClassSearch";
            this.ClassSearch.Size = new System.Drawing.Size(117, 28);
            this.ClassSearch.TabIndex = 7;
            this.ClassSearch.Text = "Search";
            this.ClassSearch.UseVisualStyleBackColor = true;
            this.ClassSearch.Click += new System.EventHandler(this.ClassSearch_Click);
            // 
            // SemesterSelect
            // 
            this.SemesterSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SemesterSelect.FormattingEnabled = true;
            this.SemesterSelect.Items.AddRange(new object[] {
            "Fall",
            "Winter"});
            this.SemesterSelect.Location = new System.Drawing.Point(132, 58);
            this.SemesterSelect.Margin = new System.Windows.Forms.Padding(4);
            this.SemesterSelect.Name = "SemesterSelect";
            this.SemesterSelect.Size = new System.Drawing.Size(167, 24);
            this.SemesterSelect.TabIndex = 8;
            this.SemesterSelect.SelectedIndexChanged += new System.EventHandler(this.SemesterSelect_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Class List";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AddToCart
            // 
            this.AddToCart.Location = new System.Drawing.Point(468, 458);
            this.AddToCart.Margin = new System.Windows.Forms.Padding(4);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(368, 31);
            this.AddToCart.TabIndex = 11;
            this.AddToCart.Text = "Add to cart";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Instructor);
            this.groupBox1.Controls.Add(this.Time);
            this.groupBox1.Controls.Add(this.Capacity);
            this.groupBox1.Controls.Add(this.Year);
            this.groupBox1.Controls.Add(this.Semester);
            this.groupBox1.Controls.Add(this.ClassName);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Section);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.SelectedCourse);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(468, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(368, 348);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Info";
            // 
            // Instructor
            // 
            this.Instructor.AutoSize = true;
            this.Instructor.Location = new System.Drawing.Point(76, 133);
            this.Instructor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Instructor.Name = "Instructor";
            this.Instructor.Size = new System.Drawing.Size(0, 16);
            this.Instructor.TabIndex = 15;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(51, 117);
            this.Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(0, 16);
            this.Time.TabIndex = 14;
            // 
            // Capacity
            // 
            this.Capacity.AutoSize = true;
            this.Capacity.Location = new System.Drawing.Point(76, 101);
            this.Capacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(0, 16);
            this.Capacity.TabIndex = 13;
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(51, 85);
            this.Year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(0, 16);
            this.Year.TabIndex = 12;
            // 
            // Semester
            // 
            this.Semester.AutoSize = true;
            this.Semester.Location = new System.Drawing.Point(76, 69);
            this.Semester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(0, 16);
            this.Semester.TabIndex = 11;
            // 
            // ClassName
            // 
            this.ClassName.AutoSize = true;
            this.ClassName.Location = new System.Drawing.Point(96, 53);
            this.ClassName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(0, 16);
            this.ClassName.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 133);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 16);
            this.label14.TabIndex = 9;
            this.label14.Text = "Instructor:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 117);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Time:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 101);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Capacity:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Year:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Semester:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Class Name:";
            // 
            // Section
            // 
            this.Section.AutoSize = true;
            this.Section.Location = new System.Drawing.Point(69, 37);
            this.Section.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Section.Name = "Section";
            this.Section.Size = new System.Drawing.Size(0, 16);
            this.Section.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Section:";
            // 
            // SelectedCourse
            // 
            this.SelectedCourse.AutoSize = true;
            this.SelectedCourse.Location = new System.Drawing.Point(125, 21);
            this.SelectedCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedCourse.Name = "SelectedCourse";
            this.SelectedCourse.Size = new System.Drawing.Size(0, 16);
            this.SelectedCourse.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Course Selected:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TextSearch);
            this.groupBox2.Controls.Add(this.ClassSearch);
            this.groupBox2.Controls.Add(this.SemesterSelect);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(19, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(427, 95);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // Enroll
            // 
            this.Enroll.Location = new System.Drawing.Point(910, 496);
            this.Enroll.Margin = new System.Windows.Forms.Padding(4);
            this.Enroll.Name = "Enroll";
            this.Enroll.Size = new System.Drawing.Size(117, 28);
            this.Enroll.TabIndex = 15;
            this.Enroll.Text = "Enroll";
            this.Enroll.UseVisualStyleBackColor = true;
            this.Enroll.Click += new System.EventHandler(this.Enroll_Click);
            // 
            // RemoveClass
            // 
            this.RemoveClass.Location = new System.Drawing.Point(467, 493);
            this.RemoveClass.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveClass.Name = "RemoveClass";
            this.RemoveClass.Size = new System.Drawing.Size(368, 31);
            this.RemoveClass.TabIndex = 16;
            this.RemoveClass.Text = "Remove from cart";
            this.RemoveClass.UseVisualStyleBackColor = true;
            this.RemoveClass.Click += new System.EventHandler(this.RemoveClass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Student Name:";
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Location = new System.Drawing.Point(120, 24);
            this.StudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(0, 16);
            this.StudentName.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Student ID:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Location = new System.Drawing.Point(120, 56);
            this.StudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(0, 16);
            this.StudentID.TabIndex = 20;
            // 
            // CartBox
            // 
            this.CartBox.FormattingEnabled = true;
            this.CartBox.ItemHeight = 16;
            this.CartBox.Location = new System.Drawing.Point(844, 122);
            this.CartBox.Margin = new System.Windows.Forms.Padding(4);
            this.CartBox.Name = "CartBox";
            this.CartBox.Size = new System.Drawing.Size(245, 372);
            this.CartBox.TabIndex = 21;
            this.CartBox.Click += new System.EventHandler(this.CartBox_Click);
            this.CartBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ClassListBox
            // 
            this.ClassListBox.FormattingEnabled = true;
            this.ClassListBox.ItemHeight = 16;
            this.ClassListBox.Location = new System.Drawing.Point(20, 123);
            this.ClassListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClassListBox.Name = "ClassListBox";
            this.ClassListBox.Size = new System.Drawing.Size(439, 372);
            this.ClassListBox.TabIndex = 22;
            this.ClassListBox.Click += new System.EventHandler(this.ClassListBox_Click);
            // 
            // ViewScheduleBtn
            // 
            this.ViewScheduleBtn.Location = new System.Drawing.Point(898, 12);
            this.ViewScheduleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ViewScheduleBtn.Name = "ViewScheduleBtn";
            this.ViewScheduleBtn.Size = new System.Drawing.Size(145, 42);
            this.ViewScheduleBtn.TabIndex = 23;
            this.ViewScheduleBtn.Text = "View Schedule";
            this.ViewScheduleBtn.UseVisualStyleBackColor = true;
            this.ViewScheduleBtn.Click += new System.EventHandler(this.ViewScheduleBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.StudentName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.StudentID);
            this.groupBox3.Location = new System.Drawing.Point(467, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 87);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 538);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ViewScheduleBtn);
            this.Controls.Add(this.ClassListBox);
            this.Controls.Add(this.CartBox);
            this.Controls.Add(this.RemoveClass);
            this.Controls.Add(this.Enroll);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePage_FormClosed);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextSearch;
        private System.Windows.Forms.Button ClassSearch;
        private System.Windows.Forms.ComboBox SemesterSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Enroll;
        private System.Windows.Forms.Button RemoveClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Label SelectedCourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.ListBox CartBox;
        private System.Windows.Forms.ListBox ClassListBox;
        private System.Windows.Forms.Label Section;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Instructor;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Capacity;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Semester;
        private System.Windows.Forms.Label ClassName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ViewScheduleBtn;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}