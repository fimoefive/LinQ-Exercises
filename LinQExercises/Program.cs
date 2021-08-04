using System;
using System.Collections.Generic;
using System.Linq;
using LinQExercises.Animals;

namespace LinQExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinQ Exercises");

            // LINQ
            // LINQ Sorting Operations

            



            List<int> numbers = new List<int>() { 8, 3, 11, 23, 9, 2, 7, 300 };

            // Max, Sum, Min, Average, Count

            var maxNumber = numbers.Max();
            Console.WriteLine(maxNumber);

            var sumofNumbers = numbers.Sum();
            Console.WriteLine(sumofNumbers);

            var averageNumber = numbers.Average();
            Console.WriteLine(averageNumber);

            var count = numbers.Count();
            Console.WriteLine(count);


            var biggerNumbers = numbers.Where(numbers => numbers > 9);

            Console.WriteLine($"biggerNumbers {string.Join(',', biggerNumbers)}");


            var biggerNumber2 = numbers.Select(num => num * 12);
            Console.WriteLine($"biggerNumbers2 {string.Join(',', biggerNumber2)}");

            var firstNumber = numbers.Last();

            // First matching item

            var firstMatchingNumber = numbers.Where(num => num > 9).First();

            var firstMatchingNumber2 = numbers.First(numbers => numbers > 9);

            Console.WriteLine(firstMatchingNumber);
            Console.WriteLine(firstMatchingNumber2);

            // Quantifier Operations
            // returns a boolean
            // all, any, contains

            var allNumbers = numbers.All(c => c > 5);
            Console.WriteLine(allNumbers);

            var anyNumbers = numbers.Any(c => c < 5);
            Console.WriteLine(anyNumbers);

            var containsNumber = numbers.Contains(7) || numbers.Contains(3);
            Console.WriteLine(containsNumber);


            //List<int> numbers = new List<int>() { 8, 3, 11, 23, 9, 2, 7, 300 };
            List<int> badNumbers = new List<int>() { 19, 11, 3, 9 };



            var firstThreeNumbersAndTheSixth = numbers.Take(3).Concat(numbers.Skip(5).Take(1));
            Console.WriteLine($"firstThreeNumbersAndTheSixth { String.Join(',', firstThreeNumbersAndTheSixth)}");

            //var animals = new List<Animal>();
            //{
            //    new Animal {Type = "Pikachu", HeightInInches = 24. WeightInPounds = 10},
            //    new Animal {Type = "Chazard", HeightInInches = 30, WeightInPounds = 250},
            //    new Animal {Type = "Bulbasaur", HeightInInches = 12, WeightInPounds = 450},
            //    new Animal {Type = "JigglyPuff", HeightInInches = 9, WeightInPounds = 5 }
            //};

            var pikachu = new Animal("Electric", 24, 10, "Pikachu");
            var charzar = new Animal("Water, Electric, Rock", 72, 250, "Charizar");
            var bulbasaur = new Animal("Grass, Poison", 12, 450, "Bulbasaur");
            var jigglyPuff = new Animal("Poison, Steel", 9, 5, "JigglyPuff");

            var AnimalList = new List<Animal> { pikachu, charzar, bulbasaur, jigglyPuff };


            //var animalsThatStartWithC = animals.Where(animal => animal.Type.StartsWith('C'));
            Console.WriteLine($"animalsThatStartWithC");

            


            // group a collection by a given key (based on a function)



        }
    }
}
