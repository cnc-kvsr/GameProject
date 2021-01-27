using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BasePlayerManager playerManager = new PlayerManager();
            playerManager.Add(new Player
            {
                FirstName = "Kevser",
                LastName = "Canca",
                NationalityId = "37229058689",
                NickName="KvsrCn"
            });
            BasePlayerManager playerManager1 = new PlayerManager();
            playerManager1.Update(new Player
            {
                FirstName = "Kevser",
                LastName = "CANCA",
                NationalityId = "37229058689",
                NickName = "Kvsr"
            });
            BasePlayerManager playerManager2 = new PlayerManager();
            playerManager2.Delete(new Player
            {
                FirstName = "Kağan",
                LastName = "Canca",
                NationalityId = "32234789098",
                NickName = "Kğn"
            });
            BasePlayerManager gameManager = new GameManager();
            gameManager.BuyGame(new Game
            {
                Id = 1,
                Name = "Green World",
                Price = 100
            });
            Console.ReadLine();
        }
    }
}
