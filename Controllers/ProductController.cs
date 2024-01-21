using Microsoft.AspNetCore.Mvc;
using CreateWebapi.Data;
using CreateWebapi.Model;
using Microsoft.EntityFrameworkCore;
namespace CreateWebapi.Controllers
{
  [ApiController]
  // [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
  public class AddProductController : ControllerBase
  {
    private readonly AppDbContext context;
    public AddProductController(AppDbContext context)
    {
      this.context = context;
    }
    [Route("api/AddProduct")]
    [HttpPost]
    public async Task<IActionResult> Post(Vehicle Vehicle)
    {
      context.Add(Vehicle);
      await context.SaveChangesAsync();
      return Ok();
    }
    public async Task<IActionResult> Post2(Vehicle Vehicle)
    {
      context.Add(Vehicle);
      await context.SaveChangesAsync();
      return Ok();
    }

  }
}