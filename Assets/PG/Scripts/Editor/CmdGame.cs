using UnityEditor;
using UnityEditor.SceneManagement;

namespace PG.Editor
{
    public class CmdGame : UnityEditor.Editor
    {

        public const string KEY_ON_MENU = "EditorPlayOnMenu";

        [MenuItem("Game/PlayOnMenu")]
        static void PlayOnMenu()
        {
            EditorPrefs.SetBool(KEY_ON_MENU, true);
            EditorSceneManager.OpenScene("Assets/PG/Scenes/System.unity");
            EditorApplication.isPlaying = true;
        }

        [MenuItem("Game/PlayEnterGame")]
        static void PlayEnterGame()
        {
            EditorPrefs.SetBool(KEY_ON_MENU, false);
            EditorSceneManager.OpenScene("Assets/PG/Scenes/System.unity");
            EditorApplication.isPlaying = true;
        }

        [MenuItem("Game/System")]
        static void LoadSystem()
        {
            EditorSceneManager.OpenScene("Assets/PG/Scenes/System.unity");
            EditorApplication.isPlaying = false;
        }

        [MenuItem("Game/Main")]
        static void LoadSpalsh()
        {
            EditorSceneManager.OpenScene("Assets/PG/Scenes/Main.unity");
            EditorApplication.isPlaying = false;
        }

        [MenuItem("Game/UI")]
        static void LoadUI()
        {
            EditorSceneManager.OpenScene("Assets/PG/Scenes/UI.unity");
            EditorApplication.isPlaying = false;
        }
    }
}