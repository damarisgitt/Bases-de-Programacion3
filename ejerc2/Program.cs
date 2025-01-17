using System;

namespace ejerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            // hacer un programa que solicite el ingreso de dos numeros y luego calcular
            // a- la resta si el primero es mayor que el segundo
            // b- la suma si son iguales.
            // c- el producto si el primero es menor.
            // se debera emitir un cartel del resultado correspondiente
             
            int n1, n2, r, s, p;

            Console.WriteLine("ingrese un numero por favor");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero por favor");
            n2 = int.Parse(Console.ReadLine());

            if(n1 > n2){
                r = n1 - n2;
                 Console.WriteLine("el resultado es: " + r);
            }
            if(n1 < n2){
                p = n1 * n2;
                 Console.WriteLine("el resultado es: " + p);
            }
            if(n1 == n2){
                s = n1 + n2;
                 Console.WriteLine("el resultado es: " + s);
            }

        }
    }
}
