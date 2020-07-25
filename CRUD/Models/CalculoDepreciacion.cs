using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class CalculoDepreciacion
    {
        public int Id { get; set; }
        [DisplayName("Año Proceso")]
        [Required]
        public int AñoProceso { get; set; }
        [DisplayName("Mes Proceso")]
        [Required]
        public int MesProceso { get; set; }
        [DisplayName("Activo Fijo")]
        [Required]
        public int ActivoFijoId { get; set; }
        [DisplayName("Depreciación")]
        [Required]
        public int DepreciaciónAcumulada { get; set; }
        [DisplayName("Cuenta de compra")]
        [Required]
        public int CuentaCompra { get; set; }
        [DisplayName("Cuenta de depreciación")]
        [Required]
        public int CuentaDepreciación { get; set; }
        [DisplayName("Monto depreciado")]
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "El valor para el campo {0} debe ser mayor que {1}")]
        public int MontoDepreciado { get; set; }
        [DisplayName("Fecha de proceso")]
        [Required]
        public DateTime FechaProceso { get; set; }

        public virtual ActivoFijo ActivoFijo { get; set; }

    }
}