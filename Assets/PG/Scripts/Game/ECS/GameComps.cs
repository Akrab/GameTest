using PG.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PG.ECS.Game
{
    public interface IKillZ
    {
        Transform transform { get; }
        void Kill();
    }

    struct EKillZComp
    {
        public IKillZ iKillZ;
    }
}
