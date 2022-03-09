using System;

namespace Facec.Aula._08._03._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conversão Data

            //Console.WriteLine("Digite a sua data de aniversário: ");
            //string dataAniversario = Console.ReadLine();

            //DateTime.TryParse(dataAniversario,
            //    out DateTime dataAniversarioFormatada);

            //Console.WriteLine("Sua idade é de " +
            //    $"{DateTime.Today.Year - dataAniversarioFormatada.Year} anos!");

            //Console.ReadLine();

            #endregion Conversão data

            #region Estruturas de Condição

            //Console.WriteLine("Informe o número do bicho: ");
            //int.TryParse(Console.ReadLine(), out int bicho);

            //if (bicho == 1)
            //    Console.WriteLine("Avestrus!");
            //else if (bicho == 2)
            //    Console.WriteLine("Águia");
            //else
            //    Console.WriteLine("Não configurado! Contate o suporte técnico.");

            //string mensagem = bicho == 1 ? "Avestrus!" : "Não identificado!";
            //Console.WriteLine(mensagem);

            //switch (bicho)
            //{
            //    case 1:
            //    case 10:
            //        Console.WriteLine("Avestrus!");
            //        break;
            //    case 2:
            //        Console.WriteLine("Águia!");
            //        break;
            //    default:
            //        Console.WriteLine("Não configurado! Contate o suporte técnico.");
            //        break;
            //}

            //string mensagem = bicho switch
            //{
            //    1 => "Avestrus!",
            //    2 => "Águia!",
            //    _ => "Não configurado! Contate o suporte técnico!"
            //};

            //Console.WriteLine(mensagem);

            //Console.ReadLine();

            #endregion Estruturas de Condição

            #region Estruturas de repetição

            //for (int i = 0; i <= 50; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int count = 0;

            //while (count <= 50)
            //{
            //    Console.WriteLine(count);
            //    count++;
            //}

            //int count = 51;

            //do
            //{
            //    Console.WriteLine(count);
            //    count++;
            //} while (count <= 50);

            //Console.WriteLine("Digite o seu nome");
            //var nome = Console.ReadLine();

            //foreach (char letra in nome)
            //{
            //    Console.WriteLine(letra);
            //}

            //Console.ReadKey();

            #endregion Estruturas de repetição

            #region Instrução de manipulação de exceções

            try
            {
                Console.WriteLine("Informe o número do bicho: ");
                int bicho = int.Parse(Console.ReadLine());

                if (bicho == 1)
                    Console.WriteLine("Avestrus!");
                else if (bicho == 2)
                    Console.WriteLine("Águia");
                else
                    throw new Exception("Não configurado!" +
                        " Contate o suporte técnico.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            #endregion Instrução de manipulação de exceções
        }
    }
}
