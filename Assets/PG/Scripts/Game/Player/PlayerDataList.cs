using Leopotam.EcsLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Game.Player
{
    public interface IEntity
    {
        void SetWorld(EcsWorld ecsWorld);
    }
}
