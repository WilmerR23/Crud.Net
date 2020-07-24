using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class AsientoContable
    {
        public int Id { get; set; }
        public int TipoInventarioId { get; set; }
        public int CuentaContable { get; set; }
        public int MontoAsiento { get; set; }
        public string Descripción { get; set; }
        public string TipoMovimiento { get; set; }
        public DateTime FechaAsiento { get; set; }
        public bool Estado { get; set; }
    }
}