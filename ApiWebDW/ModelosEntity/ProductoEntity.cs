using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDW
{
    public class ProductoEntity
    {
        [Key]
        public int Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public decimal Valor { get; set; }
    }
}
