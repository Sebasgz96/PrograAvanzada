using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AW.WCF.Dominio.Especificaciones
{
    public class Productos
    {
        public Model.Product EncontrarProductoPorNumero(string elNumero)
        {
            var elRepositorio = new Repositorio.Productos();
            var elProducto = elRepositorio.EncontrarProductoPorNumero(elNumero);
            return elProducto;
        }

        public IList<Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var elRepositorio = new Repositorio.Productos();
            var losProductos = elRepositorio.BuscarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
            return losProductos;
        }

    }

    
}