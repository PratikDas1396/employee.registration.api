using employee.registration.database.DataModels;

namespace employee.registration.repository.Interfaces
{
    public interface IDataRepository
    {
        public IQueryable<DepartmentTable> Departments { get; }
        public IQueryable<DesignationTable> Designations { get; }
        public IQueryable<EmployeeTable> Employees { get; }
        public void Add<EntityType>(EntityType entity);
        public void SaveChanges();
    }
}
