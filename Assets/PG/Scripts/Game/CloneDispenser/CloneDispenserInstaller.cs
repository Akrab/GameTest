using PG.Game.CD;
using Zenject;
namespace PG.Game
{
    public class CloneDispenserInstaller : MonoInstaller
    {
        public BaseCloneDispenser baseCloneDispenser;
        public override void InstallBindings()
        {

            Container.Bind(baseCloneDispenser.GetType()).FromInstance(baseCloneDispenser).AsSingle().NonLazy();

            //Container.Bind<>().FromInstance(characterInput).AsSingle().NonLazy();
        }
    }
}