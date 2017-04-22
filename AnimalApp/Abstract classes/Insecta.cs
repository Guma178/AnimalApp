using AnimalApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp.Abstract_classes
{
    abstract class Insecta : IAnimal
    {
        public abstract long Population { get; set; }
        public short Weight { get; set; }
        public short Height { get; set; }
        public abstract bool Extinct();
    }
}
