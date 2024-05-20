using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using replicaPROGRAMA.Data;
using replicaPROGRAMA.Models;
using Microsoft.EntityFrameworkCore;

namespace replicaPROGRAMA.Controllers.Rest
{
    [ApiController]
    [Route("api/producto")]
    public class ProductoApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProductoApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        //LISTA PRODUCTO
        public async Task<ActionResult<List<Producto>>> List()
        {
            var productos = await _context.DataProducto.ToListAsync();
             if(productos == null)
                return NotFound();
            return Ok(productos);
        }

    }
}