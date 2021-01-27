using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NickName { get; set; }
    }
}
