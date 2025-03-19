using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2P_Herencia
{
    internal class Alumno:Persona
    {
        public Alumno() { }
       
        public Alumno(string nombre, int edad, string genero, int matricula, string carrera)
        :base(nombre,edad,genero)
        {
            Matricula = matricula;
            Carrera = carrera;
        }

        public int Matricula { get; set; }
        public string Carrera { get; set; }
    }
}
