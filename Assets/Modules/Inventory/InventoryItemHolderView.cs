using UnityEngine;
using Zenject;

namespace Modules.Inventory
{
    public class InventoryItemHolderView : ItemHolderView
    {
        
        [Inject] [SerializeField] private InventoryData inventoryData;
        public override Item Item
        {
            get => inventoryData.items[ItemIndex];
            set => inventoryData.items[ItemIndex] = value;
        }
    }
}