using System;
namespace CS7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bloque de la funcion.
            // Sesion 15: Funciones
            /*
             Funcion: Bloque de instrucciones para realizar una tarea 
             especifica, que se ejecuta unicamente cuando es invocada.
             
             Sintaxis para la definicion de funcion

             tipo_dato_devuelto identificador_funcion(parametros)
             {
                Bloque de instrucciones
             }
             Nota: Los parametros se definen con el tipo de dato incluyendo tipo de dato.
             Nota2: Los parametros van separados por comas.

             Sintaxis para invocar la funcion
             idenficador_funcion(argumentos);
             Argumento: Valor del parametro.
            */
            // Ejemplo 1: Funcion vacia sin parametros
            void Saludar()
            {
                string salon="Exactas";
                Console.WriteLine($"hola {salon}");
            }
            //Invocacion
            Saludar();
            //1. Definir e invocar una funcion sin parametros para imprimir nombre, clave, salon 
            void alumno()
            {
                string nombre="abril";
                string clave="331-40";
                string salon="exactas";
                Console.WriteLine($"{nombre}, {clave}, {salon}.");
            } 
            alumno();
            // 2. definir e invocar una funcion para desplegar el horario de hoy.
            void horario()
            {
                string a="Psicologia";
                string b="Idiomas";
                string c="Dibujo";
                string d="calculo";
                string e="Formacion Humana";
                string f="Programacion";
                Console.WriteLine($"7:00-7:45 {d} \n7:50-8:35 {e} \nReceso \n8:40-9:30 {f} \n9:50-10:35 {a} \n10:40-11:30 {b} \nReceso \n11:50-1:30 {c}");
            }
            horario();

            // Sesión 16: Función con parametros
            // return: Palabra reservada para terminar una funcion y devolver una expresion.
            // Ejemplo 1: Doble
            // Definición
            int CalcularDoble(int numero)
            {
                int resultado = 2 * numero;
                return resultado;
            } 
            // Invocación
            int devolucion;
            devolucion = CalcularDoble(3);
            Console.WriteLine($"Devolución: {devolucion}");
            // Ejercitación
            // 1. Definir e invocar una funcion que devuelva la evaluacion de la siguiente expresión: f(x) = 4x - 7/5
            double expresion(double x)
            {
                double evaluacion;
                evaluacion = (4 * x) - 7/5D;
                return evaluacion;
            }   
            double funcion;
            funcion = expresion(0);
            Console.WriteLine($"Evaluación f(0): {funcion}"); 
            // 1. 
            double
             a = 1;

        }
    }
}