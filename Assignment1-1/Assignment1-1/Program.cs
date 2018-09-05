/*
 *  Steven Faulkner 
 *  U96161844 Assignment 1-1
 *  Small OOP project to get familiar with c#
 */

using System;
using System.Collections.Generic;


namespace Assignment1_1
{
    class Student
    {
        private string first_name;
        private string last_name;
        private string ID;
        private string email;
        private int age;
        private string returningStudent;

        //loop will gather all info then pass to the constructor, only need the getters to return info, and no setters since 
        // we are creating an object after all data has been passed.
        public Student(string First_Name, string Last_Name, string id, string Email, int Age, string ReturningStudent)
        {
            first_name = First_Name;
            last_name = Last_Name;
            ID = id;
            email = Email;
            age = Age;
            returningStudent = ReturningStudent;
        }

        public string GetFirst() => first_name;
        public string GetLast() => last_name;
        public string GetID() => ID;
        public string GetEmail() => email;
        public int GetAge() => age;
        public string GetStatus() => returningStudent;

    }



    class Program
    {
        static void Main(string[] args)
        {
             
            List<Student> ListOfStudents = new List<Student>();

            bool DontStop = true;


            //gather user objects until break
            while (DontStop) 
            {

                Console.Write("Enter first name: ");
                string fName = Console.ReadLine();

                Console.Write("Enter last name: ");
                string lName = Console.ReadLine();

                Console.Write("Enter University ID: ");
                string Uid = Console.ReadLine();

                Console.Write("Enter email address: ");
                string Email = Console.ReadLine();

                Console.Write("Enter your age: ");
                int Age = Convert.ToInt32(Console.ReadLine());

                Console.Write("New Student?");
                string rtrnStudent = Console.ReadLine();

                ListOfStudents.Add(new Student(fName,lName,Uid,Email,Age,rtrnStudent));
            
                Console.Write("Enter another student(Yes or No)? ");
                string loopBreak = Console.ReadLine();

                DontStop = (string.Equals(loopBreak, b: "yes", comparisonType: StringComparison.OrdinalIgnoreCase)) ? true : false; 

            }

            int count = 1;

        //iterate through each element of object list 
        foreach(Student tmpStudent in ListOfStudents)
            {
                Console.WriteLine("\nStudent # " + count++);
                Console.WriteLine("Student Name: " + tmpStudent.GetFirst() + " " + tmpStudent.GetLast());
                Console.WriteLine("Student ID: " + tmpStudent.GetID());
                Console.WriteLine("Student Email: " + tmpStudent.GetEmail());
                Console.WriteLine("Student Age: " + tmpStudent.GetAge());
                Console.WriteLine("Returning Student: " + tmpStudent.GetStatus());
            }

            ListOfStudents.Clear();
            Console.ReadLine();
        }
    }
}
