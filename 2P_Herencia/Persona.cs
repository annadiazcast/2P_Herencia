﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2P_Herencia
{
    internal class Persona
    {
        public Persona() { }
        public Persona(string nombre, int edad, string genero)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
        }

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
    }
}
