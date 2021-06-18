using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Ship.Entity
{
    public class Player
    {
        public int ID { get;}
        public string Name { get; set; }

        public Player(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}

