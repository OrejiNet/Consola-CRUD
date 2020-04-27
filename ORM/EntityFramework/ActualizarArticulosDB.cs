using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class ActualizarArticulosDB
    {

        public void  UpdateArticulo(  )
        {

            var _conexion = conexion.Articulos;

            var art = _conexion.ListaArticulos.First<ListaArticulos>();

            art.Nombre_Articulo = "Martillo";

            _conexion.SaveChanges();


                
        }
    }
}
