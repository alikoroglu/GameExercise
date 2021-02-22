using GameExercise.Concrete;
using System;

namespace GameExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game() { GameId = 001,
                GamePrice = 150.99, GameName = "Fifa 2015" };
            Gamer gamer = new Gamer() { FirstName = "Ali",
                LastName = "Can", BirtDate = new DateTime(1997, 10, 05), NationalID = "31421225482" };
            Discount discount = new Discount() { DiscountId = 001, DiscountName = "Şubat Fırsatları", DiscountRate = 0.25 };

            SalesManager salesManager = new SalesManager();
            salesManager.SalesWithDiscount(game, gamer, discount);

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer);
            





        }
    }
}
