using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class UserValidationManager:IUserValidationService
    {


        public bool Validate(Player player)
        {
            if ( player.Id ==1 && player.BirthYear == 2001 && player.FirstName == "ege" && player.FirstName == "Ozman" && player.IdentityNumber == 12345)
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
