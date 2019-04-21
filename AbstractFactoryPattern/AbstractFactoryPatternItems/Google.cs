using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactoryPatternItems
{
    class Google : SoftwareDevelopmentCompany 
    {
        public override KeyProduct CreateKeyProduct()
        {
            return new SearchEngine();
        }

        public override SubProduct CreateSubProduct()
        {
            return new Addsence();
        }
    }
}
