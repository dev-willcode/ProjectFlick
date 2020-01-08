using System;
using System.Collections.Generic;
using System.Text;

namespace FlickLibrary.Entidades
{
    class Sala_Cine
    {
        private int id;
        private string sala_nombre;
        private string salsa_capacidad_maxima;

        public Sala_Cine()
        {
        }

        public Sala_Cine(int id, string sala_nombre, string salsa_capacidad_maxima)
        {
            this.id = id;
            this.sala_nombre = sala_nombre;
            this.salsa_capacidad_maxima = salsa_capacidad_maxima;
        }

        public int Id { get => id; set => id = value; }
        public string Sala_nombre { get => sala_nombre; set => sala_nombre = value; }
        public string Salsa_capacidad_maxima { get => salsa_capacidad_maxima; set => salsa_capacidad_maxima = value; }
    }
}
