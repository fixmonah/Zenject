using UnityEngine;
using Zenject;

public class Scene2Listener : MonoBehaviour
{
    [Inject] GlobalValue _globalValue;

    private void Start()
    {
        Debug.Log($"GlobalValue.Value1: {_globalValue.Value1}");
    }
}
