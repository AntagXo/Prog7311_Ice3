using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgrammeManagementSystem.Models
{
    public class ModuleAssignment
    {
        [Key]
        public int AssignmentID { get; set; }

        [Required]
        [ForeignKey("Module")]

        public int ModuleID { get; set; }

        [Required]
        [ForeignKey("Lecturer")]
        public int LecturerID { get; set; }

    }
}
