using GrocerAPI.Models;
using GrocerAPI.DbSettings;
using Microsoft.AspNetCore.Mvc;


namespace GrocerAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class MarketController : ControllerBase
{
    private readonly ApplicationDbContext db;
    public MarketController(ApplicationDbContext db)
    {
        this.db = db;
    }

    [HttpGet("Create")]
    public async Task<ActionResult<Market>> Create(int familyid, string name)
    {
        var market = new Market();
        market.MarketName = name;
        market.FamilyId = familyid;
        db.Add(market);
        int success = await db.SaveChangesAsync();
        return success == 0 ? BadRequest() : Ok();
    }

    [HttpGet("FamilyMarkets")]
    public async Task<ActionResult<Family>> GetFamilyMarkets(int familyId)
    {
        List<Market> markets = db.Markets.Where(f => f.FamilyId == familyId).ToList();
        return markets == null ? BadRequest() : Ok(markets);
    }
}