using System.Collections.Generic;
using Zenject;

namespace Modules.Inventory
{
    public class InventoryData : ItemsCollection
    {
        [Inject] private InventoryView inventoryView;

        private void Start()
        {
            inventoryView.CreateHolders(items);
        }

        public virtual void AddItems(List<Item> getItems)
        {
            foreach (var newItem in getItems)
            {
                for (var index = 0; index < items.Count; index++)
                {
                    var item = items[index];
                    if (item != null) continue;
                    inventoryView.Items[index].SetItem(newItem);
                    break;
                }
            }
        }
    }
}