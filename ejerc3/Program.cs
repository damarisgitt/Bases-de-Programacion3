using System;

namespace ejerc3
{
    class Program
    {
        static void Main(string[] args)
        { //HACER UN PROGRAMA PARA INGRESAR DOS NUMEROS. SI EL SEGUNDO ES DISTINTO DE 0 , CALCULAR LA DIVISION
        // DEL PRIMERO POR EL SEGUNDO  Y MOSTRAR EL RESULTADO POR PANTALLA; DE LO CONTRARIO, EMITIR UN CARTEL
        // QUE NO SE PUEDE DIVIDIR POR 0

        int N1, N2, R;

            Console.WriteLine("ingrese un numero ");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero");
            N2 = int.Parse(Console.ReadLine());

            if (N2 == 0){
                Console.WriteLine("NO SE PUEDE DIVIDIR POR 0");
            }else{
                R = N1 / N2;
                Console.WriteLine(" el resultado es "  + R);
            }

        }
    }
}
