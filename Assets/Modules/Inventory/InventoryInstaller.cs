using UnityEngine;
using Zenject;

namespace Modules.Inventory
{
    public class InventoryInstaller : MonoInstaller
    {
        [SerializeField] private Transform canvasTransform;
        [SerializeField] private InventoryData inventoryData; 
        [SerializeField] private InventoryView inventoryView; 
        public override void InstallBindings()
        {
            var inventoryDataInstance =
                Container.InstantiatePrefabForComponent<InventoryData>(inventoryData);
            Container.Bind<InventoryData>().FromInstance(inventoryDataInstance).AsSingle().NonLazy();  
            var inventoryViewInstance =
                Container.InstantiatePrefabForComponent<InventoryView>(inventoryView,canvasTransform);
            Container.Bind<InventoryView>().FromInstance(inventoryViewInstance).AsSingle().NonLazy(); 
        }
    }
}