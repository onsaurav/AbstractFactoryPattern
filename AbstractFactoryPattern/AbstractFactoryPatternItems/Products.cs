using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactoryPatternItems
{
    class Products
    {
        private KeyProduct _KeyProduct;
        private SubProduct _SubProduct;

        public Products(SoftwareDevelopmentCompany _SoftwareDevelopmentCompany)
        {
            _KeyProduct = _SoftwareDevelopmentCompany.CreateKeyProduct();
            _SubProduct = _SoftwareDevelopmentCompany.CreateSubProduct();
        }

        public string ShowStatus()
        {
            return _KeyProduct.PlatformOf(_SubProduct);
        }
    }
}
