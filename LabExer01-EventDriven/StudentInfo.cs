using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExer01_EventDriven
{
    using System.Windows.Forms;

    public class StudenInfoClass {
        public delegate long DelegateNum(long number);
        public delegate string DelegateString(string txt);

        public static string FirstName = " ";
        public static string LastName = " ";
        public static string MiddleName = " ";
        public static string Address = " ";
        public static string Program = " ";
        public static long Age = 0;
        public static long ContactNum = 0;
        public static long StudentNum = 0;

        public static string GetFirstName(String fname) => FirstName;

        public static string GetLastName(string lname) => LastName;

        public static string GetMiddleName(string mname) => MiddleName;
        
        public static string GetAddress(string address) => Address;

        public static string GetProgram(string program) => Program;

        public static long GetAge(long age) => Age;

        public static long GetContactNum(long contactnum) => ContactNum;

        public static long GetStudentNum(long studentnum) => StudentNum;

    }
    
        
    }

 

