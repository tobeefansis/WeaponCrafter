using UnityEngine;
using Zenject;

namespace Modules.ScreenChanger
{
    public class ScreenShowerInstaller : MonoInstaller
    {
        [SerializeField] private ScreenShower screenShower;

        public override void InstallBindings()
        {
            var screenShowerInstance =
                Container.InstantiatePrefabForComponent<ScreenShower>(screenShower);
            Container.Bind<ScreenShower>().FromInstance(screenShowerInstance).AsSingle().NonLazy();
        }
    }
}