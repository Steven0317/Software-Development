using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StudentApp
{   [XmlRoot(ElementName ="Student")]
    public class Student
    {
        [XmlAttribute(DataType ="string")]
        public string FirstName { get; set; }

        [XmlAttribute(DataType ="string")]
        public string LastName { get; set; }

        [XmlAttribute(DataType = "string")]
        public string ID { get; set; }

        [XmlAttribute(DataType = "string")]
        public string Address { get; set; }

        [XmlAttribute(DataType = "string")]
        public string Email { get; set; }

        [XmlAttribute(DataType = "string")]
        public string PhoneNumber { get; set; }

        [XmlAttribute(DataType = "string")]
        public string DOB { get; set; }

        [XmlAttribute(DataType = "string")]
        public string Gender { get; set; }

        [XmlAttribute(DataType = "string")]
        public string Race { get; set; }

        [XmlAttribute(DataType = "string")]
        public string LearningDisabilities { get; set; }


        [XmlAttribute(DataType = "double")]
        public double GPA { get; set; }

        [XmlAttribute(DataType = "string")]
        public string Department { get; set; }

        [XmlAttribute(DataType = "int")]
        public int EnrollmentYear { get; set; }

        [XmlAttribute(DataType = "int")]
        public int GraduationDate { get; set; }

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
            GPA = 0;
            Department = "";
            EnrollmentYear = 0;
            GraduationDate = 0;
        }

        public Student(string firstName, string lastName, string iD, string address, string email, string phoneNumber, string dOB, 
                       string gender, string race, string learningDisabilities, double gPA, string department, int enrollmentYear, int graduationDate)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = iD;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            DOB = dOB;
            Gender = gender;
            Race = race;
            LearningDisabilities = learningDisabilities;
            GPA = gPA;
            Department = department;
            EnrollmentYear = enrollmentYear;
            GraduationDate = graduationDate;
        }


        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}",
                    this.FirstName, this.LastName, this.ID, this.Address, this.Email, this.PhoneNumber, this.DOB, this.Gender, this.Race, this.LearningDisabilities, this.GPA, this.GraduationDate );
        }
    }
}
