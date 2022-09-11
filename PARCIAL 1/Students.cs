using System;
using System.Collections.Generic;
using System.Text;

namespace PARCIAL_1
{
    class Students
    {
        private string _nombre;
        private int _edad;

        public Students(string nombre, int edad)
        {
            _nombre = nombre;
            _edad = edad;
        }

        public string getData()
        {
            return "Nombre: " + _nombre + " Edad: " + _edad;
        }
    }
}
