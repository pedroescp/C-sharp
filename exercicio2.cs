using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        /* Instruções
        
        Ao realizar a leitura de cada uma das palavras, o programa deverá verificar qual delas é a menor e qual delas é a maior (ordem alfabética, e não pelo tamanho).
        Após realizar a leitura de todas as palavras, o programa deverá imprimir a menor com todas as letras minúsculas, e a maior com todas as letras maiúsculas.
        Exemplo:
        Usuário informa o número 4
        O programa faz a leitura das palavras:
        Maria, Ana, Paula, Bianca
        O programa imprime a menor e a maior:
        ana
        PAULA*/

        // Console.WriteLine("bbbbbbbbbbbbbbbb".CompareTo("AAAAAAAAAA"));// maior
        // Console.WriteLine("AAAAAA".CompareTo("BBBBBBBBB")); //menor
        // Console.WriteLine("AAAAAA".CompareTo("AAAAAA")); //igual
        
        
        
        Console.WriteLine("Digite quantidade de vezes a ser repetida");
        Int32 numero = Convert.ToInt32(Console.ReadLine()); //recebe numero

        string menor = "zzzz";
        string maior = "aaaa";
        
        if (numero > 0)
        {

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("Digite a palavra : " + i);
                string palavra = Convert.ToString(Console.ReadLine());//recebe palavra

                if (palavra.CompareTo(maior) == 1)
                {
                    maior = palavra;
                }

                if (palavra.CompareTo(menor) == -1)
                {
                    menor = palavra;
                }
            }

            Console.WriteLine($"A maior palavra é: {maior.ToUpper()}");
            Console.WriteLine($"A menor palavra é: {menor.ToLower()}");
        }
        else
        {
            Console.WriteLine("Escreva um numero positivo");
        }


    }
}