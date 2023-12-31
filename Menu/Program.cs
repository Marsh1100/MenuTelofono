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
                    Console.WriteLine("¡Contacto agregado con exito!");
                    
                    break;
                case 2:
                    mostrarEntradas(libretaTelefonica);
                    break;
                case 3:
                    libretaTelefonica = marcarImportante(libretaTelefonica);
                    Console.WriteLine("¡Contacto agregado a favorito con exito!");

                    break;
                case 4:
                    libretaTelefonica=eliminarEntrada(libretaTelefonica);
                    Console.WriteLine("Contacto eliminado.");

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
        Console.WriteLine("\n***** AGREGAR NUEVA ENTRADA *****");

        Console.Write("Digite nombre del contacto: ");
        string? nombre = Convert.ToString(Console.ReadLine());
        if(nombre ==null){
            nombre = "Contacto";
        }
        Console.Write("Digite número del contacto: ");
        long numero = Convert.ToInt64(Console.ReadLine());

        
        return new Contacto (nombre,numero);
       
    }

    static void mostrarEntradas(List<Contacto> libretaTelefonica) {
        Console.WriteLine("\n***** LISTA DE CONTACTOS *****");
        Console.WriteLine("Nombre\tTeléfono\tFavoritos\n");

        foreach (var contacto in libretaTelefonica)
        {   
            if(contacto.Favorito){
                Console.WriteLine(contacto.Nombre+"\t"+contacto.Numero+"\t⭐\n");

            }else{
                Console.WriteLine(contacto.Nombre+"\t"+contacto.Numero+"\t-\n");

            }
        }
    }

    static List<Contacto> marcarImportante( List<Contacto> libretaTelefonica) {
        Console.WriteLine("\n***** MARCAR COMO FAVORITO *****");

        mostrarEntradas(libretaTelefonica);
        Console.Write("Digite nombre del contacto para añadir a favorito: ");
        string? nombre = Convert.ToString(Console.ReadLine());

        //Coincidencia del nombre
        foreach(var contacto in libretaTelefonica){

            if(contacto.Nombre == nombre){
                contacto.Favorito = true;
                break;
            }
        }
        return libretaTelefonica;
    }

    static List<Contacto> eliminarEntrada(List<Contacto> libretaTelefonica)
    {
        Console.WriteLine("\n***** ELIMINAR CONTACTO *****");

        mostrarEntradas(libretaTelefonica);
        Console.Write("Digite nombre del contacto a eliminar: ");
        string? nombre = Convert.ToString(Console.ReadLine());

        //Coincidencia del nombre
        for(int i =0 ; i<libretaTelefonica.Count(); i++){
            if(libretaTelefonica[i].Nombre == nombre){
                libretaTelefonica.RemoveAt(i);
                break;
            }
        }
        return libretaTelefonica;
    }
}
}
