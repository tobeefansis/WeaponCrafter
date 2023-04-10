using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Modules.Inventory
{
    public class ItemHolderView : MonoBehaviour
    {
        [Inject] [SerializeField] private InventoryView inventoryView;
        [SerializeField] private Image iconImage;
        [SerializeField] private TextMeshProUGUI itemCount;
        public void SetItem(Item item)
        {
            iconImage.sprite = item.ItemSprite;
            itemCount.text = $"{item.ItemCount}";
        }
    }
}
