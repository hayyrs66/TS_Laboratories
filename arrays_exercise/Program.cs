using System;

class Program {
    static void Main() {
        
        int[] Valores = { 85, 96, 65, 70, 55, 45, 62, 95, 74, 100, 74, 83, 93 };
           
        int[] primos = new int[Valores.Length];
        int countPrimos = 0;
        for (int i = 0; i < Valores.Length; i++) {
            if (esPrimo(Valores[i])) {
                primos[countPrimos] = i;
                countPrimos++;
            }
        }
        Array.Resize(ref primos, countPrimos);
        Console.WriteLine("Posiciones de los valores primos: " + string.Join(", ", primos));
                
        int[] multiplosDe5 = new int[Valores.Length];
        int countMultiplos = 0;
        for (int i = 0; i < Valores.Length; i++) {
            if (Valores[i] % 5 == 0) {
                multiplosDe5[countMultiplos] = i;
                countMultiplos++;
            }
        }
        Array.Resize(ref multiplosDe5, countMultiplos);
        Console.WriteLine("Posiciones de los valores múltiplos de 5: " + string.Join(", ", multiplosDe5));
               
        int menor = Valores[0];
        for (int i = 1; i < Valores.Length; i++) {
            if (Valores[i] < menor) {
                menor = Valores[i];
            }
        }
        Console.WriteLine("El menor valor del arreglo es: " + menor);
    }
       
    static bool esPrimo(int num) {
        if (num < 2) {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++) {
            if (num % i == 0) {
                return false;
            }
        }
        return true;
    }
}

