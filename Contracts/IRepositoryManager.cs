namespace Contracts
{
    public interface IRepositoryManager
    {
        public ICompanyRepository Company { get; }
        public IEmployeeRepository Employee { get; }

        void Save();
    }
}
