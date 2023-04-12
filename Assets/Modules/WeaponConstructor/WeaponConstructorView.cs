using Modules.Inventory;
using UnityEngine;
using Zenject;

namespace Modules.WeaponConstructor
{
    public class WeaponConstructorView : MonoBehaviour
    {
        [SerializeField] private CreatorItemHolderView creatorItemHolderViewPrefab;
        [Inject] private DiContainer diContainer;
        [SerializeField] private Transform creatorPlaceTransform;
        [SerializeField] private Transform creatorItemHolderPlaceTransform;
        [SerializeField] internal Creator creator;
        
        private void Start()
        {
            var creatorItemHolderPlaceInstance =
                diContainer.InstantiatePrefabForComponent<CreatorItemHolderView>(creatorItemHolderViewPrefab,
                    creatorItemHolderPlaceTransform);
            diContainer.Bind<CreatorItemHolderView>().FromInstance(creatorItemHolderPlaceInstance).AsCached().NonLazy();
        }

        public Creator InstantiateCreator(Creator creatorPrefab)
        {
            if (creator!=null)
            {
                 Destroy(creator.gameObject);
            }
            if (creatorPrefab == null) return null;
            creator =
                diContainer.InstantiatePrefabForComponent<Creator>(creatorPrefab,
                    creatorPlaceTransform);
            return creator;
        }
    }
}