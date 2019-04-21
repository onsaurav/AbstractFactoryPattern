using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactoryPatternItems
{
    abstract class SoftwareDevelopmentCompany
    {
        public abstract KeyProduct CreateKeyProduct();
        public abstract SubProduct CreateSubProduct();
    }
}
