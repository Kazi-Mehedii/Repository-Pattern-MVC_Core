using Microsoft.EntityFrameworkCore;
using Repository_Pattern.Models;

namespace Repository_Pattern.Services
{
    public class EmployeeRepo : IEmployee
    {
        private readonly EmpDB _context;
        private DbSet<Employee> _employees;
        public EmployeeRepo(EmpDB emp) {

            this._context = emp;
            _employees = _context.Set<Employee>();
        
        }
        public void Delete(int id)
        {
            _context.Employees.Remove(_context.Employees.Find(id));
            _context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.Find(id);
        }

        public void Insert(Employee Entity)
        {
            _context.Employees.Add(Entity);
            _context.SaveChanges();
        }

        public void Update(Employee Entity)
        {
           _context.Entry(Entity).State=EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
