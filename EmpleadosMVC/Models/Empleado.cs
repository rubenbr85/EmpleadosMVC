using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EmpleadosMVC.Models
{
    public class Empleado
    {
        public int id { get; set; }

        [Required]
        [StringLength(50, MinimumLength =4)]
        public string nombre { get; set; }

        [Required]
        [Range(1,40)]
        public int antiguedad { get; set;}

        [Required]
        [Range (18,65)]
        public int edad { get; set; }

        [Required]
        public string categoria { get; set; }
    }

    public class EmpleadoDBContext : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
    }
}