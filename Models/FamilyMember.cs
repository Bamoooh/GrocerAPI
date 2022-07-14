
using System.ComponentModel.DataAnnotations;

namespace GrocerAPI.Models
{
    public class FamilyMember
    {
        [Required]
        public int FamilyMemberId { get; set; }
        public String MemberName { get; set; }
        public int FamilyId { get; set; }
        
    }
}
