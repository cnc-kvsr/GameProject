using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public abstract class BasePlayerManager : IPlayerService,IPurchaseService
    {
        public virtual void Add(Player player)
        {
            Console.WriteLine("Added Player : {0}", player.NickName);
        }

        public void BuyGame(Game game)
        {
            Console.WriteLine("The {0} game has been purchased.",game.Name);
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Deleted Player : {0}", player.NickName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Updated Player : {0}", player.NickName);
        }
    }
}
