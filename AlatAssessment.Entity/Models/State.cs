using System.Collections.Generic;

namespace AlatAssessment.Entity.Models
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Local> Locals { get; set; }
        public List<Customer> Customers { get; set; }

        public State()
        {
            Locals = new List<Local>();
            Customers = new List<Customer>();
        }
    }
}
