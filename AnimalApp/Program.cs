using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    public interface IAnimal
    {
        long Population { get; set; }
        short Weight { get; set; }
        short Height { get; set; }
        bool Extinct();
    }
    abstract class Ostracoda : IAnimal
    {
        public abstract long Population { get; set; }
        public short Weight { get; set; }
        public short Height { get; set; }
        public abstract bool Extinct();
    }
    abstract class Insecta : IAnimal
    {
        public abstract long Population { get; set; }
        public short Weight { get; set; }
        public short Height { get; set; }
        public abstract bool Extinct();
    }
    abstract class Mammalia : IAnimal
    {
        public abstract long Population { get; set; }
        public short Weight { get; set; }
        public short Height { get; set; }
        public abstract bool Extinct();
    }

    class Human : Mammalia
    {
        static long population;
        public override long  Population
        {
            get { return population; }
            set { population = value; }
        }
        public Human(short weight, short height, long population)
        {
            if(Population==0)
                Population = population;
            this.Weight = weight;
            this.Height = height;
        }
        public override bool Extinct()
        {
            if (Population > 1000000)
                return true;
            else return false;
        }
    }
    class Bear : Mammalia
    {
        static long population;
        public override long Population
        {
            get { return population; }
            set { population = value; }
        }
        public Bear(short weight, short height, long population=0)
        {
            if (Population == 0)
                Population = population;
            this.Weight = weight;
            this.Height = height;
        }
        public override bool Extinct()
        {
            if (Population > 200000)
                return true;
            else return false;
        }
    }

    class LucanusСervus : Insecta
    {
        static long population;
        public override long Population
        {
            get { return population; }
            set { population = value; }
        }
        public LucanusСervus(short weight, short height, long population=0)
        {
            if (Population == 0)
                Population = population;
            this.Weight = weight;
            this.Height = height;
        }
        public override bool Extinct()
        {
            if (Population > 2000000)
                return true;
            else return false;
        }
    }
    class Geotrupidae : Insecta
    {
        static long population;
        public override long Population
        {
            get { return population; }
            set { population = value; }
        }
        public Geotrupidae(short weight, short height, long population=0)
        {
            if (Population == 0)
                Population = population;
            this.Weight = weight;
            this.Height = height;
        }
        public override bool Extinct()
        {
            if (Population > 1500000)
                return true;
            else return false;
        }
    }

    class ArcaZebra : Ostracoda
    {
        static long population;
        public override long Population
        {
            get { return population; }
            set { population = value; }
        }
        public ArcaZebra(short weight, short height, long population=0)
        {
            if (Population == 0)
                Population = population;
            this.Weight = weight;
            this.Height = height;
        }
        public override bool Extinct()
        {
            if (Population > 900000)
                return true;
            else return false;
        }
    }
    class BursaBubo : Ostracoda
    {
        static long population;
        public override long Population
        {
            get { return population; }
            set { population = value; }
        }
        public BursaBubo(short weight, short height, long population=0)
        {
            if (Population == 0)
                Population = population;
            this.Weight = weight;
            this.Height = height;
        }
        public override bool Extinct()
        {
            if (Population > 950000)
                return true;
            else return false;
        }
    }

    class Group<T> where T: IAnimal
    {
        private List<T> animals = new List<T>();
        public void Push(T pushed)
        {
            animals.Add(pushed);
        }
        public T Pop()
        {
            return animals[animals.Count-1];
        }
        public void Print()
        {
            foreach (T t in animals)
                Console.WriteLine("Famaly: {0}, Population: {1}, Weight: {2}, Height: {3}", t.GetType().ToString(), t.Population, t.Weight, t.Height );
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Group<Insecta> insectas = new Group<Insecta>();
            Group<Ostracoda> ostracodas = new Group<Ostracoda>();
            Group<Mammalia> mammalia = new Group<Mammalia>();

            for (byte i =0; i<10; i++)
            {
                if (i % 2 == 0)
                {
                    insectas.Push(new LucanusСervus(1, 10, 1000000));
                    mammalia.Push(new Human(100, 180, 3000000));
                }
                else
                {
                    insectas.Push(new Geotrupidae(3, 12, 600000));
                    mammalia.Push(new Bear(160, 90, 100000));
                }
            }
            insectas.Push(new LucanusСervus(5, 10, 1000001));
            mammalia.Push(new Bear(161, 90));

            insectas.Print();
            mammalia.Print();

            Console.ReadLine();
        }
    }
}
