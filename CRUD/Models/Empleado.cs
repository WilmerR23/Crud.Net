using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }

        [Required]
        [Cedula(ErrorMessage = "Debe ser una cedula valida.")]

        public string Cedula { get; set; }

        [DisplayName("Departamento")]
        [Required]
        public int DepartamentoId { get; set; }

        [DisplayName("Tipo Persona")]
        [Required]
        public string TipoPersona { get; set; }

        public bool Estado { get; set; }
        [DisplayName("Fecha de ingreso")]
        [Required]
        public DateTime FechaIngreso { get; set; }

        public virtual Departamento Departamento { get; set; }
    }
}