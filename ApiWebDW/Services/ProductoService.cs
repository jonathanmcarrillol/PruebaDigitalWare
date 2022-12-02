using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApiDW
{
    public class ProductoService: IProductoService
    {
        private readonly IContextoDB _contextoDB;

        public ProductoService(IContextoDB contextoDB)
        {
            _contextoDB = contextoDB;
        }

        public List<ProductoEntity> GetProductos()
        {
            var lista = _contextoDB.Productos.Select(x => x).ToList();

            return lista;

        }

        public void AddProducto(ProductoEntity productoEntity)
        {
            _contextoDB.Productos.Add(productoEntity);
            _contextoDB.SaveChanges();
        }

        public void DeleteProducto(int Producto)
        {
            var productoEntity = GetProducto(Producto);
            DeleteProducto(productoEntity);
        }

        public void DeleteProducto(ProductoEntity productoEntity)
        {
            _contextoDB.Productos.Remove(productoEntity);
            _contextoDB.SaveChanges();
        }

        public ProductoEntity GetProducto(int Producto)
        {
            return _contextoDB.Productos.Where(x => x.Producto == Producto).FirstOrDefault();
        }

        public ProductoEntity UpdateProducto(ProductoEntity productoEntity)
        {
            var ProductoAux = _contextoDB.Productos.Update(productoEntity).Entity;
            _contextoDB.SaveChanges();
            return ProductoAux;

        }

    }
}
