using System.Collections;


Ejercicio1();
Ejercicio2();
Ejercicio3();
/*Hacer el programa que calcula el
promedio, calificación máxima y mínima
de un salón de clases usando el ArrayList.
*/
static void Ejercicio1()
	{
        List <int> num = new List <int>();
		int promedio = 0, sumatoria = 0, maxima = 0, minima = 0;


        num.Add(5);
        num.Add(56);
        num.Add(57);
        num.Add(55);
        num.Add(85);

        maxima = num[0];
        minima = num[0];
        for(int i = 0; i <num.Count; i++){
            sumatoria += num[i];
            if(num[i] > maxima){
                maxima = num[i];
            }
            if(num[i]<maxima){
                minima = num[i];
            }
        }
        promedio = sumatoria / num.Count;
        System.Console.WriteLine($"Promedio: " + promedio);
        System.Console.WriteLine($"Maximo: " + maxima);
        System.Console.WriteLine($"Minimo: " + minima);
	}
/*2 Hacer un programa que funcione como un
diccionario, con palabra y definición,
usando el Hashtable.*/
static void Ejercicio2(){
    Hashtable diccionario = new Hashtable();
    diccionario.Add("Vida", "La vida ​ es un sistema químico que utiliza energía para evitar alcanzar el equilibrio químico.");
    diccionario.Add("Big bang", "En cosmología, se entiende por Big Bang​​ o Gran Explosión​ en español​ al principio del universo, es decir, el punto inicial en el que se formó la materia, el espacio y el tiempo.​ De acuerdo con el modelo cosmológico estándar, el Big Bang tuvo lugar hace unos 13 800 millones de años.​");

    System.Console.WriteLine($"El significado de Big bang: {diccionario["Big bang"]}");
}

/*5 Hacer un programa que funcione como
una agenda telefónica y que guarde el
nombre de la persona y su número
telefónico.*/
static void Ejercicio3(){
    Hashtable agenda = new Hashtable();
    agenda.Add("levi el muerto", 8498556235);
    agenda.Add("delgado messi", 84424235);
    agenda.Add("edgar el dao", 846542565);
    agenda.Add("stive el que pega", 5136595642);
    System.Console.WriteLine($"El numero de Marco {agenda["levi el muerto"]}");
}
