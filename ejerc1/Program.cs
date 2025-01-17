using System;

namespace ejerc1
{
    class Program
    {
        static void Main(string[] args)
        {    
           // hacer un programa que solicite el ingreso de un numero y que luego emita por cartel si 
           // multiplo de 5

           int n1;

            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());

            if(n1 % 5 == 0){
                Console.WriteLine(n1 + " si es multiplo de 5");
            }else{
                Console.WriteLine(n1 + " NO ES MULTIPLO DE 5");
            }
        
            
        }
    }   
}
