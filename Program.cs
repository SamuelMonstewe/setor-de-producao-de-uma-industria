using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex10Pag73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] salario = { 250.00, 350.00, 450.00, 550.00, 700.00, 900.00, 1300.00 };
            int ClasseDoFuncionario;
            int MaiorClasseDeFuncionarios = int.MinValue;
            int[] TotalFuncionariosEmCadaClasse = new int[7];
            string NomeDoFuncionario;

            for (int i = 0; i < salario.Length; i++)
            {
                Console.Write("Digite seu nome: ");
                NomeDoFuncionario = Console.ReadLine();
                Console.Write("Digite sua classe: ");
                ClasseDoFuncionario = int.Parse(Console.ReadLine());

                Console.WriteLine(NomeDoFuncionario + " recebe " + salario[ClasseDoFuncionario - 1] + "R$"); //subtrai a classe para encontrar o salário correto no indice

                TotalFuncionariosEmCadaClasse[ClasseDoFuncionario - 1]++;
            }

            for (int classe = 0; classe < salario.Length; classe++)
            {
                if (TotalFuncionariosEmCadaClasse[classe] > MaiorClasseDeFuncionarios)
                {

                    MaiorClasseDeFuncionarios = classe + 1; // adicionei +1 para exibir o numero da classe correta

                }

                Console.WriteLine(" A " + (classe + 1) + "º classe " + "possui " + TotalFuncionariosEmCadaClasse[classe] + " funcionário(s) ");

            }

            Console.WriteLine("A classe que possui mais funcionários é a: " + MaiorClasseDeFuncionarios + "º");
            Console.ReadKey();



        }
    }
}
