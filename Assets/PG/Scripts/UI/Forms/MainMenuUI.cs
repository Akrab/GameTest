using Leopotam.EcsLite;
using PG.ECS.UI;

namespace PG.UI
{
    public class MainMenuUI : BaseForm, IMainUI
    {
        public ButtonExt btnPlay;

        protected override void setup()
        {
            btnPlay.onClick.AddListener(Play);
        }

        private void Play()
        {
            var pool = _ecsWorld.GetPool<EStartGameComp>();
            pool.Add(ecsIndex);
            Hide();
        }
    }
}
