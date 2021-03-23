using System;
using System.Collections.Generic;

namespace consolaCurso
{
    public class Class1
    {
        public Class1()
        {
        }

      /*  static void Main(String[] arg)
        {
            //Persona persona = new Persona();
            //persona.nombre = "neiser";
            //persona.nombre = "paola";
            //persona.salariomensual = 1000;

            //Console.WriteLine(persona.nombre);
            //Console.WriteLine(" salario anual : "+persona.salarioAnual);

            // TIPOS Y REFERENCIAS 
            //Persona persona = new Persona();
            //var numero = 5;
            //Aumentar(ref numero);
            //Console.WriteLine(numero); 

            // === CONSTRUCTORES 





        } */
        public static void Aumentar(ref int aumentar)
        {
            aumentar++;
        }

    }


    class Persona
    {
        public Persona() {
            telefonos = new List<string>();
        }

        public Persona(String nombre , int salariomensual)
            :this()
        {
            nombre = nombre;
            salariomensual = salariomensual;
        }

        //static void Main(String[] arg)
        //{
        //    Persona persona = new Persona();
        //    persona.telefonos.Add("454121212");
        //    Persona persona2 = new Persona("NEISER" , 15000);
        //    persona2.telefonos.Add("77757575");
        //    Console.WriteLine(persona.telefonos);
        //}


        public String nombre { get; set; }
        public decimal salariomensual { get; set; }
        
        public decimal salarioAnual { get {
                return salariomensual * 12;   }
        }

        public List<String> telefonos { get; set; }


    }
}
