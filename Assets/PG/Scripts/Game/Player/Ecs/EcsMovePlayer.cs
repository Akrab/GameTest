using Leopotam.EcsLite;
using UnityEngine;


namespace PG.ECS.Game.Player
{
    sealed class EcsMovePlayer : IEcsRunSystem {        
        public void Run (IEcsSystems systems) {

            var world = systems.GetWorld();
            // �� ����� �������� ��� �������� � ����������� "Weapon" � ��� ���������� "Health".
            // ������ ����� ���������� ����������� ������ ���, � ����� ���� ����������� ���-��.
            var filter = world.Filter<EInputComp>().End();

            if(filter.GetEntitiesCount() == 0) {
                return;
            }
            // ������ ������ ������ ��������, ���� ����� ����� � ���� ����������� "Weapon".
            // ��� ��� �� ����� ���� ����������� ���-��.
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