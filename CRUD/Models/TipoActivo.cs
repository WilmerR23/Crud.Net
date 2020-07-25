using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class TipoActivo
    {
        public int Id { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [DisplayName("Cuenta contable de compra")]
        [Required]
        public int CuentaContableCompra { get; set; }
        [DisplayName("Cuenta contable de depreciacion")]
        [Required]
        public int CuentaContableDepreciacion { get; set; }
        public bool Estado { get; set; }
    }
}