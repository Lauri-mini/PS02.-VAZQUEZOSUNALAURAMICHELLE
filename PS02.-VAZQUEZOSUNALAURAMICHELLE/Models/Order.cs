using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PS02._VAZQUEZOSUNALAURAMICHELLE.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Display(Name = "Clave de la Orden")]
        public int ClaveOrden { get; set; }
        [Display(Name = "Nombre del Cliente")]
        public string NombreCliente { get; set; }
        [Display(Name = "¿Algún dato que desee agregar?")]
        public string Nota { get; set; }
        [Display(Name = "Satus de la orden")]
        public int Status { get; set; }
        public int MenuID { get; set; }
        [ForeignKey ("MenuID")]
        public Menu Menu { get; set; }

    }
}