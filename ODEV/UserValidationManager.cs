using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "Ahmet" && gamer.LastName == "Alaşahin" && gamer.IdentityNumber==12345678911)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
