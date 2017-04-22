using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp.Interfaces
{
    public interface IAnimal
    {
        long Population { get; set; }
        short Weight { get; set; }
        short Height { get; set; }
        bool Extinct();
    }
}
