namespace Exercise_1_MinimalAPI.Modelos
{
    public class Valores_Operacion
    {

        #region Constructor
        /// <summary>
        /// Clase para realizar operaciones aritmeticas simples
        /// </summary>
        /// <param name="Numero1">Valor decimal uno</param>
        /// <param name="Numero2">Valor decimal dos</param>
        public Valores_Operacion( decimal Numero1 ,decimal Numero2)
        {
            this.numero1 = Numero1;
            this.numero2 = Numero2;

        }
        #endregion 

        #region Propiedades
        /// <summary>
        /// Valor 1  para realizar operecion
        /// </summary>

        public decimal numero1 { get; set; }
        /// <summary>
        /// Valor 2  para realizar operecion
        /// </summary>
        public decimal numero2 { get; set; }
        #endregion
    }
}
