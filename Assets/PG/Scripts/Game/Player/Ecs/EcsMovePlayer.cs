using Leopotam.EcsLite;
using UnityEngine;


namespace PG.ECS.Game.Player
{
    sealed class EcsMovePlayer : IEcsRunSystem {        
        public void Run (IEcsSystems systems) {

            var world = systems.GetWorld();
            // Мы хотим получить все сущности с компонентом "Weapon" и без компонента "Health".
            // Фильтр может собираться динамически каждый раз, а может быть закеширован где-то.
            var filter = world.Filter<EInputComp>().End();

            if(filter.GetEntitiesCount() == 0) {
                return;
            }
            // Фильтр хранит только сущности, сами даные лежат в пуле компонентов "Weapon".
            // Пул так же может быть закеширован где-то.
            var inputComp = world.GetPool<EInputComp>();


            var filterMove = world.Filter< EMoveComp >().End();
            var playerMoveFilter = world.GetPool<EMoveComp>();


            Vector3 data = Vector3.zero;
            foreach (int entity in filter)
            {
                ref EInputComp input = ref inputComp.Get(entity);
                data = input.data;
                //weapon.Ammo = System.Math.Max(0, weapon.Ammo - 1);
                inputComp.Del(entity);
            }

            foreach (var item in filterMove)
            {
                ref EMoveComp listenerComp = ref playerMoveFilter.Get(item);
                if (listenerComp.listener == null)
                    continue;
                listenerComp.listener.SetInput(data);
            }

            
        }
    }
}