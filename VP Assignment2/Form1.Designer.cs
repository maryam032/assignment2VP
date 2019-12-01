namespace VP_Assignment2
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.grpBoxAddStudent = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.grpBoxList = new System.Windows.Forms.GroupBox();
            this.dataGridListAll = new System.Windows.Forms.DataGridView();
            this.grpBoxTop3 = new System.Windows.Forms.GroupBox();
            this.dataGridTop3 = new System.Windows.Forms.DataGridView();
            this.grpBoxSearch = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxSearchId = new System.Windows.Forms.TextBox();
            this.txtBoxSearchName = new System.Windows.Forms.TextBox();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.grpBoxDeleteStudent = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFieldDelete = new System.Windows.Forms.TextBox();
            this.grpBoxAdd = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddUniversity = new System.Windows.Forms.ComboBox();
            this.txtAddDepartment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddCgpa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddnAME = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddId = new System.Windows.Forms.TextBox();
            this.dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            this.grpBoxMarkAttendance = new System.Windows.Forms.GroupBox();
            this.grpBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListAll)).BeginInit();
            this.grpBoxTop3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTop3)).BeginInit();
            this.grpBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.grpBoxDeleteStudent.SuspendLayout();
            this.grpBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).BeginInit();
            this.grpBoxMarkAttendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete Student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Search Student";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "Top 3 Students";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 333);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 52);
            this.button5.TabIndex = 4;
            this.button5.Text = "View Attendance";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(12, 403);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 52);
            this.button6.TabIndex = 5;
            this.button6.Text = "Mark Attendance";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // grpBoxAddStudent
            // 
            this.grpBoxAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAddStudent.Location = new System.Drawing.Point(157, 12);
            this.grpBoxAddStudent.Name = "grpBoxAddStudent";
            this.grpBoxAddStudent.Size = new System.Drawing.Size(757, 443);
            this.grpBoxAddStudent.TabIndex = 6;
            this.grpBoxAddStudent.TabStop = false;
            this.grpBoxAddStudent.Text = "Add Student";
            this.grpBoxAddStudent.Visible = false;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 206);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 52);
            this.button7.TabIndex = 7;
            this.button7.Text = "List All Students";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // grpBoxList
            // 
            this.grpBoxList.Controls.Add(this.dataGridListAll);
            this.grpBoxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxList.Location = new System.Drawing.Point(157, 12);
            this.grpBoxList.Name = "grpBoxList";
            this.grpBoxList.Size = new System.Drawing.Size(757, 443);
            this.grpBoxList.TabIndex = 0;
            this.grpBoxList.TabStop = false;
            this.grpBoxList.Text = "List of Students";
            this.grpBoxList.Visible = false;
            // 
            // dataGridListAll
            // 
            this.dataGridListAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridListAll.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridListAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListAll.Location = new System.Drawing.Point(18, 49);
            this.dataGridListAll.Name = "dataGridListAll";
            this.dataGridListAll.Size = new System.Drawing.Size(721, 150);
            this.dataGridListAll.TabIndex = 0;
            // 
            // grpBoxTop3
            // 
            this.grpBoxTop3.Controls.Add(this.dataGridTop3);
            this.grpBoxTop3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxTop3.Location = new System.Drawing.Point(151, 12);
            this.grpBoxTop3.Name = "grpBoxTop3";
            this.grpBoxTop3.Size = new System.Drawing.Size(757, 443);
            this.grpBoxTop3.TabIndex = 1;
            this.grpBoxTop3.TabStop = false;
            this.grpBoxTop3.Text = "Top 3 Students";
            this.grpBoxTop3.Visible = false;
            // 
            // dataGridTop3
            // 
            this.dataGridTop3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTop3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridTop3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTop3.Location = new System.Drawing.Point(18, 49);
            this.dataGridTop3.Name = "dataGridTop3";
            this.dataGridTop3.Size = new System.Drawing.Size(721, 150);
            this.dataGridTop3.TabIndex = 0;
            // 
            // grpBoxSearch
            // 
            this.grpBoxSearch.Controls.Add(this.label2);
            this.grpBoxSearch.Controls.Add(this.label1);
            this.grpBoxSearch.Controls.Add(this.txtBoxSearchId);
            this.grpBoxSearch.Controls.Add(this.txtBoxSearchName);
            this.grpBoxSearch.Controls.Add(this.dataGridViewSearch);
            this.grpBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxSearch.Location = new System.Drawing.Point(157, 6);
            this.grpBoxSearch.Name = "grpBoxSearch";
            this.grpBoxSearch.Size = new System.Drawing.Size(757, 443);
            this.grpBoxSearch.TabIndex = 2;
            this.grpBoxSearch.TabStop = false;
            this.grpBoxSearch.Text = "Search Students";
            this.grpBoxSearch.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search By Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search By Name";
            // 
            // txtBoxSearchId
            // 
            this.txtBoxSearchId.Location = new System.Drawing.Point(510, 65);
            this.txtBoxSearchId.Name = "txtBoxSearchId";
            this.txtBoxSearchId.Size = new System.Drawing.Size(229, 21);
            this.txtBoxSearchId.TabIndex = 2;
            this.txtBoxSearchId.TextChanged += new System.EventHandler(this.txtBoxSearchId_TextChanged);
            // 
            // txtBoxSearchName
            // 
            this.txtBoxSearchName.Location = new System.Drawing.Point(18, 65);
            this.txtBoxSearchName.Name = "txtBoxSearchName";
            this.txtBoxSearchName.Size = new System.Drawing.Size(224, 21);
            this.txtBoxSearchName.TabIndex = 1;
            this.txtBoxSearchName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBoxSearchName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSearchName_KeyPress);
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(18, 102);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.Size = new System.Drawing.Size(721, 321);
            this.dataGridViewSearch.TabIndex = 0;
            // 
            // grpBoxDeleteStudent
            // 
            this.grpBoxDeleteStudent.Controls.Add(this.button8);
            this.grpBoxDeleteStudent.Controls.Add(this.label3);
            this.grpBoxDeleteStudent.Controls.Add(this.txtFieldDelete);
            this.grpBoxDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDeleteStudent.Location = new System.Drawing.Point(151, 0);
            this.grpBoxDeleteStudent.Name = "grpBoxDeleteStudent";
            this.grpBoxDeleteStudent.Size = new System.Drawing.Size(757, 449);
            this.grpBoxDeleteStudent.TabIndex = 1;
            this.grpBoxDeleteStudent.TabStop = false;
            this.grpBoxDeleteStudent.Text = "Delete Student";
            this.grpBoxDeleteStudent.Visible = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 102);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(249, 49);
            this.button8.TabIndex = 2;
            this.button8.Text = "Delete Student";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter Student ID : ";
            // 
            // txtFieldDelete
            // 
            this.txtFieldDelete.Location = new System.Drawing.Point(12, 62);
            this.txtFieldDelete.Name = "txtFieldDelete";
            this.txtFieldDelete.Size = new System.Drawing.Size(249, 21);
            this.txtFieldDelete.TabIndex = 0;
            // 
            // grpBoxAdd
            // 
            this.grpBoxAdd.Controls.Add(this.label10);
            this.grpBoxAdd.Controls.Add(this.label9);
            this.grpBoxAdd.Controls.Add(this.label8);
            this.grpBoxAdd.Controls.Add(this.txtAddUniversity);
            this.grpBoxAdd.Controls.Add(this.txtAddDepartment);
            this.grpBoxAdd.Controls.Add(this.label7);
            this.grpBoxAdd.Controls.Add(this.txtAddNumeric);
            this.grpBoxAdd.Controls.Add(this.label6);
            this.grpBoxAdd.Controls.Add(this.txtAddCgpa);
            this.grpBoxAdd.Controls.Add(this.label5);
            this.grpBoxAdd.Controls.Add(this.txtAddnAME);
            this.grpBoxAdd.Controls.Add(this.button9);
            this.grpBoxAdd.Controls.Add(this.label4);
            this.grpBoxAdd.Controls.Add(this.txtAddId);
            this.grpBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAdd.Location = new System.Drawing.Point(151, 6);
            this.grpBoxAdd.Name = "grpBoxAdd";
            this.grpBoxAdd.Size = new System.Drawing.Size(757, 461);
            this.grpBoxAdd.TabIndex = 3;
            this.grpBoxAdd.TabStop = false;
            this.grpBoxAdd.Text = "Add Student ";
            this.grpBoxAdd.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label10.Location = new System.Drawing.Point(12, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(379, 31);
            this.label10.TabIndex = 13;
            this.label10.Text = "Student Added Successfully";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(547, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "University ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Department ";
            // 
            // txtAddUniversity
            // 
            this.txtAddUniversity.FormattingEnabled = true;
            this.txtAddUniversity.Location = new System.Drawing.Point(550, 130);
            this.txtAddUniversity.Name = "txtAddUniversity";
            this.txtAddUniversity.Size = new System.Drawing.Size(189, 23);
            this.txtAddUniversity.TabIndex = 10;
            // 
            // txtAddDepartment
            // 
            this.txtAddDepartment.FormattingEnabled = true;
            this.txtAddDepartment.Location = new System.Drawing.Point(280, 130);
            this.txtAddDepartment.Name = "txtAddDepartment";
            this.txtAddDepartment.Size = new System.Drawing.Size(249, 23);
            this.txtAddDepartment.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Semester : ";
            // 
            // txtAddNumeric
            // 
            this.txtAddNumeric.Location = new System.Drawing.Point(13, 130);
            this.txtAddNumeric.Name = "txtAddNumeric";
            this.txtAddNumeric.Size = new System.Drawing.Size(248, 21);
            this.txtAddNumeric.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "CGPA : ";
            // 
            // txtAddCgpa
            // 
            this.txtAddCgpa.Location = new System.Drawing.Point(550, 55);
            this.txtAddCgpa.Name = "txtAddCgpa";
            this.txtAddCgpa.Size = new System.Drawing.Size(189, 21);
            this.txtAddCgpa.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name : ";
            // 
            // txtAddnAME
            // 
            this.txtAddnAME.Location = new System.Drawing.Point(280, 55);
            this.txtAddnAME.Name = "txtAddnAME";
            this.txtAddnAME.Size = new System.Drawing.Size(249, 21);
            this.txtAddnAME.TabIndex = 3;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Location = new System.Drawing.Point(550, 200);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(195, 49);
            this.button9.TabIndex = 2;
            this.button9.Text = "Add Student";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Student ID : ";
            // 
            // txtAddId
            // 
            this.txtAddId.Enabled = false;
            this.txtAddId.Location = new System.Drawing.Point(12, 55);
            this.txtAddId.Name = "txtAddId";
            this.txtAddId.Size = new System.Drawing.Size(249, 21);
            this.txtAddId.TabIndex = 0;
            // 
            // dataGridViewAttendance
            // 
            this.dataGridViewAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAttendance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendance.Location = new System.Drawing.Point(18, 49);
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            this.dataGridViewAttendance.Size = new System.Drawing.Size(721, 150);
            this.dataGridViewAttendance.TabIndex = 0;
            this.dataGridViewAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAttendance_CellContentClick);
            // 
            // grpBoxMarkAttendance
            // 
            this.grpBoxMarkAttendance.Controls.Add(this.dataGridViewAttendance);
            this.grpBoxMarkAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxMarkAttendance.Location = new System.Drawing.Point(145, 6);
            this.grpBoxMarkAttendance.Name = "grpBoxMarkAttendance";
            this.grpBoxMarkAttendance.Size = new System.Drawing.Size(871, 239);
            this.grpBoxMarkAttendance.TabIndex = 3;
            this.grpBoxMarkAttendance.TabStop = false;
            this.grpBoxMarkAttendance.Text = "Mark Attendance";
            this.grpBoxMarkAttendance.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 593);
            this.Controls.Add(this.grpBoxMarkAttendance);
            this.Controls.Add(this.grpBoxAdd);
            this.Controls.Add(this.grpBoxTop3);
            this.Controls.Add(this.grpBoxList);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.grpBoxAddStudent);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpBoxSearch);
            this.Controls.Add(this.grpBoxDeleteStudent);
            this.Name = "Form1";
            this.Text = "Assignment # 2";
            this.grpBoxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListAll)).EndInit();
            this.grpBoxTop3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTop3)).EndInit();
            this.grpBoxSearch.ResumeLayout(false);
            this.grpBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.grpBoxDeleteStudent.ResumeLayout(false);
            this.grpBoxDeleteStudent.PerformLayout();
            this.grpBoxAdd.ResumeLayout(false);
            this.grpBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).EndInit();
            this.grpBoxMarkAttendance.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox grpBoxAddStudent;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox grpBoxList;
        private System.Windows.Forms.DataGridView dataGridListAll;
        private System.Windows.Forms.GroupBox grpBoxTop3;
        private System.Windows.Forms.DataGridView dataGridTop3;
        private System.Windows.Forms.GroupBox grpBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.TextBox txtBoxSearchName;
        private System.Windows.Forms.TextBox txtBoxSearchId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBoxDeleteStudent;
        private System.Windows.Forms.TextBox txtFieldDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox grpBoxAdd;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddnAME;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddCgpa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtAddNumeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtAddUniversity;
        private System.Windows.Forms.ComboBox txtAddDepartment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewAttendance;
        private System.Windows.Forms.GroupBox grpBoxMarkAttendance;
    }
}

