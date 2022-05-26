using System;
using System.Collections.Generic;

namespace AnimalActions
{
    public interface IAnimal
    {
        void Eat();
        void Swim();
        void Fly();
        void GetAnimalSound();
    }
    public abstract class Animal
    {
        public abstract string EatAction { get; }
        public abstract string SwimAction { get; }
        public abstract string FlyAction { get; }
        public abstract string Sound { get; }
        public void Action(string action)
        {
            try
            {
                Console.WriteLine(action);
            }
            catch (Exception e)
            {
                HandleError(e);
            }
        }

        public void Eat()
        {
            try
            {
                Action(EatAction);
            }
            catch (Exception e)
            {
                HandleError(e);
            }
        }
        public void Fly()
        {
            try
            {
                Action(FlyAction);
            }
            catch (Exception e)
            {
                HandleError(e);
            }
        }
        public void Swim()
        {
            try
            {
                Action(SwimAction);
            }
            catch (Exception e)
            {
                HandleError(e);
            }
        }
        public void GetAnimalSound()
        {
            try
            {
                Action(Sound);
            }
            catch (Exception e)
            {
                HandleError(e);
            }
        }

        private void HandleError(Exception e) => Action($"Error: {e.Message}");
    }

    public class Parrot : Animal, IAnimal
    {
        public override string EatAction { get => "Pecks at a cracker."; }
        public override string SwimAction { get => throw new NotImplementedException("Parrots cannot swim."); }
        public override string FlyAction { get => "Spreads it's wings and flaps away."; }
        public override string Sound { get => "Polly wants a cracker!"; }
    }

    public class Penguin : Animal, IAnimal
    {
        public override string EatAction { get => "Swallows a fish whole."; }
        public override string SwimAction { get => "Glides gracefully through the water"; }
        public override string FlyAction { get => throw new NotImplementedException("Penguins cannot fly."); }
        public override string Sound { get => "Honk!"; }
    }

    public class Pterodactyl : Animal, IAnimal
    {
        public override string EatAction { get => "Grabs a small dinosaur with its powerful beak."; }
        public override string SwimAction { get => throw new NotImplementedException("Pterodactyls don't swim."); }
        public override string FlyAction { get => "Soars majestically through the sky"; }
        public override string Sound { get => "CAW!"; }
    }

    public class Duck : Animal, IAnimal
    {
        public override string EatAction { get => "Gobbles up stale bread."; }
        public override string SwimAction { get => "Paddles swiftly on the surface of a lake"; }
        public override string FlyAction { get => "Flaps it's wings and flies high"; }
        public override string Sound { get => "Quack!"; }
    }

    internal class Joseph_Roberts_AnimalActions
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal> { new Parrot(), new Penguin(), new Pterodactyl(), new Duck() };
            foreach (IAnimal animal in animals)
            {
                animal.Eat();
                animal.Fly();
                animal.Swim();
                animal.GetAnimalSound();

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
