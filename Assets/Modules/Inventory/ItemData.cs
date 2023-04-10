using UnityEngine;

namespace Modules.Inventory
{
    [CreateAssetMenu(menuName = "Items/Create ItemData", fileName = "ItemData", order = 0)]
    public class ItemData : ScriptableObject
    {
        public string itemName;
        public Sprite itemSprite;
        public Mesh itemMesh;
        public int maxCount;
    }
}