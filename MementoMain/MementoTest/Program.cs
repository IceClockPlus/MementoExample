using System;
using System.IO;
using System.Reflection;

namespace MementoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.Rut = "19884186-2";
            p1.Nombre = "Alexis";
            p1.Apellido = "Aravena";
            p1.FechaNac = new DateTime(2018, 04, 26);
            Console.WriteLine("Datos de la persona Inicial");
            Console.WriteLine(p1.ListarDatos());

            //Guardar datos iniciales de la persona con el patron Memento
            Cuidador cuidador = new Cuidador();
            cuidador.MementoPersona = p1.Guardar();
            cuidador.CrearArchivoGuardado();

            //Modificar los datos de la persona 
            p1.Rut = "11646339-3";
            p1.Nombre = "Denisse";
            p1.Apellido = "Mena";
            p1.FechaNac = new DateTime(1970, 10, 24);

            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Datos de la persona Modificada");
            Console.WriteLine(p1.ListarDatos());

            //Restaurar datos iniciales de la persona
            p1.Restaurar(cuidador.MementoPersona);

            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Datos restaurados de la persona");
            Console.WriteLine(p1.ListarDatos());


            /*Recuperar datos de archivo xml*/
            Persona p2 = new Persona();
            Cuidador c1 = new Cuidador();
            c1.RecuperarMemento();
            p2.Restaurar(c1.MementoPersona);
            Console.WriteLine(p2.ListarDatos());
    
        }
    }
}
