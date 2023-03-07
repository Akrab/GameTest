using PG.Game;
using UnityEngine;

namespace PG.ECS.Game.Player
{

    struct EInputComp
    {
        public Vector3 data;
    }

    struct EMoveComp
    {
        public IInputListener listener;
    }

    struct ERotationComp
    {
        public IInputListener listener;
    }

}