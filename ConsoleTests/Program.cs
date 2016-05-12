using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.ImplementedClass;
using Application.LogicLayer.ImplementedClass.Models.PersonModel;
using Food.FoodDataParser;
using Newtonsoft.Json;


namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonRequirements person = new PersonRequirements(Sex.Male, 14, 70, 1.95);

            Console.WriteLine(person.CaloriesRequirement);


            Console.WriteLine("done");

            Console.ReadKey();
        }
    }
}
