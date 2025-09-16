using LabExer01_EventDriven.StudentInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExer01_EventDriven
{
    public partial class Form1 : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNum;
        private long _StudentNum;


        public Form1()
        {
            InitializeComponent();
            string[] ListOfProgram = new string[]{
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management" };

            for (int i = 0; i < 6; i++)
            {
                comboBox1.Items.Add(ListOfProgram[i].ToString());
            }

            string[] ListOfGender = new string[]{
                "Male",
                "Female",
                };

            for (int i = 0; i < 2; i++)
            {
                comboBox2.Items.Add(ListOfGender[i].ToString());
            }
        }
        public long StudentNumber(string studNum)
        {

            _StudentNum = long.Parse(studNum);

            return _StudentNum;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNum = long.Parse(Contact);
            }

            return _ContactNum;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            return _Age;
        }
 
    


    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                String Studbb = "Data Source=DESKTOP-1S9DCFG\\SQLEXPRESS01;Initial Catalog=EDPDatabase;Integrated Security=True;TrustServerCertificate=True";

                Studentinfo.SetFullName = FullName(textBox2.Text, textBox4.Text, textBox5.Text);
                Studentinfo.SetStudentNum = (int)StudentNumber(textBox1.Text);
                Studentinfo.SetProgram = comboBox1.Text;
                Studentinfo.SetGender = comboBox2.Text;
                Studentinfo.SetContactNum = (int)ContactNo(textBox6.Text);
                Studentinfo.SetAge = Age(textBox3.Text);
                Studentinfo.SetBirthDay = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                using (SqlConnection nav = new SqlConnection(Studbb))
                {
                    nav.Open();

                    string db = @"INSERT INTO Student(
                       StudentNo, Program, LastName, FirstName, MiddleName, Age, Birthday, ContactNo, Gender, FullName)
                        VALUES (
                       @StudentNo, @Program, @LastName, @FirstName, @MiddleName, @Age, @Birthday, @ContactNo, @Gender, @FullName)";

                    using (SqlCommand utos = new SqlCommand(db, nav))
                    {
                        utos.Parameters.AddWithValue("@StudentNo", Studentinfo.SetStudentNum);
                        utos.Parameters.AddWithValue("@Program", Studentinfo.SetProgram);
                        utos.Parameters.AddWithValue("@LastName", textBox2.Text);
                        utos.Parameters.AddWithValue("@FirstName", textBox4.Text);
                        utos.Parameters.AddWithValue("@MiddleName", textBox5.Text);
                        utos.Parameters.AddWithValue("@Age", Studentinfo.SetAge);
                        utos.Parameters.AddWithValue("@Birthday", Studentinfo.SetBirthDay);
                        utos.Parameters.AddWithValue("@ContactNo", Studentinfo.SetContactNum);
                        utos.Parameters.AddWithValue("@Gender", Studentinfo.SetGender);
                        utos.Parameters.AddWithValue("@FullName", Studentinfo.SetFullName);

                        utos.ExecuteNonQuery();
                    }
                }

                Form2 frm = new Form2();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill out the form correctly. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
















            //    studentinfoclass.firstname = textbox4.text;
            //    studentinfoclass.lastname = textbox2.text;
            //    studentinfoclass.middlename = textbox5.text;
            //    studentinfoclass.address = richtextbox1.text;
            //    studentinfoclass.program = combobox1.text;
            //    studentinfoclass.age = long.parse(textbox3.text);
            //    studentinfoclass.contactnum = long.parse(textbox6.text);
            //    studentinfoclass.studentnum = long.parse(textbox1.text);


            //    form2 form2 = new form2();
            //    if (form2.showdialog() == dialogresult.ok)
            //    {
            //        textbox4.clear();
            //        textbox5.clear();
            //        textbox2.clear();
            //        richtextbox1.clear();
            //        textbox3.clear();
            //        textbox6.clear();
            //        textbox1.clear();

            //        combobox1.selectedindex = -1;

            //    }
            //    form2.show();
            //    this.hide();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
