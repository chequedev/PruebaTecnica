using Exercise_1_MinimalAPI.Modelos;

namespace Exercise_1_MinimalAPI.Servicios
{
    public interface IServicioOperacionesMatematicas : IServicios
    {
        /// <summary>
        /// Operacion Suma 
        /// </summary>
        /// <param name="valores">objeto  que contiene los valores de los cuales realizara la operecion</param>
        /// <returns></returns>
        decimal Suma(Valores_Operacion valores);
        /// <summary>
        /// Operacion Resta 
        /// </summary>
        /// <param name="valores">objeto  que contiene los valores de los cuales realizara la operecion</param>
        /// <returns></returns>
        decimal Resta(Valores_Operacion valores);
        /// <summary>
        /// Operacion Divicion 
        /// </summary>
        /// <param name="valores">objeto  que contiene los valores de los cuales realizara la operecion</param>
        /// <returns></returns> 
        decimal Divicion(Valores_Operacion valores);
        /// <summary>
        /// Operacion Multiplicacion 
        /// </summary>
        /// <param name="valores">objeto  que contiene los valores de los cuales realizara la operecion</param>
        /// <returns></returns>
        decimal Multiplicacion(Valores_Operacion valores);



    }
}
