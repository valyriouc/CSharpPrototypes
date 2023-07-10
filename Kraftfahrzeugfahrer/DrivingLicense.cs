using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverTask
{
    internal class DrivingLicense
    {
        private DateTime issueDate;
        private string grade;

        public DrivingLicense(DateTime issueDate, string grade)
        {
            this.issueDate = issueDate;
            this.grade = grade;
        }

        public override string ToString()
        {
            return $"Issue Date: {issueDate}\nGrade: {grade}";
        }

        public DateTime GetIssueDate()
        {
            return issueDate;
        }

        public string GetGrade()
        {
            return grade;
        }
    }
}
