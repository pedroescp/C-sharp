using System;

namespace DecisionMaking
{
    class Program
    {
        
        static Int32 LerInteiroPositivo(String mensagem)
        {
            Int32 numero = 0;
            Boolean lerNumero = true;

            Console.WriteLine(mensagem);

            do
            {
                try
                {
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero > 0)
                    {
                        lerNumero = false;
                    }
                    else
                    {
                        Console.WriteLine("Favor informar um número inteiro positivo");
                    }
                }
                catch
                {
                    Console.WriteLine("Valor inválido, favor informar um número inteiro positivo");
                }
            } while (lerNumero == true);

            return numero;
        }
        
        
        static Int32 lerMenu(String mensagem)
        {
            Console.WriteLine(mensagem);

            Int32 lermatricula = -1;


            string aluno = "";
            Int32 contador = 1;
            string matricula = "";


            do
            {
                try
                {
                    Console.WriteLine("1 -Matricular Aluno\n2 -Excluir Aluno\n3 -Procurar Aluno\n4 -Sair\n");
                    lermatricula = Convert.ToInt32(Console.ReadLine());

                    if (lermatricula > 0)
                    {
                        switch (lermatricula)
                        {
                            case 1:

                                return lermatricula;

                                break;
                            case 2:
                                Console.WriteLine("Aluno excluído com sucesso");
                                break;
                            case 3:
                                Console.WriteLine("Aluno encontrado com sucesso");
                                break;
                            case 4:
                                Console.WriteLine("Sair do sistema adios :')");
                                break;
                            default:
                                Console.WriteLine("Opção invalida");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Favor informar um número inteiro positivo");
                    }
                }
                catch
                {
                    Console.WriteLine("Valor inválido, favor informar um número inteiro positivo");
                }
            } while (lermatricula != 4);

            return lermatricula;
        }

        static void Main(string[] args)
        {
            string aluno = "";
            string matricula = "";


            Int32 alunovalida = LerInteiroPositivo("Quantos alunos deseja inserir");
            Int32 inutil = lerMenu("");

            for (int i = 0; i < alunovalida; i++)
            {
               
                    Console.WriteLine("Digite o nome do aluno");
                    aluno = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Digite matricula do aluno");
                    matricula = Convert.ToString(Console.ReadLine());

                    aluno = aluno + "-";
                    matricula = matricula + "-";
            }

        }
    }
}