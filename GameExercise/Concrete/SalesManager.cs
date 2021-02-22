using System;
using System.Collections.Generic;
using System.Text;

namespace GameExercise.Concrete
{
    public class SalesManager
    {
        public void SalesWithDiscount(Game game,Gamer gamer,Discount discount)
        {
            double priceWithDiscount = game.GamePrice - (game.GamePrice * discount.DiscountRate);
            Console.WriteLine("Tebrikler!! " + discount.DiscountName + " kampanyasından %" + discount.DiscountRate * 100 + " indirim kazandınız");
            Console.WriteLine(gamer.FirstName + ", " + game.GameName + " oyununu " + priceWithDiscount+"TL'ye satın aldı");

        }

        public void Sales(Game game,Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + ", " + game.GameName + " oyununu " + game.GamePrice+"TL'ye satın aldı");

        }
    }
}
