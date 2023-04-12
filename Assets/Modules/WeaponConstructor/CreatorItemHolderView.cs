using Modules.Inventory;
using UnityEngine;
using Zenject;

namespace Modules.WeaponConstructor
{
    public class CreatorItemHolderView : ItemHolderView
    {
        [Inject] private WeaponConstructor weaponConstructor;
        [SerializeField] private Item item;
        public override Item Item { get=>weaponConstructor.CreatorItem; set=>SetItemToWeaponConstructor(value); }

        private void SetItemToWeaponConstructor(Item item)
        {
            if (item == null)
            {
                weaponConstructor.CreatorItem = null;
                return;
            }
            if (!(item is CreatorItem creatorItem) ) return;
            weaponConstructor.CreatorItem = creatorItem;

        }
        public override bool DropConditions(Item item)
        {
            return item is CreatorItem;
        }
    }
}