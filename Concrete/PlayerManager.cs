using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class PlayerManager : BasePlayerManager
    {
        private readonly MernisServiceAdapter _playerCheckService;

        public PlayerManager()
        {

        }
        public PlayerManager(MernisServiceAdapter playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void Add(Player player)
        {

            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Add(player);
            }

            else
            {
                throw new Exception("Not a valid person!");
            }
        }
        public void Delete(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Delete(player);
            }

            else
            {
                throw new Exception("Not a valid person!");
            }

        }
        public void Update(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Update(player);
            }

            else
            {
                throw new Exception("Not a valid person!");
            }
            
        }

    }
}
