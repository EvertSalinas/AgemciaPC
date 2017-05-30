using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agemcia.Models
{
    public class Producto
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Nombre del producto:")]
        public string nombre { get; set; }

        [Display(Name = "Precio del producto:")]
        public float precio { get; set; }
    }
}