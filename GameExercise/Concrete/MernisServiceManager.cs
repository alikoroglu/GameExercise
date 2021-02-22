using GameExercise.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameExercise.Concrete
{
    public class MernisServiceManager : IGamerValidationSystem
    {
        public bool Validate(Gamer gamer)
        {
            return true;
            
        }
    }
}
