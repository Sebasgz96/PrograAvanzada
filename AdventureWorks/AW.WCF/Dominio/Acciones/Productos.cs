using System;
using System.Collections.Generic;

namespace AW.WCF.Dominio.Acciones
{
    public class Productos
    {
        public Productos()
        {
        }

        public Model.Product EncontrarProductoPorNumero(string elNumero)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var elProducto = laEspecificacion.EncontrarProductoPorNumero(elNumero);
            return elProducto;
        }

        public IList<Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var losProductos = laEspecificacion.BuscarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
            return losProductos;
        }

        /*******************************************************************************************************/

        public IList<Model.Product> BuscarProductoPorNombre(string elNombre)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var losProductos = laEspecificacion.BuscarProductoPorNombre(elNombre);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorFechaV(DateTime laFecha)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var losProductos = laEspecificacion.BuscarProductoPorFechaV(laFecha);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorColor(string elColor)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var losProductos = laEspecificacion.BuscarProductoPorColor(elColor);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorNombreSubC(string elNombre)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var losProductos = laEspecificacion.BuscarProductoPorNombreSubC(elNombre);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorNombreC(string elNombre)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var losProductos = laEspecificacion.BuscarProductoPorNombreC(elNombre);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorNombreM(string elNombre)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var losProductos = laEspecificacion.BuscarProductoPorNombreM(elNombre);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorReview()
        {
            var laEspecificacion = new Especificaciones.Productos();
            var losProductos = laEspecificacion.BuscarProductoPorReview();
            return losProductos;
        }
    }
}