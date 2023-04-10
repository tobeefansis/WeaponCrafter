using UnityEngine;
using Zenject;

namespace Modules.ScreenChanger
{
    public class ScreenBehaviourInstaller : MonoInstaller
    {
        [SerializeField] private ScreenBehaviour screenBehaviour;
        [SerializeField] private Transform canvas;
        public override  void InstallBindings()
        {
            var screenBehaviourInstance =
                Container.InstantiatePrefabForComponent<ScreenBehaviour>(screenBehaviour,canvas);
           
            Container.Bind<ScreenBehaviour>().FromInstance(screenBehaviourInstance).AsCached().NonLazy();
            if (screenBehaviourInstance.showInStart)
            {
                screenBehaviourInstance.SelectAndShow();
            }
            else
            {
                screenBehaviourInstance.Hide();
            }
        }
    }
}