using System;

namespace ejerc5
{
    class Program
    {
        static void Main(string[] args)
        {
            // hacer un programa que solicite el ingreso de las notas del primer parcial y del segundo parcial 
            // de una alumna de programacion. el programa debera analizar la nota y emitir la situacion de la alumna.
            // a- si tiene 8 o mas en ambos parciales, emitir " aprobacion directa."
            // b- si no tiene 8 o mas en ambos, pero tiene aprobado ambos parciales "rinde examen final
            // c si tiene menos de 6 en algunos de ambos parciales "d
            int p1, p2;
            Console.WriteLine("ingrese la nota del primer parcial");
            p1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la nota del segundo parcial");
            p2 = int.Parse(Console.ReadLine());

            if(p1 > 7 && p2 > 7){
                Console.WriteLine("aprobacion directa");
            }else if(p1 > 5 && p2 > 5){
                Console.WriteLine("rinde examen final");

            }else {Console.WriteLine("debe recuperar");
           
            }



        }
    }
}
