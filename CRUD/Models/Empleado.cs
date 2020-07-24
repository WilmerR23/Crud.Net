using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Cedula { get; set; }

        [DisplayName("Departamento")]
        public int DepartamentoId { get; set; }

        [DisplayName("Tipo Persona")]
        public string TipoPersona { get; set; }

        public bool Estado { get; set; }
        [DisplayName("Fecha de ingreso")]
        public DateTime FechaIngreso { get; set; }

        public virtual Departamento Departamento { get; set; }
    }
}