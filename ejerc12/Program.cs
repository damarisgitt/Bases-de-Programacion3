using System;

namespace ejerc12
{
    class Program
    {
        static void Main(string[] args)
        {
         // Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si
         //la suma de los dos primeros es mayor al producto del segundo con el tercero.

         int n1, n2, n3, suma, pro;
         
         Console.WriteLine("ingrese un numero");
         n1 = int.Parse(Console.ReadLine());
         Console.WriteLine("ingrese un numero");
         n2 = int.Parse(Console.ReadLine());
         Console.WriteLine("ingrese un numero");
         n3 = int.Parse(Console.ReadLine());

         suma = n1 + n2;
         pro = n2 * n3;

         if(suma > pro){
            Console.WriteLine("si es mayor la suma");
         }else{
            Console.WriteLine("no es mayor la suma");
         }




        }
    }
}
