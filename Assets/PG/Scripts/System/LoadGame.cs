using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PG.System
{
    public class LoadGame : MonoBehaviour
    {

        IEnumerator Start()
        {
            yield return SceneManager.LoadSceneAsync("Main", LoadSceneMode.Additive);
            Destroy(gameObject);
        }
    }
}
