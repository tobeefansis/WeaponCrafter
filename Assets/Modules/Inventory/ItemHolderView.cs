using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Zenject;

namespace Modules.Inventory
{
    public abstract class ItemHolderView : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
    {
       
        [SerializeField] private Image iconImage;
        [SerializeField] private Sprite emptySprite;
        [Inject] [SerializeField] private DragAndDropModel dragAndDropModel;
        public int ItemIndex { get; set; }
        public abstract Item Item { get; set; }
        
        public void SetItem(Item newItem)
        {
            Item = newItem;
            Refresh();
        }
        public void Refresh()
        {
            iconImage.sprite = Item != null ? Item.ItemSprite : emptySprite;
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            if (Item == null) return;
            dragAndDropModel.StartDrag(Item,this);
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            dragAndDropModel.EndDrag(this);
        }

        public void OnDrag(PointerEventData eventData)
        {
        }

        public void OnDrop(PointerEventData eventData)
        {
            Debug.Log($"asdasdasd {Item}");
            if (Item != null) return;
           
            dragAndDropModel.Drop(this);
        }

        public virtual bool DropConditions(Item item)
        {
            return true;
        }
    }
}
