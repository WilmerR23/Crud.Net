using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}