using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1989
                && gamer.FirstName == "sefa" && gamer.LastName == "memis" && gamer.IdentityNumber == 121)
            {
                return true;

            }
            return false;
        }
    }
}
