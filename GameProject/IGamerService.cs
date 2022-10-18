using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal interface IGamerService
    {
        void Add(Gamers gamer);
        void Update(Gamers gamer);
        void Delete(Gamers gamer);
    }
}
