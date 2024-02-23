using System.Collections;
using UnityEngine;
using Zenject;

public class Scene2Listener : MonoBehaviour
{
    [Inject] GlobalValue _globalValue;

    private void Start()
    {
        StartCoroutine(StartAfterFirstFrame());
    }

    IEnumerator StartAfterFirstFrame()
    {
        yield return new WaitForEndOfFrame();
        Debug.Log($"GlobalValue.Value1: {_globalValue.Value1}");
    }
}
