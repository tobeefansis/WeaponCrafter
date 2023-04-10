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
        [Inject] private DiContainer diContainer;
        [Inject] private InventoryData inventoryData;

        private void Start()
        {
            CreateHolders();
        }
        private void CreateHolders()
        {
            for (int i = 0; i < inventoryData.items.Count; i++)
            {
                var inventoryDataInstance =
                    diContainer.InstantiatePrefabForComponent<InventoryItemHolderView>(itemHolderView,itemParentTransform);
                inventoryDataInstance.ItemIndex = i;
                items.Add(inventoryDataInstance);
            }

            Refresh();
        }

        public void Refresh()
        {
            for (var index = 0; index < inventoryData.items.Count ; index++)
            {
                var holderView = items[index];
                holderView.Refresh();
            }
        }
    }
    
}