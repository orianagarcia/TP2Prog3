using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dominios
    {
    public class Articulo
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }
        public Marca marcaProducto { get; set; }
        public Categoria categoriaProducto { get; set; }
        public Decimal precio { get; set; }
        public bool activo { get; set; }

    }



}
