using System;
using System.Collections.Generic;
using System.Text;

namespace PARCIAL_1
{
    class Notas_students
    {
        private int _notas;
        private int _notas_2;
        private int _nota_parcial;

        public Notas_students(int notas, int notas_2, int nota_parcial)
        {
            _notas = notas;
            _notas_2 = notas_2;
            _nota_parcial = nota_parcial;
        }

        public string getData()
        {
            return "Nota_1: " + _notas + " Nota_2: " + _notas_2 + " Nota_Parcial: " + _nota_parcial;
        }
    }
}