using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgrammeManagementSystem.Models
{
    public class Registration
    {
        [Key]
        public int RegistrationID {  get; set; }

        [Required]

        [ForeignKey("Student")]
        public int StudentID { get; set; }

        [Required]
        [ForeignKey("Module")]

        public int ModuleID { get; set; }
    }
}
