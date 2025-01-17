using System;

namespace ejerc8
{
    class Program
    {
        static void Main(string[] args)
        { 
            // el negocio de desinfectante antes mencionado vende , ademas detergente suelto, y los precios
            // se aplican segun la siguiente escala
            //a-  $25 por litro los primeros 50L
            //B- $20 POR LITRO SI LA VENTA ES DE 51L A 200L.
            //C- $15 POR LITRO SI LA VENTA ES DE 201L A 500L
            //D- $10 POR LITRO SI LA VENTA ES MAS DE 500L
            // ADEMAS  si paga en efectivo tiene un adicional del 10% sobre el importe final 
            // hacer un programa que solicite la cantidad de litros vendido y el tipo de pagos 
            //(ingresara 1 si paga en efectivo y 0 con cualquier otro metodo de pago) y calcule y emita 
            // por pantalla el monto final a abonar por el cliente.

            int LV, TP, MF, desc, IMPF;
            TP = 0  ;
            Console.WriteLine("ingrese litros vendidos");
            LV = int.Parse(Console.ReadLine());
            Console.WriteLine("tipo de pago");
            TP = int.Parse(Console.ReadLine());

            if (LV > 500) {
              MF  = 10 * LV;
                if (TP == 1){
                   desc = MF * 10 /100;
                   IMPF = MF - desc;
                   Console.WriteLine("su  monto a pagar en efectivo es de  "  + IMPF);
                }else { 
                    Console.WriteLine("su monto a pagar es de " + MF);
                }
            } else if (LV > 200) {
                MF = 15 * LV;
                if (TP == 1){
                   desc = MF * 10 /100;
                   IMPF = MF - desc;
                   Console.WriteLine("su  monto a pagar en efectivo es de  "  + IMPF);
                }else { 
                    Console.WriteLine("su monto a pagar es de " + MF);
                }
            }else if (LV > 50) { 
                MF = 20 * LV;
                if (TP == 1){
                   desc = MF * 10 /100;
                   IMPF = MF - desc;
                   Console.WriteLine("su  monto a pagar en efectivo es de  "  + IMPF);
                }else { 
                    Console.WriteLine("su monto a pagar es de " + MF);
                }
            } else if (LV <= 50){
                MF = 25 * LV;
                if (TP == 1){
                   desc = MF * 10 /100;
                   IMPF = MF - desc;
                   Console.WriteLine("su  monto a pagar en efectivo es de  "  + IMPF);
                }else { 
                    Console.WriteLine("su monto a pagar es de " + MF);
                }
            }


        }
    }
}
