using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class conexion
    {

		private static ArticulosEntities articulosEntities;

		public static ArticulosEntities Articulos

		{
			get {
				if (articulosEntities == null)
				{
					articulosEntities = new ArticulosEntities();
				}
				
				return articulosEntities; }
			
		}

	}
}
