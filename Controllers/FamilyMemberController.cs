using GrocerAPI.Models;
using GrocerAPI.DbSettings;
using Microsoft.AspNetCore.Mvc;


namespace GrocerAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class FamilyMemberController : ControllerBase
{
    private readonly ApplicationDbContext db;
    public FamilyMemberController(ApplicationDbContext db)
    {
        this.db = db;
    }

    [HttpPost("Create")]
    public async Task<ActionResult<Grocery>> CreateMember(int familyId, string name)
    {
        FamilyMember f = new FamilyMember();
        f.MemberName = name;
        f.FamilyId = familyId;
        db.Add(f);
        await db.SaveChangesAsync();
        return Ok(f);
    }

    [HttpGet("GetMembers")]
    public ActionResult<Grocery> GetMembers (int familyId)
    {
        return Ok(db.FamilyMembers.Where(f => f.FamilyId == familyId));
    }
}