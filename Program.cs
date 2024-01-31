using System.ComponentModel;

namespace ejercicio2ObligatorioCompañero
{

    class program
    {

        static void Main(string[] args)
        {
            bool cerrarBucle = false;
            int[,] tabla = new int[4,4];
            int[,] tabla2 = new int[4,4];
            Random random = new Random();

            //array con los datos
            for (int x = 0; x < tabla2.GetLength(0); x++)
            {
                for (int y = 0; y < tabla2.GetLength(1); y++)
                {
                    tabla2[x, y] = random.Next(0, 2);
                }
            }

            //Para mostrar la tabla con los datos ocultos
            for (int x = 0; x < tabla.GetLength(0); x++)
            {
                for (int y = 0; y < tabla.GetLength(1); y++)
                {
                    
                    tabla[0, y] = y;
                    tabla[x, 0] = x;
                    if (tabla[0, 0] == 0 | tabla[0, 0] == 1)
                    {
                        tabla[0, 0] = -2;
                    }

                    if (tabla[x, y] == 0)
                    {
                        tabla[x, y] = tabla2[x,y];
                    }
                    Console.Write(tabla[x, y] + "\t");

                   
                }
                Console.WriteLine();
            }
            //Los intentos
            Console.WriteLine(" ");
            int contador = 0;
            while(!cerrarBucle && contador <= 3)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Contador: " + contador);
            //Para pedir al usuario la posicion X y Y
                Console.WriteLine("Inserte posicion X");
                int PosicionX = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte posicion Y");
                int PosicionY = Convert.ToInt32(Console.ReadLine());

            //Para que imprima la tabla pero con las posiciones que nos inserto el usuario
                for (int x = 0; x < tabla2.GetLength(0); x++)
                {
                    for (int y = 0; y < tabla2.GetLength(1); y++)
                    {
                        tabla[PosicionX, PosicionY] = tabla2[PosicionX, PosicionY];
                        Console.Write(tabla[x, y] + "\t");
                    }
                    Console.WriteLine();
                }
                if (tabla[PosicionX, PosicionY] == 0)
                {
                    cerrarBucle = true;
                    Console.WriteLine("Enorabuena");
                }
                else
                {
                    contador++;
                    Console.WriteLine(" ");
                    Console.WriteLine("Vuelve a intentarlo");
                    
                }
            }
        }
    }
}










