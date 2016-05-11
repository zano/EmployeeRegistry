namespace EmployeeRegistry.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EmployeeRegistry.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeRegistry.DataAccessLayer.EmployeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeRegistry.DataAccessLayer.EmployeeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.

            context.Employees.AddOrUpdate(
              e => e.FirstName,
              new Employee { FirstName = "Cesar", LastName = "Peters", Salary = 10000, Department = "R&D", Position = "Programmer", Company = "Acme Inc" },
              new Employee { FirstName = "Andrew", LastName = "Andrewson", Salary = 10000, Department = "R&D", Position = "Programmer" },
              new Employee { FirstName = "Brice", LastName = "Lambson", Salary = 12000, Department = "IT", Position = "Programmer" },
              new Employee { FirstName = "Rowan", LastName = "Johnson", Salary = 9000, Department = "HR", Position = "Manager" }
            );
            
        }
    }
}
