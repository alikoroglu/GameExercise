using GameExercise.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameExercise.Concrete
{
    public class GamerManager
    {
        IGamerValidationSystem _gamerValidation = new MernisServiceManager();
        //public GamerManager(IGamerValidationSystem gamerValidation)
        //{
        //    _gamerValidation = gamerValidation;
        //}

        public void Add(Gamer gamer)
        {
            if (_gamerValidation.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "\n" + "Tebrikler; Kaydınız Başarıyla Gerçekleşmiştir!");
            }
            else
            {
                Console.WriteLine("Geçersiz TC No");
            }
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "\n" + "Kaydınız Silinmiştir!");
        }

        public void Update(Gamer gamer)
        {
            if (_gamerValidation.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "\n" + "Tebrikler; Kaydınız Başarıyla Güncellenmiştir!");
            }
            else
            {
                Console.WriteLine("Geçersiz TC No");
            }
        }
    }
}
