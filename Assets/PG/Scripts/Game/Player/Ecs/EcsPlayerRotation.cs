using Leopotam.EcsLite;
using UnityEngine;

namespace PG.ECS.Game.Player
{
    sealed class EcsPlayerRotation : IEcsRunSystem {        
        public void Run (IEcsSystems systems) {
            var world = systems.GetWorld();

            var filtetInput = world.Filter<EInputComp>().End();

            if (filtetInput.GetEntitiesCount() == 0)
                return;

            var inputComp = world.GetPool<EInputComp>();

            var filterMove = world.Filter<ERotationComp>().End();
            var playerRotationPool = world.GetPool<ERotationComp>();


            Vector3 data = Vector3.zero;
            foreach (int entity in filtetInput)
            {
                ref EInputComp input = ref inputComp.Get(entity);
                data = input.data;
                //weapon.Ammo = System.Math.Max(0, weapon.Ammo - 1);
                inputComp.Del(entity);
            }

            foreach (var item in filterMove)
            {
                ref ERotationComp listenerComp = ref playerRotationPool.Get(item);
                if (listenerComp.listener == null)
                    continue;
                listenerComp.listener.SetInput(data);
            }
        }
    }
}