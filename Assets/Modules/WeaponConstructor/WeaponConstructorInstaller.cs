using System.Net.Sockets;
using UnityEngine;
using Zenject;

namespace Modules.WeaponConstructor
{
    public class WeaponConstructorInstaller : MonoInstaller
    {
        [SerializeField] private WeaponConstructor weaponConstructor;
        [SerializeField] private WeaponConstructorUI weaponConstructorUI;
        [SerializeField] private Transform canvas;
        public override void InstallBindings()
        {
            var weaponConstructorInstance =
                Container.InstantiatePrefabForComponent<WeaponConstructor>(weaponConstructor);
            Container.Bind<WeaponConstructor>().FromInstance(weaponConstructorInstance).AsSingle().NonLazy(); 
            var weaponConstructorUIInstance =
                Container.InstantiatePrefabForComponent<WeaponConstructorUI>(weaponConstructorUI,canvas);
            Container.Bind<WeaponConstructorUI>().FromInstance(weaponConstructorUIInstance).AsSingle().NonLazy();
           // Container.QueueForInject(weaponConstructorInstance);
        }
    }
}