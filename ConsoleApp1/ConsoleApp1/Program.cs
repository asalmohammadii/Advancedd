using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface Iloperations
    {
        void Add();
        void Subtract();
    }
    class Calculator : Iloperations
    {
        public void Add()
        {

        }
        public void Subtract()
        {

        }
    }
    abstract class Vehicle
    {
       public abstract void Move();
    }
    class Car:Vehicle
    {
        public override void Move()
        {
        }
    }
    class Bicycle : Vehicle
    {
        public override void Move()
        {
        }
    }

}

