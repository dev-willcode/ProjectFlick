using System;

namespace Controllers
{
    public class ControllerException : ApplicationException
    {
        public ControllerException(string mensaje, Exception original)
           : base(mensaje, original)
        {
        }

        /// <summary>
        /// Construye una instancia con un mensaje de error, 
        /// invocando al constructor de la clase base.
        /// </summary>
        /// <param name="mensaje">El mensaje de error.</param>
        public ControllerException(string mensaje)
            : base(mensaje)
        {
        }
    }
}
