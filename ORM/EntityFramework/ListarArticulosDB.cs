using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
   public  class ListarArticulosDB
    {

        public void GetArticulos() {

            var lst = conexion.Articulos.ListaArticulos;

            foreach (var oArticulo in lst)
            {

                Console.WriteLine("El nombre del Articulo {0}", oArticulo.Nombre_Articulo);


            }

        }



    }
}
