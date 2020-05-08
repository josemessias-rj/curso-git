using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.NetCore
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public double IncreaseSalary(double salary, double percentual)
        {
            Salary += (salary * percentual) / 100; 
            return Salary;
        }
    }

}
