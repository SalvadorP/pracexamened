using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamenED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practica Examen ED");
            Persona person = new Persona();
            person.Nombre = "Darrow";
            Console.WriteLine(person.mostrarPersona());
            Console.WriteLine("IMC = " + person.imc() + "; Estatura media => " + person.estaturaMedia());

            Persona person2 = new Persona("Sebro", 150, 60, 25);
            Console.WriteLine(person2.mostrarPersona());
            Console.WriteLine("IMC = " + person2.imc() + "; Estatura media => " + person2.estaturaMedia());

            Persona person3 = new Persona("Ragnar", 210, 130, -26);
            Console.WriteLine(person3.mostrarPersona());
            Console.WriteLine("IMC = " + person3.imc() + "; Estatura media => " + person3.estaturaMedia());

            Persona person4 = new Persona("Mustang", 200, 0, 23);
            Console.WriteLine(person4.mostrarPersona());
            Console.WriteLine("IMC = " + person4.imc() + "; Estatura media => " + person4.estaturaMedia());



        }
    }
}
