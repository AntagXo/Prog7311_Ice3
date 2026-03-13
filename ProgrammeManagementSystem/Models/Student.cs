using System.ComponentModel.DataAnnotations;

namespace ProgrammeManagementSystem.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required]

        public string FullName { get; set; }

        [Required]
         public string LastName { get; set; }

        [Required]

        public string Email {  get; set; }

        [Required]

        public int PhoneNumber { get; set; }

        [Required]

        public int YearOfStudy { get; set; }
    }
}
