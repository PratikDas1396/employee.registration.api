namespace employee.registration.database.DbContext
{
    using employee.registration.database.DataModels;
    using Microsoft.EntityFrameworkCore;

    public class EmployeeDatabaseContext : DbContext
    {
        public DbSet<EmployeeTable> Employees { get; set; }
        public DbSet<DepartmentTable> Departments { get; set; }
        public DbSet<DesignationTable> Designations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "EmployeeRegistration");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentTable>().HasData(
                new DepartmentTable()
                {
                    Id = Guid.NewGuid(),
                    Name = "Technology"
                }, new DepartmentTable()
                {
                    Id = Guid.NewGuid(),
                    Name = "Admin"
                },
                new DepartmentTable()
                {
                    Id = Guid.NewGuid(),
                    Name = "Finance"
                },
                new DepartmentTable()
                {
                    Id = Guid.NewGuid(),
                    Name = "Operations"
                }
            );

            modelBuilder.Entity<DesignationTable>().HasData(
               new DesignationTable()
               {
                   Id = Guid.NewGuid(),
                   Name = "Software Engineer"
               },
               new DesignationTable()
               {
                   Id = Guid.NewGuid(),
                   Name = "Transport Manager"
               },
               new DesignationTable()
               {
                   Id = Guid.NewGuid(),
                   Name = "Account"
               },
               new DesignationTable()
               {
                   Id = Guid.NewGuid(),
                   Name = "Staff Manager"
               }
           );

        }
    }
}
