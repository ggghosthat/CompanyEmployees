
using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;

        private ICompanyRepository _companyRepository;
        private IEmployeeRepository _employeeRepository;

        public ICompanyRepository Company 
        {
            get 
            {
                if (_companyRepository == null)
                    _companyRepository = new CompanyRepository(_repositoryContext);
                return _companyRepository;
            }
        }

        public IEmployeeRepository Employee 
        {
            get
            {
                if (_employeeRepository == null)
                    _employeeRepository = new EmployeeRepositoty(_repositoryContext);
                return _employeeRepository;
            }
        }



        public void Save() =>
            _repositoryContext.SaveChanges();
    }
}
