namespace Exercise_2_Crud_Employees.Repository
{
    public interface IRepository<T>
    {
        T Insertar(T entity);
        T Actualizar(T entity);
        void Eliminar(Guid identificador);

        IEnumerable<T> Listar();


    }
}
