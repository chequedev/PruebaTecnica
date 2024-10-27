namespace Exercise_2_Crud_Employees.Repository
{
    /// <summary>
    /// Interfaz Generica para definir comportamenitos genericos sobre  sus implementadores
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Metodo Insertar nuevo elemento
        /// </summary>
        /// <param name="entity">Tipo de entidad que se manipulara</param>
        /// <returns></returns>
        T Insertar(T entity);


        /// <summary>
        /// Metodo Actualizar un registro existente
        /// </summary>
        /// <param name="entity">Tipo de entidad que se manipulara</param>
        /// <returns></returns>
        T Actualizar(T entity);

        /// <summary>
        /// Metodo Eliminara un elemento seleccionado
        /// </summary>
        /// <param name="identificador">Identificador de la entidad a eliminar</param>
        /// <returns></returns>
        void Eliminar(Guid identificador);

        /// <summary>
        /// Metodo Listar  Genera una coleccion de objetos de una entidad
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        IEnumerable<T> Listar();


    }
}
