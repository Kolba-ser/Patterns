using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    public abstract class BurgerBuilder<T> where T : Burger
    {

        public abstract T Build();
    }
}
