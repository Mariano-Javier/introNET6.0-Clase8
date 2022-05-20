Console.WriteLine("Ingrese la cantidad de promedios a calcular (filas)");
int fila = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el total de valores que desea promediar (columnas)");
int columna = int.Parse(Console.ReadLine());

//Matriz con los valores ingresados
int[,] numeros = new int[fila, columna];

//Cantidad de filas
int largoFila = numeros.GetUpperBound(0) + 1;

//Cantidad de columnas
int largoColumna = numeros.GetUpperBound(1) + 1;

//Vector promedios y acumulador
int[] acumulador = new int[fila];
double[] promedios = new double[fila];

//recorrer la matriz para cargar datos
for (int i= 0; i < largoFila; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Promedio N° {i + 1}: ");

    for (int j= 0; j < largoColumna; j++)
    {
        Console.Write($"Ingrese el valor N° {j + 1}: ");
        numeros[i, j] = int.Parse(Console.ReadLine());
        acumulador[i] += numeros[i, j];
    }
}

//Calcular y asignar promedios al vector promedios
for (int i=0; i < acumulador.Length; i++)
{
    promedios[i] = (double)acumulador[i] / 10;
}

Console.Clear();

//imprimir resultados de la matriz
Console.WriteLine("=================================");
Console.WriteLine("  Valores numéricos recibidos");
Console.WriteLine("=================================");

for (int i = 0; i < largoFila; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Índice N°{i + 1}: ");

    for (int j = 0; j < largoColumna; j++)
    {
        Console.Write($"Valor recibido N° {j + 1}: ");
        Console.WriteLine($"{numeros[i, j]}");
    }
}

//Imprimir promedios
Console.WriteLine();
Console.WriteLine("=================================");
Console.WriteLine("  Cálculo de promedios");
Console.WriteLine("=================================");
Console.WriteLine();
for (int i = 0; i < promedios.Length; i++)
{
    Console.WriteLine($"Promedio del índice N°{i+1} :{promedios[i]}");
}
