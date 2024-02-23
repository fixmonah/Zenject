using UnityEngine;
using Zenject;

public class Scene1Installer : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Scene1Value>().FromNew().AsSingle();
    }
}