using Exercise_2_Crud_Employees.Models;

namespace Exercise_2_Crud_Employees.Repository
{
    public interface IRepositoryEmployees:IRepository<Employees>
    {
        /// <summary>
        /// Obtiene un objeto deacuerdo al identificador solicitado
        /// </summary>
        /// <param name="employeeId">Identificador de el elemento</param>
        /// <returns></returns>
        Employees GetById(Guid employeeId);

    }
}
