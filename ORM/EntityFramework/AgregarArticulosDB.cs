using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
   public class AgregarArticulosDB
    {
        public void CreateArticulo()
        {

            var _conexion = conexion.Articulos;

            ListaArticulos listaArticulos = new ListaArticulos();

            listaArticulos.Nombre_Articulo = "Tornillo";
            listaArticulos.Pais_Origen = "China";
            listaArticulos.Codigo_Articulo = "7736804533";

            _conexion.ListaArticulos.Add(listaArticulos);
            _conexion.SaveChanges();

           
        }
    }
}
