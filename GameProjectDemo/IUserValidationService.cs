using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    interface IUserValidationService
    {
        bool Validate(Player player);
    }
}
