using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AlatAssessment.Entity.Models
{
    public class Local
    {
        public Local()
        {
            Customers =new List<Customer>();
        }
        public int LocalId { get; set; }
        public string Name { get; set; }
        public State State { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
