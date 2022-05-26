using Microsoft.AspNetCore.Identity;

namespace AlatAssessment.Entity.Models
{
    public class Customer : IdentityUser
    {
        public string StateId { get; set; }
        public string LGAId { get; set; }
    }
}
