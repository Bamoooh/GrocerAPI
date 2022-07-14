using GrocerAPI.Models;
using GrocerAPI.DbSettings;
using Microsoft.AspNetCore.Mvc;


namespace GrocerAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class GroceryController : ControllerBase {

    private readonly ApplicationDbContext db;
    public GroceryController(ApplicationDbContext db)
    {
        this.db = db;
    }

    [HttpPost("Create")]
    public async Task<ActionResult<Grocery>> CreateGrocery(int marketId, string name)
    {
        Grocery grocery = new Grocery();
        grocery.MarketId = marketId;
        grocery.GroceryName = name;
        await db.SaveChangesAsync();
        return Ok(grocery);
    }
    [HttpGet("GetGroceries")]
    public async Task<ActionResult<Grocery>> GetGroceries(int marketId)
    {
        List<Grocery> groceryList = db.Groceries.Where(g => g.MarketId == marketId).ToList();
        return Ok(groceryList);
    }

}