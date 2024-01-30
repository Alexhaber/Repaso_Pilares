using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_pilares
{
    public class Persona
    {
        public string nombre;
        public string apellido;
        public int edad;
        public int id;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public Persona(string nombre, string apellido, int edad, int id)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.id = id;

        }
    }
}
