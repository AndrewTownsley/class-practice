using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassPractice.Math;
using ClassPractice.Arrays;



namespace ClassPractice
{

    class Program
    {
      static void Main(string[] args)
        {
            var Diona = new Person();
            Diona.firstName = "Diona";
            Diona.lastName = "Townsley";
            Diona.Introduce();

            Calculator calculator = new Calculator();
            var sum = calculator.Add(3, 7);
            Console.WriteLine(sum.ToString());

        }
    }
}