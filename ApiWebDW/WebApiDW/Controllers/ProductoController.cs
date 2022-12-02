using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using WebApiDW.Contexto;
//using WebApiDW.Models;

namespace WebApiDW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        private readonly ContextoDB _context;



        public ProductoController(ContextoDB context)
        {
            _context = context;
        }

        // GET: api/PersonaEntity
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductoEntity>>> GetProducto()
        {
            try
            {
                var Listado = (from P in _context.Productos
                               select P).Take(10).ToList();
                return Listado;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<ActionResult<bool>> PostProducto(ProductoEntity productoEntity)
        {
            try
            {
                _context.Productos.Add(productoEntity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductoEntity>> DeletePersonaEntity(int id)
        {
            var productoEntity = await _context.Productos.FindAsync(id);
            if (productoEntity == null)
            {
                return NotFound();
            }

            _context.Productos.Remove(productoEntity);
            await _context.SaveChangesAsync();

            return productoEntity;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonaEntity(int id, ProductoEntity productoEntity)
        {
            if (id != productoEntity.Producto)
            {
                return BadRequest();
            }

            _context.Entry(productoEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductoEntityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool ProductoEntityExists(int id)
        {
            return _context.Productos.Any(e => e.Producto == id);
        }



    }
}