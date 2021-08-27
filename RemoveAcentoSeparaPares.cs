using System;
using System.Text;


public class Program
{
    public void acento()
    {
       
    }

    public static void Main()
    {


        Console.WriteLine("Digite numero inteiro e positivo");
        Int32 numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0)
        {


            string frase = "", palavra1, palavra2;
            

            for (int i = 0; i < numero; i++)
            {
                palavra1 = Console.ReadLine().ToLower();
                palavra2 = Console.ReadLine().ToLower();

                frase = $"{frase} {palavra1} {palavra2}";
                
                 
                Console.WriteLine("------------------------------");
            }
            
            String[] acentos = { "á", "é", "í", "ó", "ú", "à", "è", "ì", "ò", "ù", "ä", "ë", "ï", "ö", "ü", "â", "ê", "î", "ô", "û" };
            String[] semAcentos = { "a", "e", "i", "o", "u", "a", "e", "i", "o", "u", "a", "e", "i", "o", "u", "a", "e", "i", "o", "u" };
            
            for (int a = 0; a <acentos.Length ; a++)
            {
                frase = frase.Replace(acentos[a], semAcentos[a]);
            }

            

            String[] arrfrase = frase.Split(' ');
            
            for (int i = 1; i <= arrfrase.Length; i = i +2)
            {
                Int32 j = i + 1;

                if (j > arrfrase.Length) 
                {
                    break;
                }
                if (arrfrase[i].CompareTo(arrfrase[j])== 0)
                {
                    Console.WriteLine($"{arrfrase[i]} {arrfrase[j]} igual");
                }
                else
                {
                    Console.WriteLine($"{arrfrase[i]} {arrfrase[j]} diferente" );
                }
                
            }
        }
        
        else{
            Console.WriteLine("Digite um numero inteiro e positivo");
        }
        
        
    
    }

}