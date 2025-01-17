using System;

namespace ejerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            // un importante negocio de desinfectante liquido realiza descuentos dependiendo
            // de la cantidad de litros vendidos segun la siguiente escala:
            //si vende menos de 100 litros no hay descuento
            // si vende entre 101 y 300 litros, el descuento es del 10%
            //si vende entre 301 y 500 litros el descuento es del 15%
            // si la venta es mas de 500 litros el descuento es del 25%
            // hacer un programa que solicite el ingreso del importe total de la venta y la cantidad
            // de litros vendidos y calcule y emita el importe con el descuento aplicado.

            int im, li, i, d;
            i = 0;  

             Console.WriteLine("ingrese su importe");
             im = int.Parse(Console.ReadLine());
             Console.WriteLine("ingrese la cantidad de litros");
             li = int.Parse(Console.ReadLine());

            if(li > 500){
                d = im * 25 / 100;
                i = im - d;
                 Console.WriteLine("el importe con 25% de desc es: "  + i);
            }
            else if(li > 300){
                d = im * 15 / 100;
                i = im - d;
                 Console.WriteLine("el importe con 15% de desc es:  "  + i);

            }
            else if(li > 100){
                d = im * 10 / 100;
                i = im - d;
                 Console.WriteLine("el importe con 10% de desc es;  "  + i);

            }
            else{
                d = im;
                 Console.WriteLine("el importe es:  "  + im);

            }



        }
    }
}
