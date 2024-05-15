using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    class ShippingService
    {
        double UnitPrice;

        public ShippingService(double UnitPrice)
        {
            this.UnitPrice = UnitPrice;
        }

        public double CalculateShippingFee(IShipable product)
        {
            return product.Weight * UnitPrice;
        }
    }
}
