using System;
namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unidad 1: Estructuras de control II
            //Unidad 2: Funciones II
            //Sesion 12: Instruccion while

            // sintaxis: while

            // inicializacion;
            // while(expresion)
            //{
            //   bloque de instrucciones
            //   iterador;
            //}

            // iterar: repetir.

            // Ejemplo 1: ciclo ascendente (rango: 1-3)

            // m: variable de control
            int m=1; //Inicializacion
            while(m <= 3)
            {
                //Bloque de instrucciones.
                Console.WriteLine($"m: {m}");
                m += 1; // iterador
            }
            //Ejercitacion: definir un ciclo para imprimir tu nombre 5 veces
            //nota: usar el operador menor que
            int n=1;
            while(n < 6)
            {
                Console.WriteLine("abril");
                n += 1;
            }

            //b. ciclo descendente
            int d=3;
            while(d>=1)
            {
                Console.WriteLine($"d: {d}");
                d-=1;
            }

            //c. incrementos (ciclo ascendente)
            // secuencia: 3, 6, 9, 12, 15, 18.
            int i=3;
            while(i<=18)
            {
                Console.WriteLine($"i: {i}");
                i+=3;
            }

            //ejercitacion: definir un ciclo para imprimir 331 8 veces
            // define un ciclo descendente con decrementos de dos unidades
            int s= 16;
            while(s>0)
            {
                Console.WriteLine("331");
                s-=2;
            }

            // Actividad 1: Ciclo infinito
            //1. DEfinir un ciclo infinito ascendente.
            //2. Definirun ciclo infinito descendente.
            //Nota: para la solucion, utilizar el operador de 
            //int b = 10;
            //while (b > 5)
             //{
                //Console.WriteLine($"b: {b}");
                //b += 1;
             //}

            //int c = 10;
            //while (c != 0)
            //{
             //  Console.WriteLine($"c: {c}");
             //  c -= 1;
            //}
            //Sesion 13: Medio maraton


            //Actividad asincronica.
            //Una corredora, de nombre Diana, tiene una zancada 
            //(aproximada) de 0.63 m. Si el sábado, 10 de octubre, 
            //correrá un medio maratón (21 km),
            //¿cuántas zancadas necesitará para terminar el circuito?
            //Abril Valle 331-40
            double diana=0;
            int z=0;
            double hidratacion=0;
            while (diana<21000)
            {
                z += 1;
                diana += 0.63;
                Console.WriteLine($"Metros recorridos: {z}");
                if(diana%2000<0.63) 
                {
                    hidratacion+=1;

                }
            }
            Console.WriteLine($"Zancadas que necesita: {z}");
            Console.WriteLine($"Hidratacion: {hidratacion}");
            //1. Ciclo for.
            /*
            Sintaxis:

            for(inicializacion; expresion; iterador)
            {
              //Bloque de instrucciones
            }
            */
            //Ejemplo: Secuencia 35-41
            for(int k = 35; k <= 41; k+=1)
            {
                 Console.WriteLine($"k: {k}");
            }
            //SEsion 14: ciclo for
            //1. Definir un ciclo for para la secuencia: -33, -34, -35, -36, -37, -38, -39
            for(int y = -33; y >= -39; y-=1)
            {
                Console.WriteLine($"n: {n * -1}");
            }
            //2. Ciclo ascendente
            for(int a=9; a<=15; a+=1)
            {
                if(a!=13)
                {
                    Console.WriteLine($"a: {a}");
                }
                
            }
            //3. 
            for(int l=1; l<=539; l+=88)
            {
                Console.WriteLine($"Capitulo {l}");
            }
        } 
    } 
} 
