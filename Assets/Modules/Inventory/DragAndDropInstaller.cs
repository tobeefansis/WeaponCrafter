using UnityEngine;
using Zenject;

namespace Modules.Inventory
{
    public class DragAndDropInstaller : MonoInstaller
    {
        [SerializeField] private DragAndDropModel dragAndDropModel;
        [SerializeField] private DragAndDropView dragAndDropView;
        [SerializeField] private Transform canvas;
        public override void InstallBindings()
        {
            var dragAndDropViewInstance =
                Container.InstantiatePrefabForComponent<DragAndDropView>(dragAndDropView,canvas);
            Container.Bind<DragAndDropView>().FromInstance(dragAndDropViewInstance).AsSingle().NonLazy(); 
            var dragAndDropModelInstance =
                Container.InstantiatePrefabForComponent<DragAndDropModel>(dragAndDropModel);
            Container.Bind<DragAndDropModel>().FromInstance(dragAndDropModelInstance).AsSingle().NonLazy();   
            
        }
    }
}