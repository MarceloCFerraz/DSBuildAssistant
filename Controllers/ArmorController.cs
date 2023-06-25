using Microsoft.AspNetCore.Mvc;
using DSR.Models;
using DSR.Data;

namespace DSR.Controller;

[ApiController]
[Route("[controller]")]
public class ArmorController : ControllerBase
{
    private AppDbContext _context;

    public ArmorController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost("create")]
    public IActionResult CreateArmor(Armor armor)
    {
        IActionResult? result = StatusCode(500);

        return result;
    }
}