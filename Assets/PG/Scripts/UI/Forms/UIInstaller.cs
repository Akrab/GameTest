using PG.Game;
using UnityEngine;
using Zenject;
namespace PG.UI
{
    public class UIInstaller : MonoInstaller
    {

        [SerializeField] CanvasRoot canvasRoot;
        public override void InstallBindings()
        {
            var forms = canvasRoot.SetupUI();

            foreach (var form in forms)
                Container.Bind(form.GetType()).FromInstance(form).AsSingle().NonLazy();
        }
    }
}