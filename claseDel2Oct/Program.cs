using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseDel2Oct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio de la clase del 02/10/2020
            Persona p1 = new Persona("Jorge", "Suarez", 23);
            Persona p2 = new Persona("Marta", "Sanchez", 48);

            Departamento d1 = new Departamento();
            d1.agregarEmpleado(p1);
            d1.agregarEmpleado(p2);

            foreach (Persona i in d1.Employees)
            {
                Console.WriteLine("Nombre: " + i.Nombre);
                Console.WriteLine("Apellido: " + i.Apellido);
                Console.WriteLine("Edad: " + i.Nombre);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("\nCantidad de empleados: " + d1.Employees.Count);

            Console.ReadKey();
        }
    }
}
