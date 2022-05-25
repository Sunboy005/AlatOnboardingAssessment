using System.Linq;
using WemaAssessment.Domain.Models;

namespace AlatAssessment.Persistence.Repositories
{
    public interface IUserRepository
    {
        IQueryable<Customer> GetAllCustomers();
    }
}
