using Exercise_2_Crud_Employees.DataContext;
using Exercise_2_Crud_Employees.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercise_2_Crud_Employees.Repository
{
    public class RepositoryEmployees : IRepositoryEmployees
    {
        protected DataContextApp _dbContext;
        public RepositoryEmployees(DataContextApp db)
        {
            this._dbContext = db;
        }

        public Employees Insertar(Employees entity)
        {
            _dbContext.employees.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }
       
        public Employees Actualizar(Employees entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Eliminar(Guid identificador)
        {
            var employee = _dbContext.employees.Find(identificador);

            if (employee != null)
            {
                _dbContext.employees.Remove(employee);
                _dbContext.SaveChanges();

            }

        }

        public IEnumerable<Employees> Listar()
        {
            return _dbContext.employees;
        }
    }
}
