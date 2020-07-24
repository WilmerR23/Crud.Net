using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class CalculoDepreciacion
    {
        public int Id { get; set; }
        [DisplayName("Año Proceso")]
        public int AñoProceso { get; set; }
        [DisplayName("Mes Proceso")]
        public int MesProceso { get; set; }
        [DisplayName("Activo Fijo")]
        public int ActivoFijoId { get; set; }
        [DisplayName("Depreciación")]
        public int DepreciaciónAcumulada { get; set; }
        [DisplayName("Cuenta de compra")]
        public int CuentaCompra { get; set; }
        [DisplayName("Cuenta de depreciación")]
        public int CuentaDepreciación { get; set; }
        [DisplayName("Monto depreciado")]
        public int MontoDepreciado { get; set; }
        [DisplayName("Fecha de proceso")]
        public DateTime FechaProceso { get; set; }

        public virtual ActivoFijo ActivoFijo { get; set; }

    }
}