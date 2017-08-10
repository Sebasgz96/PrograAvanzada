using System;
using System.Collections.Generic;
using System.Linq;

namespace AW.WCF.Dominio.Repositorio
{
    /// <summary>
    /// tarea moral
    /// genere el código en linq para las siguientes consultas:
    /// 1.  lista de artículos que contienen una hilera determinada en el nombre.
    /// 2.  lista de artículos cuya fecha de vencimiento sea menor o igual a una determinada.
    /// 3.  lista de artículos de un color determinado.
    /// 4.  lista de artículos cuyo nombre de la subcategoría contenga una hilera determinada.
    /// 5.  lista de artículos cuyo nombre de la categoría contenga una hilera determinada.
    /// 6.  lista de artículos cuyo nombre de modelo contenga una hilera determinada.
    /// 7.  lista de artículos que contengan al menos un review.

    /// </summary>
    public class Productos
    {
        static Model.AdventureWorks2014Entities _Contexto = new Model.AdventureWorks2014Entities();

        public Productos()
        {
        }

        public Model.Product EncontrarProductoPorNumero(string elNumero)
        {
            Model.Product elProducto = new Model.Product();
            elProducto = _Contexto.Products.Include("ProductSubCategory").Include("ProductModel").Include(" ProductReview").Include("ProductSubCategory.ProductCategory").Where(p => p.ProductNumber.Equals(elNumero)).FirstOrDefault();
            return elProducto;
        }

        public IList<Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var losProductos = _Contexto.Products.Where(p => elPrecioInferior <= p.ListPrice && p.ListPrice <= elPrecioSuperior).ToList();
            return losProductos;
        }

        /**********************************************************************************************************/

        public IList<Model.Product> BuscarProductoPorNombre(string elNombre)
        {
            var losProductos = _Contexto.Products.Where(n => n.Name.Contains(elNombre)).ToList();
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorFechaV(DateTime laFecha)
        {
            var losProductos = _Contexto.Products.Where(f => laFecha <= f.SellEndDate).ToList();
            return losProductos;
        }        

        public IList<Model.Product> BuscarProductoPorColor(string elColor)
        {
            var losProductos = _Contexto.Products.Where(c => c.Color.Contains(elColor)).ToList();
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorNombreC(string elNombre)
        {
            var losProductos = _Contexto.Products.Where(n => n.ProductSubcategory.Name.Contains(elNombre)).ToList();
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorNombreSubC(string elNombre)
        {
            var losProductos = _Contexto.Products.Where(n => n.ProductSubcategory.ProductCategory.Name.Contains(elNombre)).ToList();
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorNombreM(string elNombre)
        {
            var losProductos = _Contexto.Products.Where(n => n.ProductModel.Name.Contains(elNombre)).ToList();
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorReview()
        {
            var losProductos = _Contexto.Products.Where(p => p.ProductID > 0).ToList();
            return losProductos;
        }
    }
}