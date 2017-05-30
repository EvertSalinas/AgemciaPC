using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agemcia.Models
{
    public class Vale
    {
        // Primary key
        public int id { get; set; }
        [Display(Name = "Numero de Vale:")]
        public int numero { get; set; }

        // Navigation Properties
        [Display(Name = "Selecciona un producto:")]
        public virtual ICollection<Producto> productos { get; set; }
    }
}