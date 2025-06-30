using System.ComponentModel.DataAnnotations;

namespace StudentRecordApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Roll Number")]
        public string RollNumber { get; set; }

        [Required]
        public string Course { get; set; }

        [Range(1, 8)]
        public int Semester { get; set; }
    }
}
