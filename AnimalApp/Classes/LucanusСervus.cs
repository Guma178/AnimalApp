using AnimalApp.Abstract_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp.Classes
{
    class LucanusСervus : Insecta
    {
        static long population;
        public override long Population
        {
            get { return population; }
            set { population = value; }
        }
        public LucanusСervus(short weight, short height, long population = 0)
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
}
