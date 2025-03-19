using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // This is the Base Component that defines operations that can be altered by decorators.
    public interface ICar
    {
        ICar ManufactureCar();
    }
}
