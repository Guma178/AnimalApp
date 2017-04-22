using AnimalApp.Abstract_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp.Classes
{
    class Geotrupidae : Insecta
    {
        static long population;
        public override long Population
        {
            get { return population; }
            set { population = value; }
        }
        public Geotrupidae(short weight, short height, long population = 0)
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
}
