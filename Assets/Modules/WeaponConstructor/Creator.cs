using System.Collections.Generic;
using Modules.Inventory;
using UnityEngine;

namespace Modules.WeaponConstructor
{
    
 
    public abstract class Creator : MonoBehaviour
    {
        public abstract Weapon Create();
        public abstract List<Item> GetItems();
    }
}
