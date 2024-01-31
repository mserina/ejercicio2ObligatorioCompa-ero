namespace ejercicio2ObligatorioCompañero
{

    class program
    {

        static void Main(string[] args)
        {
            int[,] tabla = new int[4,4];

            //Columnas
            tabla[0, 1] = 1;
            tabla[0, 2] = 2;
            tabla[0, 3] = 3;

            //filas
            
            tabla[1,0] = 1;
            tabla[2,0] = 2;
            tabla[3,0] = 3;

            for (int x = 0; x < tabla.GetLength(0); x++)
            {
                for (int y = 0; y < tabla.GetLength(1); y++)
                {
                    Console.Write(tabla[x, y] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}