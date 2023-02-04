/*Agregar el cálculo del promedio para el programa con arreglo jagged.*/
promedioEdad();

const int CANTIDAD = 5;

static void promedioEdad()
	{
	int[][] jagged = new int[1][];
    jagged[0] = new int[CANTIDAD]{
        10, 43, 62, 64, 57
    };
    int menor = 0, mayor = 0;
	int promedio = 0, sumatoria = 0;
    menor = jagged[0][0];
    mayor = jagged[0][0];
    calculos(mayor, menor, jagged, sumatoria, promedio);
	}

static void calculos(int mayor, int menor, int[][] jagged, int sumatoria, int promedio)
{
    for (int i = 0; i < jagged.Length; i++)
    {
        for (int j = 0; j < jagged[i].Length; j++)
        {
            sumatoria += jagged[i][j]; 
            if(jagged[i][j] > mayor){
                mayor = jagged[i][j];
            }
            if (jagged[i][j] < menor){
                menor = jagged[i][j];
            }
        }
    }
    promedio = sumatoria / CANTIDAD;

    System.Console.WriteLine("Promedio :" + promedio);
    System.Console.WriteLine("Mayor :" + mayor);
    System.Console.WriteLine("Menor :" + menor);
}
