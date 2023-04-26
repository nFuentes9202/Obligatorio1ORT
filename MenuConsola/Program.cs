using System.Runtime.CompilerServices;
using Obligatorio1;
namespace MenuConsola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sistema s = Sistema.GetInstancia();


            int op = -1;

            while(op != 0) {

                armaMenu();
            }
        }

        private static void armaMenu() {

            Console.WriteLine("1 - Listado de todas las Actividades.");
        
        
        
        }
    }
}  