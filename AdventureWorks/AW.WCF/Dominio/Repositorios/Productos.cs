namespace Repositorio
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
    /// 
    internal class Productos
    {
        static AW.Model.AdventureWorks2014Entities _Contexto = new AW.Model.AdventureWorks2014Entities();

        public Productos()
        {
        }

        public AW.Model.Product EncontrarProductoPorNumero(string elNumero)
        {
            AW.Model.Product elProducto = new AW.Model.Product();
            elProducto = _Contexto.Product.Include("ProductSubCategory").Include("ProductModel").Include(" ProductReview").Include("ProductSubCategory.ProductCategory").Where(p => p.ProductNumber.Equals(elNumero)).FirstOrDefault();
            return elProducto;
        }

        public IList<Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var losProductos = _Contexto.Product.Where(p => elPrecioInferior <= p.ListPrice && p.ListPrice <= elPrecioSuperior).ToList();
            return losProductos;
        }
    }
}