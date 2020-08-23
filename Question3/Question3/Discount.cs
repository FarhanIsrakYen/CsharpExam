using System;
using System.Collections.Generic;
using System.Text;

namespace Question3
{
    abstract class Discount
    {
        double OriginalPrice { get; set; }
        double DiscountAmount { get; set; }
        public abstract void CalculateDiscount();        
    }
}
