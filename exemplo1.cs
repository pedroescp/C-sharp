using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        /*Instruções
        Faça um programa em C# que lê um número inteiro positivo, que representa a quantidade de palavras que serão lidas.
        Ao realizar a leitura de cada uma das palavras, o sistema deverá concatená-las utilizando o operador de soma, e através do StringBuilder.
        O programa deverá imprimir as palavras separadas por vírgula (não imprimir uma vírgula no final).
        Exemplo:
        Usuário informa o número 6
        Sistema faz a leitura de seis palavras
        Sistema imprime as palavras:
        Palavra 1, Palavra 2, Palavra 3, Palavra 4, Palavra 5, Palavra 6*/

        StringBuilder frase = new StringBuilder();
        
        Console.WriteLine("Digite quantidade de vezes a ser repetida");
        Int32 numero = Convert.ToInt32(Console.ReadLine()); //recebe numero
        
        if (numero > 0)
        {

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("Digite a palavra : " + i);
                string palavra = Convert.ToString(Console.ReadLine());//recebe palavra

                if (numero-1   ==  i )
                {
                    frase.Append(palavra);
                    break;
                }
                
                frase.Append($"{palavra}, ");
            }
            
            Console.WriteLine(frase.ToString());
            
        }
        else
        {
            Console.WriteLine("Escreva um numero positivo");
        }


    }
}