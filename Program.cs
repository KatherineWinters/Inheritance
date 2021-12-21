using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var robin = new Bird
            {
                Fly = true,
                EatsFish = false,
                HasWings = true,
                HasFeathers = true
            };

            Console.WriteLine("Do you think these things are true or false about a Robin?");
            Console.WriteLine($"Robins can fly: {robin.Fly}\n" +
                              $"Robins eat fish: {robin.EatsFish}\n" +
                              $"Robins have wings: {robin.HasWings}\n" +
                              $"Robins have feathers: {robin.HasFeathers}\n");



            var lizard = new Reptiles
            {
                HasScales = true,
                HasTail = true,
                ColdBlooded = true,
                ActiveAtNight = true,
            };

            Console.WriteLine("True or False. How many can you get right?");
            Console.WriteLine($"A lizard has scales:{lizard.HasScales}\n" +
                              $"A lizard has a tail: {lizard.HasTail}\n" +
                              $"A lizard is coldblooded: {lizard.ColdBlooded}\n" +
                              $"A lizard is active at night: {lizard.ActiveAtNight}\n");

        }
    }
}
