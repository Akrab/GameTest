using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PG.System
{
    public class LoadGame : MonoBehaviour
    {

        const string UI = "UI", MAIN = "Main";
        IEnumerator Start()
        {
            yield return SceneManager.LoadSceneAsync(UI, LoadSceneMode.Additive);
            yield return SceneManager.LoadSceneAsync(MAIN, LoadSceneMode.Additive);
            Destroy(gameObject);
        }
    }
}
