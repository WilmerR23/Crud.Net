using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class TipoActivo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        [DisplayName("Cuenta contable de compra")]
        public int CuentaContableCompra { get; set; }
        [DisplayName("Cuenta contable de depreciacion")]
        public int CuentaContableDepreciacion { get; set; }
        public bool Estado { get; set; }
    }
}