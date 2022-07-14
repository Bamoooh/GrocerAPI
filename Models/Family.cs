using GrocerAPI.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace GrocerAPI.Models;

public class Family
{
    [Required]
    public int FamilyId { get; set; }
    [Required]
    public string FamilyName { get; set; }
    public List<FamilyMember> FamilyMembers { get; set; }
    public List<Market> Markets { get; set; }
}

