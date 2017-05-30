using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agemcia.Models;

namespace Agemcia.ViewModels
{
    public class ValeFormViewModel
    {
        public IEnumerable<Producto> Productos { get; set; }
        public Vale Vale { get; set; }
    }
}