using System;

class Program {
    static void Main(string[] args) {
        int N = 10; // Cambiar por el tamaño deseado del vector
        int[] vector = new int[N];
        
        for (int i = 0; i < N; i++) {
            Console.Write("Ingrese el valor en la posición {0}: ", i);
            vector[i] = int.Parse(Console.ReadLine());
        }

        int contador1 = 0; // 0-5
        int contador2 = 0; // 6-10
        int contador3 = 0; // 11-15
        int contador4 = 0; // 16-20
        
        for (int i = 0; i < N; i++) {
            if (vector[i] >= 0 && vector[i] <= 5) {
                contador1++;
            } else if (vector[i] >= 6 && vector[i] <= 10) {
                contador2++;
            } else if (vector[i] >= 11 && vector[i] <= 15) {
                contador3++;
            } else if (vector[i] >= 16 && vector[i] <= 20) {
                contador4++;
            }
        }


        Console.WriteLine("Cantidad de valores en el rango 0-5: " + contador1);
        Console.WriteLine("Cantidad de valores en el rango 6-10: " + contador2);
        Console.WriteLine("Cantidad de valores en el rango 11-15: " + contador3);
        Console.WriteLine("Cantidad de valores en el rango 16-20: " + contador4);

        Console.ReadKey();
    }
}
