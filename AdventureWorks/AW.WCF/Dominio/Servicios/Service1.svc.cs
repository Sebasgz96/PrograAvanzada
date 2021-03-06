﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AW.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Model.Product EncontrarProductoPorNumero(string elNumero)
        {
            var laAccion = new Dominio.Acciones.Productos();
            var elProducto = laAccion.EncontrarProductoPorNumero(elNumero);
            return elProducto;
        }

        public IList<Model.Product> ListarTodos()
        {
            decimal elPrecioInferior = 10, elPrecioSuperior = 20;
            var laAccion = new Dominio.Acciones.Productos();
            var losProductos = laAccion.BuscarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var laAccion = new Dominio.Acciones.Productos();
            var losProductos = laAccion.BuscarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
            return losProductos;
        }

        /***************************************************************************************************/

        public IList<Model.Product> BuscarProductoPorNombre(string elNombre)
        {
            var laAccion = new Dominio.Acciones.Productos();
            var losProductos = laAccion.BuscarProductoPorNombre(elNombre);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorFechaV(DateTime laFecha)
        {
            var laAccion = new Dominio.Acciones.Productos();
            var losProductos = laAccion.BuscarProductoPorFechaV(laFecha);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorColor(string elColor)
        {
            var laAccion = new Dominio.Acciones.Productos();
            var losProductos = laAccion.BuscarProductoPorColor(elColor);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorNombreSubC(string elNombre)
        {
            var laAccion = new Dominio.Acciones.Productos();
            var losProductos = laAccion.BuscarProductoPorNombreSubC(elNombre);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorNombreC(string elNombre)
        {
            var laAccion = new Dominio.Acciones.Productos();
            var losProductos = laAccion.BuscarProductoPorNombreC(elNombre);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorNombreM(string elNombre)
        {
            var laAccion = new Dominio.Acciones.Productos();
            var losProductos = laAccion.BuscarProductoPorNombreM(elNombre);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorReview()
        {
            var laAccion = new Dominio.Acciones.Productos();
            var losProductos = laAccion.BuscarProductoPorReview();
            return losProductos;
        }


        /**************************************************************************************************/



        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
