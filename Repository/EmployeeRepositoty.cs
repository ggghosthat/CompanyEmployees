using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class EmployeeRepositoty : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepositoty(RepositoryContext repositoryContext) :
            base(repositoryContext)
        {
        }
    }
}
