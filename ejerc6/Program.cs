using System;

namespace ejerc6
{
    class Program
    {
        static void Main(string[] args)
        {
            //hacer un programa para ingresar por teclado la longitud de los tres lados de un triangulo
            // y que luego determine e informe con un cartel aclaratorio a que tipo de triangulo corresponde
            //a-equilatero : cuando los tres lados sean iguales
            //b-isosceles: cuando dos de los tres lados sean iguales 
            //c-escaleno : cuando los tres lados sean distintos

            int L1,L2, L3;

            Console.WriteLine("INGRESE LADO 1");
            L1 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE LADO 2");
            L2 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE LADO 3");
            L3 = int.Parse(Console.ReadLine());

            if (L1 == L2 && L2 == L3 && L3 == L1) {
                Console.WriteLine(" es un triangulo equilatero ");
            } else if (L1 != L2 && L2 != L3 && L1 != L3){
                Console.WriteLine("Es un triangulo escaleno");
            }else {
                Console.WriteLine("Es un triangulo isosceles");
            }
        }
    }
}
