using System;
namespace CS6
{
    class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine($"n: {y * -1}");
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
