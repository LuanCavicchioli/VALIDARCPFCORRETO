using System;

namespace ValidarCPF
{
    internal class ValidarCPF
    {
        static void Main(string[] args)
        {
            bool validaCpf = false;

            while (!validaCpf)
            {
                Console.Write("Digite o CPF: ");
                string cpf = Console.ReadLine();

                if (!ValidateInput(cpf))
                {
                    Console.WriteLine("//////////////////////////////");
                    Console.WriteLine("Apenas números são permitidos!");
                    Console.WriteLine("//////////////////////////////");
                }
                else
                {
                    validaCpf = true;

                    int[] mult = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                    int[] mult1 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                    int dig1 = 0;
                    int dig2 = 0;
                    int[] x = new int[11];
                    int soma = 0, soma1 = 0;

                    for (int i = 0; i < 11; i++)
                    {
                        x[i] = int.Parse(cpf[i].ToString());
                    }

                    for (int i = 0; i < 9; i++)
                    {
                        soma += x[i] * mult[i];
                        dig1 = (soma * 10) % 11;
                        if (dig1 == 10 || dig1 == 11)
                        {
                            dig1 = 0;
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        soma1 += x[i] * mult1[i];
                        dig2 = (soma1 * 10) % 11;
                        if (dig2 == 10 || dig2 == 11)
                        {
                            dig2 = 0;
                        }
                    }
                    Console.Clear();
                    if (dig1 != x[9] || dig2 != x[10])
                    {
                        Console.WriteLine("/////////////////");
                        Console.WriteLine("   CPF INVÁLIDO!   ");
                        Console.WriteLine("/////////////////");
                        Console.WriteLine("O CPF DIGITADO FOI:\n" + cpf);
                    }
                    else
                    {
                        Console.WriteLine("/////////////////");
                        Console.WriteLine("   CPF VÁLIDO!   ");
                        Console.WriteLine("/////////////////");
                        Console.WriteLine("\nO CPF DIGITADO FOI:\n" + cpf);
                    }
                }
            }
        }

        static bool ValidateInput(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
