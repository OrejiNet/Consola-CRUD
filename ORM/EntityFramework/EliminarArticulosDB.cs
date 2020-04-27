using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class EliminarArticulosDB
    {
        public void DeleteArticulo()
        {


            var _conexion = conexion.Articulos;

            ListaArticulos Articulo = _conexion.ListaArticulos.Find(27);

            _conexion.ListaArticulos.Remove(Articulo);

            _conexion.SaveChanges();

            ListarArticulosDB listarArticulosDB = new ListarArticulosDB();

            listarArticulosDB.GetArticulos();
            Console.ReadKey();

        }



    }
}
