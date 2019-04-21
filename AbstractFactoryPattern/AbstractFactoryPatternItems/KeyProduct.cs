using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactoryPatternItems
{
    abstract class KeyProduct
    {
        public abstract string PlatformOf(SubProduct _subPro);
    }
}
