using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Subject
    {
        // Default values
        const string DEF_SUBJECT_CODE = "No Subject code provided";
        const string DEF_SUBJECT_NAME = "No Subject name provided";
        const double DEF_COST = 0;

        // Getters & Setters
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public double SubjectCost { get; set; }

        // All-arg constructor
        public Subject(string subjectCode, string subjectName, double subjectCost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            SubjectCost = subjectCost;
        }

        // No-arg constructor
        public Subject() : this(DEF_SUBJECT_CODE, DEF_SUBJECT_NAME, DEF_COST) { }

        // ToString
        public override string ToString()
        {
            return "Subject Code: " + SubjectCode +
                  "\nSubject Name: " + SubjectName +
                  "\nSubject Cost: " + SubjectCost +
                  "\n";
        }
    }
}
