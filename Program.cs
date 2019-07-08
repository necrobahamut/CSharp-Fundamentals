﻿using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console; //ESTO NOS PERMITE PODER UTILIZAR EL WRITELINE CONTENIDO EN SYSTEM.CONSOLE SIN TENER QUE ESCRIBIRLO TODO

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicilizar();
            Printer.WriteTitle("Bienvenidos a la Escuela");
            //cantidad es el 3er parametro, pero aqui esta como segundo, pero funciona porque tien el caracter ':'
            //que le indica a que parametro pertenece el valor que le estoy mandando, no importa el orden de los parametros
            // Printer.Beep(10000,cantidad:10);
            imprimirCursosEscuela(engine.Escuela);
        }

        private static void imprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos en la Escuela");

            //la siguiente comparacion es para las nuevas versiones de C#,
            //el simbolo ? le indica que la expresion a evaluar solo sera cierta
            //solo si lo que esta entes del simbolo ?, en este caso el objeto escuela,
            //es diferente de null, para posteriormente revisar si su atributo cursos es igualmente
            //diferente de null
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, ID {curso.UniqueId}");
                }
            }
        }
    }
}
