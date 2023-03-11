using Leopotam.EcsLite;
using PG.ECS.Game.CD;
using UnityEngine;
using Zenject;
using static PG.System.GameConfig;

namespace PG.Game.CD
{
    using CloneDispenserSettings = PG.System.GameConfig.CloneDispenserSettings;
    public abstract class BaseCloneDispenser : CustomBehaviour
    {
        [Inject] protected CloneDispenserSettings settings;

        [Inject] protected EcsWorld _world;

        protected int _ecsIndex = -1;


        [Inject]
        private void Initialize()
        {
            _ecsIndex = _world.NewEntity();
            var pool = _world.GetPool<CloneDispenserComp>();
            pool.Add(_ecsIndex);
            Init();
        }

        protected abstract void Init();

    }
}
