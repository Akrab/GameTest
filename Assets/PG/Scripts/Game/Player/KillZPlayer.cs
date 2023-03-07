using Leopotam.EcsLite;
using PG.ECS.Game;
using PG.Game.Player;
using UnityEngine;

namespace Assets.PG.Scripts.Game.Player
{
    public class KillZPlayer : MonoBehaviour, IKillZ, IEntity
    {
        public void Kill()
        {
            Destroy(gameObject);
        }

        public void SetWorld(EcsWorld ecsWorld)
        {
            var e = ecsWorld.NewEntity();

            var pool = ecsWorld.GetPool<EKillZComp>();
            ref EKillZComp c1 = ref pool.Add(e);
            c1.iKillZ = this;
        }
    }
}
