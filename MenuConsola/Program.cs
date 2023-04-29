using System;
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
                op = int.Parse(Console.ReadLine());


                switch (op)
                {

                    case 1:
                        List<Actividad> todas = s.GetActividades();
                        if(todas.Count > 0) { 
                        foreach(Actividad actividad in todas)
                            {
                                Console.WriteLine(actividad.ToString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay Actividades");
                        }
                      
                        
                        break;

                    case 2:
                        List<Proveedor> todos = s.GetProveedoresAlfabeticamente();
                        if(todos.Count > 0)
                        {
                            foreach (Proveedor proveedor in todos)
                            {
                                Console.WriteLine(proveedor.ToString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay Proveedores");
                        }



                        break;

                    case 3:

                        Console.WriteLine("Ingrese Fecha Inicial");
                        DateTime fechaini = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Fecha Final");
                        DateTime fechafin = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Costo");
                        double costo = double.Parse(Console.ReadLine());

                          //TODO
                        break;

                    case 4:
                        Console.WriteLine("Ingrese IdProveedor");
                        int idProv = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Nuevo valor Promocion.");
                        double valPromo = Double.Parse(Console.ReadLine());
                     
                        //TODO
                        break;

                    case 5:
                        Console.WriteLine("Ingrese Tipo de Documento");
                        string tipoDoc = Console.ReadLine();
                        Console.WriteLine("Ingrese Numero de Documento");
                        string numDoc = Console.ReadLine();
                        Console.WriteLine("Ingrese Nombre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Apellido");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese Habitacion");
                        string habitacion = Console.ReadLine();
                        Console.WriteLine("Ingrese Fecha de Nacimiento");
                        DateTime fechaNac = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese nivel de Fidelidad");
                        int nivFidelidad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Email");
                        string email = Console.ReadLine();
                        Console.WriteLine("Ingrese contrasenia");
                        string contrasenia = Console.ReadLine();

                        Huesped nuevo = new Huesped(tipoDoc,numDoc,nombre,apellido,habitacion,fechaNac,nivFidelidad,email,contrasenia);
                        try
                        {
                            s.AltaUsuario(nuevo);
                            Console.WriteLine("Huesped Registrado!");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("ERROR" + " " + e.Message);
                        }
                      


                        //TODO
                        break;
                }


                Console.ReadKey();
            }

        }

        private static void armaMenu() {
            Console.Clear();
            Console.WriteLine($"  ___    _       _   _                   _                    _             ____    ____      __  __   ____       _    \r\n  / _ \\  | |__   | | (_)   __ _    __ _  | |_    ___    _ __  (_)   ___     |  _ \\  |___ \\    |  \\/  | |___ \\     / \\   \r\n | | | | | '_ \\  | | | |  / _` |  / _` | | __|  / _ \\  | '__| | |  / _ \\    | |_) |   __) |   | |\\/| |   __) |   / _ \\  \r\n | |_| | | |_) | | | | | | (_| | | (_| | | |_  | (_) | | |    | | | (_) |   |  __/   / __/    | |  | |  / __/   / ___ \\ \r\n  \\___/  |_.__/  |_| |_|  \\__, |  \\__,_|  \\__|  \\___/  |_|    |_|  \\___/    |_|     |_____|   |_|  |_| |_____| /_/   \\_\\\r\n                          |___/                                                                                         ");
            Console.WriteLine("1 - Listado de todas las Actividades.");
            Console.WriteLine("2 - Listado de proveedores.");
            Console.WriteLine("3 - Acvtividades entre fechas que cuesten mas de");
            Console.WriteLine("4 - Establecer el valor de promocion para actividades del proveedor.");
            Console.WriteLine("5 - Alta de huespedes."); 
            Console.WriteLine("0 - Salir.");

        }
    }
}  