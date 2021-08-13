using System;
					
public class Program
{
    public static void Main()
    {
        System.Console.WriteLine("digite o numero para repetidor");
        Int32 contador = Convert.ToInt32(Console.ReadLine());
        
        int fatorial = 1;
        for (int repetidor = 1; repetidor <= contador; repetidor++)
        {
            fatorial*=repetidor;
            Console.WriteLine(repetidor+" fatorial= "+fatorial);
        }
    }
}