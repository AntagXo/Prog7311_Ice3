using System.ComponentModel.DataAnnotations;

namespace ProgrammeManagementSystem.Models
{
    public class Module //might get error from database table being named modules
    {
        [Key]

        public int ModuleID { get; set; }

        [Required]

        public string ModuleName { get; set; }

        [Required]
        
        public string ModuleCode { get; set; }

        [Required]

        public int Credits { get; set; }
        [Required]

        public int AcademicYear { get; set; }
    }
}
