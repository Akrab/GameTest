using UnityEngine;
using Zenject;

namespace PG.Game
{
    public class CharacterInputInstaller : MonoInstaller
    {
        [SerializeField] CharacterInput characterInput;
        public override void InstallBindings()
        {
            Container.Bind<CharacterInput>().FromInstance(characterInput).AsSingle().NonLazy();
            //Container.Bind<CharacterInput>().FromInstance(characterInput).AsSingle().NonLazy();
        }
    }
}