using System;

namespace DataAccess.Utilidades
{
    public class ConexionException : ApplicationException
    {
        public ConexionException(string mensaje, Exception original)
           : base(mensaje, original)
        {
        }

        /// <summary>
        /// Construye una instancia con un mensaje de error, 
        /// invocando al constructor de la clase base.
        /// </summary>
        /// <param name="mensaje">El mensaje de error.</param>
        public ConexionException(string mensaje)
            : base(mensaje)
        {
        }
    }
}
