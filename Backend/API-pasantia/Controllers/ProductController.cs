using API_pasantia.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_pasantia.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProductController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_context.Products.ToList());
    }

    [HttpGet("codigo")]
    public IActionResult GetByCodigo(string cod)
    {
        var x = _context.Products.FirstOrDefault(y => y.CodigoProducto == cod);
        
        return Ok(x);
    }
    
    [HttpPost]
    public IActionResult Post([FromBody] Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
        return Ok();
    }

    //con id autoincrementable
    [HttpDelete]
    public IActionResult DeleteID(int id)
    {
        var x = _context.Products.Find(id);
        
        _context .Products.Remove(x);
        _context.SaveChanges();
        
        return Ok();
    }
}