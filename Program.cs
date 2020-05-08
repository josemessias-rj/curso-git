using System;
using System.Collections.Generic;
using System.Linq;

namespace Curso.NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de funcionarios: ");
            int n = int.Parse(Console.ReadLine());            

            List<Funcionario> funcionarioList = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                Funcionario funcionario = new Funcionario();

                Console.Write("Informe o Id do funcionário: ");
                funcionario.Id = int.Parse(Console.ReadLine());

                Console.Write("Informe o nome do funcionário: ");
                funcionario.Name = Console.ReadLine();

                Console.Write("Informe o salário do funcionário: ");
                funcionario.Salary = double.Parse(Console.ReadLine());

                funcionarioList.Add(funcionario);
            }

            Console.Write("Informe o código do funcionário a receber promoção salarial: ");
            int id = int.Parse(Console.ReadLine());

            if (funcionarioList.Find(x => x.Id == id) != null)
            {
                Console.Write("Informe o percentual de aumento a ser efetuado: ");
                double perc = double.Parse(Console.ReadLine());

                Funcionario func = funcionarioList.Find(x => x.Id == id);
                func.IncreaseSalary(func.Salary, perc);
            }
            else
            {
                Console.WriteLine("Id inexistente.");
            }


            Console.WriteLine("Lista de Funcionário");
            foreach (Funcionario list in funcionarioList)
            {
                Console.WriteLine($"{list.Id}, {list.Name}, {list.Salary}");
            }
        }
    }
}
