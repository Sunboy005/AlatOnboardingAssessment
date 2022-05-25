using AlatAssessment.Entity.Models;
using System.Linq;

namespace AlatAssessment.Data.Repositories
{
    public interface IUserRepository
    {
        IQueryable<Customer> GetAllCustomers();
    }
}
