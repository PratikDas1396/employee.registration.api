using employee.registration.database.DataModels;
using employee.registration.database.DbContext;
using employee.registration.repository.Interfaces;

namespace employee.registration.repository.Implementation
{
    public class DataRepository : IDataRepository
    {
        private readonly EmployeeDatabaseContext context;

        public DataRepository(EmployeeDatabaseContext _context)
        {
            context = _context;
            context.Database.EnsureCreated();
        }

        public IQueryable<DepartmentTable> Departments => context.Departments.AsQueryable();

        public IQueryable<DesignationTable> Designations => context.Designations.AsQueryable();

        public IQueryable<EmployeeTable> Employees => context.Employees.AsQueryable();

        public void Add<EntityType>(EntityType entity)
        {
            _ = context.Add(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
