using Modules.Inventory;
using UnityEngine;

namespace Modules.WeaponConstructor
{
    [CreateAssetMenu(menuName = "Items/CreatorItem", fileName = "CreatorItem", order = 0)]
    public class CreatorItem : Item
    {
        [SerializeField] private Creator creator;

        public Creator Creator
        {
            get => creator;
            private set => creator = value;
        }
    }
}