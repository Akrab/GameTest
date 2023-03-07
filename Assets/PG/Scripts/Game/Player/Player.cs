
using Leopotam.EcsLite;
using UnityEngine;
using Zenject;

namespace PG.Game.Player
{
    public class Player : CustomBehaviour
    {

        [Inject] private CharacterInput characterInput;
        [Inject] private EcsWorld _ecsWorld;
        Rigidbody controller;

        [Inject]
        public void Initialize()
        {
            controller = GetComponent<Rigidbody>();

            var c = GetComponentsInChildren<IEntity>(true);
            foreach (var e in c) { e.SetWorld(_ecsWorld); }
            //var inputs = GetComponentsInChildren<IInput>();
        }

    }
}
