using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PS02._VAZQUEZOSUNALAURAMICHELLE.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string TipoComida { get; set; }
        public string NombreComida { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
    }
}