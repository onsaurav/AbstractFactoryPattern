using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactoryPatternItems
{
    class Microsoft1: SoftwareDevelopmentCompany 
    {
        public override KeyProduct CreateKeyProduct()
        {
            return new Windows();
        }

        public override SubProduct CreateSubProduct()
        {
            return new DevelopmentsTools();
        }
    }
}
