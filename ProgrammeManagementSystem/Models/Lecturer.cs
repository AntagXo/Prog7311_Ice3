using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgrammeManagementSystem.Models
{
    public class Lecturer
    {
        [Key]
        public int LecturerID {  get; set; }

        [Required]

        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]

        public string Department { get; set; }
    }
}
