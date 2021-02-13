using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    interface IPlayerManager
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);

    }
}
