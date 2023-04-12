using System;
using Modules.Inventory;
using UnityEngine;
using Zenject;

namespace Modules.WeaponConstructor
{
    public class CreatorIngredientItemHolder : ItemHolderView
    {
        public Action<PartWeapon> SetPartWeapon;
        public Func<PartWeapon> GetPartWeapon;
        public Func<Item,bool> SetDropConditions;

        public override Item Item
        {
            get => GetPartWeapon();
            set => SetItemToWeaponConstructor(value);
        }

        private void SetItemToWeaponConstructor(Item item)
        {
            if (item == null)
            {
                SetPartWeapon( null);
                return;
            }

            if (item is not PartWeapon partWeapon) return;
            SetPartWeapon(  partWeapon);
        }

        public override bool DropConditions(Item item)
        {
            return SetDropConditions.Invoke(item);
        }
    }
}