using System;
using System.Collections.Generic;
using Modules.Inventory;
using UnityEngine;

namespace Modules.WeaponConstructor.Sword
{
    public class SwordCreator : Creator
    {
        public SwordBlade blade;
        public SwordGrip grip;
        public SwordGuard guard;
        public SwordHilt hilt;

        public CreatorIngredientItemHolder bladeHolder;
        public CreatorIngredientItemHolder gripHolder;
        public CreatorIngredientItemHolder guardHolder;
        public CreatorIngredientItemHolder hiltHolder;

        private void Awake()
        {
            InitBladeHolder();
            InitGripHolder();
            InitGuardHolder();
            InitHiltHolder();
        }

        private void InitBladeHolder()
        {
            bladeHolder.SetPartWeapon = pw =>
            {
                if (pw is null)
                {
                    blade = null;
                    return;
                }

                if (pw is not SwordBlade swordBlade) return;
                blade = swordBlade;
            };
            bladeHolder.GetPartWeapon = () => blade;
            bladeHolder.SetDropConditions = item => item is SwordBlade;
        }

        private void InitGripHolder()
        {
            gripHolder.SetPartWeapon = pw =>
            {
                if (pw is null)
                {
                    grip = null;
                    return;
                }
                if (pw is not SwordGrip swordGrip) return;
                grip = swordGrip;
            };
            gripHolder.GetPartWeapon = () => grip;
            gripHolder.SetDropConditions = item => item is SwordGrip;
        } 
        private void InitGuardHolder()
        {
            guardHolder.SetPartWeapon = pw =>
            {
                if (pw is null)
                {
                    guard = null;
                    return;
                }
                if (pw is not SwordGuard swordGuard) return;
                guard = swordGuard;
            };
            guardHolder.GetPartWeapon = () => guard;
            guardHolder.SetDropConditions = item => item is SwordGuard;
        } 
        private void InitHiltHolder()
        {
            hiltHolder.SetPartWeapon = pw =>
            {
                if (pw is null)
                {
                    hilt = null;
                    return;
                }
                if (pw is not SwordHilt swordHilt) return;
                hilt = swordHilt;
            };
            hiltHolder.GetPartWeapon = () => hilt;
            hiltHolder.SetDropConditions = item => item is SwordHilt;
        }

        public bool IsStock()
        {
            if (blade == null) return false;
            if (grip == null) return false;
            if (guard == null) return false;
            if (hilt == null) return false;

            return true;
        }

        public override Weapon Create()
        {
            return new Sword();
        }

        public override List<Item> GetItems()
        {
            var items = new List<Item>();
            if (blade!=null)items.Add(blade);
            if (grip!=null)items.Add(grip);
            if (guard!=null)items.Add(guard);
            if (hilt!=null)items.Add(hilt);
            return items;
        }
    }
}