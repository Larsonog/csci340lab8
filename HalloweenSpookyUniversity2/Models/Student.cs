using System;
using System.Collections.Generic;

namespace HalloweenSpookyUniversity2.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public int Age { get; set; }
        public DateTime EnrollmentDate { get; set; }
        
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}