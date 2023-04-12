using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Modules.Inventory
{
    public class InventoryView : MonoBehaviour
    {
        [SerializeField] private InventoryItemHolderView itemHolderView;
        [SerializeField] private Transform itemParentTransform;
        [SerializeField] private List<InventoryItemHolderView> items = new List<InventoryItemHolderView>();

        public List<InventoryItemHolderView> Items
        {
            get => items;
            set => items = value;
        }

        [Inject] private DiContainer diContainer;
        //[Inject] private InventoryData inventoryData;

       

        public void CreateHolders(List<Item> newItems)
        {
            for (int i = 0; i < newItems.Count; i++)
            {
                var inventoryDataInstance =
                    diContainer.InstantiatePrefabForComponent<InventoryItemHolderView>(itemHolderView,
                        itemParentTransform);
                inventoryDataInstance.ItemIndex = i;
                items.Add(inventoryDataInstance);
            }

            Refresh(newItems);
        }

        public void Refresh(List<Item> newItems)
        {
            for (var index = 0; index < newItems.Count; index++)
            {
                var holderView = items[index];
                holderView.Refresh();
            }
        }
    }
}