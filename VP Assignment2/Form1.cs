using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Assignment2
{
   
    public partial class Form1 : Form
    {
        Student[] obj;
        
        int count;
        List<Student> listObj = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            readDataFromFile();

        }
        public void readDataFromFile()
        {
            count = 0;
            listObj.Clear();
            int records = 0;
            string[] fileData;
            String filePath = "Data.txt";
            
            fileData = File.ReadAllLines(filePath);
            count = fileData.Length;
            obj = new Student[count];
            int temp = 0;
            int i = 0;
                    while(i<count)
                    {
                        if (temp == 7)
                        {
                          
                            temp = 0;
                            records++; 
                        }
                      obj[records] = new Student();
                      obj[records].id = fileData[i];
                      i++;
                      temp++;
                      obj[records].name = fileData[i];
                      i++;
                      temp++;
                      obj[records].cgpa = fileData[i];
                      i++;
                      temp++;
                      
                      obj[records].department = fileData[i];
                      i++;
                      temp++;
                      obj[records].university = fileData[i];
                      i++;
                      temp++;
                      obj[records].semester = fileData[i];
                      i++;
                      temp++;
                      obj[records].attendance = fileData[i];
                      i++;
                      temp++;  

                        listObj.Add(obj[records]);
                    }
                    dataGridListAll.DataSource = listObj;

        }
        public void reset()
        {
            listObj.Clear();

            readDataFromFile();
            grpBoxAdd.Visible = false;
            grpBoxList.Visible = false;
            grpBoxSearch.Visible = false;
            grpBoxTop3.Visible = false;
            grpBoxDeleteStudent.Visible = false;
            grpBoxMarkAttendance.Visible = false;
            //grpBoxMarkAttendance.Visible = false;
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reset();
            grpBoxList.Visible = true;
            dataGridListAll.DataSource = listObj;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reset();
            grpBoxTop3.Visible = true;
            try
            {
                List<Student> listTop3 = listObj.OrderByDescending(obj => obj.cgpa).ToList().GetRange(0, 3);
                dataGridTop3.DataSource = listTop3;
            }

            catch(Exception ex)
            {

            }
            



        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset();
            grpBoxSearch.Visible = true;
            

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtBoxSearchId.Text = "";
            List<Student> searchList= new List<Student>();
            readDataFromFile();
            listObj.ForEach(obj =>
            {
                if(txtBoxSearchName.Text == obj.name )
                {
                    searchList.Add(obj);
                }

            });

            dataGridViewSearch.DataSource = searchList;
        }

        private void txtBoxSearchId_TextChanged(object sender, EventArgs e)
        {
            txtBoxSearchName.Text = "";
            List<Student> searchList = new List<Student>();
            readDataFromFile();
            listObj.ForEach(obj =>
            {
                if (txtBoxSearchId.Text == obj.id)
                {
                    searchList.Add(obj);
                }

            });

            dataGridViewSearch.DataSource = searchList;
        }

        private void txtBoxSearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string data = "";
            data += "ID\t Name\t\tAttendance\n";

            listObj.ForEach(obj=> {
            
                data+= obj.id + "\t" + obj.name + "\t\t" + obj.attendance + "\n";
            });

            MessageBox.Show(data);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            File.WriteAllText("Data.txt", String.Empty);
            int del = 0;
            listObj.ForEach(i=> {
            
            if(i.id != txtFieldDelete.Text)
            {
                String[] write = {i.id,i.name,i.cgpa,i.department,i.university,i.semester,i.attendance };
                File.AppendAllLines("Data.txt", write);
                del = 1;
            }
            });
            if (del == 1)
            {
                MessageBox.Show("Student Deleted Successfully ");
            }
            else
            {
                MessageBox.Show("No Student Found ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
            grpBoxDeleteStudent.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {


                String[] write = { txtAddId.Text, txtAddnAME.Text, txtAddCgpa.Text, txtAddDepartment.Text, txtAddUniversity.Text, txtAddNumeric.Value.ToString(), "N/A" };
                File.AppendAllLines("Data.txt", write);
                label10.Visible = true;
                txtAddnAME.Text = "";
                txtAddNumeric.Value = 0;
                txtAddUniversity.Text = "";
                txtAddDepartment.Text = "";
                txtAddCgpa.Text = "";
            }

            catch(Exception o )
            {
                label10.Text = "Adding Student Failed ! ";
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            reset();
            grpBoxAdd.Visible = true;
            txtAddId.Text = ((count / 7) + 1).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reset();

            grpBoxMarkAttendance.Visible = true;

           

          


            DataTable attendanceTable = new DataTable();

            attendanceTable.Columns.Add("ID", typeof(string));
            attendanceTable.Columns.Add("Name", typeof(string));
            attendanceTable.Columns.Add("Present",System.Type.GetType("System.Boolean"));

            listObj.ForEach(i => {

                DataRow row = attendanceTable.NewRow();
                row[0] = i.id;
                row[1] = i.name;
                if(i.attendance != "Present")
                {
                    row[2] = false;
                }
                else 
                {
                    row[2] = true;
                }

                attendanceTable.Rows.Add(row);
            
            });

            dataGridViewAttendance.DataSource = attendanceTable;
        }

        private void dataGridViewAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if(e.ColumnIndex == dataGridViewAttendance.Columns["Present"].Index)
            {

                dataGridViewAttendance.EndEdit();
                if ((bool)dataGridViewAttendance.Rows[e.RowIndex].Cells["Present"].Value)
                {
                    MessageBox.Show(dataGridViewAttendance.Rows[e.RowIndex].Cells[1].Value + " =>  Marked Present");
                    File.WriteAllText("Data.txt", string.Empty);

                    Student st = listObj.Find(i => i.id == dataGridViewAttendance.Rows[e.RowIndex].Cells[0].Value);

                    listObj.ForEach(i =>
                    {


                        if (i.id == dataGridViewAttendance.Rows[e.RowIndex].Cells[0].Value)
                        {
                            i.attendance = "Present";
                            String[] write = { i.id, i.name, i.cgpa, i.department, i.university, i.semester, "Present" };
                            File.AppendAllLines("Data.txt", write);
                        }
                        else
                        {
                            String[] write = { i.id, i.name, i.cgpa, i.department, i.university, i.semester, i.attendance };
                            File.AppendAllLines("Data.txt", write);
                        }

                    });
                }


                else
                {
                    MessageBox.Show(dataGridViewAttendance.Rows[e.RowIndex].Cells[1].Value + " =>  Marked Absent");
                    File.WriteAllText("Data.txt", string.Empty);

                    Student st = listObj.Find(i => i.id == dataGridViewAttendance.Rows[e.RowIndex].Cells[0].Value);

                    listObj.ForEach(i =>
                    {


                        if (i.id == dataGridViewAttendance.Rows[e.RowIndex].Cells[0].Value)
                        {
                            i.attendance = "Absent";
                            String[] write = { i.id, i.name, i.cgpa, i.department, i.university, i.semester, "Absent" };
                            File.AppendAllLines("Data.txt", write);
                        }
                        else
                        {
                            String[] write = { i.id, i.name, i.cgpa, i.department, i.university, i.semester, i.attendance };
                            File.AppendAllLines("Data.txt", write);
                        }

                    });
                }
            }
        }
    }

    public class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public string cgpa { get; set; }
        
        public string department { get; set; }
        public string university { get; set; }
        public string semester { get; set; }
        public string attendance { get; set; }
    }
}
