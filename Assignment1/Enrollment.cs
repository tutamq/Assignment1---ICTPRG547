using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Enrollment
    {
        // Default values
        static DateTime DEF_DATE_ENROLLED = new DateTime(2000, 01, 01);
        const string DEF_GRADE = "No Grade provided";
        const string DEF_SEMESTER = "No Semester provided";

        // Aggregation class Subject
        public Subject EnrollmentSubject;


        // Getters & Setters
        public DateTime EnrollmentDate { get; set; }
        public string EnrollmentGrade { get; set; }
        public string EnrollmentSemester { get; set; }
        public Subject Subject { get; set; }

        // All-arg constructor
        public Enrollment(DateTime enrollmentDate, string enrollmentGrade, string enrollmentSemester, Subject enrollmentSubject)
        {
            EnrollmentDate = enrollmentDate;
            EnrollmentGrade = enrollmentGrade;
            EnrollmentSemester = enrollmentSemester;
            Subject = enrollmentSubject;
        }

        // No-arg constructor
        public Enrollment() : this(DEF_DATE_ENROLLED, DEF_GRADE, DEF_SEMESTER, new Subject()) { }

        // ToString
        public override string ToString()
        {
            return  "Date Enrolled: " + EnrollmentDate +
                  "\nGrade: " + EnrollmentGrade +
                  "\nSemester: " + EnrollmentSemester +
                  "\n--- Subject: \n" + Subject +
                  "\n";
        }
    }
}
