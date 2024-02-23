using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class Scene1Listener : MonoBehaviour
{
    [Inject] GlobalValue _globalValue;

    private void Start()
    {
        _globalValue.Value1 = "Scene1";
        Debug.Log($"GlobalValue.Value1: {_globalValue.Value1}");
        SceneManager.LoadScene("Scene2");
    }
}
