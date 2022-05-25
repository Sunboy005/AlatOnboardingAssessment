using Microsoft.AspNetCore.Identity;

namespace AlatAssessment.Entity.Models
{
    public class Customer : IdentityUser
    {
        public string State { get; set; }
        public string LGA { get; set; }
    }
}
