using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactoryPatternItems
{
    class Windows : KeyProduct
    {
        public override string PlatformOf(SubProduct _subPro)
        {
            return this.GetType().Name + " Platform Of " + _subPro.GetType().Name;
        }
    }
}
