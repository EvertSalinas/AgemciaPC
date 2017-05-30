using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agemcia.Models
{
    public class Reporte
    {
        // Primary key
        public int id { get; set; }
        [Display(Name = "Fecha:")]
        public DateTime fecha { get; set; }

        // Navigation Properties
        public virtual ICollection<Vale> vales { get; set; }
    }
}
