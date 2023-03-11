using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;
using PG.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace PG.System
{
    public class LoadGame : MonoBehaviour
    {
        public const string KEY_ON_MENU = "EditorPlayOnMenu";
        const string UI = "UI", MAIN = "Main";
        IEnumerator Start()
        {
#if UNITY_EDITOR
            yield return SceneManager.LoadSceneAsync(UI, LoadSceneMode.Additive);
            var loadMenu = EditorPrefs.GetBool(KEY_ON_MENU, true);

            // TODO : Add auto load GAME scene

#else
            yield return SceneManager.LoadSceneAsync(UI, LoadSceneMode.Additive);
#endif

            Destroy(gameObject);
        }
    }
}
