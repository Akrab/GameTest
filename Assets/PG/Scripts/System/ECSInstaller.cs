using Leopotam.EcsLite;
using Zenject;

namespace PG.System 
{
    public class ECSInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            var world = new EcsWorld();
            Container.Bind<EcsWorld>().FromInstance(world).AsSingle().NonLazy();
            // var world = Container.Instantiate<EcsWorld>(new object[] { def });
            //Container.BindInstance(world);

            //Container.QueueForInject(world);
            //Container.Bind<EcsWorld>().FromNew().AsSingle().NonLazy();
            //Container.Bind<EcsWorld>().AsSingle().NonLazy();
        }
    }
}