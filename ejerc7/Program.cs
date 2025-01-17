using System;

namespace ejerc7
{
    class Program
    {
        static void Main(string[] args)
        {
            // hacer un programa para ingresar 4 numeros. luego analizar e informar por pantalla
            // si los mismos se encuentran ordenados de forma decreciente.
            
            int n1, n2, n3, n4;

            Console.WriteLine("ingrese un numero por favor");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero por favor");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero por favor");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero por favor");
            n4 = int.Parse(Console.ReadLine());

            if(n1 > n2 && n2 > n3 && n3 > n4){
                Console.WriteLine("SI ESTA ORDENADO DE FORMA DECRECIENTE");
            } else{
                Console.WriteLine("no esta ordenado de forma decreciente");
            }
        }
    }

    
}
