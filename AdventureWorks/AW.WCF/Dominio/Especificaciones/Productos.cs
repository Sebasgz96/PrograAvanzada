using System;
using System.Collections.Generic;

namespace AW.WCF.Dominio.Especificaciones
{
    public class Productos
    {
        public Productos()
        {
        }

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

        /*****************************************************************************************************/

        public IList<Model.Product> BuscarProductoPorNombre(string elNombre)
        {
            var elRepositorio = new Repositorio.Productos();
            var losProductos = elRepositorio.BuscarProductoPorNombre(elNombre);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorFechaV(DateTime laFecha)
        {
            var elRepositorio = new Repositorio.Productos();
            var losProductos = elRepositorio.BuscarProductoPorFechaV(laFecha);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorColor(string elColor)
        {
            var elRepositorio = new Repositorio.Productos();
            var losProductos = elRepositorio.BuscarProductoPorColor(elColor);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorNombreSubC(string elNombre)
        {
            var elRepositorio = new Repositorio.Productos();
            var losProductos = elRepositorio.BuscarProductoPorNombreSubC(elNombre);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorNombreC(string elNombre)
        {
            var elRepositorio = new Repositorio.Productos();
            var losProductos = elRepositorio.BuscarProductoPorNombreC(elNombre);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorNombreM(string elNombre)
        {
            var elRepositorio = new Repositorio.Productos();
            var losProductos = elRepositorio.BuscarProductoPorNombreM(elNombre);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorReview()
        {
            var elRepositorio = new Repositorio.Productos();
            var losProductos = elRepositorio.BuscarProductoPorReview();
            return losProductos;
        }
    }
}