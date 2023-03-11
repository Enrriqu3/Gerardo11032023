using System;

class Datos {
    static void Main(string[] args) {
        Console.Write("Ingrese un número entero: ");
        int h = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < h; i++) {
            for (int j = 0; j <= i; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
