using System;

namespace consolaCurso
{
    public class Class1
    {
        public Class1()
        {
        }

        static void Main(String[] arg)
        {
            Persona persona = new Persona();
            persona.nombre = "neiser";
            persona.nombre = "paola";
            Console.WriteLine(persona.nombre);

        }

    }


    class Persona
    {


        public String nombre { get; set; }




    }
}
