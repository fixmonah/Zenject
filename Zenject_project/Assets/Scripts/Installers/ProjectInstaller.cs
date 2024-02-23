using Zenject;

public class ProjectInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<GlobalValue>().FromNew().AsSingle();
    }
}