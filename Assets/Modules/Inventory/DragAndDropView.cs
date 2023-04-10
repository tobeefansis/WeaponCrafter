using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Modules.Inventory
{
    public class DragAndDropView : MonoBehaviour
    {
        [SerializeField] private Image itemImage;
        [SerializeField] private RectTransform draggableImageTransform;
        [SerializeField] private Item item;
        public void SetItem(Item newItem, Vector3 transformPosition)
        {
            item = newItem;
            if (item!=null)
            {
                itemImage.sprite = item.ItemSprite; 
                itemImage.enabled = true;
                draggableImageTransform.position = transformPosition;
            }
            else
            {
                itemImage.enabled = false;
            }
            
            
        }

        private void Update()
        {
            if (item == null) return;
            draggableImageTransform.position = Input.mousePosition;
        }
    }
}
