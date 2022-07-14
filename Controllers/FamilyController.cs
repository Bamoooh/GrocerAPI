using GrocerAPI.Models;
using GrocerAPI.DbSettings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace GrocerAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class FamilyController : ControllerBase{

    private readonly ApplicationDbContext db;
    public FamilyController(ApplicationDbContext dbc)
    {
        this.db= dbc;
    }

    [HttpPost("Create")]
    public async Task<ActionResult<Family>> CreateFamily(String name)
    {
        Family family = new Family();
        family.FamilyName = name;
        db.Families.Add(family);
        await db.SaveChangesAsync();
        return Ok();
    }

    [HttpGet("GetFamilies")]
    public async Task<ActionResult<Family>> GetFamilies()
    {
        return Ok(await db.Families.Include(f => f.Markets).Include(f => f.FamilyMembers).ToListAsync());
    }

    [HttpGet("GetFamily")]
    public async Task<ActionResult<Family>> GetFamily(int id)
    {
        Family f = await db.Families.FindAsync(id);
        if (f == null)
            return NotFound();
        return Ok(f);
    }
}