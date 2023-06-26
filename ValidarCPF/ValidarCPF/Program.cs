using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ValidarCPF
{
    internal class ValidarCPF
    {
        static void Main(string[] args)
        {   
            string cpf;
            int[] mult = {10,9,8,7,6,5,4,3,2 };
            int[] mult1 = {11,10,9,8,7,6,5,4,3,2};
            int dig1 = 0;
            int dig2 = 0;
            int i;
            char[] v = new char[11];
            int[] x = new int[11];
            int soma = 0, soma1 = 0;



            Console.Write("Digite o cpf : ");
            cpf = Console.ReadLine();

            //Leitura do cpf digitado, por ser inteiro teve que converter para string
            for (i = 0 ;i < 11; i++)
            {
                v[i] = cpf[i];
                x[i] = Convert.ToInt32(v[i].ToString());
            }
            //Calculo primeiro digito
            for(i = 0 ;i < 9; i++)
            {
                soma += x[i] * mult[i];
                dig1 = (soma * 10) % 11;
                if(dig1 == 10 || dig1 == 11)
                {
                    dig1 = 0;
                }
            }
            //Calculo segundo digito
            for (i = 0; i < 10; i++)
            {
                soma1 += x[i] * mult1[i];
                dig2 = (soma1 * 10) % 11;
                if(dig2 == 10 || dig2 == 11)
                {
                    dig2 = 0;
                }
            }
            //Onde ira validar se o primeiro digito é igual a 10 é se o segundo digito vericiado é igual a 9, imprimindo a resposta
            if(dig1 != x[9] || dig2 != x[10]) 
                {
                Console.WriteLine("/////////////////");
                Console.WriteLine("   CPF INVALIDO!   ");
                Console.WriteLine("/////////////////");
                Console.WriteLine("O CPF DIGITADO FOI:" +"\n"+cpf);
            }
            else
                {
                Console.WriteLine("/////////////////");
                Console.WriteLine("   CPF VALIDO!   ");
                Console.WriteLine("/////////////////");
                Console.WriteLine("\nO CPF DIGITADO FOI:" + "\n"+cpf);
                }
        }
    }
}
