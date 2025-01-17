using System;

namespace ejerc10
{
    class Program
    {
        static void Main(string[] args)
        {
          // Hacer un programa que solicite cuatro números y emitir un cartel aclaratorio si
          //son todos iguales entre sí, caso contrario, no emitir nada.
          
          int n1, n2, n3, n4;

          Console.WriteLine("ingrese un numero");
          n1 = int.Parse(Console.ReadLine());
          Console.WriteLine("ingrese un numero");
          n2 = int.Parse(Console.ReadLine());
          Console.WriteLine("ingrese un numero");
          n3 = int.Parse(Console.ReadLine());
          Console.WriteLine("ingrese un numero");
          n4 = int.Parse(Console.ReadLine());

          if(n1 == n2 && n2 == n3 && n3 == n4){
            Console.WriteLine("son todos iguales");
          }else{
            Console.WriteLine("no Emite nada");
          }

        }
    }
}
