using PARCIAL_1;
using System;
using System.Collections;

namespace PARCIAL_l
{
    class Program
    {
        private static double promedio;
        static void Main(string[] args)
        {
            int numberStudents;
            ArrayList registro = new ArrayList();
            ArrayList registro_2 = new ArrayList();
            string nombre;
            int edad;
            int notas;
            int notas_2;
            int nota_parcial;
            int continuar = 0;
            int contador = 0;

            Console.WriteLine("Ingrese el número de estudiantes: ");
            numberStudents = int.Parse(Console.ReadLine());
            contador = numberStudents;
            while (contador != 0 || continuar != 0)
            {
                contador--;     //Es mejor reducir el contador
                Console.WriteLine("Ingrese el nombre del estudiante: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del estudiante: ");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la nota del laboratorio 1");
                notas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la nota del laboratorio 2");
                notas_2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la nota de tu parcial");
                nota_parcial = int.Parse(Console.ReadLine());
           
                registro.Add(new Students(nombre, edad));

                registro_2.Add(new Notas_students(notas, notas_2, nota_parcial));

                promedio = (notas * .3) + (notas_2 * .3) + (nota_parcial * .4);

                if (contador == 0)
                {
                    Console.WriteLine("Ingresa 1 para repetir el proceso, (0 CERRAR)");
                    continuar = int.Parse(Console.ReadLine());

                    if (continuar == 1)
                    {
                        Console.Clear(); //Para limpiar la consola
                        Console.WriteLine("Ingrese el número de estudiantes: ");
                        numberStudents = int.Parse(Console.ReadLine());
                        contador = numberStudents;
                    }

                }

            }

            foreach (Students st in registro)
            {
                Console.WriteLine(st.getData());
            }
            foreach (Notas_students st in registro_2)
            {
                Console.WriteLine(st.getData());
            }
            if (promedio >= 6.0)
            {
                Console.WriteLine("APROBADO");
            }
            else if (promedio < 6.0)
            {
                Console.WriteLine("REPROBADO");
            }
        }
    }
}