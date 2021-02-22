using System;
using System.Collections.Generic;
using System.Text;

namespace GameExercise
{
    public class DiscountManager
    {
        public void Update(Discount discount)
        {
            Console.WriteLine(discount.DiscountName + " güncellendi");

        }

        public void Delete(Discount discount)
        {
            Console.WriteLine(discount.DiscountName + " silindi");

        }

        public void Add(Discount discount)
        {
            Console.WriteLine(discount.DiscountName + " eklendi");

        }
    }
}
