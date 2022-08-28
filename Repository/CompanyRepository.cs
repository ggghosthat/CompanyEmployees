using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext) :
                base(repositoryContext)
        {
        }
    }
}
