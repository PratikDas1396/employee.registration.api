using System.ComponentModel.DataAnnotations;

namespace employee.registration.database.DataModels
{
    public class DepartmentTable
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; } 
    }
}
