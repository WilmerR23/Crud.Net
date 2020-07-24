using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class ActivoFijo
    {
        public int Id { get; set; }
        public string Descripción { get; set; }
        [DisplayName("Departamento")]
        public int DepartamentoId { get; set; }
        [DisplayName("Tipo de activo")]
        public int TipoActivoId { get; set; }
        [DisplayName("Fecha de registro")]
        public DateTime FechaRegistro { get; set; }
        [DisplayName("Valor de compra")]
        public int ValorCompra { get; set; }
        [DisplayName("Depreciacion")]
        public int CalculoDepreciacion { get; set; }

        public virtual TipoActivo TipoActivo { get; set; }

        public virtual Departamento Departamento { get; set; }

    }
}