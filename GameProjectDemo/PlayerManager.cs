using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class PlayerManager
    {
        List<Player> players = new List<Player>() { };
        public void Add(Player player)
        {
            players.Add(player);
            Console.WriteLine("{0} {1}, oyuncu eklendi.", player.FirstName, " ", player.LastName);
        }

        public void Update(Player player, int Id)
        {

        }
        
        public void Delete(string NationalId)
        {
            foreach (var player in players)
            {
                if (player.NationalId == NationalId)
                {
                    players.Remove(player);
                    Console.WriteLine("{0} {1}, Oyuncu Silindi", player.FirstName, " ", player.LastName);
                    //break;
                     
                }
                else
                {
                    continue;
                }

            }
        }
    }
}
