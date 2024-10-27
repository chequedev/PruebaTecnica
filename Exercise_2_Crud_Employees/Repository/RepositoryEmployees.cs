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
            var infoActualizar = _dbContext.employees.Find(entity.EmployeeId);

            if (infoActualizar == null)
                throw new Exception("Empleado no encontrado.");

            infoActualizar.FirstName=entity.FirstName;
            infoActualizar.LastName=entity.LastName;
            infoActualizar.Salary=entity.Salary;

            _dbContext.SaveChanges();
            return entity;
        }

        public void Eliminar(Guid identificador)
        {
            var infoEliminar = _dbContext.employees.Find(identificador);

            if (infoEliminar == null)
                throw new Exception("Empleado no encontrado.");


            _dbContext.employees.Remove(infoEliminar);
            _dbContext.SaveChanges();

           

        }

        public IEnumerable<Employees> Listar()
        {
            return _dbContext.employees;
        }

        public Employees GetById(Guid employeeId)
        {
            var info = _dbContext.employees.Find(employeeId);
            if (info == null)
                throw new Exception("Empleado no encontrado.");

            return info;
        }
    }
}
