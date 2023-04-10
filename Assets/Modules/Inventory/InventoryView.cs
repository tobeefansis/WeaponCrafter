using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Modules.Inventory
{
    public class InventoryView : MonoBehaviour
    {
        //[Inject] [SerializeField] private InventoryData inventoryData;
        [SerializeField] private ItemHolderView itemHolderView;
        [SerializeField] private Transform itemParentTransform;
        [SerializeField] private List<ItemHolderView> items = new List<ItemHolderView>();
        [SerializeField] private int holdersCount;
        [Inject] private DiContainer diContainer;
        [Inject] private InventoryData inventoryData;

        private void Start()
        {
            CreateHolders();
        }
        private void CreateHolders()
        {
            for (int i = 0; i < holdersCount; i++)
            {
                var inventoryDataInstance =
                    diContainer.InstantiatePrefabForComponent<ItemHolderView>(itemHolderView,itemParentTransform);
                items.Add(inventoryDataInstance);
            }

            Refresh();
        }

        public void Refresh()
        {
            for (var index = 0; index < items.Count&&index < inventoryData.items.Count ; index++)
            {
                var holderView = items[index];
                var item = inventoryData.items[index];
                holderView.SetItem(item);
            }
        }
    }
    
}