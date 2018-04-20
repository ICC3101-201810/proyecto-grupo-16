using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega_2
{
    class Interfaz
    {
        public Interfaz() { }

        public List<String> LogInLogOut()
        {
            List<String> credenciales = new List<string>();
            Console.BackgroundColor = ConsoleColor.Black;
            RedColorConsole("\tMódulo de talleres de la Universidad de los Andes\n");
            WhiteColorConsole("Ingrese Usuario: ");
            credenciales.Add(Console.ReadLine());
            WhiteColorConsole("Ingrese contraseña: ");
            credenciales.Add(Console.ReadLine());
            return credenciales;
        }

        private void RedColorConsole(String s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
        }
        private void WhiteColorConsole(String s)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(s);
        }
    }
}
