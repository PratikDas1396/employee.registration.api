using System.ComponentModel.DataAnnotations;

namespace employee.registration.database.DataModels
{
    public class EmployeeTable
    {
        [Key]
        public Guid Id { get; set; }

        public string EmployeeNumber { get; set; }
        
        public string Name { get; set; }

        [Required]
        public DepartmentTable DepartmentId { get; set; }

        [Required]
        public DesignationTable DesignationId { get; set; }

        public DateOnly DateOfJoining { get; set; }

    }
}
