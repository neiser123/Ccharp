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
            //Persona persona = new Persona();
            //persona.nombre = "neiser";
            //persona.nombre = "paola";
            //persona.salariomensual = 1000;

            //Console.WriteLine(persona.nombre);
            //Console.WriteLine(" salario anual : "+persona.salarioAnual);


            Persona persona = new Persona();
            var numero = 5;
            Aumentar(ref numero);
            Console.WriteLine(numero);


        }
        public static void Aumentar(ref int aumentar)
        {
            aumentar++;
        }

    }


    class Persona
    {


        public String nombre { get; set; }
        public decimal salariomensual { get; set; }
        
        public decimal salarioAnual { get {
                return salariomensual * 12;   }
        }




    }
}
