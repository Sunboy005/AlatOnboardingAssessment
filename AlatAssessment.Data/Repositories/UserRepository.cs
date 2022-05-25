using AlatAssessment.Entity.Models;
using System.Linq;

namespace AlatAssessment.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Customer> GetAllCustomers()
        {
            return _dbContext.Customers.AsQueryable();
        }
    }
}
