using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace PG.System
{
    [CreateAssetMenu(fileName = "GameConfig", menuName = "Tools/New GameConfig")]
    public class GameConfig : ScriptableObjectInstaller<GameConfig>
    {

        public CloneDispenserSettings cloneDispenserSettings;

        public override void InstallBindings()
        {
            Container.BindInstance(cloneDispenserSettings);
        }

        [Serializable]
        
        public class CloneDispenserSettings
        {
            public float spawnDuration = 2f;
        }
    }

}