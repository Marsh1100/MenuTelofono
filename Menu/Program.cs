﻿using System;
using System.Collections;
using Menu.Models;
//Libreta telefónica

namespace Menu{
class Program {
    static void Main() {
        

        //Lista que guarda el contacto y número de teléfono
        List<Contacto> libretaTelefonica = new List<Contacto>();
        
        int opcion;

        do {
            MostrarMenu();
            opcion = PedirOpcion();

            switch (opcion) {
                case 1:
                    libretaTelefonica.Add(agregarEntrada());
                    foreach(var telefono in libretaTelefonica){
                        Console.WriteLine(telefono.Nombre);
                    }
                    break;
                case 2:
                    mostrarEntradas();
                    break;
                case 3:
                    marcarImportante();
                    break;
                case 4:
                    eliminarEntrada();
                    break;
                case 5:
                    Console.WriteLine("Hasta luego.");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 5);
    }

    static void MostrarMenu() {
        Console.WriteLine("Menú de opciones:");
        Console.WriteLine("1. Agregar entrada");
        Console.WriteLine("2. Mostrar entradas");
        Console.WriteLine("3. Marcar entrada como importante");
        Console.WriteLine("4. Eliminar entrada");
        Console.WriteLine("5. Salir");

    }

    static int PedirOpcion() {
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static Contacto agregarEntrada() {
        Console.WriteLine("***** AGREGAR NUEVA ENTRADA *****");

        Console.Write("Digite nombre del contacto: ");
        string? nombre = Convert.ToString(Console.ReadLine());
        if(nombre ==null){
            nombre = "Contacto";
        }
        Console.Write("Digite número del contacto: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        
        return new Contacto (nombre,numero);
       
    }

    static void mostrarEntradas() {
        
    }

    static void marcarImportante() {
        
    }

    static void eliminarEntrada()
    {

    }
}
}