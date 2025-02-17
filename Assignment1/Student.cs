using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Student
    {
        // Default values
        const string DEF_STUDENT_ID = "No Student ID provided";
        const string DEF_PROGRAM = "No Program provided";
        static DateTime DEF_DATE_REGISTERED = new DateTime(2000, 01, 01);

        // Aggregation class Enrollment
        public Enrollment StudentEnrollment;

        // Getters & Setters
        public string StudentID { get; set; }
        public string StudentProgram { get; set; }
        public DateTime StudentDateRegistered { get; set; }
        public Enrollment Enrollment { get; set; }

        // All-arg constructor
        public Student(string studentID, string studentProgram, DateTime studentDateRegistered, Enrollment studentEnrollment)
        {
            StudentID = studentID;
            StudentProgram = studentProgram;
            StudentDateRegistered = studentDateRegistered;
            Enrollment = studentEnrollment;
        }

        // No-arg constructor
        public Student() : this(DEF_STUDENT_ID, DEF_PROGRAM, DEF_DATE_REGISTERED, new Enrollment()) { }

        // ToString
        public override string ToString()
        {
            return base.ToString() + "Student ID: " + StudentID +
                                    "\nStudent Program: " + StudentProgram +
                                    "\nDate Registered: " + StudentDateRegistered +
                                    "\n--- Enrollment: \n" + Enrollment +
                                    "\n";
        }
    }
}
