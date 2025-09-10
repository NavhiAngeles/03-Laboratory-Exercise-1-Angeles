using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabExer01_EventDriven.StudentInfo; 
namespace LabExer01_EventDriven
{
    public partial class Form2 : Form 
    {
        private StudentInfoclass.DelegateString delProgram, delLastName, delFirstName, delMiddleName, delAddress, delGender,delBirthday;
        private StudentInfoclass.DelegateNum delAge, delContactNum, delStudentnum;

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Registration Confirmed!");

        }

        public Form2()
        {
            InitializeComponent();
            delProgram = new StudentInfoclass.DelegateString(StudentInfoclass.GetProgram);
            delLastName = new StudentInfoclass.DelegateString(StudentInfoclass.GetLastName);
            delFirstName = new StudentInfoclass.DelegateString(StudentInfoclass.GetFirstName);  
            delMiddleName = new StudentInfoclass.DelegateString(StudentInfoclass.GetMiddleName);
            delAddress = new StudentInfoclass.DelegateString(StudentInfoclass.GetAddress);  
            delAge = new StudentInfoclass.DelegateNum(StudentInfoclass.GetAge);
            delContactNum = new StudentInfoclass.DelegateNum(StudentInfoclass.GetContactNum);
            delStudentnum = new StudentInfoclass.DelegateNum(StudentInfoclass.GetStudentNum);
           




            textBox1.Text = delProgram(StudentInfoclass.Program);
            maskedTextBox2.Text = delLastName(StudentInfoclass.LastName);
            textBox2.Text = delFirstName(StudentInfoclass.FirstName);   
            maskedTextBox3.Text = delMiddleName(StudentInfoclass.MiddleName);    
            textBox4.Text = delAddress(StudentInfoclass.Address);
            textBox3.Text = delAge(StudentInfoclass.Age).ToString();
            maskedTextBox4.Text = delContactNum(StudentInfoclass.ContactNum).ToString();
            maskedTextBox1.Text = delStudentnum(StudentInfoclass.StudentNum).ToString();
           




        }

            
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
