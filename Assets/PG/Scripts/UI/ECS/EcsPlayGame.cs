using Leopotam.EcsLite;
using PG.ECS.Game;
using UnityEngine.SceneManagement;

namespace PG.ECS.UI
{
    sealed class EcsPlayGame : IEcsRunSystem
    {
        const string MAIN = "Main";
        public void Run(IEcsSystems systems)
        {
            var world = systems.GetWorld();

            var startGammeFilter = world.Filter<EStartGameComp>().End();

            if (startGammeFilter.GetEntitiesCount() == 0)
                return;

            var pool = world.GetPool<EStartGameComp>();

            foreach (int entity in startGammeFilter)
            {
                ref EStartGameComp kz = ref pool.Get(entity);
                pool.Del(entity);
            }

            SceneManager.LoadSceneAsync(MAIN, LoadSceneMode.Additive);
        }
    }
}
