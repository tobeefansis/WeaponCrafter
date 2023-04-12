using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

namespace Modules.Inventory
{
    public class DragAndDropModel : MonoBehaviour
    {
        [Inject] private DragAndDropView dragAndDropView;

        [SerializeField] private Item item;
        [SerializeField] private ItemHolderView lastItemHolder;

        public void StartDrag(Item selectItem, ItemHolderView selectHolder)
        {
            if (selectHolder == null) return;
            if (item != null) return;
            item = selectItem;
            lastItemHolder = selectHolder;
            selectHolder.SetItem(null);
            dragAndDropView.SetItem(item, selectHolder.transform.position);
        }

        public void EndDrag(ItemHolderView selectHolder)
        {
            if (item == null) return;
            lastItemHolder.SetItem(item);
            item = null;
            dragAndDropView.SetItem(null, selectHolder.transform.position);
        }

        public void Drop(ItemHolderView selectHolder)
        {
            if (!selectHolder.DropConditions(item)) return;

            selectHolder.SetItem(item);
            item = null;
            dragAndDropView.SetItem(null, selectHolder.transform.position);
        }
    }
}