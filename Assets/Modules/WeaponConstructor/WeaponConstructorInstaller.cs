using System.Net.Sockets;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace Modules.WeaponConstructor
{
    public class WeaponConstructorInstaller : MonoInstaller
    {
        [SerializeField] private WeaponConstructor weaponConstructor;
        [FormerlySerializedAs("weaponConstructorUI")] [SerializeField] private WeaponConstructorView weaponConstructorView;
        [SerializeField] private Transform canvas;
        public override void InstallBindings()
        {
          
            var weaponConstructorUIInstance =
                Container.InstantiatePrefabForComponent<WeaponConstructorView>(weaponConstructorView,canvas);
            Container.Bind<WeaponConstructorView>().FromInstance(weaponConstructorUIInstance).AsSingle().NonLazy();
            var weaponConstructorInstance =
                Container.InstantiatePrefabForComponent<WeaponConstructor>(weaponConstructor);
            Container.Bind<WeaponConstructor>().FromInstance(weaponConstructorInstance).AsSingle().NonLazy(); 
        }
    }
}