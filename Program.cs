namespace programaInPro;
class Program
{
    static void Main()
    {
        int opcion=0;
        string resultados="";
        string? ganador=null;
        string? estrategia=null;
        int resultadosAgregados=0;
        do
        {
            Console.WriteLine("-----PlayLab-----");
                        Console.WriteLine(resultados);
            Console.WriteLine();
            Console.WriteLine("1-.Mostrar resultados");
            Console.WriteLine("2-.Agregar resultados");
            Console.WriteLine("3-.Mostrar porcentaje del META");
            Console.WriteLine("4-.Salir");
            Console.WriteLine("Elige una opcion");
            opcion=Convert.ToInt32(Console.ReadLine());
            if (opcion==1) {
                if (resultados=="")
            {
                Console.WriteLine("No hay resultados");
            }
                else
            {
                Console.WriteLine("Resultados:");
                Console.WriteLine(resultados);
            }
            }
            else if (opcion==2) {
                Console.WriteLine("Agregar resultados");
                if (resultados=="")
                {
                    Console.WriteLine("¿Que a ganado?");
                    estrategia=Console.ReadLine();
                    Console.WriteLine("¿Quien a ganado?");
                    ganador=Console.ReadLine();
                    Console.WriteLine("Resultado agregado");
                    Console.WriteLine(estrategia + " por " + ganador);
                    resultados=estrategia +" por "+ganador;
                }
                else
                {
                    Console.WriteLine("¿Que a ganado?");
                    estrategia=Console.ReadLine();
                    Console.WriteLine("¿Quien a ganado?");
                    ganador=Console.ReadLine();
                    Console.WriteLine("Resultados agregado");
                    Console.WriteLine(estrategia + " por " + ganador);
                    resultados+=$"{Environment.NewLine}{estrategia} por {ganador}";
                }
            }
            else if (opcion==3) {
                Console.WriteLine("¿Cuantos resultados se agregaron?");
                Console.WriteLine(resultadosAgregados);
            }
            else if (opcion==4) {
                Console.WriteLine("Saliendo del programa");
            }
            else
            {
                Console.WriteLine("Elije una opcion valida");
            }
            resultadosAgregados++;
        }
            while (opcion!=0);
    }
}