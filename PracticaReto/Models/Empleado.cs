﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PracticaReto.Models
{
    [Table("emp")]
    public class Empleado
    {
        [Key]
        [Column("emp_no")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdEmpleado { get; set; }
        [Column("apellido")]
        public String Apellido { get; set; }
        [Column("Oficio")]
        public String Oficio { get; set; }
        [Column("salario")]
        public int Salario { get; set; }
        [Column("dept_no")]
        public int Departamento { get; set; }
    }
}