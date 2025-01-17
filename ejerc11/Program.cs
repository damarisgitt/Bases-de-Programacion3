using System;

namespace ejerc11
{
    class Program
    {
        static void Main(string[] args)
        { //Hacer un programa para ingresar tres números y luego mostrarlos ordenados
          //de menor a mayor.
            int n1, n2, n3;

            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero");
            n3 = int.Parse(Console.ReadLine());

            if(n1 > n2 && n1 > n3) {
                if(n2 > n3) {
                    Console.WriteLine("ordenado " + n3 + n2 + n1);
                }else{
                    Console.WriteLine("ordenado " + n2 + n3 + n1);
                }
            }if(n2 > n3 && n2 > n1){
                if(n1 > n3){
                    Console.WriteLine("orden 3 " + n3 + n1 + n2);
                }else{
                 Console.WriteLine("orden 4 " + n1 + n3 + n2);
                }
            }if(n3 > n1 && n3 > n2){
                if(n1 > n2){ 
                    Console.WriteLine(" ORDEN 5 " + n2 + n1 + n3);
                }else{ 
                      Console.WriteLine(" orden 6 " + n1 + n2 + n3);
                }
            }
        }
    }

}
