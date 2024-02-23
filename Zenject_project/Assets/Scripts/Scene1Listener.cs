using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class Scene1Listener : MonoBehaviour
{
    [Inject] GlobalValue _globalValue;
    [Inject] Scene1Value _scene1Value;

    private void Start()
    {
        _globalValue.Value1 = "Scene1";
        Debug.Log($"GlobalValue.Value1: {_globalValue.Value1}");

        _scene1Value.Value1 = "Scene1Value1";
        Debug.Log($"Scene1Value.Value1: {_scene1Value.Value1}");
        StartCoroutine(WaitEndFrame());
    }

    IEnumerator WaitEndFrame()
    { 
        yield return new WaitForEndOfFrame();
        SceneManager.LoadScene("Scene2");
    }
}
