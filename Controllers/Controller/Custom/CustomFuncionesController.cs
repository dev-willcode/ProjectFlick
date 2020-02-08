using System;
using System.Collections.Generic;
using Entity.Entidades;

namespace Controllers.Controller
{
    /* 
     * Clase personalizada que agrupa las carácteristicas principales de una Función,
     * Permite agrupar en propiedades, para un mejor acceso a los datos.
     */
    public class CustomFuncionesController
    {
        /* 
         * Crea la clase personalizada e inicializa las propiedades de la Función, 
         * en base a la Funcion entregada.
         */
        public CustomFuncionesController(Funcion funciones)
        {
            Funcion = funciones;
            inicializarPropiedades();
        }

        private void inicializarPropiedades()
        {
            Idioma = new IdiomaController().Get(Funcion.funcion_idioma);
            Pelicula = new PeliculaController().Get(Funcion.funcion_pelicula);
            Categorias = new CategoriaController().ListarCategorias(Funcion.funcion_pelicula);
            Horarios = new HorariosController().Get(Funcion.funcion_horario);
            Sala_Cine = new Sala_CineController().Get(Funcion.funcion_sala);
        }

        public Funcion Funcion { get; set; }

        public Pelicula Pelicula { get; set; }
        public List<Categoria> Categorias { get; set; }
        public Sala_Cine Sala_Cine { get; set; }
        public Horarios Horarios { get; set; }

        public Idioma Idioma { get; set; }

        public string ObtenerCategorias()
        {
            String resul = "";
            List<Categoria> listaCategorias = Categorias;
            if (listaCategorias.Count != 0)
            {
                foreach (Categoria item in listaCategorias)
                {
                    resul += item.categoria_nombre + ", ";
                }
                return resul.Substring(0, resul.Length - 2);
            }
            else
            {
                return resul;
            }
        }
    }
}
