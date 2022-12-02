using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApiDW
{
    public interface IProductoService
    {
        List<ProductoEntity> GetProductos();
        void AddProducto(ProductoEntity productoEntity);
        void DeleteProducto(int Producto);
        void DeleteProducto(ProductoEntity productoEntity);
        ProductoEntity GetProducto(int Producto);
        ProductoEntity UpdateProducto(ProductoEntity productoEntity);
    }
}
