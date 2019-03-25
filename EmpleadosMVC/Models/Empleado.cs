using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EmpleadosMVC.Models
{
    public class Empleado
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int antiguedad { get; set;}
        public int edad { get; set; }
    }

    public class EmpleadoDBContext : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
    }
}