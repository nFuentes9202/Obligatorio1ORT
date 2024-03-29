﻿using System;
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

                        try
                        {
                            Console.WriteLine("Ingrese Fecha Inicial (dd,mm,aaaa)");
                            DateTime fechaini = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese Fecha Final (dd,mm,aaaa)");
                            DateTime fechafin = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese Costo");
                            double costo = double.Parse(Console.ReadLine());


                            List<Actividad> todasLasActividades = s.getActividadesSegunFechayCosto(fechaini, fechafin, costo);
                            if (todasLasActividades.Count > 0)
                            {
                                foreach (Actividad actividad in todasLasActividades)
                                {
                                    Console.WriteLine(actividad.ToString() + " Costo:" + actividad.CostoDolares);

                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay Actividades");
                            }


                        }
                        catch (Exception e)
                        {

                            Console.WriteLine("ERROR" + " " + e.Message);
                        }
                  
                        break;

                    case 4:
                        try
                        {
                            Console.WriteLine("Ingrese IdProveedor");
                            int idProv = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese Nuevo valor Promocion.");
                            double valPromo = Double.Parse(Console.ReadLine());
                            if(valPromo < 0 || valPromo > 100)
                            {
                                throw new Exception("El valor de promocion debe estar comprendido entre 0 y 100");
                            }
                            if(s.EstablecerValorPromociondeProveedor(idProv, valPromo))
                            {
                                Console.WriteLine("Valor establecido correctamente");
                            }else
                            {
                                Console.WriteLine("Proveedor no encontrado");
                            }
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine($"ERROR {e.Message}");
                        }
                        
                        break;

                    case 5:
                        try
                        {
                        Console.WriteLine("Ingrese Tipo de Documento (CI, PASAPORTE , OTROS)");
                        string tipoDoc = Console.ReadLine();
                        Console.WriteLine("Ingrese Numero de Documento (Sin puntos ni guiones)");
                        string numDoc = Console.ReadLine();
                        Console.WriteLine("Ingrese Nombre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Apellido");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese Habitacion");
                        string habitacion = Console.ReadLine();
                        Console.WriteLine("Ingrese Fecha de Nacimiento (dd,mm,aaaa)");
                        DateTime fechaNac = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese nivel de Fidelidad de 1 a 4");
                        int nivFidelidad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Email");
                        string email = Console.ReadLine();
                        Console.WriteLine("Ingrese contraseña (de 8 digitos o mas)");
                        string contrasenia = Console.ReadLine();

                        Huesped nuevo = new Huesped(tipoDoc,numDoc,nombre,apellido,habitacion,fechaNac,nivFidelidad,email,contrasenia);
                        
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