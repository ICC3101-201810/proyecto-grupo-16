using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega_2
{
    class Interfaz
    {
        List<String> studentsMenu = new List<String>() { "Mostrar talleres Disponibles", "Prueba 2" };
        List<Boolean> studentOption = new List<Boolean>() { false, false };

        public Interfaz() { }

        public List<String> LogInLogOut()
        {
            List<String> credenciales = new List<string>();
            Console.BackgroundColor = ConsoleColor.Black;
            RedColorConsole("\tMódulo de talleres de la Universidad de los Andes\n");
            GreenColorConsole("\tInicio de Sesión\n");
            WhiteColorConsole("Ingrese Usuario: ");
            credenciales.Add(Console.ReadLine());
            WhiteColorConsole("Ingrese contraseña: ");
            credenciales.Add(Console.ReadLine());
            return credenciales;
        }
        public void ErrorCredenciales(Boolean verifyUser)
        {
            if(!verifyUser)ErrorColorConsole("\tERROR: Usuario/Contraseña Incorrecta\n");
        }

        public List<Boolean> StudentsMenu()
        {
            int i = 1;
            for (int j =0; j<studentOption.Count; j++) studentOption[i]= false;
            RedColorConsole("\tMenu Estudiante\n");
            GreenColorConsole("Seleccione Opcion:\n");
            foreach (String index in studentsMenu) Console.WriteLine("("+ (i++) +") "+index);
            studentOption[Int32.Parse(Console.ReadLine()) - 1]=true;
            return studentOption;
        }

        public void WorkShopAvailable(Dictionary<Taller,List<String>> wsAvaliable)
        {
            int i = 1;
            String schedule = "";
            GreenColorConsole("Talleres Disponibles:\n");

            foreach (Taller ws in wsAvaliable.Keys)
            {
                foreach (String blocks in wsAvaliable[ws]) schedule=String.Concat(schedule, "| ", blocks);
                Console.WriteLine("(" + (i++) + ") " + ws.nombre + ", Horario: " + schedule);
            }

        }

        public void RedColorConsole(String s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void WhiteColorConsole(String s)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(s);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void GreenColorConsole(String s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void ErrorColorConsole(String s)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.Beep();
            Console.Beep();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
