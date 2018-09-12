using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string LearningDisabilities { get; set; }

        public string GPA { get; set; }
        public string Department { get; set; }
        public int EnrollmentYear { get; set; }
        public string GraduationDate { get; set; }

        public Student()
        {
            FirstName = "";
            LastName = "";
            ID = "";
            Address = "";
            Email = "";
            PhoneNumber = "";
            DOB = "";
            Gender = "";
            LearningDisabilities = "";
            GPA = "";
            Department = "";
            EnrollmentYear = 0;
            GraduationDate = "";
        }

        public Student(string firstName, string lastName, string iD, string address, string email, string phoneNumber, string dOB, 
                       string gender, string learningDisabilities, string gPA, string department, int enrollmentYear, string graduationDate)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = iD;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            DOB = dOB;
            Gender = gender;
            LearningDisabilities = learningDisabilities;
            GPA = gPA;
            Department = department;
            EnrollmentYear = enrollmentYear;
            GraduationDate = graduationDate;
        }
    }
}
