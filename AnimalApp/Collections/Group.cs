using AnimalApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp.Collections
{
    class Group<T> where T : IAnimal
    {
        private List<T> animals = new List<T>();
        public void Push(T pushed)
        {
            animals.Add(pushed);
        }
        public T Pop()
        {
            return animals[animals.Count - 1];
        }
        public void Print()
        {
            foreach (T t in animals)
                Console.WriteLine("Famaly: {0}, Population: {1}, Weight: {2}, Height: {3}", t.GetType().ToString(), t.Population, t.Weight, t.Height);
        }
    }
}
