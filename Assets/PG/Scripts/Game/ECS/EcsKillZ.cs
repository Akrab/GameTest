using Leopotam.EcsLite;

namespace PG.ECS.Game
{
    sealed class EcsKillZ : IEcsRunSystem
    {
        const float KILL_Y = -100f;
        public void Run(IEcsSystems systems)
        {
            var world = systems.GetWorld();

            var killCompFilter = world.Filter<EKillZComp>().End();

            if (killCompFilter.GetEntitiesCount() == 0)
                return;

            var pool = world.GetPool<EKillZComp>();

            foreach (int entity in killCompFilter)
            {
                ref EKillZComp kz = ref pool.Get(entity);
                if (kz.iKillZ.transform.position.y <= KILL_Y)
                {
                    kz.iKillZ.Kill();
                    pool.Del(entity);
                }
            }
        }

    }
}