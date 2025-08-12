using LabExer01_EventDriven.StudentInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExer01_EventDriven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Bachelor of Science in Computer Science");
            comboBox1.Items.Add("Bachelor of Science in Information Technology");
            comboBox1.Items.Add("Bachelor of Science in Tourism Management");
            comboBox1.Items.Add("Bachelor of Science in Bussiness Administration");
            comboBox1.Items.Add("Bachelor of Science in Psychology");
            comboBox1.Items.Add("Bachelor of Science in MultiMedia Arts");
            comboBox1.Items.Add("Bachelor of Science in Secondary Education");
            comboBox1.Items.Add("Bachelor of Science in Hospitality Management");
            comboBox1.Items.Add("Bachelor of Science in Accountancy");
            comboBox1.Items.Add("Bachelor of Science in Civil Engineering");
            comboBox1.Items.Add("Bachelor of Science in Architecture");
            comboBox1.Items.Add("Bachelor of Science in Electronics Engineering");
            comboBox1.Items.Add("Bachelor of Science in Electrical Engineering");
            comboBox1.Items.Add("Bachelor of Science in Mechanical Engineering");
            comboBox1.Items.Add("Bachelor of Science in Chemical Engineering");
            comboBox1.Items.Add("Bachelor of Science in Agriculture");
            comboBox1.Items.Add("Bachelor of Science in Fisheries");
            comboBox1.Items.Add("Bachelor of Science in Criminology");
            comboBox1.Items.Add("Bachelor of Science in Agriculture and Biosystems Engineering");
            comboBox1.Items.Add("Bachelor of Science in Food Technology");
            comboBox1.Items.Add("Bachelor of Science in Environmental Science");
            comboBox1.Items.Add("Bachelor of Science in Geology");
            comboBox1.Items.Add("Bachelor of Science in Marine Biology");
            comboBox1.Items.Add("Bachelor of Science in Nursing");
            comboBox1.Items.Add("Bachelor of Science in Pharmacy");
            comboBox1.Items.Add("Bachelor of Science in Radiologic Technology");
            comboBox1.Items.Add("Bachelor of Science in Physical Therapy");
            comboBox1.Items.Add("Bachelor of Science in Occupational Therapy");
            comboBox1.Items.Add("Bachelor of Science in Veterinary Medicine");
            comboBox1.Items.Add("Bachelor of Science in Agriculture and Food Technology");
            comboBox1.Items.Add("Bachelor of Science in Data Science");
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
            StudentInfoclass.FirstName = textBox4.Text;
            StudentInfoclass.LastName = textBox2.Text;
            StudentInfoclass.MiddleName = textBox5.Text;
            StudentInfoclass.Address = richTextBox1.Text;
            StudentInfoclass.Program = comboBox1.Text;
            StudentInfoclass.Age = long.Parse(textBox3.Text);
            StudentInfoclass.ContactNum = long.Parse(textBox6.Text);
            StudentInfoclass.StudentNum = long.Parse(textBox1.Text);

            Form2 form2= new Form2();
            form2.Show();
            this.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
