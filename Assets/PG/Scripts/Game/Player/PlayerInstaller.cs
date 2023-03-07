using PG.Game;
using PG.Game.Player;
using UnityEngine;
using Zenject;
namespace PG.Game.Player
{
    public class PlayerInstaller : MonoInstaller
    {
        public GameObject playerPrefab;
        public override void InstallBindings()
        {
            var newPlayerObj = Container.InstantiatePrefab(playerPrefab, playerPrefab.transform.position, Quaternion.identity, null);
            var _p = newPlayerObj.GetComponent<Player>();
            Container.Bind<Player>().FromInstance(_p).AsSingle().NonLazy();

            var c = FindObjectOfType<SmoothCameraFollow>();
            c.SetTarget(_p.transform);

        }

    }
}