namespace PG.UI
{
    public class MainMenuUI : BaseForm
    {
        public ButtonExt btnPlay;

        protected override void setup()
        {
            btnPlay.onClick.AddListener(Play);
        }

        private void Play()
        {

        }
    }
}
