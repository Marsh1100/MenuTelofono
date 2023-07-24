using System;
using System.Collections;
using System.Text;

namespace Menu.Models
{
    class Contacto
    {
        public string? Nombre {get; set;}
        public int? Numero {get; set;}

        //Constructor
        public Contacto(string Nombre, int Numero){
            this.Nombre = Nombre;
            this.Numero = Numero;
        }

    }
}