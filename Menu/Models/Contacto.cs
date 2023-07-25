using System;
using System.Collections;
using System.Text;

namespace Menu.Models
{
    class Contacto
    {
        public string? Nombre {get; set;}
        public long? Numero {get; set;}
        public bool Favorito {get; set;}


        //Constructor
        public Contacto(string Nombre, long Numero, bool Favorito=false){
            this.Nombre = Nombre;
            this.Numero = Numero;
            this.Favorito = Favorito;
        }

    }
}