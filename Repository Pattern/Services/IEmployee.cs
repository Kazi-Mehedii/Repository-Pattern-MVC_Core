using Repository_Pattern.Models;

namespace Repository_Pattern.Services
{
    public interface IEmployee
    {
        void Insert(Employee Entity);

        void Update(Employee Entity);

        void Delete(int id);

        List<Employee> GetAll();

        Employee GetById(int id);


    }
}
