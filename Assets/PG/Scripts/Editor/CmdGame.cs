using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEditor;
using UnityEngine;

namespace PG.Editor
{
    public class CmdGame : UnityEditor.Editor
    {
        [MenuItem("Game/Play")]
        static void Play()
        {
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