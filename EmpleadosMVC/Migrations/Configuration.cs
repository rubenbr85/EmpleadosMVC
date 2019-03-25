namespace EmpleadosMVC.Migrations
{
    using EmpleadosMVC.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmpleadosMVC.Models.EmpleadoDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmpleadosMVC.Models.EmpleadoDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Empleados.AddOrUpdate(i => i.nombre, new Empleado
            {
                nombre = "Angel Arias",
                antiguedad = 15,
                edad = 38,
                categoria="A"
            },

              new Empleado
              {
                  nombre = "Patricia Durango",
                  antiguedad = 15,
                  edad = 36,
                  categoria = "A"
              },
              new Empleado
              {
                  nombre = "Raul Martínez",
                  antiguedad = 4,
                  edad = 25,
                  categoria = "A"
              },

              new Empleado
              {
                  nombre = "Andrés García",
                  antiguedad = 8,
                  edad = 34,
                  categoria = "A"
              },

              new Empleado
              {
                  nombre = "Carolina Pérez",
                  antiguedad = 2,
                  edad = 35,
                  categoria = "A"
              },

              new Empleado
              {
                  nombre = "Jacobo Ferreira",
                  antiguedad = 5,
                  edad = 28,
                  categoria = "A"
              },

              new Empleado
              {
                  nombre = "Francisco Arenas",
                  antiguedad = 3,
                  edad = 33,
                  categoria = "A"
              }
              );

        }
    }
}
