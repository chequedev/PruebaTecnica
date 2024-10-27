using Exercise_1_MinimalAPI.Modelos;

namespace Exercise_1_MinimalAPI.Servicios
{
    public class ServicioOperacionesMatematicasSimples : IServicioOperacionesMatematicas
    {


        #region Implementacion de metodos de interfaz
        public void LogRegistroActividad(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
        public decimal Divicion(Valores_Operacion valores)
        {
            LogRegistroActividad("Se Ejecuto Divicion");

            return valores.numero1 / valores.numero2;
        }


        public decimal Multiplicacion(Valores_Operacion valores)
        {
            LogRegistroActividad("Se Ejecuto Multiplicacion");

            return valores.numero1 * valores.numero2;
        }


        public decimal Resta(Valores_Operacion valores)
        {
            LogRegistroActividad("Se Ejecuto Resta");

            return valores.numero1 - valores.numero2;
        }

        public decimal Suma(Valores_Operacion valores)
        {
            LogRegistroActividad("Se Ejecuto Suma");

            return valores.numero1 + valores.numero2;
        }
        #endregion

    }
}
