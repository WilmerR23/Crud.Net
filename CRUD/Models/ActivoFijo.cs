using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class ActivoFijo
    {
        public int Id { get; set; }
        [Required]
        public string Descripción { get; set; }
        [Required]
        [DisplayName("Departamento")]
        public int DepartamentoId { get; set; }
        [Required]
        [DisplayName("Tipo de activo")]
        public int TipoActivoId { get; set; }
        [DisplayName("Fecha de registro")]
        [Required]
        public DateTime FechaRegistro { get; set; }
        [DisplayName("Valor de compra")]
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "El valor para el campo {0} debe ser mayor que {1}")]
        public int ValorCompra { get; set; }
        [DisplayName("Depreciacion")]
        public int CalculoDepreciacion { get; set; }

        public virtual TipoActivo TipoActivo { get; set; }

        public virtual Departamento Departamento { get; set; }

    }
}