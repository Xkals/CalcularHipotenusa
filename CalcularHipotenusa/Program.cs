//Dados los catetos de un triángulo rectángulo, calcular su hipotenusa.



class CalcularHipotenusa   
{
    static void Main()
    {
       double cateto1, cateto2, hipotenusa;

        Console.WriteLine("Ingresa la longitud del cateto a: ");
        if (double.TryParse(Console.ReadLine(), out cateto1))
        {
            Console.WriteLine("Ingresa la longitud del cateto b: ");
            if (double.TryParse(Console.ReadLine(), out cateto2))
            {
                // Calcula la hipotenusa
                hipotenusa = Math.Sqrt(cateto1 * cateto1 + cateto2 * cateto2);

                Console.WriteLine($"La hipotenusa del triángulo rectángulo es: {hipotenusa}");
            }
            else
            {
                Console.WriteLine("Entrada inválida para el cateto b.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida para el cateto a.");
        }
    }
}
