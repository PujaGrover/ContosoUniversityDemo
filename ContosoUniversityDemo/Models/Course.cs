using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversityDemo.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//LET'S U ENTER Primary Key rather than havind database generate it
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
