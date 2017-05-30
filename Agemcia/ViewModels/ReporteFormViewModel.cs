using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agemcia.Models;

namespace Agemcia.ViewModels
{
    public class ReporteFormViewModel
    {
        public IEnumerable<Vale> Vales { get; set; }
        public Reporte Reporte { get; set; }
    }
}