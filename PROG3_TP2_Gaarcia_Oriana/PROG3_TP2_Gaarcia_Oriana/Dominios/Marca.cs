using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominios

{
    public class Marca
    {
        public int id { get; set; }
        public string nombre { get; set; }
    
    public override string ToString()
    {
        return nombre;
    }

    public Marca (int i,string d)
        {
            id = i;
            nombre = d;
        }
    public Marca() { }
    }

}
